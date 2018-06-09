using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Bancos
{
    public class ba_Cbte_Ban_tipo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_tipo_Data odata = new ba_Cbte_Ban_tipo_Data();

        public List<ba_Cbte_Ban_tipo_Info> Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA()
        {
            try
            {
                return odata.Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }
        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo()
        {
            try
            {
                return odata.Get_List_Cbte_Ban_tipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }
        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo_Todos()
        {
            try
            {
                return odata.Get_List_Cbte_Ban_tipo_Todos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_Todos", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_Bus) };
            }
        }

    }
}
