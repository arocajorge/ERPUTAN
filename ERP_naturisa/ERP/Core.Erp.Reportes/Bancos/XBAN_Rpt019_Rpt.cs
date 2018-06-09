using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;


namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt019_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XBAN_Rpt019_Rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt019_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XBAN_Rpt019_Bus repbus = new XBAN_Rpt019_Bus();
                List<XBAN_Rpt019_Info> listDataRpt = new List<XBAN_Rpt019_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble = Convert.ToDecimal(this.PIdCbteCble.Value);
                IdTipoCbte = Convert.ToInt32(this.PIdTipo_Cbte.Value);

                listDataRpt = repbus.GetData(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);
                this.DataSource = listDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt019_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt019_Rpt) };
            }
        }

    }
}
