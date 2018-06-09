using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt009 : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCONTA_Rpt009_Bus bus_rpt = new XCONTA_Rpt009_Bus();
        List<XCONTA_Rpt009_Info> lst_rpt = new List<XCONTA_Rpt009_Info>();

        public XCONTA_Rpt009()
        {
            InitializeComponent();
        }

        public void Set_Parametros(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                p_IdEmpresa.Value = IdEmpresa;
                p_IdConciliacion_caja.Value = IdConciliacion_caja;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_Parametros", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt009) };
            }
        }

        private void XCONTA_Rpt009_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLEmpresa.Text = param.NombreEmpresa;
                xrLabelUsuario.Text = param.IdUsuario;
                xrLabelFecha.Text = DateTime.Now.ToString();
                int IdEmpresa = 0;
                decimal IdConciliacion_caja = 0;

                IdEmpresa = Convert.ToInt32(p_IdEmpresa.Value);
                IdConciliacion_caja = Convert.ToDecimal(p_IdConciliacion_caja.Value);

                lst_rpt = bus_rpt.Get_list_CbteCble_x_cp_Conciliacion_caja(IdEmpresa, IdConciliacion_caja);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCONTA_Rpt009_BeforePrint", ex.Message), ex) { EntityType = typeof(XCONTA_Rpt009) };
            }
        }

    }
}
