//Form hecho por Pablo Cesar Flores Marroquín || 0901-21-3546
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace AdminRepartoApp
{
    public partial class frmVerProductos : Form
    {
        public frmVerProductos()
        {
            InitializeComponent();
            pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage; // Escalar imagen en PictureBox
            HabilitarCampos(false); // Desactivar todos los campos al inicio
        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre_Producto FROM Producto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBuscarProducto.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBuscarProducto.Items.Add(reader["Nombre_Producto"].ToString());
                    }
                    reader.Close();

                    // Mostrar mensaje si no hay elementos
                    if (cmbBuscarProducto.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void cmbBuscarProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBuscarProducto.SelectedItem == null)
                return;

            // Obtener el producto seleccionado
            string nombreProducto = cmbBuscarProducto.SelectedItem.ToString();
            CargarProducto(nombreProducto);
        }

        private void CargarProducto(string nombreProducto)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT * FROM Producto
                        WHERE Nombre_Producto = @nombreProducto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombreProducto.Text = reader["Nombre_Producto"].ToString();
                        txtDetalleProducto.Text = reader["Detalle_Producto"].ToString();
                        txtPrecioProducto.Text = reader["Precio_Producto"].ToString();
                        txtPaisFabricante.Text = reader["Pais_Fabricante"].ToString();
                        txtIVA.Text = reader["IVA"].ToString();
                        txtComentariosProducto.Text = reader["Comentarios_Producto"].ToString();
                        txtStock.Text = reader["Stock"].ToString();
                        txtMarca.Text = reader["Marca"].ToString();
                        txtPaisMarca.Text = reader["Pais_Marca"].ToString();
                        txtContactoMarca.Text = reader["Contacto_Marca"].ToString();
                        cmbTipoUM.SelectedItem = reader["Tipo_UM"].ToString();
                        txtNombrePresentacion.Text = reader["Nombre_Presentacion"].ToString();
                        txtDescripcionPresentacion.Text = reader["Descripcion_Presentacion"].ToString();

                        // Cargar imagen si existe
                        byte[] imageBytes = reader["Imagen_Producto"] as byte[];
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (var ms = new System.IO.MemoryStream(imageBytes))
                            {
                                pbImagenProducto.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pbImagenProducto.Image = null;
                        }

                        // Habilitar los campos y el botón de eliminar producto
                        HabilitarCampos(true);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (cmbBuscarProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto para actualizar.");
                return;
            }

            string nombreProducto = cmbBuscarProducto.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Actualizar el producto
                    string query = @"UPDATE Producto 
                                     SET Detalle_Producto = @detalle, Precio_Producto = @precio, Pais_Fabricante = @pais, 
                                         IVA = @iva, Comentarios_Producto = @comentarios, Stock = @stock, Marca = @marca, Pais_Marca = @paisMarca, 
                                         Contacto_Marca = @contactoMarca, Tipo_UM = @tipoUM, Nombre_Presentacion = @nombrePresentacion, Descripcion_Presentacion = @descripcionPresentacion
                                     WHERE Nombre_Producto = @nombreProducto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@detalle", txtDetalleProducto.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecioProducto.Text));
                    cmd.Parameters.AddWithValue("@pais", txtPaisFabricante.Text);
                    cmd.Parameters.AddWithValue("@iva", Convert.ToDecimal(txtIVA.Text));
                    cmd.Parameters.AddWithValue("@comentarios", txtComentariosProducto.Text);
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@paisMarca", txtPaisMarca.Text);
                    cmd.Parameters.AddWithValue("@contactoMarca", txtContactoMarca.Text);
                    cmd.Parameters.AddWithValue("@tipoUM", cmbTipoUM.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@nombrePresentacion", txtNombrePresentacion.Text);
                    cmd.Parameters.AddWithValue("@descripcionPresentacion", txtDescripcionPresentacion.Text);
                    cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                }
            }
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            string nombreProducto = cmbBuscarProducto.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar el producto: " + nombreProducto + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Producto WHERE Nombre_Producto = @nombreProducto";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado exitosamente.");
                            cmbBuscarProducto.Items.Remove(nombreProducto);
                            HabilitarCampos(false);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                    }
                }
            }
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto para cambiar la imagen.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp *.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pbImagenProducto.Image = Image.FromFile(imagePath);
                txtImagenPath.Text = imagePath; // Actualiza la ruta de la imagen

                // Actualizar imagen en la base de datos
                string nombreProducto = cmbBuscarProducto.SelectedItem.ToString();
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        byte[] imageBytes = null;
                        if (!string.IsNullOrEmpty(txtImagenPath.Text))
                        {
                            imageBytes = File.ReadAllBytes(txtImagenPath.Text);
                        }

                        string query = "UPDATE Producto SET Imagen_Producto = @imagen WHERE Nombre_Producto = @nombreProducto";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@imagen", imageBytes);
                        cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Imagen del producto actualizada exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la imagen del producto.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al actualizar la imagen del producto: " + ex.Message);
                    }
                }
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombreProducto.Enabled = habilitar;
            txtDetalleProducto.Enabled = habilitar;
            txtPrecioProducto.Enabled = habilitar;
            txtPaisFabricante.Enabled = habilitar;
            txtIVA.Enabled = habilitar;
            txtComentariosProducto.Enabled = habilitar;
            txtStock.Enabled = habilitar;
            txtMarca.Enabled = habilitar;
            txtPaisMarca.Enabled = habilitar;
            txtContactoMarca.Enabled = habilitar;
            cmbTipoUM.Enabled = habilitar;
            txtNombrePresentacion.Enabled = habilitar;
            txtDescripcionPresentacion.Enabled = habilitar;
            pbImagenProducto.Enabled = habilitar;
            btnUpdate.Enabled = habilitar;
            btnEliminarProducto.Enabled = habilitar;
            btnCargarImagen.Enabled = habilitar; // Habilitar o deshabilitar el botón de cargar imagen
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDetalleProducto.Clear();
            txtPrecioProducto.Clear();
            txtPaisFabricante.Clear();
            txtIVA.Clear();
            txtComentariosProducto.Clear();
            txtStock.Clear();
            txtMarca.Clear();
            txtPaisMarca.Clear();
            txtContactoMarca.Clear();
            cmbTipoUM.SelectedIndex = -1;
            txtNombrePresentacion.Clear();
            txtDescripcionPresentacion.Clear();
            pbImagenProducto.Image = null;
            txtImagenPath.Clear(); // Limpiar el TextBox de la ruta de imagen
        }

        private bool ValidarCampos()
        {
            try
            {
                // Validar que los campos de texto no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtDetalleProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPaisFabricante.Text) ||
                    string.IsNullOrWhiteSpace(txtIVA.Text) ||
                    string.IsNullOrWhiteSpace(txtComentariosProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtPaisMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtContactoMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtNombrePresentacion.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcionPresentacion.Text) ||
                    cmbTipoUM.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return false;
                }

                // Validar que el precio y el IVA sean números válidos
                if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return false;
                }

                if (!decimal.TryParse(txtIVA.Text, out decimal iva) || iva < 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor de IVA válido.");
                    return false;
                }

                // Validar que el stock sea un número entero
                if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor de stock válido.");
                    return false;
                }

                // Validar que el nombre del producto pueda contener letras, números, espacios, tildes y ñ
                if (!Regex.IsMatch(txtNombreProducto.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ]+$"))
                {
                    MessageBox.Show("El nombre del producto contiene caracteres no válidos.");
                    return false;
                }

                // Validar que los comentarios puedan contener tildes y ñ
                if (!Regex.IsMatch(txtComentariosProducto.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ.,]+$"))
                {
                    MessageBox.Show("Los comentarios contienen caracteres no válidos.");
                    return false;
                }

                // Validar que los contactos de marca no contengan caracteres especiales no deseados
                if (!Regex.IsMatch(txtContactoMarca.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ.,@]+$"))
                {
                    MessageBox.Show("Los contactos de marca contienen caracteres no válidos.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la validación: " + ex.Message);
                return false;
            }
        }
    }
}
