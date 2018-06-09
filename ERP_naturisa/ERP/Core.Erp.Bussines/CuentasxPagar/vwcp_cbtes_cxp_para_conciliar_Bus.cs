using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
//DEREK MEJIA 24/03/2014
namespace Core.Erp.Business.CuentasxPagar
{
    public class vwcp_cbtes_cxp_para_conciliar_Bus
    {
        vwcp_cbtes_cxp_para_conciliar_Data OPD = new vwcp_cbtes_cxp_para_conciliar_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


        public List<vwcp_cbtes_cxp_para_conciliar_Info> Get_List_cbtes_cxp_para_conciliar(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return OPD.Get_List_cbtes_cxp_para_conciliar(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cbtes_cxp_para_conciliar", ex.Message), ex) { EntityType = typeof(vwcp_cbtes_cxp_para_conciliar_Bus) };
            }
        }


        public List<vwcp_cbtes_cxp_para_conciliar_Info> Get_List_cbtes_cxp_para_conciliar(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                return OPD.Get_List_cbtes_cxp_para_conciliar(IdEmpresa, IdConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cbtes_cxp_para_conciliar", ex.Message), ex) { EntityType = typeof(vwcp_cbtes_cxp_para_conciliar_Bus) };
            }
        }

    }
}
