namespace Core.Erp.Winform.Controles
{
    partial class UCFa_ClienteCmb
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFa_ClienteCmb));
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_cliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_razonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // colestado
            // 
            this.colestado.Caption = "estado";
            this.colestado.FieldName = "Estado";
            this.colestado.Name = "colestado";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_cliente.EditValue = "<";
            this.cmb_cliente.Location = new System.Drawing.Point(3, 5);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmb_cliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cliente.Properties.DisplayMember = "Nombre_Cliente";
            this.cmb_cliente.Properties.ValueMember = "IdCliente";
            this.cmb_cliente.Properties.View = this.searchLookUpEdit1View;
            this.cmb_cliente.Size = new System.Drawing.Size(333, 20);
            this.cmb_cliente.TabIndex = 31;
            this.cmb_cliente.EditValueChanged += new System.EventHandler(this.cmb_cliente_EditValueChanged);
            this.cmb_cliente.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_cliente_Validating);
            this.cmb_cliente.Validated += new System.EventHandler(this.cmb_cliente_Validated);
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
            this.pe_cedulaRuc,
            this.ColSEstado,
            this.colestado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colestado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "I";
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Id Cliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 0;
            this.colIdCliente.Width = 57;
            // 
            // colNombre_Cliente
            // 
            this.colNombre_Cliente.Caption = "Nombre";
            this.colNombre_Cliente.FieldName = "Nombre_Cliente";
            this.colNombre_Cliente.Name = "colNombre_Cliente";
            this.colNombre_Cliente.Visible = true;
            this.colNombre_Cliente.VisibleIndex = 1;
            this.colNombre_Cliente.Width = 221;
            // 
            // colpe_razonSocial
            // 
            this.colpe_razonSocial.Caption = "Razon Social";
            this.colpe_razonSocial.FieldName = "Persona_Info.pe_razonSocial";
            this.colpe_razonSocial.Name = "colpe_razonSocial";
            this.colpe_razonSocial.Visible = true;
            this.colpe_razonSocial.VisibleIndex = 3;
            this.colpe_razonSocial.Width = 241;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Persona_Info.pe_direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 4;
            this.colDireccion.Width = 261;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Persona_Info.pe_celular";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 5;
            this.colTelefono.Width = 162;
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
            this.pe_cedulaRuc.FieldName = "Persona_Info.pe_cedulaRuc";
            this.pe_cedulaRuc.Name = "pe_cedulaRuc";
            this.pe_cedulaRuc.Visible = true;
            this.pe_cedulaRuc.VisibleIndex = 2;
            this.pe_cedulaRuc.Width = 176;
            // 
            // ColSEstado
            // 
            this.ColSEstado.Caption = "Estado";
            this.ColSEstado.FieldName = "Persona_Info.pe_estado";
            this.ColSEstado.Name = "ColSEstado";
            this.ColSEstado.Visible = true;
            this.ColSEstado.VisibleIndex = 6;
            this.ColSEstado.Width = 62;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(346, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(31, 26);
            this.cmb_Acciones.TabIndex = 32;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(2, "downloads1.ico");
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
            // UCFa_ClienteCmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_cliente);
            this.Name = "UCFa_ClienteCmb";
            this.Size = new System.Drawing.Size(384, 26);
            this.Load += new System.EventHandler(this.UCFa_ClienteCmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit cmb_cliente;
        public DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_razonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colUbicacion;
        private DevExpress.XtraGrid.Columns.GridColumn pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn ColSEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;

    }
}
