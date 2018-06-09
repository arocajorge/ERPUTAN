namespace Core.Erp.Reportes.Compras
{
    partial class XCOMP_Rpt004_frm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCOMP_Rpt004_frm));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dockPanelMenu_Izquierdo = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.PVGrid_orden_compra = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.xCOMPRpt004InfoBindingSource = new System.Windows.Forms.BindingSource();
            this.fieldIdOrdenCompra1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldocfecha1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnomproveedor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnomcomprador1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIdEstadoAprobacion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNommotivooc1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnomproducto1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fielddoCantidad1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldprecio1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fielddosubtotal1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fielddoiva1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fielddototal1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnompuntocargo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCentrocosto1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldsubcentrocosto1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnImprimir = new System.Windows.Forms.ToolStripButton();
            this.xtraTabControlData = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Matriz_pivot = new DevExpress.XtraTab.XtraTabPage();
            this.ucGe_Menu = new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelMenu_Izquierdo.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_orden_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCOMPRpt004InfoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).BeginInit();
            this.xtraTabControlData.SuspendLayout();
            this.xtraTabPage_Matriz_pivot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMenu_Izquierdo});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanelMenu_Izquierdo
            // 
            this.dockPanelMenu_Izquierdo.Controls.Add(this.dockPanel1_Container);
            this.dockPanelMenu_Izquierdo.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenu_Izquierdo.ID = new System.Guid("e452b009-67f9-4634-9e5b-c4b1a5e6899f");
            this.dockPanelMenu_Izquierdo.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMenu_Izquierdo.Name = "dockPanelMenu_Izquierdo";
            this.dockPanelMenu_Izquierdo.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelMenu_Izquierdo.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenu_Izquierdo.SavedIndex = 0;
            this.dockPanelMenu_Izquierdo.Size = new System.Drawing.Size(200, 600);
            this.dockPanelMenu_Izquierdo.Text = "Opciones";
            this.dockPanelMenu_Izquierdo.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 573);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl1.Size = new System.Drawing.Size(192, 573);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.FloatVertical = true;
            this.dockPanel2.ID = new System.Guid("c07e659c-69a4-4e9f-a3a4-7d5c0bf5ece1");
            this.dockPanel2.Location = new System.Drawing.Point(0, 470);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(1121, 232);
            this.dockPanel2.Size = new System.Drawing.Size(1121, 232);
            this.dockPanel2.Text = "Graficos";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.chartControl1);
            this.dockPanel2_Container.Controls.Add(this.toolStrip1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1113, 205);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.PVGrid_orden_compra;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 25);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Series 1";
            sideBySideBarSeriesLabel2.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel2;
            series2.Name = "Series 2";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel3.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(1113, 180);
            this.chartControl1.TabIndex = 14;
            // 
            // PVGrid_orden_compra
            // 
            this.PVGrid_orden_compra.DataSource = this.xCOMPRpt004InfoBindingSource;
            this.PVGrid_orden_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_orden_compra.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldIdOrdenCompra1,
            this.fieldocfecha1,
            this.fieldnomproveedor1,
            this.fieldnomcomprador1,
            this.fieldIdEstadoAprobacion1,
            this.fieldNommotivooc1,
            this.fieldnomproducto1,
            this.fielddoCantidad1,
            this.fieldprecio1,
            this.fielddosubtotal1,
            this.fielddoiva1,
            this.fielddototal1,
            this.fieldnompuntocargo1,
            this.fieldCentrocosto1,
            this.fieldsubcentrocosto1});
            this.PVGrid_orden_compra.Location = new System.Drawing.Point(0, 0);
            this.PVGrid_orden_compra.Name = "PVGrid_orden_compra";
            this.PVGrid_orden_compra.Size = new System.Drawing.Size(1115, 347);
            this.PVGrid_orden_compra.TabIndex = 0;
            // 
            // xCOMPRpt004InfoBindingSource
            // 
            this.xCOMPRpt004InfoBindingSource.DataSource = typeof(Core.Erp.Reportes.Compras.XCOMP_Rpt004_Info);
            // 
            // fieldIdOrdenCompra1
            // 
            this.fieldIdOrdenCompra1.AreaIndex = 9;
            this.fieldIdOrdenCompra1.Caption = "#Orden Compra";
            this.fieldIdOrdenCompra1.FieldName = "IdOrdenCompra";
            this.fieldIdOrdenCompra1.Name = "fieldIdOrdenCompra1";
            this.fieldIdOrdenCompra1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldocfecha1
            // 
            this.fieldocfecha1.AreaIndex = 11;
            this.fieldocfecha1.Caption = "Fecha";
            this.fieldocfecha1.FieldName = "oc_fecha";
            this.fieldocfecha1.Name = "fieldocfecha1";
            // 
            // fieldnomproveedor1
            // 
            this.fieldnomproveedor1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnomproveedor1.AreaIndex = 0;
            this.fieldnomproveedor1.Caption = "Proveedor";
            this.fieldnomproveedor1.FieldName = "nom_proveedor";
            this.fieldnomproveedor1.Name = "fieldnomproveedor1";
            this.fieldnomproveedor1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldnomcomprador1
            // 
            this.fieldnomcomprador1.AreaIndex = 10;
            this.fieldnomcomprador1.Caption = "Comprador";
            this.fieldnomcomprador1.FieldName = "nom_comprador";
            this.fieldnomcomprador1.Name = "fieldnomcomprador1";
            this.fieldnomcomprador1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldIdEstadoAprobacion1
            // 
            this.fieldIdEstadoAprobacion1.AreaIndex = 0;
            this.fieldIdEstadoAprobacion1.Caption = "Estado Aprobacion";
            this.fieldIdEstadoAprobacion1.FieldName = "IdEstadoAprobacion";
            this.fieldIdEstadoAprobacion1.Name = "fieldIdEstadoAprobacion1";
            // 
            // fieldNommotivooc1
            // 
            this.fieldNommotivooc1.AreaIndex = 1;
            this.fieldNommotivooc1.Caption = "Motivo";
            this.fieldNommotivooc1.FieldName = "Nom_motivo_oc";
            this.fieldNommotivooc1.Name = "fieldNommotivooc1";
            // 
            // fieldnomproducto1
            // 
            this.fieldnomproducto1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnomproducto1.AreaIndex = 1;
            this.fieldnomproducto1.Caption = "Producto";
            this.fieldnomproducto1.FieldName = "nom_producto";
            this.fieldnomproducto1.Name = "fieldnomproducto1";
            // 
            // fielddoCantidad1
            // 
            this.fielddoCantidad1.AreaIndex = 2;
            this.fielddoCantidad1.Caption = "Cantidad";
            this.fielddoCantidad1.FieldName = "do_Cantidad";
            this.fielddoCantidad1.Name = "fielddoCantidad1";
            // 
            // fieldprecio1
            // 
            this.fieldprecio1.AreaIndex = 3;
            this.fieldprecio1.Caption = "Precio";
            this.fieldprecio1.FieldName = "precio";
            this.fieldprecio1.Name = "fieldprecio1";
            // 
            // fielddosubtotal1
            // 
            this.fielddosubtotal1.AreaIndex = 4;
            this.fielddosubtotal1.Caption = "SubTotal";
            this.fielddosubtotal1.FieldName = "do_subtotal";
            this.fielddosubtotal1.Name = "fielddosubtotal1";
            // 
            // fielddoiva1
            // 
            this.fielddoiva1.AreaIndex = 5;
            this.fielddoiva1.Caption = "Iva";
            this.fielddoiva1.FieldName = "do_iva";
            this.fielddoiva1.Name = "fielddoiva1";
            // 
            // fielddototal1
            // 
            this.fielddototal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fielddototal1.AreaIndex = 0;
            this.fielddototal1.Caption = "Total";
            this.fielddototal1.FieldName = "do_total";
            this.fielddototal1.Name = "fielddototal1";
            // 
            // fieldnompuntocargo1
            // 
            this.fieldnompuntocargo1.AreaIndex = 6;
            this.fieldnompuntocargo1.Caption = "Punto Cargo";
            this.fieldnompuntocargo1.FieldName = "nom_punto_cargo";
            this.fieldnompuntocargo1.Name = "fieldnompuntocargo1";
            // 
            // fieldCentrocosto1
            // 
            this.fieldCentrocosto1.AreaIndex = 7;
            this.fieldCentrocosto1.Caption = "Centro Costo";
            this.fieldCentrocosto1.FieldName = "Centro_costo";
            this.fieldCentrocosto1.Name = "fieldCentrocosto1";
            // 
            // fieldsubcentrocosto1
            // 
            this.fieldsubcentrocosto1.AreaIndex = 8;
            this.fieldsubcentrocosto1.Caption = "Sub Centro Costo";
            this.fieldsubcentrocosto1.FieldName = "sub_centro_costo";
            this.fieldsubcentrocosto1.Name = "fieldsubcentrocosto1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1113, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bttnImprimir
            // 
            this.bttnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("bttnImprimir.Image")));
            this.bttnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnImprimir.Name = "bttnImprimir";
            this.bttnImprimir.Size = new System.Drawing.Size(23, 22);
            this.bttnImprimir.Text = "Imprimir";
            this.bttnImprimir.Click += new System.EventHandler(this.bttnImprimir_Click_1);
            // 
            // xtraTabControlData
            // 
            this.xtraTabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlData.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlData.Name = "xtraTabControlData";
            this.xtraTabControlData.SelectedTabPage = this.xtraTabPage_Matriz_pivot;
            this.xtraTabControlData.Size = new System.Drawing.Size(1121, 375);
            this.xtraTabControlData.TabIndex = 0;
            this.xtraTabControlData.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Matriz_pivot});
            // 
            // xtraTabPage_Matriz_pivot
            // 
            this.xtraTabPage_Matriz_pivot.Controls.Add(this.PVGrid_orden_compra);
            this.xtraTabPage_Matriz_pivot.Name = "xtraTabPage_Matriz_pivot";
            this.xtraTabPage_Matriz_pivot.Size = new System.Drawing.Size(1115, 347);
            this.xtraTabPage_Matriz_pivot.Text = "Ordenes de Compras";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_Imprimir = true;
            this.ucGe_Menu.Enable_boton_Refrescar = true;
            this.ucGe_Menu.Enable_boton_Salir = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1121, 95);
            this.ucGe_Menu.TabIndex = 13;
            this.ucGe_Menu.Visible_boton_Imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Refrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Grupo_acciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Reportes_Compras1_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucGe_Menu_Reportes_Compras1_event_btnRefrescar_ItemClick);
            this.ucGe_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucGe_Menu_event_btnsalir_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraTabControlData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 375);
            this.panel1.TabIndex = 14;
            // 
            // XCOMP_Rpt004_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.dockPanel2);
            this.Name = "XCOMP_Rpt004_frm";
            this.Text = "MATRIZ DE COMPRAS";
            this.Load += new System.EventHandler(this.XCOMP_Rpt004_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelMenu_Izquierdo.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel2_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_orden_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCOMPRpt004InfoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).EndInit();
            this.xtraTabControlData.ResumeLayout(false);
            this.xtraTabPage_Matriz_pivot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlData;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Matriz_pivot;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_orden_compra;
        private System.Windows.Forms.BindingSource xCOMPRpt004InfoBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdOrdenCompra1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldocfecha1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnomproveedor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnomcomprador1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdEstadoAprobacion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNommotivooc1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnomproducto1;
        private DevExpress.XtraPivotGrid.PivotGridField fielddoCantidad1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldprecio1;
        private DevExpress.XtraPivotGrid.PivotGridField fielddosubtotal1;
        private DevExpress.XtraPivotGrid.PivotGridField fielddoiva1;
        private DevExpress.XtraPivotGrid.PivotGridField fielddototal1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnompuntocargo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCentrocosto1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldsubcentrocosto1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelMenu_Izquierdo;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCCom_Menu_Reportes ucGe_Menu;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bttnImprimir;



    }
}