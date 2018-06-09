namespace Core.Erp.Reportes.CuentasxCobrar
{
    partial class XCXC_Rpt001_frm
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pivotGridControlCobros = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldSucursal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldCliente = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldAnio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldMes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTotal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldTipoCobro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldDocumento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.ucFa_Menu = new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.ucFa_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 497);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pivotGridControlCobros);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 419);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 1;
            // 
            // pivotGridControlCobros
            // 
            this.pivotGridControlCobros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlCobros.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldSucursal,
            this.pivotGridFieldCliente,
            this.pivotGridFieldAnio,
            this.pivotGridFieldMes,
            this.pivotGridFieldTotal,
            this.pivotGridFieldTipoCobro,
            this.pivotGridFieldDocumento});
            this.pivotGridControlCobros.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControlCobros.Name = "pivotGridControlCobros";
            this.pivotGridControlCobros.OptionsLayout.Columns.StoreAppearance = true;
            this.pivotGridControlCobros.Size = new System.Drawing.Size(1045, 229);
            this.pivotGridControlCobros.TabIndex = 0;
            // 
            // pivotGridFieldSucursal
            // 
            this.pivotGridFieldSucursal.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldSucursal.AreaIndex = 0;
            this.pivotGridFieldSucursal.Caption = "Sucursal";
            this.pivotGridFieldSucursal.FieldName = "IdSucursal";
            this.pivotGridFieldSucursal.Name = "pivotGridFieldSucursal";
            // 
            // pivotGridFieldCliente
            // 
            this.pivotGridFieldCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldCliente.AreaIndex = 1;
            this.pivotGridFieldCliente.Caption = "Cliente";
            this.pivotGridFieldCliente.FieldName = "nombreCliente";
            this.pivotGridFieldCliente.Name = "pivotGridFieldCliente";
            // 
            // pivotGridFieldAnio
            // 
            this.pivotGridFieldAnio.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldAnio.AreaIndex = 0;
            this.pivotGridFieldAnio.Caption = "Año";
            this.pivotGridFieldAnio.FieldName = "AnioFiscal";
            this.pivotGridFieldAnio.Name = "pivotGridFieldAnio";
            // 
            // pivotGridFieldMes
            // 
            this.pivotGridFieldMes.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldMes.AreaIndex = 1;
            this.pivotGridFieldMes.Caption = "Mes";
            this.pivotGridFieldMes.FieldName = "NombreMes";
            this.pivotGridFieldMes.Name = "pivotGridFieldMes";
            // 
            // pivotGridFieldTotal
            // 
            this.pivotGridFieldTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridFieldTotal.AreaIndex = 0;
            this.pivotGridFieldTotal.Caption = "Total Cobrado";
            this.pivotGridFieldTotal.FieldName = "cr_TotalCobro";
            this.pivotGridFieldTotal.Name = "pivotGridFieldTotal";
            // 
            // pivotGridFieldTipoCobro
            // 
            this.pivotGridFieldTipoCobro.AreaIndex = 0;
            this.pivotGridFieldTipoCobro.Caption = "Tipo Cobro";
            this.pivotGridFieldTipoCobro.FieldName = "IdCobro_tipo";
            this.pivotGridFieldTipoCobro.Name = "pivotGridFieldTipoCobro";
            // 
            // pivotGridFieldDocumento
            // 
            this.pivotGridFieldDocumento.AreaIndex = 1;
            this.pivotGridFieldDocumento.Caption = "Documento";
            this.pivotGridFieldDocumento.FieldName = "numDocumento";
            this.pivotGridFieldDocumento.Name = "pivotGridFieldDocumento";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControlCobros;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(1045, 186);
            this.chartControl1.TabIndex = 0;
            // 
            // ucFa_Menu
            // 
            this.ucFa_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFa_Menu.EnableBotonImprimir = true;
            this.ucFa_Menu.EnableBotonRefrescar = true;
            this.ucFa_Menu.EnableBotonSalir = true;
            this.ucFa_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucFa_Menu.Name = "ucFa_Menu";
            this.ucFa_Menu.Size = new System.Drawing.Size(1045, 78);
            this.ucFa_Menu.TabIndex = 0;
            this.ucFa_Menu.VisibleBotonImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleBotonRefrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleBotonSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbCliente = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbMotivo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbSucursal = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucFa_Menu.VisibleCmbTipoDocumento = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbTipoPago = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleCmbTipoProducto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucFa_Menu.VisibleGrupoFecha = true;
            this.ucFa_Menu.VisibleGrupoMotivo = false;
            this.ucFa_Menu.VisibleGrupoOtros = true;
            this.ucFa_Menu.VisibleGrupoSucursal = true;
            this.ucFa_Menu.VisibleTipo = true;
            this.ucFa_Menu.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnConsultar_ItemClick(this.ucFa_Menu_event_btnConsultar_ItemClick);
            this.ucFa_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucFa_Menu_event_btnImprimir_ItemClick);
            this.ucFa_Menu.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCFa_Menu_Reportes.delegate_btnSalir_ItemClick(this.ucFa_Menu_event_btnSalir_ItemClick);
            // 
            // XCXC_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 497);
            this.Controls.Add(this.panel1);
            this.Name = "XCXC_Rpt001_frm";
            this.Text = "XCXC_Rpt001_frm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlCobros;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldSucursal;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldCliente;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldAnio;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldMes;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTotal;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldTipoCobro;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDocumento;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Controles.UCFa_Menu_Reportes ucFa_Menu;
    }
}