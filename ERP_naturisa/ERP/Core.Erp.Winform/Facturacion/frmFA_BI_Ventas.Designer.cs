namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_BI_Ventas
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
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Total General");
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pivotGridControlVentas = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldMargenUtilidad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSubtotal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCliente = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEmpresa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProducto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVendedor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAnioFiscal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFecha = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTrimestre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Imprimir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pivotGridControlVentas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainer1.Size = new System.Drawing.Size(826, 435);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 2;
            // 
            // pivotGridControlVentas
            // 
            this.pivotGridControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlVentas.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldMargenUtilidad,
            this.fieldSubtotal,
            this.fieldCliente,
            this.fieldEmpresa,
            this.fieldProducto,
            this.fieldVendedor,
            this.fieldAnioFiscal,
            this.fieldMes,
            this.fieldFecha,
            this.fieldTrimestre});
            this.pivotGridControlVentas.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControlVentas.Name = "pivotGridControlVentas";
            this.pivotGridControlVentas.OLAPConnectionString = "provider=MSOLAP;data source=localhost;initial catalog=DataWareHouseFacturacion;cu" +
    "be name=Facturacion";
            this.pivotGridControlVentas.Size = new System.Drawing.Size(826, 290);
            this.pivotGridControlVentas.TabIndex = 0;
            // 
            // fieldMargenUtilidad
            // 
            this.fieldMargenUtilidad.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMargenUtilidad.AreaIndex = 1;
            this.fieldMargenUtilidad.Caption = "Total Margen";
            this.fieldMargenUtilidad.DisplayFolder = "FAC Ventas";
            this.fieldMargenUtilidad.FieldName = "[Measures].[Margen Utilidad]";
            this.fieldMargenUtilidad.Name = "fieldMargenUtilidad";
            // 
            // fieldSubtotal
            // 
            this.fieldSubtotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSubtotal.AreaIndex = 0;
            this.fieldSubtotal.Caption = "Total Vta";
            this.fieldSubtotal.DisplayFolder = "FAC Ventas";
            this.fieldSubtotal.FieldName = "[Measures].[Subtotal]";
            this.fieldSubtotal.Name = "fieldSubtotal";
            // 
            // fieldCliente
            // 
            this.fieldCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCliente.AreaIndex = 0;
            this.fieldCliente.Caption = "Cliente";
            this.fieldCliente.FieldName = "[Cliente].[Cliente].[Cliente]";
            this.fieldCliente.Name = "fieldCliente";
            // 
            // fieldEmpresa
            // 
            this.fieldEmpresa.AreaIndex = 0;
            this.fieldEmpresa.Caption = "Empresa";
            this.fieldEmpresa.FieldName = "[Empresa].[Empresa].[Empresa]";
            this.fieldEmpresa.Name = "fieldEmpresa";
            // 
            // fieldProducto
            // 
            this.fieldProducto.AreaIndex = 1;
            this.fieldProducto.Caption = "Producto";
            this.fieldProducto.FieldName = "[Producto].[Producto].[Producto]";
            this.fieldProducto.Name = "fieldProducto";
            // 
            // fieldVendedor
            // 
            this.fieldVendedor.AreaIndex = 2;
            this.fieldVendedor.Caption = "Vendedor";
            this.fieldVendedor.FieldName = "[Vendedor].[Vendedor].[Vendedor]";
            this.fieldVendedor.Name = "fieldVendedor";
            // 
            // fieldAnioFiscal
            // 
            this.fieldAnioFiscal.AreaIndex = 6;
            this.fieldAnioFiscal.Caption = "AnioFiscal";
            this.fieldAnioFiscal.FieldName = "[Periodo].[AnioFiscal].[AnioFiscal]";
            this.fieldAnioFiscal.Name = "fieldAnioFiscal";
            // 
            // fieldMes
            // 
            this.fieldMes.AreaIndex = 3;
            this.fieldMes.Caption = "Mes";
            this.fieldMes.FieldName = "[Periodo].[Mes].[Mes]";
            this.fieldMes.Name = "fieldMes";
            // 
            // fieldFecha
            // 
            this.fieldFecha.AreaIndex = 4;
            this.fieldFecha.Caption = "Fecha";
            this.fieldFecha.FieldName = "[Periodo].[Fecha].[Fecha]";
            this.fieldFecha.Name = "fieldFecha";
            // 
            // fieldTrimestre
            // 
            this.fieldTrimestre.AreaIndex = 5;
            this.fieldTrimestre.Caption = "Trimestre";
            this.fieldTrimestre.FieldName = "[Periodo].[Periodo_trimestrales].[Trimestre]";
            this.fieldTrimestre.Name = "fieldTrimestre";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControlVentas;
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
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Total General | Total Vta";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1});
            series1.Tag = "Total General | Total Vta";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(826, 141);
            this.chartControl1.TabIndex = 0;
            // 
            // frmFa_BI_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFa_BI_Ventas";
            this.Text = "Bussines Inteligent";
            this.Load += new System.EventHandler(this.frmFa_BI_Ventas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlVentas;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMargenUtilidad;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSubtotal;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCliente;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEmpresa;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProducto;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVendedor;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAnioFiscal;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMes;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFecha;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTrimestre;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}