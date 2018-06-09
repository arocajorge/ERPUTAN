namespace Core.Erp.Reportes.ActivoFijo
{
    partial class XACTF_Rpt005_rpt
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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.lblIdActivoFijo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIdUsuario = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPeriodoFin = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPeriodoIni = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDepreciacion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFechaImpresion = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xlbl_idReporte = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrPivotAf_Nombre = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotDepre = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Periodo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotValor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.IdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdTipoDepreciacion = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdActivoFijo = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdPeriodoIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdPeriodoFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 8.333333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel9,
            this.xrLine1,
            this.xrLine2,
            this.xrPanel1});
            this.ReportHeader.HeightF = 149.5417F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Logo")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.5F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(164.5833F, 44.70834F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 65.70834F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(587.5F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Reporte Montos Mensuales de Importe en Libros de los AF.";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1103F, 10.5F);
            // 
            // xrLine2
            // 
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55.20833F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1103F, 10.5F);
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 2;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblIdActivoFijo,
            this.xrLabel1,
            this.lblIdUsuario,
            this.lblPeriodoFin,
            this.lblPeriodoIni,
            this.lblDepreciacion,
            this.xrLabel39,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.70831F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(1101.75F, 60.83335F);
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // lblIdActivoFijo
            // 
            this.lblIdActivoFijo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblIdActivoFijo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdActivoFijo.LocationFloat = new DevExpress.Utils.PointFloat(90.08296F, 10F);
            this.lblIdActivoFijo.Name = "lblIdActivoFijo";
            this.lblIdActivoFijo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblIdActivoFijo.SizeF = new System.Drawing.SizeF(309.5004F, 23F);
            this.lblIdActivoFijo.StylePriority.UseBorders = false;
            this.lblIdActivoFijo.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 10.00009F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(80.08292F, 23F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Activo Fijo:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblIdUsuario.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.LocationFloat = new DevExpress.Utils.PointFloat(885.6255F, 33.00012F);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblIdUsuario.SizeF = new System.Drawing.SizeF(137.4999F, 23F);
            this.lblIdUsuario.StylePriority.UseBorders = false;
            this.lblIdUsuario.StylePriority.UseFont = false;
            // 
            // lblPeriodoFin
            // 
            this.lblPeriodoFin.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPeriodoFin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoFin.LocationFloat = new DevExpress.Utils.PointFloat(543.8754F, 32.99999F);
            this.lblPeriodoFin.Name = "lblPeriodoFin";
            this.lblPeriodoFin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPeriodoFin.SizeF = new System.Drawing.SizeF(122.0003F, 23F);
            this.lblPeriodoFin.StylePriority.UseBorders = false;
            this.lblPeriodoFin.StylePriority.UseFont = false;
            this.lblPeriodoFin.Text = "lblPeriodoFin";
            // 
            // lblPeriodoIni
            // 
            this.lblPeriodoIni.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblPeriodoIni.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoIni.LocationFloat = new DevExpress.Utils.PointFloat(90.08296F, 32.99999F);
            this.lblPeriodoIni.Name = "lblPeriodoIni";
            this.lblPeriodoIni.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPeriodoIni.SizeF = new System.Drawing.SizeF(191.6668F, 23F);
            this.lblPeriodoIni.StylePriority.UseBorders = false;
            this.lblPeriodoIni.StylePriority.UseFont = false;
            this.lblPeriodoIni.Text = "lblPeriodoIni";
            // 
            // lblDepreciacion
            // 
            this.lblDepreciacion.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblDepreciacion.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepreciacion.LocationFloat = new DevExpress.Utils.PointFloat(587.5001F, 10.0001F);
            this.lblDepreciacion.Name = "lblDepreciacion";
            this.lblDepreciacion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDepreciacion.SizeF = new System.Drawing.SizeF(436.5837F, 23F);
            this.lblDepreciacion.StylePriority.UseBorders = false;
            this.lblDepreciacion.StylePriority.UseFont = false;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(817.9171F, 33.00012F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(67.70831F, 23.00001F);
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.Text = "Usuario:";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(489.7088F, 32.99999F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(54.16669F, 23F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Hasta:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 33.00002F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(64.58332F, 23F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Desde:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(489.7088F, 10.0001F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(97.79126F, 23F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Depreciación:";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel42,
            this.lblFechaImpresion});
            this.PageHeader.HeightF = 11.45833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1043.646F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(54.87512F, 10.00001F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(1004.062F, 0F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(39.58331F, 10.00001F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.Text = "Pagina:";
            // 
            // lblFechaImpresion
            // 
            this.lblFechaImpresion.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaImpresion.LocationFloat = new DevExpress.Utils.PointFloat(4.478943F, 0F);
            this.lblFechaImpresion.Name = "lblFechaImpresion";
            this.lblFechaImpresion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechaImpresion.SizeF = new System.Drawing.SizeF(344.7917F, 10.00001F);
            this.lblFechaImpresion.StylePriority.UseFont = false;
            this.lblFechaImpresion.Text = "lblFechaImpresion";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlbl_idReporte});
            this.PageFooter.HeightF = 23.95833F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xlbl_idReporte
            // 
            this.xlbl_idReporte.Font = new System.Drawing.Font("Verdana", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_idReporte.LocationFloat = new DevExpress.Utils.PointFloat(970.4166F, 0F);
            this.xlbl_idReporte.Name = "xlbl_idReporte";
            this.xlbl_idReporte.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_idReporte.SizeF = new System.Drawing.SizeF(131.3333F, 23F);
            this.xlbl_idReporte.StylePriority.UseFont = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.GroupHeader1.HeightF = 111.4583F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.BackColor = System.Drawing.Color.White;
            this.xrPivotGrid1.Appearance.Cell.BorderColor = System.Drawing.Color.White;
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.xrPivotGrid1.Appearance.CustomTotalCell.BackColor = System.Drawing.Color.White;
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Appearance.FilterSeparator.BackColor = System.Drawing.Color.White;
            this.xrPivotGrid1.Appearance.Lines.BackColor = System.Drawing.Color.White;
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.xrPivotAf_Nombre,
            this.xrPivotDepre,
            this.Periodo,
            this.xrPivotValor});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300;
            this.xrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.xrPivotGrid1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(462.9167F, 88.33332F);
            // 
            // xrPivotAf_Nombre
            // 
            this.xrPivotAf_Nombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotAf_Nombre.AreaIndex = 0;
            this.xrPivotAf_Nombre.Caption = "Activo Fijo";
            this.xrPivotAf_Nombre.FieldName = "Af_Nombre";
            this.xrPivotAf_Nombre.Name = "xrPivotAf_Nombre";
            this.xrPivotAf_Nombre.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.xrPivotAf_Nombre.Width = 160;
            // 
            // xrPivotDepre
            // 
            this.xrPivotDepre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotDepre.AreaIndex = 1;
            this.xrPivotDepre.Caption = "Tipo Depreciacion";
            this.xrPivotDepre.FieldName = "nom_tipo_depreciacion";
            this.xrPivotDepre.Name = "xrPivotDepre";
            this.xrPivotDepre.Width = 140;
            // 
            // Periodo
            // 
            this.Periodo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Periodo.AreaIndex = 0;
            this.Periodo.FieldName = "Periodo_Mes";
            this.Periodo.Name = "Periodo";
            this.Periodo.Width = 68;
            // 
            // xrPivotValor
            // 
            this.xrPivotValor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.xrPivotValor.AreaIndex = 0;
            this.xrPivotValor.Caption = "Valor";
            this.xrPivotValor.FieldName = "Valor_Importe";
            this.xrPivotValor.Name = "xrPivotValor";
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Description = "Parameter1";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Type = typeof(int);
            this.IdEmpresa.Value = 0;
            // 
            // IdTipoDepreciacion
            // 
            this.IdTipoDepreciacion.Description = "Parameter1";
            this.IdTipoDepreciacion.Name = "IdTipoDepreciacion";
            this.IdTipoDepreciacion.Type = typeof(int);
            this.IdTipoDepreciacion.Value = 0;
            // 
            // IdActivoFijo
            // 
            this.IdActivoFijo.Description = "Parameter1";
            this.IdActivoFijo.Name = "IdActivoFijo";
            this.IdActivoFijo.Type = typeof(int);
            this.IdActivoFijo.Value = 0;
            // 
            // IdPeriodoIni
            // 
            this.IdPeriodoIni.Description = "Parameter1";
            this.IdPeriodoIni.Name = "IdPeriodoIni";
            this.IdPeriodoIni.Type = typeof(int);
            this.IdPeriodoIni.Value = 0;
            // 
            // IdPeriodoFin
            // 
            this.IdPeriodoFin.Description = "Parameter1";
            this.IdPeriodoFin.Name = "IdPeriodoFin";
            this.IdPeriodoFin.Type = typeof(int);
            this.IdPeriodoFin.Value = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Reportes.ActivoFijo.XACTF_Rpt005_Info);
            // 
            // XACTF_Rpt005_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(42, 24, 23, 50);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Rotated;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdEmpresa,
            this.IdTipoDepreciacion,
            this.IdActivoFijo,
            this.IdPeriodoIni,
            this.IdPeriodoFin});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XACTF_Rpt005_rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel lblIdActivoFijo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblIdUsuario;
        private DevExpress.XtraReports.UI.XRLabel lblPeriodoFin;
        private DevExpress.XtraReports.UI.XRLabel lblPeriodoIni;
        private DevExpress.XtraReports.UI.XRLabel lblDepreciacion;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel lblFechaImpresion;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xlbl_idReporte;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotAf_Nombre;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotDepre;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Periodo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotValor;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpresa;
        private DevExpress.XtraReports.Parameters.Parameter IdTipoDepreciacion;
        private DevExpress.XtraReports.Parameters.Parameter IdActivoFijo;
        private DevExpress.XtraReports.Parameters.Parameter IdPeriodoIni;
        private DevExpress.XtraReports.Parameters.Parameter IdPeriodoFin;
    }
}
