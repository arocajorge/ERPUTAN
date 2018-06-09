using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_tipo_x_CodBancoExterno_Data data = new ba_Cbte_Ban_tipo_x_CodBancoExterno_Data();

        public List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info> Get_List_Cbte_Ban_tipo_x_CodBancoExterno()
        {
            try
            {
              return data.Get_List_Cbte_Ban_tipo_x_CodBancoExterno();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_x_CodBancoExterno", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus) };
            }

        }
    }
}
