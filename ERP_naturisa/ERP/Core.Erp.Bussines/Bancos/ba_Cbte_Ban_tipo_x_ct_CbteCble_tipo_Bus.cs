using Core.Erp.Data;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus
    {
        
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Data Data = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Data();

        public ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(int Idempresa, string CodCbte)
        {
            try
            {
                return Data.Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(Idempresa, CodCbte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus) };
            }
        }

        public List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(int IdEmpresa)
        {
            try
            {
              return Data.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus) };
            }

        }


        public Boolean ModificarDB(List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lista, int IdEmpresa)
        {
            try
            {
                return Data.ModificarDB(lista,IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus) };
            }
        }


        public List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> Get_List_Banco_Parametros(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_Banco_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus) };
            }

        }

        

    }
}
