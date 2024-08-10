//Form hecho por Pablo Cesar Flores Marroquín || 0901-21-3546
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AdminRepartoApp
{
    public partial class frmReportesBodegasTransportes : Form
    {
        public frmReportesBodegasTransportes()
        {
            InitializeComponent();
            // Cargar valores iniciales en los ComboBoxes
            CargarComboboxValores();
            // Cargar datos en los ComboBoxes durante la carga del formulario
            CargarComboboxPedidos();
        }

        private void CargarComboboxValores()
        {
            try
            {
                cmbTipoPedido.Items.AddRange(new object[] { "Normal", "Urgente", "Especial" });
                cmbEstado.Items.AddRange(new object[] { "Pendiente", "En Proceso", "Completado", "Cancelado" });
                cmbEstadoEnvio.Items.AddRange(new object[] { "En Tránsito", "Entregado", "Retrasado", "Cancelado" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar valores en los comboboxes: " + ex.Message);
                LogError("CargarComboboxValores", ex.Message);
            }
        }

        private void CargarComboboxPedidos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT No_Factura FROM Pedido"; // Usar DISTINCT para evitar duplicados
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBuscarPedido.Items.Clear(); // Limpiar el ComboBox antes de añadir nuevos elementos
                    while (reader.Read())
                    {
                        cmbBuscarPedido.Items.Add(reader["No_Factura"].ToString());
                    }
                    reader.Close();

                    if (cmbBuscarPedido.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pedidos en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    LogError("CargarComboboxPedidos", ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                    LogError("CargarComboboxPedidos", ex.Message);
                }
            }
        }


        private void cmbBuscarPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarPedido.SelectedItem == null)
                return;

            string noFactura = cmbBuscarPedido.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.No_Factura, p.Tipo_Pedido, p.Fecha_Solicitud, p.Cantidad, p.Monto, p.Empresa, p.Envio, p.Estado,
                               dp.Nombres AS ClienteNombres, dp.Apellidos AS ClienteApellidos, dp.Direccion_Personal AS ClienteDireccion, dp.Correo_Personal AS ClienteCorreo,
                               e.Estado_Envio, e.ID_Pedido
                        FROM Pedido p
                        LEFT JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        LEFT JOIN envio e ON p.ID_Pedido = e.ID_Pedido
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Datos del Pedido
                        txtNoFactura.Text = reader["No_Factura"].ToString();
                        cmbTipoPedido.SelectedItem = reader["Tipo_Pedido"].ToString();
                        dtpFechaSolicitud.Value = Convert.ToDateTime(reader["Fecha_Solicitud"]);
                        txtCantidad.Text = reader["Cantidad"].ToString();
                        txtMonto.Text = reader["Monto"].ToString();
                        txtEmpresa.Text = reader["Empresa"].ToString();
                        txtEnvio.Text = reader["Envio"].ToString();
                        cmbEstado.SelectedItem = reader["Estado"].ToString();

                        // Datos del Cliente
                        txtNombreCliente.Text = reader["ClienteNombres"].ToString();
                        txtApellidosCliente.Text = reader["ClienteApellidos"].ToString();
                        txtDireccionCliente.Text = reader["ClienteDireccion"].ToString();
                        txtCorreoCliente.Text = reader["ClienteCorreo"].ToString();

                        // Datos del Envío
                        cmbEstadoEnvio.SelectedItem = reader["Estado_Envio"].ToString();
                        txtIDPedidoEnvio.Text = reader["ID_Pedido"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el pedido seleccionado.");
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos del pedido: " + ex.Message);
                    LogError("cmbBuscarPedido_SelectedIndexChanged", ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                    LogError("cmbBuscarPedido_SelectedIndexChanged", ex.Message);
                }
            }
        }

        private void frmReportesBodegasTransportes_Load(object sender, EventArgs e)
        {
            // Cargar valores iniciales en los ComboBoxes
            CargarComboboxValores();
            // Cargar datos en los ComboBoxes durante la carga del formulario
            CargarComboboxPedidos();
        }

        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarPedido.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un pedido para generar el reporte.");
                return;
            }

            string noFactura = cmbBuscarPedido.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.No_Factura, p.Fecha_Solicitud, p.Monto, p.Envio, p.Estado,
                               dp.Nombres AS ClienteNombres, dp.Apellidos AS ClienteApellidos, dp.Direccion_Personal AS ClienteDireccion, dp.Correo_Personal AS ClienteCorreo,
                               e.Estado_Envio
                        FROM Pedido p
                        JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        LEFT JOIN envio e ON p.ID_Pedido = e.ID_Pedido
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("ReportePedido");
                        ws.Cell(1, 1).InsertTable(dt);

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel files|*.xlsx",
                            Title = "Guardar reporte como",
                            FileName = "ReportePedido.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Reporte generado exitosamente.");
                            LogAction("Reporte generado", noFactura);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al generar el reporte: " + ex.Message);
                    LogError("btnGenerarReporte_Click_1", ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                    LogError("btnGenerarReporte_Click_1", ex.Message);
                }
            }
        }

        private void LogAction(string action, string detail)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO logactividades (ID_Empleado, Accion, FechaHora) VALUES (@idEmpleado, @accion, @fechaHora)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmpleado", 1); // Suponiendo que ID_Empleado es 1 para el ejemplo
                    cmd.Parameters.AddWithValue("@accion", $"{{ \"action\": \"{action}\", \"detail\": \"{detail}\" }}");
                    cmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar la acción en el log: " + ex.Message);
                }
            }
        }

        private void LogError(string function, string errorMessage)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO logactividades (ID_Empleado, Accion, FechaHora) VALUES (@idEmpleado, @accion, @fechaHora)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmpleado", 1); // Suponiendo que ID_Empleado es 1 para el ejemplo
                    cmd.Parameters.AddWithValue("@accion", $"{{ \"error\": \"{errorMessage}\", \"function\": \"{function}\" }}");
                    cmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar el error en el log: " + ex.Message);
                }
            }
        }
    }
}
