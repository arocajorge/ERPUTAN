using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;



namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt006_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XBAN_Rpt006_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt006_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XBAN_Rpt006_Bus repbus = new XBAN_Rpt006_Bus();
                List<XBAN_Rpt006_Info> listDataRpt = new List<XBAN_Rpt006_Info>();


                string mensaje = "";
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;


                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdTipoCbte = Convert.ToInt32(PIdTipoCbte.Value );
                IdCbteCble = Convert.ToDecimal(PIdCbteCble.Value);


                listDataRpt = repbus.Get_Data_Reporte(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);
                this.DataSource = listDataRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt006_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt011_rpt) };

            }
        }


        

        




    }
}
