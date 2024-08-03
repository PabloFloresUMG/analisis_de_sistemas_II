using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientesRepartoApp
{
    public partial class frmPerfil : Form
    {
        private int idPersona;
        private string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
        private bool isEditing = false;

        public frmPerfil(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            CargarDatosCliente();
            HabilitarCampos(false);
            txtContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            lblConfirmarContrasena.Visible = false;
            txtConfirmarContrasena.Visible = false;
        }

        private void CargarDatosCliente()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombres, Apellidos, Direccion_Personal, Correo_Personal, DPI, Contrasena, Telefono, Genero FROM datos_personales WHERE ID_Persona = @idPersona";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombres.Text = reader["Nombres"].ToString();
                        txtApellidos.Text = reader["Apellidos"].ToString();
                        txtDireccionPersonal.Text = reader["Direccion_Personal"].ToString();
                        txtCorreoPersonal.Text = reader["Correo_Personal"].ToString();
                        txtDPI.Text = reader["DPI"].ToString();
                        txtContrasena.Text = reader["Contrasena"].ToString();
                        txtConfirmarContrasena.Text = reader["Contrasena"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        txtGenero.Text = reader["Genero"].ToString();
                        txtContrasena.UseSystemPasswordChar = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos del cliente: " + ex.Message);
                }
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombres.ReadOnly = !habilitar;
            txtApellidos.ReadOnly = !habilitar;
            txtDireccionPersonal.ReadOnly = !habilitar;
            txtCorreoPersonal.ReadOnly = !habilitar;
            txtDPI.ReadOnly = !habilitar;
            txtContrasena.ReadOnly = !habilitar;
            txtConfirmarContrasena.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtGenero.ReadOnly = !habilitar;
            lblConfirmarContrasena.Visible = habilitar;
            txtConfirmarContrasena.Visible = habilitar;
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            // Código para manejar eventos de carga del formulario, si es necesario
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Cambiar a modo edición
                HabilitarCampos(true);
                btnActualizarDatos.Text = "Confirmar Cambios";
                isEditing = true;
                txtContrasena.UseSystemPasswordChar = false;
                txtConfirmarContrasena.UseSystemPasswordChar = false;
                lblConfirmarContrasena.Visible = true;
                txtConfirmarContrasena.Visible = true;
                txtGenero.ReadOnly = true;
            }
            else
            {
                // Confirmar cambios
                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Confirmación antes de guardar cambios
                DialogResult result = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    HabilitarCampos(false);
                    btnActualizarDatos.Text = "Actualizar Datos";
                    isEditing = false;
                    CargarDatosCliente(); // Revertir cambios
                    return;
                }

                // Guardar cambios
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"
                            UPDATE datos_personales 
                            SET Nombres = @nombres, Apellidos = @apellidos, Direccion_Personal = @direccion, 
                                Correo_Personal = @correo, DPI = @dpi, Contrasena = @contrasena, Telefono = @telefono, Genero = @genero
                            WHERE ID_Persona = @idPersona";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@nombres", txtNombres.Text);
                        cmd.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                        cmd.Parameters.AddWithValue("@direccion", txtDireccionPersonal.Text);
                        cmd.Parameters.AddWithValue("@correo", txtCorreoPersonal.Text);
                        cmd.Parameters.AddWithValue("@dpi", txtDPI.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@genero", txtGenero.Text);
                        cmd.Parameters.AddWithValue("@idPersona", idPersona);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos actualizados exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    HabilitarCampos(false);
                    btnActualizarDatos.Text = "Actualizar Datos";
                    isEditing = false;
                    txtContrasena.UseSystemPasswordChar = true;
                    txtConfirmarContrasena.UseSystemPasswordChar = true;
                    lblConfirmarContrasena.Visible = false;
                    txtConfirmarContrasena.Visible = false;
                }
            }
        }
    }
}
