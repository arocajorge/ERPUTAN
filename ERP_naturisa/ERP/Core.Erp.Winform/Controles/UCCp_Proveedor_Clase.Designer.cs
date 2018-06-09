namespace Core.Erp.Winform.Controles
{
    partial class UCCp_Proveedor_Clase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCp_Proveedor_Clase));
            this.cmb_Provedor_clase = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion_clas_prove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClaseProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NuevotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colIdCtaCble_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Anticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_clase_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Provedor_clase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Provedor_clase
            // 
            this.cmb_Provedor_clase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Provedor_clase.Location = new System.Drawing.Point(3, 8);
            this.cmb_Provedor_clase.Name = "cmb_Provedor_clase";
            this.cmb_Provedor_clase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Provedor_clase.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Provedor_clase.Size = new System.Drawing.Size(287, 20);
            this.cmb_Provedor_clase.TabIndex = 0;
            this.cmb_Provedor_clase.EditValueChanged += new System.EventHandler(this.cmb_Provedor_clase_EditValueChanged);
            this.cmb_Provedor_clase.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Provedor_clase_Validating);
            this.cmb_Provedor_clase.Validated += new System.EventHandler(this.cmb_Provedor_clase_Validated);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion_clas_prove,
            this.colIdClaseProveedor,
            this.colEstado,
            this.colIdCtaCble_CXP,
            this.colIdCtaCble_Anticipo,
            this.colIdCtaCble_gasto,
            this.colcod_clase_proveedor});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion_clas_prove
            // 
            this.coldescripcion_clas_prove.Caption = "Clase Proveedor";
            this.coldescripcion_clas_prove.FieldName = "descripcion_clas_prove";
            this.coldescripcion_clas_prove.Name = "coldescripcion_clas_prove";
            this.coldescripcion_clas_prove.Visible = true;
            this.coldescripcion_clas_prove.VisibleIndex = 1;
            this.coldescripcion_clas_prove.Width = 578;
            // 
            // colIdClaseProveedor
            // 
            this.colIdClaseProveedor.Caption = "IdClaseProveedor";
            this.colIdClaseProveedor.FieldName = "IdClaseProveedor";
            this.colIdClaseProveedor.Name = "colIdClaseProveedor";
            this.colIdClaseProveedor.Visible = true;
            this.colIdClaseProveedor.VisibleIndex = 2;
            this.colIdClaseProveedor.Width = 95;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 132;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 0;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(296, 5);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.Size = new System.Drawing.Size(45, 23);
            this.cmb_Acciones.TabIndex = 1;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripMenuItem,
            this.ModificartoolStripMenuItem,
            this.ConsultartoolStripMenuItem});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Text = "Acciones";
            this.MenuAcciones.Opening += new System.ComponentModel.CancelEventHandler(this.MenuAcciones_Opening);
            // 
            // NuevotoolStripMenuItem
            // 
            this.NuevotoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NuevotoolStripMenuItem.Image")));
            this.NuevotoolStripMenuItem.Name = "NuevotoolStripMenuItem";
            this.NuevotoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.NuevotoolStripMenuItem.Text = "Nuevo";
            this.NuevotoolStripMenuItem.Click += new System.EventHandler(this.NuevotoolStripMenuItem_Click);
            // 
            // ModificartoolStripMenuItem
            // 
            this.ModificartoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ModificartoolStripMenuItem.Image")));
            this.ModificartoolStripMenuItem.Name = "ModificartoolStripMenuItem";
            this.ModificartoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ModificartoolStripMenuItem.Text = "Modificar";
            this.ModificartoolStripMenuItem.Click += new System.EventHandler(this.ModificartoolStripMenuItem_Click);
            // 
            // ConsultartoolStripMenuItem
            // 
            this.ConsultartoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConsultartoolStripMenuItem.Image")));
            this.ConsultartoolStripMenuItem.Name = "ConsultartoolStripMenuItem";
            this.ConsultartoolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ConsultartoolStripMenuItem.Text = "Consultar";
            this.ConsultartoolStripMenuItem.Click += new System.EventHandler(this.ConsultartoolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(1, "empleado.ico");
            this.imageList1.Images.SetKeyName(2, "downloads.ico");
            this.imageList1.Images.SetKeyName(3, "insert1.png");
            this.imageList1.Images.SetKeyName(4, "agregar2.png");
            // 
            // colIdCtaCble_CXP
            // 
            this.colIdCtaCble_CXP.Caption = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.FieldName = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.Name = "colIdCtaCble_CXP";
            this.colIdCtaCble_CXP.Visible = true;
            this.colIdCtaCble_CXP.VisibleIndex = 3;
            this.colIdCtaCble_CXP.Width = 113;
            // 
            // colIdCtaCble_Anticipo
            // 
            this.colIdCtaCble_Anticipo.Caption = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.FieldName = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.Name = "colIdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.Visible = true;
            this.colIdCtaCble_Anticipo.VisibleIndex = 4;
            this.colIdCtaCble_Anticipo.Width = 113;
            // 
            // colIdCtaCble_gasto
            // 
            this.colIdCtaCble_gasto.Caption = "IdCtaCble_gasto";
            this.colIdCtaCble_gasto.FieldName = "IdCtaCble_gasto";
            this.colIdCtaCble_gasto.Name = "colIdCtaCble_gasto";
            this.colIdCtaCble_gasto.Width = 146;
            // 
            // colcod_clase_proveedor
            // 
            this.colcod_clase_proveedor.Caption = "codigo";
            this.colcod_clase_proveedor.FieldName = "cod_clase_proveedor";
            this.colcod_clase_proveedor.Name = "colcod_clase_proveedor";
            this.colcod_clase_proveedor.Visible = true;
            this.colcod_clase_proveedor.VisibleIndex = 0;
            this.colcod_clase_proveedor.Width = 111;
            // 
            // UCCp_Proveedor_Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_Provedor_clase);
            this.Name = "UCCp_Proveedor_Clase";
            this.Size = new System.Drawing.Size(344, 32);
            this.Load += new System.EventHandler(this.UCCp_Proveedor_Clase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Provedor_clase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Provedor_clase;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem NuevotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultartoolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_clas_prove;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClaseProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CXP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Anticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_gasto;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_clase_proveedor;
    }
}
