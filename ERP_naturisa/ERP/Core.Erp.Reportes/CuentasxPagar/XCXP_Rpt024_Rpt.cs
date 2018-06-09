using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt024_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt024_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt024_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int idEmpresa = 0;
                decimal idOrdenGiro = 0;
                int idTipoCbte = 0;
                XCXP_Rpt024_Bus oBus = new XCXP_Rpt024_Bus();

                idEmpresa = param.IdEmpresa;
                idOrdenGiro = Convert.ToDecimal(this.Parameters["idOrdenGiro"].Value);
                idTipoCbte = Convert.ToInt32(this.p_IdTipoCbte.Value);

                this.DataSource = oBus.Get_Lista_Sub_Reporte(idEmpresa, idTipoCbte, idOrdenGiro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());   
            }
        }

    }
}
