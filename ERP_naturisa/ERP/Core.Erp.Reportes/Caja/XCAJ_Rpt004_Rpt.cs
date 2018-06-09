using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt004_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCAJ_Rpt004_Bus bus_rpt = new XCAJ_Rpt004_Bus();
        List<XCAJ_Rpt004_Info> lst_rpt= new List<XCAJ_Rpt004_Info>();

        public void Set_Parametros(decimal IdConciliacion_caja)
        {
            try
            {
                P_IdConcilacionCaja.Value = IdConciliacion_caja;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_Parametros", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt004_Rpt) };
            }
        }

        public XCAJ_Rpt004_Rpt()
        {
            InitializeComponent();
        }

        private void XCAJ_Rpt004_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                //tabl.Text = param.NombreEmpresa;
                int Id_empresa = 0;
                decimal Id_concilacion_caja=0;
                

                Id_empresa = Convert.ToInt32(param.IdEmpresa);
                Id_concilacion_caja = Convert.ToDecimal(P_IdConcilacionCaja.Value);

                lst_rpt = bus_rpt.Get_List(Id_empresa, Id_concilacion_caja);
                

                this.DataSource = lst_rpt;

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCAJ_Rpt004_BeforePrint", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt004_Rpt) };
            }
        }

        

    }
}
