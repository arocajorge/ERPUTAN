namespace Core.Erp.Reportes.Caja
{
    partial class XCAJ_Rpt001_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCAJ_Rpt001_frm));
            this.ucGe_Menu = new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControlData = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Matriz_pivot = new DevExpress.XtraTab.XtraTabPage();
            this.PVGrid_caja = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldValor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldCaja = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdEmpresa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdCbteCble = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdTipocbte = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTipo_Cbte = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldcod_caja = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldSucursal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTipo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldBeneficiario = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldFecha = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTipo_Movi_Caja = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdCobro_tipo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldBanco = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldNum_Documento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldObservacion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.fieldIdEstadoAprobacion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldAnioFiscal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldMes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldDia = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldIdCalendario = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).BeginInit();
            this.xtraTabControlData.SuspendLayout();
            this.xtraTabPage_Matriz_pivot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_caja)).BeginInit();
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
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_Imprimir = true;
            this.ucGe_Menu.Enable_boton_Refrescar = true;
            this.ucGe_Menu.Enable_boton_Salir = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1121, 95);
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
            this.splitContainer1.Size = new System.Drawing.Size(1121, 647);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControlData
            // 
            this.xtraTabControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlData.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlData.Name = "xtraTabControlData";
            this.xtraTabControlData.SelectedTabPage = this.xtraTabPage_Matriz_pivot;
            this.xtraTabControlData.Size = new System.Drawing.Size(1121, 373);
            this.xtraTabControlData.TabIndex = 1;
            this.xtraTabControlData.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Matriz_pivot});
            // 
            // xtraTabPage_Matriz_pivot
            // 
            this.xtraTabPage_Matriz_pivot.Controls.Add(this.PVGrid_caja);
            this.xtraTabPage_Matriz_pivot.Name = "xtraTabPage_Matriz_pivot";
            this.xtraTabPage_Matriz_pivot.Size = new System.Drawing.Size(1115, 345);
            this.xtraTabPage_Matriz_pivot.Text = "Movimientos de caja";
            // 
            // PVGrid_caja
            // 
            this.PVGrid_caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_caja.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldValor,
            this.pivotGridFieldCaja,
            this.pivotGridFieldIdEmpresa,
            this.pivotGridFieldIdCbteCble,
            this.pivotGridFieldIdTipocbte,
            this.pivotGridFieldTipo_Cbte,
            this.pivotGridFieldcod_caja,
            this.pivotGridFieldSucursal,
            this.pivotGridFieldTipo,
            this.pivotGridFieldBeneficiario,
            this.pivotGridFieldFecha,
            this.pivotGridFieldTipo_Movi_Caja,
            this.pivotGridFieldIdCobro_tipo,
            this.pivotGridFieldBanco,
            this.pivotGridFieldNum_Documento,
            this.pivotGridFieldObservacion,
            this.pivotGridFieldIdCalendario,
            this.pivotGridFieldAnioFiscal,
            this.pivotGridFieldMes,
            this.pivotGridFieldDia});
            this.PVGrid_caja.Location = new System.Drawing.Point(0, 0);
            this.PVGrid_caja.Name = "PVGrid_caja";
            this.PVGrid_caja.Size = new System.Drawing.Size(1115, 345);
            this.PVGrid_caja.TabIndex = 0;
            // 
            // pivotGridFieldValor
            // 
            this.pivotGridFieldValor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridFieldValor.AreaIndex = 0;
            this.pivotGridFieldValor.Caption = "Valor";
            this.pivotGridFieldValor.FieldName = "Valor";
            this.pivotGridFieldValor.Name = "pivotGridFieldValor";
            // 
            // pivotGridFieldCaja
            // 
            this.pivotGridFieldCaja.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldCaja.AreaIndex = 0;
            this.pivotGridFieldCaja.Caption = "Caja";
            this.pivotGridFieldCaja.FieldName = "Caja";
            this.pivotGridFieldCaja.Name = "pivotGridFieldCaja";
            this.pivotGridFieldCaja.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.pivotGridFieldCaja.Width = 194;
            // 
            // pivotGridFieldIdEmpresa
            // 
            this.pivotGridFieldIdEmpresa.AreaIndex = 0;
            this.pivotGridFieldIdEmpresa.Caption = "IdEmpresa";
            this.pivotGridFieldIdEmpresa.FieldName = "IdEmpresa";
            this.pivotGridFieldIdEmpresa.Name = "pivotGridFieldIdEmpresa";
            // 
            // pivotGridFieldIdCbteCble
            // 
            this.pivotGridFieldIdCbteCble.AreaIndex = 1;
            this.pivotGridFieldIdCbteCble.Caption = "IdCbteCble";
            this.pivotGridFieldIdCbteCble.FieldName = "IdCbteCble";
            this.pivotGridFieldIdCbteCble.Name = "pivotGridFieldIdCbteCble";
            // 
            // pivotGridFieldIdTipocbte
            // 
            this.pivotGridFieldIdTipocbte.AreaIndex = 2;
            this.pivotGridFieldIdTipocbte.Caption = "IdTipocbte";
            this.pivotGridFieldIdTipocbte.FieldName = "IdTipocbte";
            this.pivotGridFieldIdTipocbte.Name = "pivotGridFieldIdTipocbte";
            // 
            // pivotGridFieldTipo_Cbte
            // 
            this.pivotGridFieldTipo_Cbte.AreaIndex = 3;
            this.pivotGridFieldTipo_Cbte.Caption = "Tipo Cbte";
            this.pivotGridFieldTipo_Cbte.FieldName = "Tipo_Cbte";
            this.pivotGridFieldTipo_Cbte.Name = "pivotGridFieldTipo_Cbte";
            // 
            // pivotGridFieldcod_caja
            // 
            this.pivotGridFieldcod_caja.AreaIndex = 4;
            this.pivotGridFieldcod_caja.Caption = "código";
            this.pivotGridFieldcod_caja.FieldName = "cod_caja";
            this.pivotGridFieldcod_caja.Name = "pivotGridFieldcod_caja";
            // 
            // pivotGridFieldSucursal
            // 
            this.pivotGridFieldSucursal.AreaIndex = 5;
            this.pivotGridFieldSucursal.Caption = "Sucursal";
            this.pivotGridFieldSucursal.FieldName = "Sucursal";
            this.pivotGridFieldSucursal.Name = "pivotGridFieldSucursal";
            // 
            // pivotGridFieldTipo
            // 
            this.pivotGridFieldTipo.AreaIndex = 6;
            this.pivotGridFieldTipo.Caption = "Tipo";
            this.pivotGridFieldTipo.FieldName = "Tipo";
            this.pivotGridFieldTipo.Name = "pivotGridFieldTipo";
            // 
            // pivotGridFieldBeneficiario
            // 
            this.pivotGridFieldBeneficiario.AreaIndex = 7;
            this.pivotGridFieldBeneficiario.Caption = "Beneficiario";
            this.pivotGridFieldBeneficiario.FieldName = "Beneficiario";
            this.pivotGridFieldBeneficiario.Name = "pivotGridFieldBeneficiario";
            // 
            // pivotGridFieldFecha
            // 
            this.pivotGridFieldFecha.AreaIndex = 8;
            this.pivotGridFieldFecha.Caption = "Fecha";
            this.pivotGridFieldFecha.FieldName = "Fecha";
            this.pivotGridFieldFecha.Name = "pivotGridFieldFecha";
            // 
            // pivotGridFieldTipo_Movi_Caja
            // 
            this.pivotGridFieldTipo_Movi_Caja.AreaIndex = 9;
            this.pivotGridFieldTipo_Movi_Caja.Caption = "Tipo Movimiento";
            this.pivotGridFieldTipo_Movi_Caja.FieldName = "Tipo_Movi_Caja";
            this.pivotGridFieldTipo_Movi_Caja.Name = "pivotGridFieldTipo_Movi_Caja";
            // 
            // pivotGridFieldIdCobro_tipo
            // 
            this.pivotGridFieldIdCobro_tipo.AreaIndex = 10;
            this.pivotGridFieldIdCobro_tipo.Caption = "IdCobro";
            this.pivotGridFieldIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.pivotGridFieldIdCobro_tipo.Name = "pivotGridFieldIdCobro_tipo";
            // 
            // pivotGridFieldBanco
            // 
            this.pivotGridFieldBanco.AreaIndex = 11;
            this.pivotGridFieldBanco.Caption = "Banco";
            this.pivotGridFieldBanco.FieldName = "Banco";
            this.pivotGridFieldBanco.Name = "pivotGridFieldBanco";
            // 
            // pivotGridFieldNum_Documento
            // 
            this.pivotGridFieldNum_Documento.AreaIndex = 12;
            this.pivotGridFieldNum_Documento.Caption = "N° Documento";
            this.pivotGridFieldNum_Documento.FieldName = "Num_Documento";
            this.pivotGridFieldNum_Documento.Name = "pivotGridFieldNum_Documento";
            // 
            // pivotGridFieldObservacion
            // 
            this.pivotGridFieldObservacion.AreaIndex = 13;
            this.pivotGridFieldObservacion.Caption = "Observacion";
            this.pivotGridFieldObservacion.FieldName = "Observacion";
            this.pivotGridFieldObservacion.Name = "pivotGridFieldObservacion";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.PVGrid_caja;
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
            this.chartControl1.Size = new System.Drawing.Size(1121, 245);
            this.chartControl1.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Imprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1121, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Imprimir
            // 
            this.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(23, 22);
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // fieldIdEstadoAprobacion1
            // 
            this.fieldIdEstadoAprobacion1.AreaIndex = 0;
            this.fieldIdEstadoAprobacion1.Caption = "Estado Aprobacion";
            this.fieldIdEstadoAprobacion1.FieldName = "IdEstadoAprobacion";
            this.fieldIdEstadoAprobacion1.Name = "fieldIdEstadoAprobacion1";
            // 
            // pivotGridFieldAnioFiscal
            // 
            this.pivotGridFieldAnioFiscal.AreaIndex = 15;
            this.pivotGridFieldAnioFiscal.Caption = "Año Fiscal";
            this.pivotGridFieldAnioFiscal.FieldName = "AnioFiscal";
            this.pivotGridFieldAnioFiscal.Name = "pivotGridFieldAnioFiscal";
            // 
            // pivotGridFieldMes
            // 
            this.pivotGridFieldMes.AreaIndex = 16;
            this.pivotGridFieldMes.Caption = "Mes";
            this.pivotGridFieldMes.FieldName = "Mes";
            this.pivotGridFieldMes.Name = "pivotGridFieldMes";
            // 
            // pivotGridFieldDia
            // 
            this.pivotGridFieldDia.AreaIndex = 17;
            this.pivotGridFieldDia.Caption = "Dia";
            this.pivotGridFieldDia.FieldName = "Dia";
            this.pivotGridFieldDia.Name = "pivotGridFieldDia";
            // 
            // pivotGridFieldIdCalendario
            // 
            this.pivotGridFieldIdCalendario.AreaIndex = 14;
            this.pivotGridFieldIdCalendario.Caption = "IdCalendario";
            this.pivotGridFieldIdCalendario.FieldName = "IdCalendario";
            this.pivotGridFieldIdCalendario.Name = "pivotGridFieldIdCalendario";
            // 
            // XCAJ_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 742);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "XCAJ_Rpt001_frm";
            this.Text = "MATRIZ DE CAJA";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlData)).EndInit();
            this.xtraTabControlData.ResumeLayout(false);
            this.xtraTabPage_Matriz_pivot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_caja)).EndInit();
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

        private Controles.UCCom_Menu_Reportes ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Imprimir;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlData;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Matriz_pivot;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_caja;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldValor;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldCaja;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdEmpresa;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdCbteCble;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdTipocbte;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTipo_Cbte;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldcod_caja;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldSucursal;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTipo;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldBeneficiario;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldFecha;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTipo_Movi_Caja;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdCobro_tipo;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldBanco;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldNum_Documento;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldObservacion;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdEstadoAprobacion1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldIdCalendario;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldAnioFiscal;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldMes;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDia;
    }
}