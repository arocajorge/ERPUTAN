using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXC_Rpt008_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XCXC_Rpt008_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXC_Rpt008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt008_Bus rptBus = new XCXC_Rpt008_Bus();
                List<XCXC_Rpt008_Info> lstRpt = new List<XCXC_Rpt008_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                DateTime FechaCorte = DateTime.Now;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                FechaCorte = Convert.ToDateTime(Parameters["FechaCorte"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);

                lstRpt = rptBus.get_ReporteCarteraVencida(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte);
                this.DataSource = lstRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt008_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt008_rpt) };
            }
        }

    }
}
