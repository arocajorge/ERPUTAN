namespace Core.Erp.Winform.Controles
{
    partial class UCCon_PlanCtaCmb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCon_PlanCtaCmb));
            this.colSEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPlanCta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlanCta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // colSEstado
            // 
            this.colSEstado.Caption = "Estado";
            this.colSEstado.FieldName = "SEstado";
            this.colSEstado.Name = "colSEstado";
            this.colSEstado.Visible = true;
            this.colSEstado.VisibleIndex = 5;
            this.colSEstado.Width = 46;
            // 
            // cmbPlanCta
            // 
            this.cmbPlanCta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlanCta.Location = new System.Drawing.Point(3, 3);
            this.cmbPlanCta.Name = "cmbPlanCta";
            this.cmbPlanCta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbPlanCta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPlanCta.Properties.DisplayMember = "pc_Cuenta2";
            this.cmbPlanCta.Properties.ValueMember = "IdCtaCble";
            this.cmbPlanCta.Properties.View = this.gridView6;
            this.cmbPlanCta.Size = new System.Drawing.Size(293, 20);
            this.cmbPlanCta.TabIndex = 5;
            this.cmbPlanCta.EditValueChanged += new System.EventHandler(this.cmbPlanCta_EditValueChanged);
            this.cmbPlanCta.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPlanCta_Validating);
            this.cmbPlanCta.Validated += new System.EventHandler(this.cmbPlanCta_Validated);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_Cuenta2,
            this.colIdCtaCble,
            this.colSEstado,
            this.colpc_clave_corta,
            this.IdCtaCblePadre,
            this.colCuentaPadre});
            this.gridView6.DetailHeight = 700;
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colSEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "*ANULADO*";
            this.gridView6.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.Caption = "Cuenta";
            this.colpc_Cuenta2.FieldName = "pc_Cuenta";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            this.colpc_Cuenta2.Visible = true;
            this.colpc_Cuenta2.VisibleIndex = 2;
            this.colpc_Cuenta2.Width = 500;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCuenta";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 0;
            this.colIdCtaCble.Width = 133;
            // 
            // colpc_clave_corta
            // 
            this.colpc_clave_corta.Caption = "Clave";
            this.colpc_clave_corta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta.Name = "colpc_clave_corta";
            this.colpc_clave_corta.Visible = true;
            this.colpc_clave_corta.VisibleIndex = 1;
            this.colpc_clave_corta.Width = 97;
            // 
            // IdCtaCblePadre
            // 
            this.IdCtaCblePadre.Caption = "IdCtaCblePadre";
            this.IdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.IdCtaCblePadre.Name = "IdCtaCblePadre";
            this.IdCtaCblePadre.Visible = true;
            this.IdCtaCblePadre.VisibleIndex = 3;
            this.IdCtaCblePadre.Width = 113;
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.Caption = "Cta Cble Padre";
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            this.colCuentaPadre.Visible = true;
            this.colCuentaPadre.VisibleIndex = 4;
            this.colCuentaPadre.Width = 291;
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
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(302, 0);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 7;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // UCCon_PlanCtaCmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmbPlanCta);
            this.Name = "UCCon_PlanCtaCmb";
            this.Size = new System.Drawing.Size(342, 26);
            this.Load += new System.EventHandler(this.UCCon_PlanCtaCmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlanCta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colSEstado;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbPlanCta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        private DevExpress.XtraGrid.Columns.GridColumn IdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
    }
}
