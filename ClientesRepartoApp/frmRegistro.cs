// Form hecho por Pablo Cesar Flores Marroquín || 0901-21-3546
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace ClientesRepartoApp
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar si ya existe un usuario con el correo o DPI ingresado
                    string queryVerificacion = "SELECT COUNT(*) FROM datos_personales WHERE Correo_Personal = @correo OR DPI = @dpi";
                    MySqlCommand cmdVerificacion = new MySqlCommand(queryVerificacion, connection);
                    cmdVerificacion.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmdVerificacion.Parameters.AddWithValue("@dpi", txtDPI.Text);

                    int count = Convert.ToInt32(cmdVerificacion.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo o DPI ingresado.");
                        return;
                    }

                    // Validar contraseñas
                    if (txtContrasena.Text != txtContrasena2.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                        return;
                    }

                    // Insertar nuevo cliente y obtener ID_Cliente
                    string queryCliente = "INSERT INTO cliente () VALUES (); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection);
                    int idCliente = Convert.ToInt32(cmdCliente.ExecuteScalar());

                    // Insertar datos personales con el ID_Cliente obtenido
                    string queryInsert = @"
                        INSERT INTO datos_personales (Nombres, Apellidos, Direccion_Personal, Correo_Personal, DPI, Genero, Telefono, Contrasena, ID_Cliente)
                        VALUES (@nombres, @apellidos, @direccion, @correo, @dpi, @genero, @telefono, @contrasena, @idCliente)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, connection);
                    cmdInsert.Parameters.AddWithValue("@nombres", txtNombre.Text);
                    cmdInsert.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    cmdInsert.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmdInsert.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmdInsert.Parameters.AddWithValue("@dpi", txtDPI.Text);
                    cmdInsert.Parameters.AddWithValue("@genero", cmbGenero.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmdInsert.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                    cmdInsert.Parameters.AddWithValue("@idCliente", idCliente);

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Registro exitoso.");
                    RegistrarLogActividad("Registro exitoso de nuevo usuario");

                    this.Close();
                    frmLogin loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
                    if (loginForm == null)
                    {
                        loginForm = new frmLogin();
                        loginForm.Show();
                    }
                    else
                    {
                        loginForm.Show();
                        loginForm.Focus();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    RegistrarLogActividad($"Error de conexión: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                    RegistrarLogActividad($"Error inesperado: {ex.Message}");
                }
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) ||
                    string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
                    string.IsNullOrEmpty(txtDPI.Text) || cmbGenero.SelectedItem == null ||
                    string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                    string.IsNullOrEmpty(txtContrasena2.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return false;
                }

                // Validar formato de correo electrónico
                if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.");
                    return false;
                }

                // Validar formato de DPI (agregar más validaciones si es necesario)
                if (!Regex.IsMatch(txtDPI.Text, @"^\d+$"))
                {
                    MessageBox.Show("El DPI debe contener solo números.");
                    return false;
                }

                // Validar formato de teléfono (agregar más validaciones si es necesario)
                if (!Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("El teléfono debe contener solo números.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al validar los campos: " + ex.Message);
                return false;
            }
        }

        private void lnklblRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
            if (loginForm == null)
            {
                loginForm = new frmLogin();
                loginForm.Show();
            }
            else
            {
                loginForm.Show();
                loginForm.Focus();
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarLogActividad(string accion)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string equipo = Dns.GetHostName();
                    string ip = ObtenerIPv4();
                    string jsonAccion = $"{{\"accion\":\"{accion}\", \"equipo\":\"{equipo}\", \"ip\":\"{ip}\"}}";
                    string query = "INSERT INTO logactividades (ID_Empleado, Accion, FechaHora) VALUES (NULL, @accion, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@accion", jsonAccion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la actividad: " + ex.Message);
                }
            }
        }

        private string ObtenerIPv4()
        {
            string ip = string.Empty;
            foreach (IPAddress ipAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = ipAddress.ToString();
                    break;
                }
            }
            return ip;
        }
    }
}
