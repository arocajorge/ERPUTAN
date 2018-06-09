namespace Core.Erp.Reportes.Roles
{
    partial class XROL_Rpt013_rpt
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
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.ro_periodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.ro_dias_adicionales = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.ro_corte_actual = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.ro_fechaIngreso = new DevExpress.XtraReports.Parameters.Parameter();
            this.LbPeriodos = new DevExpress.XtraReports.UI.XRLabel();
            this.LbDiasAdicionales = new DevExpress.XtraReports.UI.XRLabel();
            this.LbCorteActual = new DevExpress.XtraReports.UI.XRLabel();
            this.LbFechaIngreso = new DevExpress.XtraReports.UI.XRLabel();
            this.lbSueldo = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNombres = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCedula = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.tot_ingreso_bruto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.lb_vacaciones = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_neto_recibir = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_IESS = new DevExpress.XtraReports.UI.XRLabel();
            this.lbtotal = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_Valor_adicional = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbRevisado = new DevExpress.XtraReports.UI.XRLabel();
            this.lbValorNeto = new DevExpress.XtraReports.UI.XRLabel();
            this.lbIess = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.LbValor_DiaAdicional = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabeTotIngreso = new DevExpress.XtraReports.UI.XRLabel();
            this.ro_TotIngresp = new DevExpress.XtraReports.UI.CalculatedField();
            this.ro_Valor_DiasAdicionales = new DevExpress.XtraReports.UI.CalculatedField();
            this.ro_total = new DevExpress.XtraReports.UI.CalculatedField();
            this.ro_iess = new DevExpress.XtraReports.UI.CalculatedField();
            this.ro_valor_neto = new DevExpress.XtraReports.UI.CalculatedField();
            this.ro_vacaciones = new DevExpress.XtraReports.UI.CalculatedField();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel4,
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pe_cedulaRuc")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(106.875F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Periodo")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(19.79167F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(68.75F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Ingreso", "{0:$0.00}")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(630.3748F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pe_nombreCompleto")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(233.9584F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(319.1667F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLine2,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.LbPeriodos,
            this.LbDiasAdicionales,
            this.LbCorteActual,
            this.LbFechaIngreso,
            this.lbSueldo,
            this.lbNombres,
            this.lbCedula,
            this.lbPeriodo});
            this.TopMargin.HeightF = 200.1249F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TopMargin.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TopMargin_BeforePrint);
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(233.9584F, 10.00001F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(359.125F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "LIQUIDACION DE VACACIONES ";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 52.62497F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(738.9999F, 23F);
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ro_periodo, "Text", "")});
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(285.0836F, 144.625F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(327.0833F, 23.00001F);
            this.xrLabel11.Text = "xrLabel11";
            // 
            // ro_periodo
            // 
            this.ro_periodo.Description = "ro_periodo";
            this.ro_periodo.Name = "ro_periodo";
            this.ro_periodo.Value = "";
            this.ro_periodo.Visible = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ro_dias_adicionales, "Text", "")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(285.0836F, 121.625F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // ro_dias_adicionales
            // 
            this.ro_dias_adicionales.Description = "ro_dias_Adicionales";
            this.ro_dias_adicionales.Name = "ro_dias_adicionales";
            this.ro_dias_adicionales.Type = typeof(int);
            this.ro_dias_adicionales.Value = 0;
            this.ro_dias_adicionales.Visible = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ro_corte_actual, "Text", "")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(285.0836F, 98.62498F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel9.Text = "xrLabel9";
            // 
            // ro_corte_actual
            // 
            this.ro_corte_actual.Description = "ro_corte_actual";
            this.ro_corte_actual.Name = "ro_corte_actual";
            this.ro_corte_actual.Value = "";
            this.ro_corte_actual.Visible = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ro_fechaIngreso, "Text", "")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(285.0836F, 75.62498F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // ro_fechaIngreso
            // 
            this.ro_fechaIngreso.Description = "ro_fechaIngreso";
            this.ro_fechaIngreso.Name = "ro_fechaIngreso";
            this.ro_fechaIngreso.Value = "";
            this.ro_fechaIngreso.Visible = false;
            // 
            // LbPeriodos
            // 
            this.LbPeriodos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbPeriodos.LocationFloat = new DevExpress.Utils.PointFloat(30.54137F, 144.625F);
            this.LbPeriodos.Name = "LbPeriodos";
            this.LbPeriodos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LbPeriodos.SizeF = new System.Drawing.SizeF(145.0836F, 23F);
            this.LbPeriodos.StylePriority.UseFont = false;
            this.LbPeriodos.Text = "PERIODO:";
            // 
            // LbDiasAdicionales
            // 
            this.LbDiasAdicionales.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbDiasAdicionales.LocationFloat = new DevExpress.Utils.PointFloat(30.54137F, 121.625F);
            this.LbDiasAdicionales.Name = "LbDiasAdicionales";
            this.LbDiasAdicionales.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LbDiasAdicionales.SizeF = new System.Drawing.SizeF(145.0836F, 23F);
            this.LbDiasAdicionales.StylePriority.UseFont = false;
            this.LbDiasAdicionales.Text = "DIAS ADICIONALES:";
            // 
            // LbCorteActual
            // 
            this.LbCorteActual.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbCorteActual.LocationFloat = new DevExpress.Utils.PointFloat(30.54137F, 98.62498F);
            this.LbCorteActual.Name = "LbCorteActual";
            this.LbCorteActual.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LbCorteActual.SizeF = new System.Drawing.SizeF(145.0836F, 23F);
            this.LbCorteActual.StylePriority.UseFont = false;
            this.LbCorteActual.Text = "CORTE ACTUAL:";
            // 
            // LbFechaIngreso
            // 
            this.LbFechaIngreso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbFechaIngreso.LocationFloat = new DevExpress.Utils.PointFloat(30.54137F, 75.62498F);
            this.LbFechaIngreso.Name = "LbFechaIngreso";
            this.LbFechaIngreso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LbFechaIngreso.SizeF = new System.Drawing.SizeF(145.0836F, 23F);
            this.LbFechaIngreso.StylePriority.UseFont = false;
            this.LbFechaIngreso.Text = "FECHA DE INGRESO:";
            // 
            // lbSueldo
            // 
            this.lbSueldo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSueldo.LocationFloat = new DevExpress.Utils.PointFloat(628.9999F, 177.1249F);
            this.lbSueldo.Name = "lbSueldo";
            this.lbSueldo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbSueldo.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbSueldo.StylePriority.UseFont = false;
            this.lbSueldo.Text = "Sueldo";
            // 
            // lbNombres
            // 
            this.lbNombres.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNombres.LocationFloat = new DevExpress.Utils.PointFloat(233.9584F, 177.1249F);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNombres.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbNombres.StylePriority.UseFont = false;
            this.lbNombres.Text = "Nombre";
            // 
            // lbCedula
            // 
            this.lbCedula.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCedula.LocationFloat = new DevExpress.Utils.PointFloat(106.875F, 177.1249F);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCedula.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbCedula.StylePriority.UseFont = false;
            this.lbCedula.Text = "Cedula";
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(19.79167F, 177.1249F);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPeriodo.SizeF = new System.Drawing.SizeF(48.95833F, 23F);
            this.lbPeriodo.StylePriority.UseFont = false;
            this.lbPeriodo.Text = "Periodo";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tot_ingreso_bruto,
            this.xrLabel12,
            this.xrLine3,
            this.lb_vacaciones,
            this.lb_neto_recibir,
            this.lb_IESS,
            this.lbtotal,
            this.lb_Valor_adicional,
            this.xrLine1,
            this.lbRevisado,
            this.lbValorNeto,
            this.lbIess,
            this.xrLabel13,
            this.LbValor_DiaAdicional,
            this.xrLabel6,
            this.xrLabeTotIngreso});
            this.BottomMargin.HeightF = 214.8748F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tot_ingreso_bruto
            // 
            this.tot_ingreso_bruto.LocationFloat = new DevExpress.Utils.PointFloat(630.3748F, 0F);
            this.tot_ingreso_bruto.Name = "tot_ingreso_bruto";
            this.tot_ingreso_bruto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tot_ingreso_bruto.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.tot_ingreso_bruto.Text = "vacaciones";
            // 
            // xrLabel12
            // 
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(233.9584F, 68.99999F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel12.Text = "Aprobado por:";
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(203.417F, 122.9166F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(175.625F, 22.99999F);
            // 
            // lb_vacaciones
            // 
            this.lb_vacaciones.LocationFloat = new DevExpress.Utils.PointFloat(628.9999F, 22.99999F);
            this.lb_vacaciones.Name = "lb_vacaciones";
            this.lb_vacaciones.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_vacaciones.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.lb_vacaciones.Text = "vacaciones";
            // 
            // lb_neto_recibir
            // 
            this.lb_neto_recibir.LocationFloat = new DevExpress.Utils.PointFloat(631.7499F, 122.9166F);
            this.lb_neto_recibir.Name = "lb_neto_recibir";
            this.lb_neto_recibir.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_neto_recibir.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.lb_neto_recibir.Text = "neto";
            // 
            // lb_IESS
            // 
            this.lb_IESS.LocationFloat = new DevExpress.Utils.PointFloat(631.7499F, 99.91659F);
            this.lb_IESS.Name = "lb_IESS";
            this.lb_IESS.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_IESS.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.lb_IESS.Text = "iess";
            // 
            // lbtotal
            // 
            this.lbtotal.LocationFloat = new DevExpress.Utils.PointFloat(631.7499F, 74.20829F);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbtotal.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.lbtotal.Text = "total";
            // 
            // lb_Valor_adicional
            // 
            this.lb_Valor_adicional.LocationFloat = new DevExpress.Utils.PointFloat(630.3748F, 51.20831F);
            this.lb_Valor_adicional.Name = "lb_Valor_adicional";
            this.lb_Valor_adicional.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_Valor_adicional.SizeF = new System.Drawing.SizeF(97.25006F, 23F);
            this.lb_Valor_adicional.Text = "valor adic";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 122.9166F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(175.625F, 22.99999F);
            // 
            // lbRevisado
            // 
            this.lbRevisado.LocationFloat = new DevExpress.Utils.PointFloat(30.54137F, 68.99999F);
            this.lbRevisado.Name = "lbRevisado";
            this.lbRevisado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbRevisado.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbRevisado.Text = "Realizado por:";
            // 
            // lbValorNeto
            // 
            this.lbValorNeto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbValorNeto.LocationFloat = new DevExpress.Utils.PointFloat(485.0835F, 115F);
            this.lbValorNeto.Name = "lbValorNeto";
            this.lbValorNeto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbValorNeto.SizeF = new System.Drawing.SizeF(127.0835F, 23F);
            this.lbValorNeto.StylePriority.UseFont = false;
            this.lbValorNeto.Text = "VALOR NETO";
            // 
            // lbIess
            // 
            this.lbIess.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbIess.LocationFloat = new DevExpress.Utils.PointFloat(485.0835F, 91.99998F);
            this.lbIess.Name = "lbIess";
            this.lbIess.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbIess.SizeF = new System.Drawing.SizeF(127.0835F, 23F);
            this.lbIess.StylePriority.UseFont = false;
            this.lbIess.Text = "IESS";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(485.0836F, 68.99999F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(127.0833F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "TOTAL";
            // 
            // LbValor_DiaAdicional
            // 
            this.LbValor_DiaAdicional.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbValor_DiaAdicional.LocationFloat = new DevExpress.Utils.PointFloat(485.0835F, 45.99997F);
            this.LbValor_DiaAdicional.Name = "LbValor_DiaAdicional";
            this.LbValor_DiaAdicional.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LbValor_DiaAdicional.SizeF = new System.Drawing.SizeF(127.0835F, 23F);
            this.LbValor_DiaAdicional.StylePriority.UseFont = false;
            this.LbValor_DiaAdicional.Text = "DIAS ADIC.";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(485.0836F, 22.99999F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(127.0833F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "VACACIONES";
            // 
            // xrLabeTotIngreso
            // 
            this.xrLabeTotIngreso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabeTotIngreso.LocationFloat = new DevExpress.Utils.PointFloat(485.0836F, 0F);
            this.xrLabeTotIngreso.Name = "xrLabeTotIngreso";
            this.xrLabeTotIngreso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabeTotIngreso.SizeF = new System.Drawing.SizeF(127.0833F, 23F);
            this.xrLabeTotIngreso.StylePriority.UseFont = false;
            this.xrLabeTotIngreso.Text = "TOTAL INGRESO";
            // 
            // ro_TotIngresp
            // 
            this.ro_TotIngresp.Name = "ro_TotIngresp";
            // 
            // ro_Valor_DiasAdicionales
            // 
            this.ro_Valor_DiasAdicionales.Expression = "[tot_Ingreso]/360*[Parameters.ro_dias_adicionales]";
            this.ro_Valor_DiasAdicionales.Name = "ro_Valor_DiasAdicionales";
            // 
            // ro_total
            // 
            this.ro_total.Name = "ro_total";
            // 
            // ro_iess
            // 
            this.ro_iess.Name = "ro_iess";
            // 
            // ro_valor_neto
            // 
            this.ro_valor_neto.Name = "ro_valor_neto";
            // 
            // ro_vacaciones
            // 
            this.ro_vacaciones.Expression = "[tot_Ingreso] / 24";
            this.ro_vacaciones.Name = "ro_vacaciones";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Reportes.Roles.XROL_Rpt013_Info);
            // 
            // XROL_Rpt013_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ro_TotIngresp,
            this.ro_Valor_DiasAdicionales,
            this.ro_total,
            this.ro_iess,
            this.ro_valor_neto,
            this.ro_vacaciones});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(63, 48, 200, 215);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ro_fechaIngreso,
            this.ro_corte_actual,
            this.ro_dias_adicionales,
            this.ro_periodo});
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabeTotIngreso;
        private DevExpress.XtraReports.UI.CalculatedField ro_TotIngresp;
        private DevExpress.XtraReports.UI.XRLabel lbCedula;
        private DevExpress.XtraReports.UI.XRLabel lbPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel lbSueldo;
        private DevExpress.XtraReports.UI.XRLabel lbNombres;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel LbDiasAdicionales;
        private DevExpress.XtraReports.UI.XRLabel LbCorteActual;
        private DevExpress.XtraReports.UI.XRLabel LbFechaIngreso;
        private DevExpress.XtraReports.UI.XRLabel LbPeriodos;
        private DevExpress.XtraReports.Parameters.Parameter ro_fechaIngreso;
        private DevExpress.XtraReports.Parameters.Parameter ro_corte_actual;
        private DevExpress.XtraReports.Parameters.Parameter ro_dias_adicionales;
        private DevExpress.XtraReports.Parameters.Parameter ro_periodo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel LbValor_DiaAdicional;
        private DevExpress.XtraReports.UI.CalculatedField ro_Valor_DiasAdicionales;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel lbIess;
        private DevExpress.XtraReports.UI.CalculatedField ro_total;
        private DevExpress.XtraReports.UI.CalculatedField ro_iess;
        private DevExpress.XtraReports.UI.CalculatedField ro_valor_neto;
        private DevExpress.XtraReports.UI.XRLabel lbValorNeto;
        private DevExpress.XtraReports.UI.CalculatedField ro_vacaciones;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lbRevisado;
        private DevExpress.XtraReports.UI.XRLabel lb_Valor_adicional;
        private DevExpress.XtraReports.UI.XRLabel lbtotal;
        private DevExpress.XtraReports.UI.XRLabel lb_neto_recibir;
        private DevExpress.XtraReports.UI.XRLabel lb_IESS;
        private DevExpress.XtraReports.UI.XRLabel lb_vacaciones;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel tot_ingreso_bruto;
    }
}
