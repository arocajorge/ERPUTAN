using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_cbte_ban_verificado_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_cbte_ban_verificado_Data Data = new ba_cbte_ban_verificado_Data();

        public Boolean GuardarDB(List<ba_cbte_ban_verificado_Info> List_Info)
        {
            try
            {
                  return Data.GuardarDB(List_Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_cbte_ban_verificado_Bus) };
            }

        }

        public Boolean EliminarDB(int IdEmpresa, int IdPeriodo)
        {
            try
            {
               return Data.EliminarDB(IdEmpresa, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ba_cbte_ban_verificado_Bus) };
            }

        }

        public List<ba_cbte_ban_verificado_Info> Get_List_cbte_ban_verificado(int IdEmpresa, int Idperiodo)
        {
            try
            {
               return Data.Get_List_cbte_ban_verificado(IdEmpresa, Idperiodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cbte_ban_verificado", ex.Message), ex) { EntityType = typeof(ba_cbte_ban_verificado_Bus) };
            }

        }

    }

}
