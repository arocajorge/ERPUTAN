namespace Cus.Erp.Reports.FJ.Facturacion
{
    partial class XFAC_FJ_Rpt008_Rpt
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
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.Periodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.Col_zo_descripcion = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_em_fecha_ingreso = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_pe_FechaIni = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_fechaSalida = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_pe_cedulaRuc = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_Nombres = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_cargo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_SueldoActual = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_Orden = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_Valor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Col_ru_descripcion = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.IdPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.Suma_subtotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.fee = new DevExpress.XtraReports.Parameters.Parameter();
            this.Anio = new DevExpress.XtraReports.Parameters.Parameter();
            this.Mes = new DevExpress.XtraReports.Parameters.Parameter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 31.25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrPictureBox1,
            this.xrLabel17,
            this.xrLabel18});
            this.TopMargin.HeightF = 83F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Periodo, "Text", "")});
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(367.7084F, 56.00001F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(422.7085F, 23F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "xrLabel19";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Periodo
            // 
            this.Periodo.Description = "Mes";
            this.Periodo.Name = "Periodo";
            this.Periodo.Value = "";
            this.Periodo.Visible = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "em_logo")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 8.124988F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(180.6249F, 64.87502F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "em_nombre")});
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(406.0519F, 10.00001F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(338.74F, 23F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel11";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(205.2084F, 33.00001F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(800.5427F, 23F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "COMPANIA DE TRANSPORTE DE CARGA  PESADA  Y EQUIPO CAMINERO  TRANSGANDIA S.A.";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("nom_Centro_costo_sub_centro_costo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 69.7917F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.Cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Verdana", 5F);
            this.xrPivotGrid1.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.FilterSeparator.BackColor = System.Drawing.Color.Yellow;
            this.xrPivotGrid1.Appearance.FilterSeparator.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.HeaderGroupLine.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Verdana", 5.25F);
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.Col_zo_descripcion,
            this.Col_em_fecha_ingreso,
            this.Col_pe_FechaIni,
            this.Col_fechaSalida,
            this.Col_pe_cedulaRuc,
            this.Col_Nombres,
            this.Col_cargo,
            this.Col_SueldoActual,
            this.Col_Orden,
            this.Col_Valor,
            this.Col_ru_descripcion});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300;
            this.xrPivotGrid1.OptionsPrint.MergeColumnFieldValues = false;
            this.xrPivotGrid1.OptionsPrint.MergeRowFieldValues = false;
            this.xrPivotGrid1.OptionsPrint.PrintUnusedFilterFields = false;
            this.xrPivotGrid1.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
            this.xrPivotGrid1.OptionsView.FilterSeparatorBarPadding = 5;
            this.xrPivotGrid1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Near;
            this.xrPivotGrid1.OptionsView.RowTreeOffset = 10;
            this.xrPivotGrid1.OptionsView.RowTreeWidth = 660;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowColumnTotals = false;
            this.xrPivotGrid1.OptionsView.ShowFilterSeparatorBar = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowRowTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1273.958F, 66.6667F);
            // 
            // Col_zo_descripcion
            // 
            this.Col_zo_descripcion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_zo_descripcion.AreaIndex = 0;
            this.Col_zo_descripcion.Caption = "Sector";
            this.Col_zo_descripcion.FieldName = "zo_descripcion";
            this.Col_zo_descripcion.Name = "Col_zo_descripcion";
            // 
            // Col_em_fecha_ingreso
            // 
            this.Col_em_fecha_ingreso.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_em_fecha_ingreso.AreaIndex = 1;
            this.Col_em_fecha_ingreso.Caption = "Fecha Ingreso";
            this.Col_em_fecha_ingreso.FieldName = "em_fecha_ingreso";
            this.Col_em_fecha_ingreso.Name = "Col_em_fecha_ingreso";
            // 
            // Col_pe_FechaIni
            // 
            this.Col_pe_FechaIni.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_FechaIni.AreaIndex = 2;
            this.Col_pe_FechaIni.Caption = "Fecha Mes";
            this.Col_pe_FechaIni.FieldName = "pe_FechaIni";
            this.Col_pe_FechaIni.Name = "Col_pe_FechaIni";
            // 
            // Col_fechaSalida
            // 
            this.Col_fechaSalida.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_fechaSalida.AreaIndex = 3;
            this.Col_fechaSalida.Caption = "Fecha Salida";
            this.Col_fechaSalida.FieldName = "ca_descripcion";
            this.Col_fechaSalida.Name = "Col_fechaSalida";
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_cedulaRuc.AreaIndex = 4;
            this.Col_pe_cedulaRuc.Caption = "Cédula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            // 
            // Col_Nombres
            // 
            this.Col_Nombres.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Nombres.AreaIndex = 5;
            this.Col_Nombres.Caption = "Nombres";
            this.Col_Nombres.FieldName = "Nombres";
            this.Col_Nombres.Name = "Col_Nombres";
            // 
            // Col_cargo
            // 
            this.Col_cargo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_cargo.AreaIndex = 6;
            this.Col_cargo.Caption = "Cargo";
            this.Col_cargo.FieldName = "ca_descripcion";
            this.Col_cargo.Name = "Col_cargo";
            // 
            // Col_SueldoActual
            // 
            this.Col_SueldoActual.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_SueldoActual.AreaIndex = 7;
            this.Col_SueldoActual.Caption = "Sueldo";
            this.Col_SueldoActual.FieldName = "SueldoActual";
            this.Col_SueldoActual.Name = "Col_SueldoActual";
            // 
            // Col_Orden
            // 
            this.Col_Orden.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_Orden.AreaIndex = 0;
            this.Col_Orden.FieldName = "Orden";
            this.Col_Orden.Name = "Col_Orden";
            // 
            // Col_Valor
            // 
            this.Col_Valor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.Col_Valor.AreaIndex = 0;
            this.Col_Valor.Caption = "Valor";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            // 
            // Col_ru_descripcion
            // 
            this.Col_ru_descripcion.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_ru_descripcion.AreaIndex = 1;
            this.Col_ru_descripcion.Caption = "Concepto";
            this.Col_ru_descripcion.FieldName = "ru_descripcion";
            this.Col_ru_descripcion.Name = "Col_ru_descripcion";
            // 
            // IdPeriodo
            // 
            this.IdPeriodo.Description = "IdPeriodo";
            this.IdPeriodo.Name = "IdPeriodo";
            this.IdPeriodo.Type = typeof(int);
            this.IdPeriodo.Value = 0;
            this.IdPeriodo.Visible = false;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Description = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Type = typeof(int);
            this.IdEmpresa.Value = 0;
            this.IdEmpresa.Visible = false;
            // 
            // Suma_subtotal
            // 
            this.Suma_subtotal.Expression = "[Parameters.fee]";
            this.Suma_subtotal.Name = "Suma_subtotal";
            // 
            // fee
            // 
            this.fee.Description = "fee";
            this.fee.Name = "fee";
            this.fee.Type = typeof(double);
            this.fee.Value = 0D;
            this.fee.Visible = false;
            // 
            // Anio
            // 
            this.Anio.Description = "Anio";
            this.Anio.Name = "Anio";
            this.Anio.Type = typeof(int);
            this.Anio.Value = 0;
            this.Anio.Visible = false;
            // 
            // Mes
            // 
            this.Mes.Description = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.Type = typeof(int);
            this.Mes.Value = 0;
            this.Mes.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Cus.Erp.Reports.FJ.Facturacion.XFAC_FJ_Rpt008_Info);
            // 
            // XFAC_FJ_Rpt008_Rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Suma_subtotal});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(16, 12, 83, 100);
            this.PageHeight = 850;
            this.PageWidth = 50000;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdPeriodo,
            this.Periodo,
            this.IdEmpresa,
            this.fee,
            this.Anio,
            this.Mes});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XFAC_FJ_Rpt008_Rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.Parameters.Parameter IdPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter Periodo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpresa;
        private DevExpress.XtraReports.UI.CalculatedField Suma_subtotal;
        private DevExpress.XtraReports.Parameters.Parameter fee;
        private DevExpress.XtraReports.Parameters.Parameter Anio;
        private DevExpress.XtraReports.Parameters.Parameter Mes;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_zo_descripcion;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_em_fecha_ingreso;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_pe_FechaIni;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_fechaSalida;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_pe_cedulaRuc;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_Nombres;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_cargo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_SueldoActual;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_Orden;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_Valor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField Col_ru_descripcion;
    }
}
