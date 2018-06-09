using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt009_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

       private int IdEmpresa = 0;
       private Decimal IdCbteCble_OG = 0;
       private int IdTipoCbte_OG = 0;

        public XCXP_NATU_Rpt009_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt009_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt009_Bus busReporte = new XCXP_NATU_Rpt009_Bus();

                lblFecha.Text = DateTime.Now.ToString();
                lblEmpresa.Text = param.NombreEmpresa;
                lblUsuario.Text = param.IdUsuario;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble_OG = Convert.ToDecimal(this.PIdCbteCble_OG.Value);
                IdTipoCbte_OG = Convert.ToInt32(this.PIdTipoCbte_OG.Value);

                this.DataSource = busReporte.Get_Lista_Orden_Giro(IdEmpresa, IdCbteCble_OG, IdTipoCbte_OG);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt009_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt009_Rpt) };
            }
        }

        private void xrSubreportDiarioRetenciones_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa"].Value = IdEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdCbteCble_Ogiro"].Value = IdCbteCble_OG;
                ((XRSubreport)sender).ReportSource.Parameters["IdTipoCbte_OG"].Value = IdTipoCbte_OG;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
                 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "xrSubreportDiarioRetenciones_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt009_Rpt) };
            }
        }
    }
}
