namespace Core.Erp.Reportes.Bancos
{
    partial class XBAN_Rpt007_saldos_rpt
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbl_detalle = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cel_det_saldo_inicial = new DevExpress.XtraReports.UI.XRTableCell();
            this.cel_det_saldo_final = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTipoSaldo = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.tbl_pieInforme = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cel_total_inicial = new DevExpress.XtraReports.UI.XRTableCell();
            this.cel_total_fin = new DevExpress.XtraReports.UI.XRTableCell();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pieInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbl_detalle});
            this.Detail.HeightF = 16.66666F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tbl_detalle
            // 
            this.tbl_detalle.Font = new System.Drawing.Font("Verdana", 8F);
            this.tbl_detalle.LocationFloat = new DevExpress.Utils.PointFloat(45.83333F, 0F);
            this.tbl_detalle.Name = "tbl_detalle";
            this.tbl_detalle.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tbl_detalle.SizeF = new System.Drawing.SizeF(678.9583F, 16.66666F);
            this.tbl_detalle.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.cel_det_saldo_inicial,
            this.cel_det_saldo_final});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nom_cuenta_banco")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "tblNom_cuenta";
            this.xrTableCell1.Weight = 2.3100961009451151D;
            // 
            // cel_det_saldo_inicial
            // 
            this.cel_det_saldo_inicial.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Saldo_inicial", "{0:n2}")});
            this.cel_det_saldo_inicial.Name = "cel_det_saldo_inicial";
            this.cel_det_saldo_inicial.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.cel_det_saldo_inicial.StylePriority.UsePadding = false;
            this.cel_det_saldo_inicial.StylePriority.UseTextAlignment = false;
            this.cel_det_saldo_inicial.Text = "tbl_saldoIni";
            this.cel_det_saldo_inicial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.cel_det_saldo_inicial.Weight = 0.37500024697717443D;
            // 
            // cel_det_saldo_final
            // 
            this.cel_det_saldo_final.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Saldo_final", "{0:n2}")});
            this.cel_det_saldo_final.Name = "cel_det_saldo_final";
            this.cel_det_saldo_final.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.cel_det_saldo_final.StylePriority.UsePadding = false;
            this.cel_det_saldo_final.StylePriority.UseTextAlignment = false;
            this.cel_det_saldo_final.Text = "tblsaldoFin";
            this.cel_det_saldo_final.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.cel_det_saldo_final.Weight = 0.3149036582553964D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 17.54166F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 28.75001F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTipoSaldo});
            this.ReportHeader.HeightF = 22.91667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblTipoSaldo
            // 
            this.lblTipoSaldo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblTipoSaldo.LocationFloat = new DevExpress.Utils.PointFloat(45.83333F, 0F);
            this.lblTipoSaldo.Name = "lblTipoSaldo";
            this.lblTipoSaldo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTipoSaldo.SizeF = new System.Drawing.SizeF(678.9583F, 19.58332F);
            this.lblTipoSaldo.StylePriority.UseFont = false;
            this.lblTipoSaldo.StylePriority.UseTextAlignment = false;
            this.lblTipoSaldo.Text = "lblTipoSaldo";
            this.lblTipoSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbl_pieInforme});
            this.ReportFooter.HeightF = 16.66666F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // tbl_pieInforme
            // 
            this.tbl_pieInforme.Font = new System.Drawing.Font("Verdana", 8F);
            this.tbl_pieInforme.LocationFloat = new DevExpress.Utils.PointFloat(45.83324F, 0F);
            this.tbl_pieInforme.Name = "tbl_pieInforme";
            this.tbl_pieInforme.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tbl_pieInforme.SizeF = new System.Drawing.SizeF(678.9584F, 16.66666F);
            this.tbl_pieInforme.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.cel_total_inicial,
            this.cel_total_fin});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "TOTAL";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 1.9214743443981592D;
            // 
            // cel_total_inicial
            // 
            this.cel_total_inicial.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.cel_total_inicial.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Saldo_inicial")});
            this.cel_total_inicial.Name = "cel_total_inicial";
            this.cel_total_inicial.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.cel_total_inicial.StylePriority.UseBorders = false;
            this.cel_total_inicial.StylePriority.UsePadding = false;
            this.cel_total_inicial.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cel_total_inicial.Summary = xrSummary1;
            this.cel_total_inicial.Text = "cel_total_inicial";
            this.cel_total_inicial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.cel_total_inicial.Weight = 0.37500024697717443D;
            // 
            // cel_total_fin
            // 
            this.cel_total_fin.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.cel_total_fin.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Saldo_final")});
            this.cel_total_fin.Name = "cel_total_fin";
            this.cel_total_fin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.cel_total_fin.StylePriority.UseBorders = false;
            this.cel_total_fin.StylePriority.UsePadding = false;
            this.cel_total_fin.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cel_total_fin.Summary = xrSummary2;
            this.cel_total_fin.Text = "cel_total_fin";
            this.cel_total_fin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.cel_total_fin.Weight = 0.3149036582553964D;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Reportes.Bancos.XBAN_Rpt007_saldos_Info);
            // 
            // XBAN_Rpt007_saldos_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(21, 26, 18, 29);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XBAN_Rpt007_rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pieInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable tbl_detalle;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell cel_det_saldo_inicial;
        private DevExpress.XtraReports.UI.XRTableCell cel_det_saldo_final;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTipoSaldo;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable tbl_pieInforme;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell cel_total_inicial;
        private DevExpress.XtraReports.UI.XRTableCell cel_total_fin;
    }
}
