namespace Core.Erp.Reportes.CuentasxPagar
{
    partial class XCXP_Rpt016_frm
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
            this.ucGe_Menu = new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes();
            this.xtraTabControlData = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.PVGrid_Factura_x_Pagar = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldIdCbteCble_Ogiro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_Estado_Aproba = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnum_factura = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_FechaFactura = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_baseImponible = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_valoriva = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_total = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_valorpagar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_proveedor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_tipo_Documento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSu_Descripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Imprimir_Grafico = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).BeginInit();
            this.xtraTabControlData.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_Factura_x_Pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_Imprimir = true;
            this.ucGe_Menu.Enable_boton_Refrescar = true;
            this.ucGe_Menu.Enable_boton_Salir = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1016, 95);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_boton_Imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Refrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Grupo_acciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucGe_Menu_event_btnRefrescar_ItemClick);
            this.ucGe_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucGe_Menu_event_btnsalir_ItemClick);
            // 
            // xtraTabControlData
            // 
            this.xtraTabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlData.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlData.Name = "xtraTabControlData";
            this.xtraTabControlData.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControlData.Size = new System.Drawing.Size(1016, 343);
            this.xtraTabControlData.TabIndex = 1;
            this.xtraTabControlData.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1010, 315);
            this.xtraTabPage1.Text = "Facturas Proveedor";
            // 
            // PVGrid_Factura_x_Pagar
            // 
            this.PVGrid_Factura_x_Pagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_Factura_x_Pagar.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldIdCbteCble_Ogiro,
            this.fieldnom_Estado_Aproba,
            this.fieldnum_factura,
            this.fieldco_FechaFactura,
            this.fieldco_baseImponible,
            this.fieldco_valoriva,
            this.fieldco_total,
            this.fieldco_valorpagar,
            this.fieldnom_proveedor,
            this.fieldnom_tipo_Documento,
            this.fieldSu_Descripcion});
            this.PVGrid_Factura_x_Pagar.Location = new System.Drawing.Point(2, 2);
            this.PVGrid_Factura_x_Pagar.Name = "PVGrid_Factura_x_Pagar";
            this.PVGrid_Factura_x_Pagar.Size = new System.Drawing.Size(1006, 311);
            this.PVGrid_Factura_x_Pagar.TabIndex = 0;
            // 
            // fieldIdCbteCble_Ogiro
            // 
            this.fieldIdCbteCble_Ogiro.AreaIndex = 6;
            this.fieldIdCbteCble_Ogiro.Caption = "ID Fact. x Pagar";
            this.fieldIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.fieldIdCbteCble_Ogiro.Name = "fieldIdCbteCble_Ogiro";
            this.fieldIdCbteCble_Ogiro.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldnom_Estado_Aproba
            // 
            this.fieldnom_Estado_Aproba.AreaIndex = 0;
            this.fieldnom_Estado_Aproba.Caption = "Estado Aprobación";
            this.fieldnom_Estado_Aproba.FieldName = "nom_Estado_Aproba";
            this.fieldnom_Estado_Aproba.Name = "fieldnom_Estado_Aproba";
            // 
            // fieldnum_factura
            // 
            this.fieldnum_factura.AreaIndex = 1;
            this.fieldnum_factura.Caption = "# Factura";
            this.fieldnum_factura.FieldName = "num_factura";
            this.fieldnum_factura.Name = "fieldnum_factura";
            // 
            // fieldco_FechaFactura
            // 
            this.fieldco_FechaFactura.AreaIndex = 2;
            this.fieldco_FechaFactura.Caption = "Fec.Factura";
            this.fieldco_FechaFactura.FieldName = "co_FechaFactura";
            this.fieldco_FechaFactura.Name = "fieldco_FechaFactura";
            // 
            // fieldco_baseImponible
            // 
            this.fieldco_baseImponible.AreaIndex = 3;
            this.fieldco_baseImponible.Caption = "Subtotal";
            this.fieldco_baseImponible.FieldName = "co_baseImponible";
            this.fieldco_baseImponible.Name = "fieldco_baseImponible";
            // 
            // fieldco_valoriva
            // 
            this.fieldco_valoriva.AreaIndex = 4;
            this.fieldco_valoriva.Caption = "Iva";
            this.fieldco_valoriva.FieldName = "co_valoriva";
            this.fieldco_valoriva.Name = "fieldco_valoriva";
            // 
            // fieldco_total
            // 
            this.fieldco_total.AreaIndex = 5;
            this.fieldco_total.Caption = "Total";
            this.fieldco_total.FieldName = "co_total";
            this.fieldco_total.Name = "fieldco_total";
            // 
            // fieldco_valorpagar
            // 
            this.fieldco_valorpagar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldco_valorpagar.AreaIndex = 0;
            this.fieldco_valorpagar.Caption = "Total a Pagar";
            this.fieldco_valorpagar.FieldName = "co_valorpagar";
            this.fieldco_valorpagar.Name = "fieldco_valorpagar";
            // 
            // fieldnom_proveedor
            // 
            this.fieldnom_proveedor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnom_proveedor.AreaIndex = 0;
            this.fieldnom_proveedor.Caption = "Proveedor";
            this.fieldnom_proveedor.FieldName = "nom_proveedor";
            this.fieldnom_proveedor.Name = "fieldnom_proveedor";
            // 
            // fieldnom_tipo_Documento
            // 
            this.fieldnom_tipo_Documento.AreaIndex = 7;
            this.fieldnom_tipo_Documento.Caption = "Documento";
            this.fieldnom_tipo_Documento.FieldName = "nom_tipo_Documento";
            this.fieldnom_tipo_Documento.Name = "fieldnom_tipo_Documento";
            // 
            // fieldSu_Descripcion
            // 
            this.fieldSu_Descripcion.AreaIndex = 8;
            this.fieldSu_Descripcion.Caption = "Sucursal";
            this.fieldSu_Descripcion.FieldName = "Su_Descripcion";
            this.fieldSu_Descripcion.Name = "fieldSu_Descripcion";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1016, 182);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Gráficos";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.PVGrid_Factura_x_Pagar;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(2, 46);
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
            this.chartControl1.Size = new System.Drawing.Size(1012, 134);
            this.chartControl1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Imprimir_Grafico});
            this.toolStrip1.Location = new System.Drawing.Point(2, 21);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Imprimir_Grafico
            // 
            this.btn_Imprimir_Grafico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Imprimir_Grafico.Image = global::Core.Erp.Reportes.Properties.Resources.printok;
            this.btn_Imprimir_Grafico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir_Grafico.Name = "btn_Imprimir_Grafico";
            this.btn_Imprimir_Grafico.Size = new System.Drawing.Size(23, 22);
            this.btn_Imprimir_Grafico.Text = "toolStripButton1";
            this.btn_Imprimir_Grafico.Click += new System.EventHandler(this.btn_Imprimir_Grafico_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 95);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControlData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 529);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.PVGrid_Factura_x_Pagar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1010, 315);
            this.panelControl1.TabIndex = 1;
            // 
            // XCXP_Rpt016_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 624);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "XCXP_Rpt016_frm";
            this.Text = "MATRIZ CUENTAS POR PAGAR";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).EndInit();
            this.xtraTabControlData.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_Factura_x_Pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCCom_Menu_Reportes ucGe_Menu;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlData;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_Factura_x_Pagar;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdCbteCble_Ogiro;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_Estado_Aproba;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnum_factura;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_FechaFactura;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_baseImponible;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_valoriva;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_total;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_valorpagar;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_proveedor;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_tipo_Documento;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSu_Descripcion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Imprimir_Grafico;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}