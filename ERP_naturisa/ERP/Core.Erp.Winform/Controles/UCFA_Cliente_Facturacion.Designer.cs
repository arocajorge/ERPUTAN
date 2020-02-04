namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Cliente_Facturacion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFa_Cliente_Facturacion));
            this.txt_Telefonos = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txt_Ruc = new System.Windows.Forms.TextBox();
            this.llblRuc = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmb_cliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.faClienteInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_razonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.faClienteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_vendedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVe_Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Telefonos
            // 
            this.txt_Telefonos.Enabled = false;
            this.txt_Telefonos.Location = new System.Drawing.Point(397, 68);
            this.txt_Telefonos.Name = "txt_Telefonos";
            this.txt_Telefonos.Size = new System.Drawing.Size(173, 20);
            this.txt_Telefonos.TabIndex = 24;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(333, 65);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(57, 13);
            this.lbltelefono.TabIndex = 23;
            this.lbltelefono.Text = "Teléfonos:";
            // 
            // txt_Ruc
            // 
            this.txt_Ruc.Enabled = false;
            this.txt_Ruc.Location = new System.Drawing.Point(397, 33);
            this.txt_Ruc.MaxLength = 13;
            this.txt_Ruc.Name = "txt_Ruc";
            this.txt_Ruc.Size = new System.Drawing.Size(100, 20);
            this.txt_Ruc.TabIndex = 20;
            // 
            // llblRuc
            // 
            this.llblRuc.AutoSize = true;
            this.llblRuc.Location = new System.Drawing.Point(333, 41);
            this.llblRuc.Name = "llblRuc";
            this.llblRuc.Size = new System.Drawing.Size(33, 13);
            this.llblRuc.TabIndex = 19;
            this.llblRuc.Text = "Ruc.:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(83, 59);
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Direccion.Size = new System.Drawing.Size(231, 41);
            this.txt_Direccion.TabIndex = 22;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.txt_Direccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 36);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 25;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Location = new System.Drawing.Point(83, 4);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmb_cliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cliente.Properties.DataSource = this.faClienteInfoBindingSource1;
            this.cmb_cliente.Properties.DisplayMember = "Nombre_Cliente";
            this.cmb_cliente.Properties.ValueMember = "IdCliente";
            this.cmb_cliente.Properties.View = this.searchLookUpEdit1View;
            this.cmb_cliente.Size = new System.Drawing.Size(231, 20);
            this.cmb_cliente.TabIndex = 29;
            this.cmb_cliente.EditValueChanged += new System.EventHandler(this.cmb_cliente_EditValueChanged);
            // 
            // faClienteInfoBindingSource1
            // 
            this.faClienteInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Facturacion.fa_Cliente_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colNombre_Cliente,
            this.colpe_razonSocial,
            this.colDireccion,
            this.colTelefono,
            this.colUbicacion,
            this.pe_cedulaRuc});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Id Cliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 0;
            this.colIdCliente.Width = 74;
            // 
            // colNombre_Cliente
            // 
            this.colNombre_Cliente.Caption = "Nombre";
            this.colNombre_Cliente.FieldName = "Nombre_Cliente";
            this.colNombre_Cliente.Name = "colNombre_Cliente";
            this.colNombre_Cliente.Visible = true;
            this.colNombre_Cliente.VisibleIndex = 1;
            this.colNombre_Cliente.Width = 254;
            // 
            // colpe_razonSocial
            // 
            this.colpe_razonSocial.Caption = "Razon Social";
            this.colpe_razonSocial.FieldName = "pe_razonSocial";
            this.colpe_razonSocial.Name = "colpe_razonSocial";
            this.colpe_razonSocial.Visible = true;
            this.colpe_razonSocial.VisibleIndex = 3;
            this.colpe_razonSocial.Width = 168;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 4;
            this.colDireccion.Width = 258;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 5;
            this.colTelefono.Width = 138;
            // 
            // colUbicacion
            // 
            this.colUbicacion.FieldName = "Ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.Width = 138;
            // 
            // pe_cedulaRuc
            // 
            this.pe_cedulaRuc.Caption = "R.U.C.";
            this.pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.pe_cedulaRuc.Name = "pe_cedulaRuc";
            this.pe_cedulaRuc.Visible = true;
            this.pe_cedulaRuc.VisibleIndex = 2;
            this.pe_cedulaRuc.Width = 150;
            // 
            // faClienteInfoBindingSource
            // 
            this.faClienteInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_Cliente_Info);
            // 
            // cmb_vendedor
            // 
            this.cmb_vendedor.Location = new System.Drawing.Point(83, 33);
            this.cmb_vendedor.Name = "cmb_vendedor";
            this.cmb_vendedor.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmb_vendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_vendedor.Properties.DisplayMember = "Ve_Vendedor";
            this.cmb_vendedor.Properties.ValueMember = "IdVendedor";
            this.cmb_vendedor.Properties.View = this.gridView1;
            this.cmb_vendedor.Size = new System.Drawing.Size(231, 20);
            this.cmb_vendedor.TabIndex = 30;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVendedor,
            this.colVe_Vendedor});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdVendedor
            // 
            this.colIdVendedor.Caption = "Codigo";
            this.colIdVendedor.FieldName = "IdVendedor";
            this.colIdVendedor.Name = "colIdVendedor";
            this.colIdVendedor.Visible = true;
            this.colIdVendedor.VisibleIndex = 0;
            // 
            // colVe_Vendedor
            // 
            this.colVe_Vendedor.Caption = "Vendedor";
            this.colVe_Vendedor.FieldName = "Ve_Vendedor";
            this.colVe_Vendedor.Name = "colVe_Vendedor";
            this.colVe_Vendedor.Visible = true;
            this.colVe_Vendedor.VisibleIndex = 1;
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.AllowDrop = true;
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Text = "Acciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(2, "downloads1.ico");
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(340, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 32;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // UCFa_Cliente_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_vendedor);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txt_Ruc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Telefonos);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.llblRuc);
            this.Name = "UCFa_Cliente_Facturacion";
            this.Size = new System.Drawing.Size(582, 106);
            this.Load += new System.EventHandler(this.UCFA_Cliente_Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Telefonos;
        public System.Windows.Forms.Label lbltelefono;
        public System.Windows.Forms.TextBox txt_Ruc;
        public System.Windows.Forms.Label llblRuc;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TextBox txt_Direccion;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.BindingSource faClienteInfoBindingSource;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_cliente;
        public DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource faClienteInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_razonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacion;
        private DevExpress.XtraGrid.Columns.GridColumn pe_cedulaRuc;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_vendedor;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colVe_Vendedor;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        public DevExpress.XtraEditors.DropDownButton cmb_Acciones;
    }
}
