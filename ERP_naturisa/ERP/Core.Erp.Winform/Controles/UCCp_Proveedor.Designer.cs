namespace Core.Erp.Winform.Controles
{
    partial class UCCp_Proveedor
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCp_Proveedor));
            this.gridSEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_proveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Anticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_contribuyenteEspecial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSEstado
            // 
            this.gridSEstado.Caption = "Estado";
            this.gridSEstado.FieldName = "SEstado";
            this.gridSEstado.Name = "gridSEstado";
            this.gridSEstado.Width = 95;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_proveedor.Location = new System.Drawing.Point(3, 1);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_proveedor.Properties.DisplayMember = "pr_nombre2";
            this.cmb_proveedor.Properties.ValueMember = "IdProveedor";
            this.cmb_proveedor.Properties.View = this.searchLookUpEdit1View;
            this.cmb_proveedor.Size = new System.Drawing.Size(245, 20);
            this.cmb_proveedor.TabIndex = 0;
            this.cmb_proveedor.EditValueChanged += new System.EventHandler(this.cmb_proveedor_EditValueChanged);
            this.cmb_proveedor.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_proveedor_Validating);
            this.cmb_proveedor.Validated += new System.EventHandler(this.cmb_proveedor_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor,
            this.colpr_codigo,
            this.colpr_nombre,
            this.colIdCtaCble_CXP,
            this.colIdCtaCble_Anticipo,
            this.ColCedulaRuc,
            this.colpr_contribuyenteEspecial,
            this.colIdTipoDocumento,
            this.gridSEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridSEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "*ANULADO*";
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "IdProveedor";
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 3;
            this.colIdProveedor.Width = 54;
            // 
            // colpr_codigo
            // 
            this.colpr_codigo.Caption = "Código";
            this.colpr_codigo.FieldName = "pr_codigo";
            this.colpr_codigo.Name = "colpr_codigo";
            this.colpr_codigo.Visible = true;
            this.colpr_codigo.VisibleIndex = 0;
            this.colpr_codigo.Width = 100;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.Caption = "Nombre";
            this.colpr_nombre.FieldName = "pr_nombre";
            this.colpr_nombre.Name = "colpr_nombre";
            this.colpr_nombre.Visible = true;
            this.colpr_nombre.VisibleIndex = 1;
            this.colpr_nombre.Width = 510;
            // 
            // colIdCtaCble_CXP
            // 
            this.colIdCtaCble_CXP.Caption = "Cuenta Contable";
            this.colIdCtaCble_CXP.FieldName = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.Name = "colIdCtaCble_CXP";
            this.colIdCtaCble_CXP.Width = 130;
            // 
            // colIdCtaCble_Anticipo
            // 
            this.colIdCtaCble_Anticipo.Caption = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.FieldName = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.Name = "colIdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.Width = 182;
            // 
            // ColCedulaRuc
            // 
            this.ColCedulaRuc.Caption = "Cédula/Ruc";
            this.ColCedulaRuc.FieldName = "Persona_Info.pe_cedulaRuc";
            this.ColCedulaRuc.Name = "ColCedulaRuc";
            this.ColCedulaRuc.Visible = true;
            this.ColCedulaRuc.VisibleIndex = 2;
            this.ColCedulaRuc.Width = 180;
            // 
            // colpr_contribuyenteEspecial
            // 
            this.colpr_contribuyenteEspecial.Caption = "Contrib. Especial";
            this.colpr_contribuyenteEspecial.FieldName = "pr_contribuyenteEspecial";
            this.colpr_contribuyenteEspecial.Name = "colpr_contribuyenteEspecial";
            this.colpr_contribuyenteEspecial.Width = 92;
            // 
            // colIdTipoDocumento
            // 
            this.colIdTipoDocumento.Caption = "Tipo Documento";
            this.colIdTipoDocumento.FieldName = "IdTipoDocumento";
            this.colIdTipoDocumento.Name = "colIdTipoDocumento";
            this.colIdTipoDocumento.Width = 112;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(255, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(43, 22);
            this.cmb_Acciones.TabIndex = 1;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
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
            this.MenuAcciones.Opening += new System.ComponentModel.CancelEventHandler(this.MenuAcciones_Opening);
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
            this.imageList1.Images.SetKeyName(3, "ico_insert1.png");
            this.imageList1.Images.SetKeyName(4, "agregar2.png");
            // 
            // UCCp_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_proveedor);
            this.Name = "UCCp_Proveedor";
            this.Size = new System.Drawing.Size(298, 26);
            this.Load += new System.EventHandler(this.UCCp_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_proveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CXP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Anticipo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_contribuyenteEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridSEstado;
    }
}
