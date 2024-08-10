
namespace AdminRepartoApp
{
    partial class frmVerProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerProductos));
            this.txtImagenPath = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.txtDescripcionPresentacion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcionPresentacion = new System.Windows.Forms.Label();
            this.txtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblUnidadM = new System.Windows.Forms.Label();
            this.cmbTipoUM = new System.Windows.Forms.ComboBox();
            this.txtContactoMarca = new System.Windows.Forms.TextBox();
            this.lblContactoMarca = new System.Windows.Forms.Label();
            this.txtPaisMarca = new System.Windows.Forms.TextBox();
            this.lblPaisMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtComentariosProducto = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtPaisFabricante = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblVerProductos = new System.Windows.Forms.Label();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.cmbBuscarProducto = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.lblIVA = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImagenPath
            // 
            this.txtImagenPath.Location = new System.Drawing.Point(808, 160);
            this.txtImagenPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImagenPath.Name = "txtImagenPath";
            this.txtImagenPath.Size = new System.Drawing.Size(279, 22);
            this.txtImagenPath.TabIndex = 65;
            this.txtImagenPath.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 558);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(280, 59);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Actualizar Producto";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(316, 505);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(279, 22);
            this.txtStock.TabIndex = 15;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(312, 484);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 62;
            this.lblStock.Text = "Stock";
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Location = new System.Drawing.Point(312, 274);
            this.lblImagenProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(137, 17);
            this.lblImagenProducto.TabIndex = 60;
            this.lblImagenProducto.Text = "Imagen del producto";
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(316, 191);
            this.txtDescripcionPresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(279, 73);
            this.txtDescripcionPresentacion.TabIndex = 13;
            this.txtDescripcionPresentacion.Text = "";
            // 
            // lblDescripcionPresentacion
            // 
            this.lblDescripcionPresentacion.AutoSize = true;
            this.lblDescripcionPresentacion.Location = new System.Drawing.Point(312, 172);
            this.lblDescripcionPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionPresentacion.Name = "lblDescripcionPresentacion";
            this.lblDescripcionPresentacion.Size = new System.Drawing.Size(203, 17);
            this.lblDescripcionPresentacion.TabIndex = 57;
            this.lblDescripcionPresentacion.Text = "Descripción de la presentación";
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(316, 135);
            this.txtNombrePresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(279, 22);
            this.txtNombrePresentacion.TabIndex = 12;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(312, 116);
            this.lblPresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(179, 17);
            this.lblPresentacion.TabIndex = 55;
            this.lblPresentacion.Text = "Nombre de la presentación";
            // 
            // lblUnidadM
            // 
            this.lblUnidadM.AutoSize = true;
            this.lblUnidadM.Location = new System.Drawing.Point(312, 62);
            this.lblUnidadM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadM.Name = "lblUnidadM";
            this.lblUnidadM.Size = new System.Drawing.Size(123, 17);
            this.lblUnidadM.TabIndex = 54;
            this.lblUnidadM.Text = "Unidad de Medida";
            // 
            // cmbTipoUM
            // 
            this.cmbTipoUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUM.FormattingEnabled = true;
            this.cmbTipoUM.ItemHeight = 16;
            this.cmbTipoUM.Items.AddRange(new object[] {
            "Kilogramo (kg)",
            "Gramo (g)",
            "Litro (l)",
            "Mililitro (ml)",
            "Metro (m)",
            "Centímetro (m)",
            "Milímetro (mm",
            "Pieza (pz)",
            "Paquete (pkg)",
            "Caja (box)",
            "Galón (gal)",
            "Onza (oz)",
            "Libra (lb)",
            "Tonelada (t)",
            "Unidad (u)"});
            this.cmbTipoUM.Location = new System.Drawing.Point(316, 81);
            this.cmbTipoUM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoUM.Name = "cmbTipoUM";
            this.cmbTipoUM.Size = new System.Drawing.Size(279, 24);
            this.cmbTipoUM.TabIndex = 53;
            // 
            // txtContactoMarca
            // 
            this.txtContactoMarca.Location = new System.Drawing.Point(11, 667);
            this.txtContactoMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactoMarca.Name = "txtContactoMarca";
            this.txtContactoMarca.Size = new System.Drawing.Size(279, 22);
            this.txtContactoMarca.TabIndex = 10;
            // 
            // lblContactoMarca
            // 
            this.lblContactoMarca.AutoSize = true;
            this.lblContactoMarca.Location = new System.Drawing.Point(7, 647);
            this.lblContactoMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactoMarca.Name = "lblContactoMarca";
            this.lblContactoMarca.Size = new System.Drawing.Size(142, 17);
            this.lblContactoMarca.TabIndex = 51;
            this.lblContactoMarca.Text = "Contacto de la marca";
            // 
            // txtPaisMarca
            // 
            this.txtPaisMarca.Location = new System.Drawing.Point(11, 610);
            this.txtPaisMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaisMarca.Name = "txtPaisMarca";
            this.txtPaisMarca.Size = new System.Drawing.Size(279, 22);
            this.txtPaisMarca.TabIndex = 9;
            // 
            // lblPaisMarca
            // 
            this.lblPaisMarca.AutoSize = true;
            this.lblPaisMarca.Location = new System.Drawing.Point(7, 590);
            this.lblPaisMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaisMarca.Name = "lblPaisMarca";
            this.lblPaisMarca.Size = new System.Drawing.Size(113, 17);
            this.lblPaisMarca.TabIndex = 49;
            this.lblPaisMarca.Text = "País de la marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(11, 558);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(279, 22);
            this.txtMarca.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 537);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(130, 17);
            this.lblMarca.TabIndex = 47;
            this.lblMarca.Text = "Marca del producto";
            // 
            // txtComentariosProducto
            // 
            this.txtComentariosProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentariosProducto.Location = new System.Drawing.Point(11, 459);
            this.txtComentariosProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComentariosProducto.Name = "txtComentariosProducto";
            this.txtComentariosProducto.Size = new System.Drawing.Size(279, 73);
            this.txtComentariosProducto.TabIndex = 7;
            this.txtComentariosProducto.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(7, 439);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(171, 17);
            this.lblComentarios.TabIndex = 45;
            this.lblComentarios.Text = "Comentarios del Producto";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(11, 402);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(279, 22);
            this.txtIVA.TabIndex = 6;
            // 
            // txtPaisFabricante
            // 
            this.txtPaisFabricante.Location = new System.Drawing.Point(11, 347);
            this.txtPaisFabricante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaisFabricante.Name = "txtPaisFabricante";
            this.txtPaisFabricante.Size = new System.Drawing.Size(279, 22);
            this.txtPaisFabricante.TabIndex = 5;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 327);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(102, 17);
            this.lblPais.TabIndex = 42;
            this.lblPais.Text = "País fabricante";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(11, 294);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(279, 22);
            this.txtPrecioProducto.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 274);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(131, 17);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "Precio del producto";
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleProducto.Location = new System.Drawing.Point(11, 190);
            this.txtDetalleProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(279, 73);
            this.txtDetalleProducto.TabIndex = 3;
            this.txtDetalleProducto.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 169);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(142, 17);
            this.lblDescripcion.TabIndex = 38;
            this.lblDescripcion.Text = "Detalles del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(11, 135);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(279, 22);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 114);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 17);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre del producto";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblVerProductos);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(703, 49);
            this.pnlMain.TabIndex = 35;
            // 
            // lblVerProductos
            // 
            this.lblVerProductos.AutoSize = true;
            this.lblVerProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerProductos.ForeColor = System.Drawing.Color.White;
            this.lblVerProductos.Location = new System.Drawing.Point(5, 11);
            this.lblVerProductos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVerProductos.Name = "lblVerProductos";
            this.lblVerProductos.Size = new System.Drawing.Size(176, 32);
            this.lblVerProductos.TabIndex = 0;
            this.lblVerProductos.Text = "Ver Productos";
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenProducto.InitialImage = global::AdminRepartoApp.Properties.Resources.cerrar_sesion;
            this.pbImagenProducto.Location = new System.Drawing.Point(316, 294);
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(279, 171);
            this.pbImagenProducto.TabIndex = 59;
            this.pbImagenProducto.TabStop = false;
            // 
            // cmbBuscarProducto
            // 
            this.cmbBuscarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarProducto.FormattingEnabled = true;
            this.cmbBuscarProducto.Location = new System.Drawing.Point(11, 89);
            this.cmbBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuscarProducto.Name = "cmbBuscarProducto";
            this.cmbBuscarProducto.Size = new System.Drawing.Size(279, 24);
            this.cmbBuscarProducto.TabIndex = 1;
            this.cmbBuscarProducto.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarProducto_SelectedIndexChanged_1);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(9, 64);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(112, 17);
            this.lblBuscar.TabIndex = 67;
            this.lblBuscar.Text = "Buscar producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(316, 633);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(280, 59);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click_1);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(604, 406);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(97, 59);
            this.btnCargarImagen.TabIndex = 14;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click_1);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(9, 381);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 21);
            this.lblIVA.TabIndex = 70;
            this.lblIVA.Text = "IVA";
            // 
            // frmVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 699);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cmbBuscarProducto);
            this.Controls.Add(this.txtImagenPath);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblImagenProducto);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.txtDescripcionPresentacion);
            this.Controls.Add(this.lblDescripcionPresentacion);
            this.Controls.Add(this.txtNombrePresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblUnidadM);
            this.Controls.Add(this.cmbTipoUM);
            this.Controls.Add(this.txtContactoMarca);
            this.Controls.Add(this.lblContactoMarca);
            this.Controls.Add(this.txtPaisMarca);
            this.Controls.Add(this.lblPaisMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtComentariosProducto);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtPaisFabricante);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDetalleProducto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmVerProductos";
            this.Text = "Ver Productos";
            this.Load += new System.EventHandler(this.frmVerProductos_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagenPath;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblImagenProducto;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.RichTextBox txtDescripcionPresentacion;
        private System.Windows.Forms.Label lblDescripcionPresentacion;
        private System.Windows.Forms.TextBox txtNombrePresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblUnidadM;
        private System.Windows.Forms.ComboBox cmbTipoUM;
        private System.Windows.Forms.TextBox txtContactoMarca;
        private System.Windows.Forms.Label lblContactoMarca;
        private System.Windows.Forms.TextBox txtPaisMarca;
        private System.Windows.Forms.Label lblPaisMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RichTextBox txtComentariosProducto;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPaisFabricante;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RichTextBox txtDetalleProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblVerProductos;
        private System.Windows.Forms.ComboBox cmbBuscarProducto;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label lblIVA;
    }
}