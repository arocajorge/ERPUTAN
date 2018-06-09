using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt008_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt008_Rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt008_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCONTA_Rpt008_Bus BusRpt = new XCONTA_Rpt008_Bus();
                List<XCONTA_Rpt008_Info> ListaRpt = new List<XCONTA_Rpt008_Info>();

                int IdEmpresa = 0;
                decimal IdOrdenPago = 0;

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa_op.Value);
                IdOrdenPago = Convert.ToDecimal(this.PIdCbteCble.Value);
                ListaRpt = BusRpt.Get_List_Reporte(IdEmpresa, IdOrdenPago);
                this.DataSource = ListaRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt008_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt008_Rpt) };
            }
        }
    }
}
