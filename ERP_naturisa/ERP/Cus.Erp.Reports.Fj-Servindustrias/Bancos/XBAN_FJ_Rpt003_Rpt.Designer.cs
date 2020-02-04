namespace Cus.Erp.Reports.FJ.Bancos
{
    partial class XBAN_FJ_Rpt003_Rpt
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel2 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.cc_porcentaje = new DevExpress.XtraReports.UI.CalculatedField();
            this.IdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.FechaInicio = new DevExpress.XtraReports.Parameters.Parameter();
            this.FechaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Porcentaje", "{0:0.00%}")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(339.8611F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(86.80554F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cb_Valor", "{0:#.00}")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(248.8889F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(90.97224F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tc_TipoCbte")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(238.8889F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart1.DataSource = this.bindingSource1;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.xrChart1.Diagram = simpleDiagram3D1;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(450F, 12.5F);
            this.xrChart1.Name = "xrChart1";
            series1.ArgumentDataMember = "tc_TipoCbte";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.DataFiltersConjunctionMode = DevExpress.XtraCharts.ConjunctionTypes.Or;
            pie3DSeriesLabel1.LineVisible = true;
            series1.Label = pie3DSeriesLabel1;
            series1.Name = "Flujo Egreso";
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.SummaryFunction = "SUM([cb_Valor])";
            series1.View = pie3DSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pie3DSeriesLabel2.LineVisible = true;
            this.xrChart1.SeriesTemplate.Label = pie3DSeriesLabel2;
            this.xrChart1.SeriesTemplate.View = pie3DSeriesView2;
            this.xrChart1.SizeF = new System.Drawing.SizeF(327.5417F, 172.2917F);
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.TopMargin.HeightF = 91.66666F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 66.66666F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(429.1667F, 25F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "TIPO FLUJO";
            this.xrTableCell1.Weight = 1.7199999648437516D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "DEBITO";
            this.xrTableCell2.Weight = 0.65500009008788618D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "PORCENTUAL";
            this.xrTableCell3.Weight = 0.7149999406738311D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.BottomMargin.HeightF = 192.5416F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // cc_porcentaje
            // 
            this.cc_porcentaje.Expression = "[cb_Valor] / [cb_total]";
            this.cc_porcentaje.Name = "cc_porcentaje";
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Description = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Type = typeof(int);
            this.IdEmpresa.Value = 0;
            this.IdEmpresa.Visible = false;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Type = typeof(System.DateTime);
            this.FechaInicio.Visible = false;
            // 
            // FechaFin
            // 
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Type = typeof(System.DateTime);
            this.FechaFin.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Cus.Erp.Reports.FJ.Bancos.XBAN_FJ_Rpt003_Info);
            // 
            // XBAN_FJ_Rpt003_Rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cc_porcentaje});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(25, 26, 92, 193);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdEmpresa,
            this.FechaInicio,
            this.FechaFin});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XBAN_FJ_Rpt003_Rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.CalculatedField cc_porcentaje;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpresa;
        private DevExpress.XtraReports.Parameters.Parameter FechaInicio;
        private DevExpress.XtraReports.Parameters.Parameter FechaFin;
    }
}
