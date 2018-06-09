namespace Cus.Erp.Reports.Talme.Roles
{
    partial class XROL_TALME_Rpt002_Rpt
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrSubreportRolCopia = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportRol = new DevExpress.XtraReports.UI.XRSubreport();
            this.PIdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdNomina_Tipo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdNominaTipoLiqui = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdDepartamento = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 20.83333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 40F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportRolCopia,
            this.xrSubreportRol});
            this.GroupHeader1.HeightF = 158.3333F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrSubreportRolCopia
            // 
            this.xrSubreportRolCopia.LocationFloat = new DevExpress.Utils.PointFloat(587F, 12.5F);
            this.xrSubreportRolCopia.Name = "xrSubreportRolCopia";
            this.xrSubreportRolCopia.ReportSource = new Cus.Erp.Reports.Talme.Roles.XROL_TALME_Rpt001_Rpt();
            this.xrSubreportRolCopia.SizeF = new System.Drawing.SizeF(196.88F, 132.38F);
            this.xrSubreportRolCopia.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreportRolCopia_BeforePrint);
            // 
            // xrSubreportRol
            // 
            this.xrSubreportRol.LocationFloat = new DevExpress.Utils.PointFloat(30F, 12.5F);
            this.xrSubreportRol.Name = "xrSubreportRol";
            this.xrSubreportRol.ReportSource = new Cus.Erp.Reports.Talme.Roles.XROL_TALME_Rpt001_Rpt();
            this.xrSubreportRol.SizeF = new System.Drawing.SizeF(196.88F, 132.38F);
            this.xrSubreportRol.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreportRol_BeforePrint);
            // 
            // PIdEmpresa
            // 
            this.PIdEmpresa.Name = "PIdEmpresa";
            this.PIdEmpresa.Type = typeof(int);
            // 
            // PIdNomina_Tipo
            // 
            this.PIdNomina_Tipo.Name = "PIdNomina_Tipo";
            this.PIdNomina_Tipo.Type = typeof(int);
            // 
            // PIdNominaTipoLiqui
            // 
            this.PIdNominaTipoLiqui.Name = "PIdNominaTipoLiqui";
            this.PIdNominaTipoLiqui.Type = typeof(int);
            // 
            // PIdPeriodo
            // 
            this.PIdPeriodo.Name = "PIdPeriodo";
            this.PIdPeriodo.Type = typeof(int);
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.Type = typeof(int);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Type = typeof(int);
            // 
            // XROL_TALME_Rpt002_Rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 40, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.PIdEmpresa,
            this.PIdNomina_Tipo,
            this.PIdNominaTipoLiqui,
            this.PIdPeriodo,
            this.IdDepartamento,
            this.IdEmpleado});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XROL_TALME_Rpt002_Rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportRolCopia;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportRol;
        public DevExpress.XtraReports.Parameters.Parameter PIdEmpresa;
        public DevExpress.XtraReports.Parameters.Parameter PIdNomina_Tipo;
        public DevExpress.XtraReports.Parameters.Parameter PIdNominaTipoLiqui;
        public DevExpress.XtraReports.Parameters.Parameter PIdPeriodo;
        public DevExpress.XtraReports.Parameters.Parameter IdDepartamento;
        public DevExpress.XtraReports.Parameters.Parameter IdEmpleado;
    }
}
