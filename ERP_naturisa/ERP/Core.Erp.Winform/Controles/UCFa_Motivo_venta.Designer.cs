namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Motivo_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFa_Motivo_venta));
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbMotivo_Vta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion_motivo_vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_Vta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo_Vta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(389, 1);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(43, 22);
            this.cmb_Acciones.TabIndex = 24;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "nuevo_32x32.png");
            this.imageList1.Images.SetKeyName(2, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(3, "downloads1.ico");
            this.imageList1.Images.SetKeyName(4, "ico_insert1.png");
            this.imageList1.Images.SetKeyName(5, "agregar2.png");
            // 
            // cmbMotivo_Vta
            // 
            this.cmbMotivo_Vta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMotivo_Vta.Location = new System.Drawing.Point(3, 3);
            this.cmbMotivo_Vta.Name = "cmbMotivo_Vta";
            this.cmbMotivo_Vta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivo_Vta.Properties.DisplayMember = "descripcion_motivo_vta";
            this.cmbMotivo_Vta.Properties.ValueMember = "IdMotivo_Vta";
            this.cmbMotivo_Vta.Properties.View = this.gridView1;
            this.cmbMotivo_Vta.Size = new System.Drawing.Size(380, 20);
            this.cmbMotivo_Vta.TabIndex = 23;
            this.cmbMotivo_Vta.EditValueChanged += new System.EventHandler(this.cmbMotivo_Vta_EditValueChanged);
            this.cmbMotivo_Vta.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMotivo_Vta_Validating);
            this.cmbMotivo_Vta.Validated += new System.EventHandler(this.cmbMotivo_Vta_Validated);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion_motivo_vta,
            this.colIdMotivo_Vta});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion_motivo_vta
            // 
            this.coldescripcion_motivo_vta.Caption = "descripcion";
            this.coldescripcion_motivo_vta.FieldName = "descripcion_motivo_vta";
            this.coldescripcion_motivo_vta.Name = "coldescripcion_motivo_vta";
            this.coldescripcion_motivo_vta.Visible = true;
            this.coldescripcion_motivo_vta.VisibleIndex = 1;
            this.coldescripcion_motivo_vta.Width = 1034;
            // 
            // colIdMotivo_Vta
            // 
            this.colIdMotivo_Vta.Caption = "Id";
            this.colIdMotivo_Vta.FieldName = "IdMotivo_Vta";
            this.colIdMotivo_Vta.Name = "colIdMotivo_Vta";
            this.colIdMotivo_Vta.Visible = true;
            this.colIdMotivo_Vta.VisibleIndex = 0;
            this.colIdMotivo_Vta.Width = 130;
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
            this.MenuAcciones.Size = new System.Drawing.Size(153, 92);
            this.MenuAcciones.Text = "Acciones";
            this.MenuAcciones.Opening += new System.ComponentModel.CancelEventHandler(this.MenuAcciones_Opening);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // UCFa_Motivo_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmbMotivo_Vta);
            this.Name = "UCFa_Motivo_venta";
            this.Size = new System.Drawing.Size(435, 28);
            this.Load += new System.EventHandler(this.UCFa_Motivo_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo_Vta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMotivo_Vta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_motivo_vta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Vta;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}
