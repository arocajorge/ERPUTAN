namespace Core.Erp.Reportes.Controles
{
    partial class UCCp_Menu_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCp_Menu_Reportes));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGenerar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.dtpDesde = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.dtpHasta = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cmbProveedor = new DevExpress.XtraBars.BarEditItem();
            this.risProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bei_clase_proveedor = new DevExpress.XtraBars.BarEditItem();
            this.risClase = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beiCheck1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.beiCheck2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.beiCheck3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupProveedor = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupFechas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupCheck = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupGenerar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupImprimir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupSalir = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.risProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.risClase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnGenerar,
            this.btnSalir,
            this.dtpDesde,
            this.dtpHasta,
            this.cmbProveedor,
            this.btnImprimir,
            this.bei_clase_proveedor,
            this.beiCheck1,
            this.beiCheck2,
            this.beiCheck3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.risProveedor,
            this.risClase,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(788, 94);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Caption = "Generar";
            this.btnGenerar.Description = "Generar Reporte";
            this.btnGenerar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Glyph")));
            this.btnGenerar.Id = 2;
            this.btnGenerar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGenerar.LargeGlyph")));
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGenerar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 3;
            this.btnSalir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.LargeGlyph")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Caption = "Desde: ";
            this.dtpDesde.Edit = this.repositoryItemDateEdit1;
            this.dtpDesde.Id = 4;
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Width = 125;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // dtpHasta
            // 
            this.dtpHasta.Caption = "Hasta:  ";
            this.dtpHasta.Edit = this.repositoryItemDateEdit2;
            this.dtpHasta.Id = 5;
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Width = 125;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Caption = "Proveedor: ";
            this.cmbProveedor.Edit = this.risProveedor;
            this.cmbProveedor.Id = 8;
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Width = 200;
            // 
            // risProveedor
            // 
            this.risProveedor.AutoHeight = false;
            this.risProveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.risProveedor.DisplayMember = "pr_nombre2";
            this.risProveedor.Name = "risProveedor";
            this.risProveedor.ValueMember = "IdProveedor";
            this.risProveedor.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProveedor,
            this.colNombreP});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colProveedor
            // 
            this.colProveedor.Caption = "Id Proveedor";
            this.colProveedor.FieldName = "IdProveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            this.colProveedor.Width = 109;
            // 
            // colNombreP
            // 
            this.colNombreP.Caption = "Nombre";
            this.colNombreP.FieldName = "pr_nombre";
            this.colNombreP.Name = "colNombreP";
            this.colNombreP.Visible = true;
            this.colNombreP.VisibleIndex = 0;
            this.colNombreP.Width = 395;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 9;
            this.btnImprimir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnImprimir.LargeGlyph")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
            // 
            // bei_clase_proveedor
            // 
            this.bei_clase_proveedor.Caption = "Clase:         ";
            this.bei_clase_proveedor.Edit = this.risClase;
            this.bei_clase_proveedor.Id = 10;
            this.bei_clase_proveedor.Name = "bei_clase_proveedor";
            this.bei_clase_proveedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bei_clase_proveedor.Width = 200;
            this.bei_clase_proveedor.EditValueChanged += new System.EventHandler(this.bei_clase_proveedor_EditValueChanged);
            // 
            // risClase
            // 
            this.risClase.AutoHeight = false;
            this.risClase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.risClase.DisplayMember = "descripcion_clas_prove2";
            this.risClase.Name = "risClase";
            this.risClase.ValueMember = "IdClaseProveedor";
            this.risClase.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdClaseProveedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clase";
            this.gridColumn2.FieldName = "descripcion_clas_prove";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 397;
            // 
            // beiCheck1
            // 
            this.beiCheck1.Caption = "Check1";
            this.beiCheck1.Edit = this.repositoryItemCheckEdit1;
            this.beiCheck1.EditValue = true;
            this.beiCheck1.Id = 11;
            this.beiCheck1.Name = "beiCheck1";
            this.beiCheck1.EditValueChanged += new System.EventHandler(this.beiCheck1_EditValueChanged);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // beiCheck2
            // 
            this.beiCheck2.Caption = "Check2";
            this.beiCheck2.Edit = this.repositoryItemCheckEdit2;
            this.beiCheck2.EditValue = false;
            this.beiCheck2.Id = 13;
            this.beiCheck2.Name = "beiCheck2";
            this.beiCheck2.EditValueChanged += new System.EventHandler(this.beiCheck2_EditValueChanged);
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // beiCheck3
            // 
            this.beiCheck3.Caption = "Check3";
            this.beiCheck3.Edit = this.repositoryItemCheckEdit3;
            this.beiCheck3.EditValue = false;
            this.beiCheck3.Id = 14;
            this.beiCheck3.Name = "beiCheck3";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupProveedor,
            this.groupFechas,
            this.groupCheck,
            this.groupGenerar,
            this.groupImprimir,
            this.groupSalir});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // groupProveedor
            // 
            this.groupProveedor.ItemLinks.Add(this.bei_clase_proveedor);
            this.groupProveedor.ItemLinks.Add(this.cmbProveedor);
            this.groupProveedor.Name = "groupProveedor";
            this.groupProveedor.ShowCaptionButton = false;
            // 
            // groupFechas
            // 
            this.groupFechas.ItemLinks.Add(this.dtpDesde);
            this.groupFechas.ItemLinks.Add(this.dtpHasta);
            this.groupFechas.Name = "groupFechas";
            this.groupFechas.ShowCaptionButton = false;
            // 
            // groupCheck
            // 
            this.groupCheck.ItemLinks.Add(this.beiCheck1);
            this.groupCheck.ItemLinks.Add(this.beiCheck2);
            this.groupCheck.ItemLinks.Add(this.beiCheck3);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Visible = false;
            // 
            // groupGenerar
            // 
            this.groupGenerar.ItemLinks.Add(this.btnGenerar);
            this.groupGenerar.Name = "groupGenerar";
            this.groupGenerar.ShowCaptionButton = false;
            // 
            // groupImprimir
            // 
            this.groupImprimir.ItemLinks.Add(this.btnImprimir);
            this.groupImprimir.Name = "groupImprimir";
            this.groupImprimir.ShowCaptionButton = false;
            // 
            // groupSalir
            // 
            this.groupSalir.ItemLinks.Add(this.btnSalir);
            this.groupSalir.Name = "groupSalir";
            this.groupSalir.ShowCaptionButton = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // UCCp_Menu_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UCCp_Menu_Reportes";
            this.Size = new System.Drawing.Size(788, 94);
            this.Load += new System.EventHandler(this.UCCp_Menu_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.risProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.risClase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnGenerar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupProveedor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupFechas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupGenerar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarEditItem cmbProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit risProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreP;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupImprimir;
        private DevExpress.XtraBars.BarEditItem bei_clase_proveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit risClase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        public DevExpress.XtraBars.BarEditItem dtpDesde;
        public DevExpress.XtraBars.BarEditItem dtpHasta;
        public DevExpress.XtraBars.BarEditItem beiCheck1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraBars.BarEditItem beiCheck2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        public DevExpress.XtraBars.BarEditItem beiCheck3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
