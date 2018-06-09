namespace Core.Erp.Reportes.Contabilidad
{
    partial class XCONTA_Rpt005_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt005_frm));
            this.ucCom_Menu = new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControlData = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Matriz_pivot = new DevExpress.XtraTab.XtraTabPage();
            this.PVGrid_contabilidad = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldIdEmpresa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdTipoCbte = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdCbteCble = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididctacble = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididperiodo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridIdCtaCblePadre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididcentro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididmes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididfecha = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGrididvalor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridCentro_costo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridTipoCbte = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridnomcuenta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvgridnatu = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvgridaño = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridmes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).BeginInit();
            this.xtraTabControlData.SuspendLayout();
            this.xtraTabPage_Matriz_pivot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_contabilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucCom_Menu
            // 
            this.ucCom_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCom_Menu.Enable_boton_Imprimir = true;
            this.ucCom_Menu.Enable_boton_Refrescar = true;
            this.ucCom_Menu.Enable_boton_Salir = true;
            this.ucCom_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucCom_Menu.Name = "ucCom_Menu";
            this.ucCom_Menu.Size = new System.Drawing.Size(902, 95);
            this.ucCom_Menu.TabIndex = 0;
            this.ucCom_Menu.Visible_boton_Imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucCom_Menu.Visible_boton_Refrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucCom_Menu.Visible_boton_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucCom_Menu.Visible_Grupo_acciones = true;
            this.ucCom_Menu.Visible_Grupo_filtro = true;
            this.ucCom_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucCom_Menu_event_btnImprimir_ItemClick);
            this.ucCom_Menu.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucCom_Menu_event_btnRefrescar_ItemClick);
            this.ucCom_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucCom_Menu_event_btnsalir_ItemClick);
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
            this.splitContainer1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(902, 403);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControlData
            // 
            this.xtraTabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlData.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlData.Name = "xtraTabControlData";
            this.xtraTabControlData.SelectedTabPage = this.xtraTabPage_Matriz_pivot;
            this.xtraTabControlData.Size = new System.Drawing.Size(902, 233);
            this.xtraTabControlData.TabIndex = 2;
            this.xtraTabControlData.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Matriz_pivot});
            // 
            // xtraTabPage_Matriz_pivot
            // 
            this.xtraTabPage_Matriz_pivot.Controls.Add(this.PVGrid_contabilidad);
            this.xtraTabPage_Matriz_pivot.Name = "xtraTabPage_Matriz_pivot";
            this.xtraTabPage_Matriz_pivot.Size = new System.Drawing.Size(896, 205);
            this.xtraTabPage_Matriz_pivot.Text = "Movimientos de Contabilidad";
            // 
            // PVGrid_contabilidad
            // 
            this.PVGrid_contabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_contabilidad.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldIdEmpresa,
            this.pivotGridFieldIdTipoCbte,
            this.pivotGridFieldIdCbteCble,
            this.pivotGrididctacble,
            this.pivotGrididperiodo,
            this.pivotGridIdCtaCblePadre,
            this.pivotGrididcentro,
            this.pivotGrididmes,
            this.pivotGrididfecha,
            this.pivotGrididvalor,
            this.pivotGridCentro_costo,
            this.pivotGridTipoCbte,
            this.pivotGridnomcuenta,
            this.pvgridnatu,
            this.pvgridaño,
            this.pivotGridmes});
            this.PVGrid_contabilidad.Location = new System.Drawing.Point(0, 0);
            this.PVGrid_contabilidad.Name = "PVGrid_contabilidad";
            this.PVGrid_contabilidad.Size = new System.Drawing.Size(896, 205);
            this.PVGrid_contabilidad.TabIndex = 0;
            // 
            // pivotGridFieldIdEmpresa
            // 
            this.pivotGridFieldIdEmpresa.AreaIndex = 14;
            this.pivotGridFieldIdEmpresa.Caption = "IdEmpresa";
            this.pivotGridFieldIdEmpresa.FieldName = "IdEmpresa";
            this.pivotGridFieldIdEmpresa.Name = "pivotGridFieldIdEmpresa";
            // 
            // pivotGridFieldIdTipoCbte
            // 
            this.pivotGridFieldIdTipoCbte.AreaIndex = 0;
            this.pivotGridFieldIdTipoCbte.Caption = "IdTipoCbte";
            this.pivotGridFieldIdTipoCbte.FieldName = "IdTipoCbte";
            this.pivotGridFieldIdTipoCbte.Name = "pivotGridFieldIdTipoCbte";
            // 
            // pivotGridFieldIdCbteCble
            // 
            this.pivotGridFieldIdCbteCble.AreaIndex = 1;
            this.pivotGridFieldIdCbteCble.Caption = "IdCbteCble";
            this.pivotGridFieldIdCbteCble.FieldName = "IdCbteCble";
            this.pivotGridFieldIdCbteCble.Name = "pivotGridFieldIdCbteCble";
            // 
            // pivotGrididctacble
            // 
            this.pivotGrididctacble.AreaIndex = 2;
            this.pivotGrididctacble.Caption = "IdCtaCble ";
            this.pivotGrididctacble.FieldName = "IdCtaCble";
            this.pivotGrididctacble.Name = "pivotGrididctacble";
            // 
            // pivotGrididperiodo
            // 
            this.pivotGrididperiodo.AreaIndex = 3;
            this.pivotGrididperiodo.Caption = "IdPeriodo ";
            this.pivotGrididperiodo.FieldName = "IdPeriodo";
            this.pivotGrididperiodo.Name = "pivotGrididperiodo";
            // 
            // pivotGridIdCtaCblePadre
            // 
            this.pivotGridIdCtaCblePadre.AreaIndex = 4;
            this.pivotGridIdCtaCblePadre.Caption = "IdCtaCblePadre";
            this.pivotGridIdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.pivotGridIdCtaCblePadre.Name = "pivotGridIdCtaCblePadre";
            // 
            // pivotGrididcentro
            // 
            this.pivotGrididcentro.AreaIndex = 5;
            this.pivotGrididcentro.Caption = "IdCentroCosto";
            this.pivotGrididcentro.FieldName = "IdCentroCosto";
            this.pivotGrididcentro.Name = "pivotGrididcentro";
            // 
            // pivotGrididmes
            // 
            this.pivotGrididmes.AreaIndex = 6;
            this.pivotGrididmes.Caption = "IdMes   ";
            this.pivotGrididmes.FieldName = "IdMes";
            this.pivotGrididmes.Name = "pivotGrididmes";
            // 
            // pivotGrididfecha
            // 
            this.pivotGrididfecha.AreaIndex = 7;
            this.pivotGrididfecha.Caption = "Fecha ";
            this.pivotGrididfecha.FieldName = "Fecha";
            this.pivotGrididfecha.Name = "pivotGrididfecha";
            // 
            // pivotGrididvalor
            // 
            this.pivotGrididvalor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGrididvalor.AreaIndex = 0;
            this.pivotGrididvalor.Caption = "Valor ";
            this.pivotGrididvalor.FieldName = "Valor";
            this.pivotGrididvalor.Name = "pivotGrididvalor";
            // 
            // pivotGridCentro_costo
            // 
            this.pivotGridCentro_costo.AreaIndex = 8;
            this.pivotGridCentro_costo.Caption = "Centro Costo ";
            this.pivotGridCentro_costo.FieldName = "Centro_costo";
            this.pivotGridCentro_costo.Name = "pivotGridCentro_costo";
            // 
            // pivotGridTipoCbte
            // 
            this.pivotGridTipoCbte.AreaIndex = 9;
            this.pivotGridTipoCbte.Caption = "TipoCbte ";
            this.pivotGridTipoCbte.FieldName = "TipoCbte";
            this.pivotGridTipoCbte.Name = "pivotGridTipoCbte";
            // 
            // pivotGridnomcuenta
            // 
            this.pivotGridnomcuenta.AreaIndex = 10;
            this.pivotGridnomcuenta.Caption = "Nombre Cuenta";
            this.pivotGridnomcuenta.FieldName = "nom_Cuenta";
            this.pivotGridnomcuenta.Name = "pivotGridnomcuenta";
            // 
            // pvgridnatu
            // 
            this.pvgridnatu.AreaIndex = 11;
            this.pvgridnatu.Caption = "Naturaleza Cuenta";
            this.pvgridnatu.FieldName = "Naturaleza_cta";
            this.pvgridnatu.Name = "pvgridnatu";
            // 
            // pvgridaño
            // 
            this.pvgridaño.AreaIndex = 12;
            this.pvgridaño.Caption = "Año Fiscal";
            this.pvgridaño.FieldName = "AnioFiscal";
            this.pvgridaño.Name = "pvgridaño";
            // 
            // pivotGridmes
            // 
            this.pivotGridmes.AreaIndex = 13;
            this.pivotGridmes.Caption = "Mes ";
            this.pivotGridmes.FieldName = "Mes";
            this.pivotGridmes.Name = "pivotGridmes";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.PVGrid_contabilidad;
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
            this.chartControl1.Size = new System.Drawing.Size(902, 141);
            this.chartControl1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 17;
            this.pivotGridField1.Caption = "Dia";
            this.pivotGridField1.FieldName = "Dia";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 17;
            this.pivotGridField2.Caption = "Dia";
            this.pivotGridField2.FieldName = "Dia";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // XCONTA_Rpt005_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucCom_Menu);
            this.Name = "XCONTA_Rpt005_frm";
            this.Text = "Matriz de Contabilidad";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).EndInit();
            this.xtraTabControlData.ResumeLayout(false);
            this.xtraTabPage_Matriz_pivot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_contabilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCCom_Menu_Reportes ucCom_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlData;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Matriz_pivot;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_contabilidad;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdEmpresa;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdTipoCbte;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdCbteCble;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididctacble;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididperiodo;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridIdCtaCblePadre;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididcentro;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididmes;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididfecha;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGrididvalor;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridCentro_costo;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridTipoCbte;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridnomcuenta;
        private DevExpress.XtraPivotGrid.PivotGridField pvgridnatu;
        private DevExpress.XtraPivotGrid.PivotGridField pvgridaño;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridmes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}