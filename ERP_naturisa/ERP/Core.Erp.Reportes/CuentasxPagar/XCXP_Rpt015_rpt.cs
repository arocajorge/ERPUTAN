using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt015_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt015_rpt()
        {
            InitializeComponent();
        }

        int IdEmpresa = 0;
        int IdTipoCbte = 0;
        decimal IdCbteCble = 0;

        public void set_parametros(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                IdEmpresa = IdEmpresa_Ogiro;
                IdTipoCbte = IdTipoCbte_Ogiro;
                IdCbteCble = IdCbteCble_Ogiro;                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt015_rpt) };
            }
        }

        private void XCXP_Rpt015_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt015_Bus repbus = new XCXP_Rpt015_Bus();
                List<XCXP_Rpt015_Info> ListDataRpt = new List<XCXP_Rpt015_Info>();
           
                string mensaje = "";
            
                ListDataRpt = repbus.consultar_data(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);

                string format = "dd/MM/yyyy";

                foreach (var item in ListDataRpt)
                {
                     item.fecha_ret= item.fecha_retencion.ToString(format);

                     switch (param.IdCliente_Ven_x_Default)
                     {
                         
                         case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.FJ:

                             if (item.cod_Impuesto_SRI == "RTF")
                             {
                                 item.cod_Impuesto_SRI = "RENTA";
                             }
                             
                             break;
                           
                         default:
                             break;
                     }
                }
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt015_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt015_rpt) };         
            }
        }

    }
}
