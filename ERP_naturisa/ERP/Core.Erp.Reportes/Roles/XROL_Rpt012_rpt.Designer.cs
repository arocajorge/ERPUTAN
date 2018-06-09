namespace Core.Erp.Reportes.Roles
{
    partial class XROL_Rpt012_rpt
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
            this.bindingSourceEmpleado = new System.Windows.Forms.BindingSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrSubreportRolCopia = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportRol = new DevExpress.XtraReports.UI.XRSubreport();
            this.PIdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdNomina_Tipo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdNominaTipoLiqui = new DevExpress.XtraReports.Parameters.Parameter();
            this.PIdPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdDepartamento = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 39.62501F;
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
            // bindingSourceEmpleado
            // 
            this.bindingSourceEmpleado.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportRolCopia,
            this.xrSubreportRol});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NomCompleto", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 158.3333F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // xrSubreportRolCopia
            // 
            this.xrSubreportRolCopia.LocationFloat = new DevExpress.Utils.PointFloat(600F, 12.5F);
            this.xrSubreportRolCopia.Name = "xrSubreportRolCopia";
            this.xrSubreportRolCopia.ReportSource = new Core.Erp.Reportes.Roles.XROL_Rpt003_rpt();
            this.xrSubreportRolCopia.SizeF = new System.Drawing.SizeF(184.7916F, 132.375F);
            this.xrSubreportRolCopia.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreportRolCopia_BeforePrint);
            // 
            // xrSubreportRol
            // 
            this.xrSubreportRol.LocationFloat = new DevExpress.Utils.PointFloat(30F, 12.5F);
            this.xrSubreportRol.Name = "xrSubreportRol";
            this.xrSubreportRol.ReportSource = new Core.Erp.Reportes.Roles.XROL_Rpt003_rpt();
            this.xrSubreportRol.SizeF = new System.Drawing.SizeF(196.875F, 132.375F);
            this.xrSubreportRol.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreportRol_BeforePrint);
            // 
            // PIdEmpresa
            // 
            this.PIdEmpresa.Description = "PIdEmpresa";
            this.PIdEmpresa.Name = "PIdEmpresa";
            this.PIdEmpresa.Type = typeof(int);
            this.PIdEmpresa.Value = 0;
            // 
            // PIdNomina_Tipo
            // 
            this.PIdNomina_Tipo.Description = "PIdNomina_Tipo";
            this.PIdNomina_Tipo.Name = "PIdNomina_Tipo";
            this.PIdNomina_Tipo.Type = typeof(int);
            this.PIdNomina_Tipo.Value = 0;
            // 
            // PIdNominaTipoLiqui
            // 
            this.PIdNominaTipoLiqui.Description = "PIdNominaTipoLiqui";
            this.PIdNominaTipoLiqui.Name = "PIdNominaTipoLiqui";
            this.PIdNominaTipoLiqui.Type = typeof(int);
            this.PIdNominaTipoLiqui.Value = 0;
            // 
            // PIdPeriodo
            // 
            this.PIdPeriodo.Description = "PIdPeriodo";
            this.PIdPeriodo.Name = "PIdPeriodo";
            this.PIdPeriodo.Type = typeof(int);
            this.PIdPeriodo.Value = 0;
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.Description = "Id_Departamento";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.Type = typeof(int);
            this.IdDepartamento.Value = 0;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Description = "Id_Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Type = typeof(int);
            this.IdEmpleado.Value = 0;
            // 
            // XROL_Rpt012_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.DataSource = this.bindingSourceEmpleado;
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XROL_Rpt012_rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSourceEmpleado;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        public DevExpress.XtraReports.UI.XRSubreport xrSubreportRol;
        private DevExpress.XtraReports.Parameters.Parameter PIdEmpresa;
        private DevExpress.XtraReports.Parameters.Parameter PIdNomina_Tipo;
        private DevExpress.XtraReports.Parameters.Parameter PIdNominaTipoLiqui;
        private DevExpress.XtraReports.Parameters.Parameter PIdPeriodo;
        public DevExpress.XtraReports.UI.XRSubreport xrSubreportRolCopia;
        private DevExpress.XtraReports.Parameters.Parameter IdDepartamento;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpleado;
    }
}
