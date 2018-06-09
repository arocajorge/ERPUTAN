using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using System.Collections.Generic;
using System.IO;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt033_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt033_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt033_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string msg = "";
                XCXP_Rpt033_Bus Bus = new XCXP_Rpt033_Bus();
                List<XCXP_Rpt033_Info> lista = new List<XCXP_Rpt033_Info>();

                int IdEmpresa = 0;
                decimal IdConciliacion_Caja = 0;


                IdEmpresa = Convert.ToInt32(this.P_IdEmpresa.Value);
                IdConciliacion_Caja = Convert.ToDecimal(this.P_IdConciliacion_Caja.Value);

                lista = Bus.Get_List_Data(IdEmpresa, IdConciliacion_Caja, ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt033_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt033_Rpt) };
            }
        }

    }
}
