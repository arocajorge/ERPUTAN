namespace Core.Erp.Winform.Controles
{
    partial class UCCon_CentroCosto_ctas_Movi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCon_CentroCosto_ctas_Movi));
            this.columpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCbleCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columSestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // columpc_Estado
            // 
            this.columpc_Estado.Caption = "Estado";
            this.columpc_Estado.FieldName = "pc_Estado";
            this.columpc_Estado.Name = "columpc_Estado";
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCentroCosto.Location = new System.Drawing.Point(4, 4);
            this.cmbCentroCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbCentroCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto.Properties.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto.Properties.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto.Properties.View = this.gridView7;
            this.cmbCentroCosto.Size = new System.Drawing.Size(332, 22);
            this.cmbCentroCosto.TabIndex = 15;
            this.cmbCentroCosto.EditValueChanged += new System.EventHandler(this.cmbCentroCosto_EditValueChanged);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto,
            this.colCentro_costo,
            this.colIdCtaCbleCosto,
            this.columpc_Estado,
            this.columSestado});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.columpc_Estado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "I";
            this.gridView7.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Id Centro Costo";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 0;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro de Costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            // 
            // colIdCtaCbleCosto
            // 
            this.colIdCtaCbleCosto.Caption = "Cta Cble";
            this.colIdCtaCbleCosto.FieldName = "IdCtaCble";
            this.colIdCtaCbleCosto.Name = "colIdCtaCbleCosto";
            this.colIdCtaCbleCosto.Visible = true;
            this.colIdCtaCbleCosto.VisibleIndex = 2;
            // 
            // columSestado
            // 
            this.columSestado.Caption = "Estado";
            this.columSestado.FieldName = "Sestado";
            this.columSestado.Name = "columSestado";
            this.columSestado.Visible = true;
            this.columSestado.VisibleIndex = 3;
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 4;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(341, 1);
            this.cmb_Acciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(48, 32);
            this.cmb_Acciones.TabIndex = 14;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(2, "downloads1.ico");
            this.imageList1.Images.SetKeyName(3, "ico_insert1.png");
            this.imageList1.Images.SetKeyName(4, "nuevo_32x32.png");
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
            this.MenuAcciones.Size = new System.Drawing.Size(143, 76);
            this.MenuAcciones.Text = "Acciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // UCCon_CentroCosto_ctas_Movi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCentroCosto);
            this.Controls.Add(this.cmb_Acciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCCon_CentroCosto_ctas_Movi";
            this.Size = new System.Drawing.Size(396, 37);
            this.Load += new System.EventHandler(this.UCCon_CentroCosto_ctas_Movi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCbleCosto;
        private DevExpress.XtraGrid.Columns.GridColumn columpc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn columSestado;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbCentroCosto;

    }
}
