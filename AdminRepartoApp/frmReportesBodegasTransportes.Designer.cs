
namespace AdminRepartoApp
{
    partial class frmReportesBodegasTransportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesBodegasTransportes));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblReportesdeBodegas = new System.Windows.Forms.Label();
            this.gpbPedido = new System.Windows.Forms.GroupBox();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.cmbBuscarPedido = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gpbEnvio = new System.Windows.Forms.GroupBox();
            this.lblEstadoEnvio = new System.Windows.Forms.Label();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtIDPedidoEnvio = new System.Windows.Forms.TextBox();
            this.lblID_Envio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gpbPedido.SuspendLayout();
            this.gpbEnvio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblReportesdeBodegas);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(907, 53);
            this.pnlMain.TabIndex = 3;
            // 
            // lblReportesdeBodegas
            // 
            this.lblReportesdeBodegas.AutoSize = true;
            this.lblReportesdeBodegas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportesdeBodegas.ForeColor = System.Drawing.Color.White;
            this.lblReportesdeBodegas.Location = new System.Drawing.Point(5, 11);
            this.lblReportesdeBodegas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportesdeBodegas.Name = "lblReportesdeBodegas";
            this.lblReportesdeBodegas.Size = new System.Drawing.Size(212, 28);
            this.lblReportesdeBodegas.TabIndex = 0;
            this.lblReportesdeBodegas.Text = "Reportes de Bodegas";
            // 
            // gpbPedido
            // 
            this.gpbPedido.Controls.Add(this.txtNoFactura);
            this.gpbPedido.Controls.Add(this.lblFactura);
            this.gpbPedido.Controls.Add(this.lblEstado);
            this.gpbPedido.Controls.Add(this.cmbEstado);
            this.gpbPedido.Controls.Add(this.txtEnvio);
            this.gpbPedido.Controls.Add(this.lblEnvio);
            this.gpbPedido.Controls.Add(this.txtEmpresa);
            this.gpbPedido.Controls.Add(this.lblEmpresa);
            this.gpbPedido.Controls.Add(this.txtMonto);
            this.gpbPedido.Controls.Add(this.lblMonto);
            this.gpbPedido.Controls.Add(this.txtCantidad);
            this.gpbPedido.Controls.Add(this.lblCantidad);
            this.gpbPedido.Controls.Add(this.lblFecha);
            this.gpbPedido.Controls.Add(this.dtpFechaSolicitud);
            this.gpbPedido.Controls.Add(this.lblTipo);
            this.gpbPedido.Controls.Add(this.cmbTipoPedido);
            this.gpbPedido.Location = new System.Drawing.Point(11, 97);
            this.gpbPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPedido.Name = "gpbPedido";
            this.gpbPedido.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPedido.Size = new System.Drawing.Size(441, 298);
            this.gpbPedido.TabIndex = 4;
            this.gpbPedido.TabStop = false;
            this.gpbPedido.Text = "Datos del Pedido";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(175, 250);
            this.txtNoFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(257, 22);
            this.txtNoFactura.TabIndex = 9;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(5, 250);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(82, 17);
            this.lblFactura.TabIndex = 17;
            this.lblFactura.Text = "No. Factura";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(5, 217);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(123, 17);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado del Pedido";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "En Tránsito",
            "Entregado",
            "Retrasado",
            "Cancelado",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(175, 217);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(257, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(175, 185);
            this.txtEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.ReadOnly = true;
            this.txtEnvio.Size = new System.Drawing.Size(257, 22);
            this.txtEnvio.TabIndex = 7;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(5, 185);
            this.lblEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(43, 17);
            this.lblEnvio.TabIndex = 15;
            this.lblEnvio.Text = "Envío";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(175, 153);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(257, 22);
            this.txtEmpresa.TabIndex = 6;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(5, 153);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(64, 17);
            this.lblEmpresa.TabIndex = 13;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(175, 121);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(257, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(5, 121);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(175, 89);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(257, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(5, 89);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(5, 57);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 17);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha Solicitud";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Enabled = false;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(175, 57);
            this.dtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(257, 22);
            this.dtpFechaSolicitud.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(5, 23);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(107, 17);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo del Pedido";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.Enabled = false;
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Location = new System.Drawing.Point(175, 23);
            this.cmbTipoPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(257, 24);
            this.cmbTipoPedido.TabIndex = 2;
            // 
            // cmbBuscarPedido
            // 
            this.cmbBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedido.FormattingEnabled = true;
            this.cmbBuscarPedido.Location = new System.Drawing.Point(124, 66);
            this.cmbBuscarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarPedido.Name = "cmbBuscarPedido";
            this.cmbBuscarPedido.Size = new System.Drawing.Size(208, 24);
            this.cmbBuscarPedido.TabIndex = 1;
            this.cmbBuscarPedido.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedido_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(16, 69);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(100, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar Pedido";
            // 
            // gpbEnvio
            // 
            this.gpbEnvio.Controls.Add(this.lblEstadoEnvio);
            this.gpbEnvio.Controls.Add(this.cmbEstadoEnvio);
            this.gpbEnvio.Controls.Add(this.txtIDPedidoEnvio);
            this.gpbEnvio.Controls.Add(this.lblID_Envio);
            this.gpbEnvio.Location = new System.Drawing.Point(459, 273);
            this.gpbEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEnvio.Name = "gpbEnvio";
            this.gpbEnvio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEnvio.Size = new System.Drawing.Size(441, 97);
            this.gpbEnvio.TabIndex = 19;
            this.gpbEnvio.TabStop = false;
            this.gpbEnvio.Text = "Datos del Envío";
            // 
            // lblEstadoEnvio
            // 
            this.lblEstadoEnvio.AutoSize = true;
            this.lblEstadoEnvio.Location = new System.Drawing.Point(7, 23);
            this.lblEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEnvio.Name = "lblEstadoEnvio";
            this.lblEstadoEnvio.Size = new System.Drawing.Size(113, 17);
            this.lblEstadoEnvio.TabIndex = 17;
            this.lblEstadoEnvio.Text = "Estado del envío";
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEnvio.Enabled = false;
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(173, 23);
            this.cmbEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(257, 24);
            this.cmbEstadoEnvio.TabIndex = 15;
            // 
            // txtIDPedidoEnvio
            // 
            this.txtIDPedidoEnvio.Location = new System.Drawing.Point(173, 57);
            this.txtIDPedidoEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPedidoEnvio.Name = "txtIDPedidoEnvio";
            this.txtIDPedidoEnvio.ReadOnly = true;
            this.txtIDPedidoEnvio.Size = new System.Drawing.Size(257, 22);
            this.txtIDPedidoEnvio.TabIndex = 16;
            // 
            // lblID_Envio
            // 
            this.lblID_Envio.AutoSize = true;
            this.lblID_Envio.Location = new System.Drawing.Point(7, 59);
            this.lblID_Envio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_Envio.Name = "lblID_Envio";
            this.lblID_Envio.Size = new System.Drawing.Size(83, 17);
            this.lblID_Envio.TabIndex = 13;
            this.lblID_Envio.Text = "ID del Envío";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorreoCliente);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.txtDireccionCliente);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.txtApellidosCliente);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(460, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(440, 164);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(173, 127);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(257, 22);
            this.txtCorreoCliente.TabIndex = 14;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 128);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(173, 92);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(257, 22);
            this.txtDireccionCliente.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 94);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(173, 60);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.ReadOnly = true;
            this.txtApellidosCliente.Size = new System.Drawing.Size(257, 22);
            this.txtApellidosCliente.TabIndex = 11;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 62);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(173, 28);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(257, 22);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 30);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(772, 378);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(128, 28);
            this.btnGenerarReporte.TabIndex = 17;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click_1);
            // 
            // frmReportesBodegasTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 418);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbEnvio);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cmbBuscarPedido);
            this.Controls.Add(this.gpbPedido);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmReportesBodegasTransportes";
            this.Text = "Reporte de Bodegas";
            this.Load += new System.EventHandler(this.frmReportesBodegasTransportes_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbPedido.ResumeLayout(false);
            this.gpbPedido.PerformLayout();
            this.gpbEnvio.ResumeLayout(false);
            this.gpbEnvio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblReportesdeBodegas;
        private System.Windows.Forms.GroupBox gpbPedido;
        private System.Windows.Forms.ComboBox cmbBuscarPedido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox gpbEnvio;
        private System.Windows.Forms.Label lblEstadoEnvio;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtIDPedidoEnvio;
        private System.Windows.Forms.Label lblID_Envio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}