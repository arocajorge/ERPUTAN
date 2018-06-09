using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_notasDebCre_masivo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_notasDebCre_masivo_Data data = new ba_notasDebCre_masivo_Data();
        
        public Boolean GuardarDB(ba_notasDebCre_masivo_Info Info, ref decimal IdTransaccion )
        {
            try
            {
               return data.GuardarDB(Info,ref IdTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_notasDebCre_masivo_Bus) };
            }

        }

        public List<ba_notasDebCre_masivo_Info> Get_List_notasDebCre_masivo_(int IdEmpresa, decimal IdTransaccion)
        {
            try
            {
                 return data.Get_List_ba_notasDebCre_masivo(IdEmpresa, IdTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ba_notasDebCre_masivo", ex.Message), ex) { EntityType = typeof(ba_notasDebCre_masivo_Bus) };
            }

        }

        public List<vwba_notasDebCre_masivo_Info> Get_List_notasDebCre_masivo(int IdEmpresa, decimal IdTransaccion)
        {
            try
            {
               return data.Get_List_vwba_notasDebCre_masivo(IdEmpresa, IdTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_vwba_notasDebCre_masivo", ex.Message), ex) { EntityType = typeof(ba_notasDebCre_masivo_Bus) };
            }

        }

        public Boolean GuardarDB(List<ba_notasDebCre_masivo_Info> Lis, ref decimal IdTran, int IdEmpresa)
        {
            try
            {
               return data.GuardarDB(Lis, ref IdTran, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_notasDebCre_masivo_Bus) };
            }

        }

        public List<ba_notasDebCre_masivo_Info> Get_List_notasDebCre_masivo(int IdEmpresa)
       {
           try
           {
                 return data.Get_List_notasDebCre_masivo(IdEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_notasDebCre_masivo", ex.Message), ex) { EntityType = typeof(ba_notasDebCre_masivo_Bus) };
           }

       }

        public ba_notasDebCre_masivo_Bus(){
            
        }
    }
}
