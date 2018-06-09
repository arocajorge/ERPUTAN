using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt027_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XCXP_Rpt027_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt027_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt027_Bus repbus = new XCXP_Rpt027_Bus();
                List<XCXP_Rpt027_Info> listDataRpt = new List<XCXP_Rpt027_Info>();


                string mensaje = "";
                int IdEmpresa = 0;

                decimal IdConciliacion_Caja = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdConciliacion_Caja = Convert.ToDecimal(Parameters["IdConciliacion_Caja"].Value);

                listDataRpt = repbus.Get_Lista_Sub_Reporte(IdEmpresa, IdConciliacion_Caja, ref mensaje);
                this.DataSource = listDataRpt.ToArray();


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt019_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt019_rpt) };

            }

        }

    }
}
