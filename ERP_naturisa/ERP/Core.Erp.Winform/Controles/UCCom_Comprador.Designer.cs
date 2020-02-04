namespace Core.Erp.Winform.Controles
{
    partial class UCCom_Comprador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCom_Comprador));
            this.gridSEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_comprador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdComprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcioncom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_comprador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSEstado
            // 
            this.gridSEstado.Caption = "Estado";
            this.gridSEstado.FieldName = "SEstado";
            this.gridSEstado.Name = "gridSEstado";
            this.gridSEstado.Visible = true;
            this.gridSEstado.VisibleIndex = 2;
            this.gridSEstado.Width = 131;
            // 
            // cmb_comprador
            // 
            this.cmb_comprador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_comprador.Location = new System.Drawing.Point(0, 3);
            this.cmb_comprador.Name = "cmb_comprador";
            this.cmb_comprador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_comprador.Properties.DisplayMember = "Descripcion";
            this.cmb_comprador.Properties.ValueMember = "IdComprador";
            this.cmb_comprador.Properties.View = this.gridView1;
            this.cmb_comprador.Size = new System.Drawing.Size(253, 20);
            this.cmb_comprador.TabIndex = 105;
            this.cmb_comprador.EditValueChanged += new System.EventHandler(this.cmb_comprador_EditValueChanged);
            this.cmb_comprador.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_comprador_Validating);
            this.cmb_comprador.Validated += new System.EventHandler(this.cmb_comprador_Validated);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdComprador,
            this.colDescripcioncom,
            this.gridSEstado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridSEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "*ANULADO*";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdComprador
            // 
            this.colIdComprador.Caption = "Código";
            this.colIdComprador.FieldName = "IdComprador";
            this.colIdComprador.Name = "colIdComprador";
            this.colIdComprador.Visible = true;
            this.colIdComprador.VisibleIndex = 0;
            this.colIdComprador.Width = 129;
            // 
            // colDescripcioncom
            // 
            this.colDescripcioncom.Caption = "Nombre";
            this.colDescripcioncom.FieldName = "Descripcion";
            this.colDescripcioncom.Name = "colDescripcioncom";
            this.colDescripcioncom.Visible = true;
            this.colDescripcioncom.VisibleIndex = 1;
            this.colDescripcioncom.Width = 898;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(2, "downloads1.ico");
            this.imageList1.Images.SetKeyName(3, "ico_insert1.png");
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
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(259, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 107;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // UCCom_Comprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_comprador);
            this.Name = "UCCom_Comprador";
            this.Size = new System.Drawing.Size(298, 26);
            this.Load += new System.EventHandler(this.UCCom_Comprador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_comprador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_comprador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComprador;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcioncom;
        private DevExpress.XtraGrid.Columns.GridColumn gridSEstado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
    }
}
