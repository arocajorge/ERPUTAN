using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Bancos;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Bancos
{
    public class ba_Banco_Parametros_bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Banco_Parametros_Data oDat = new Data.Bancos.ba_Banco_Parametros_Data();
        ba_Banco_Parametros_Info info=new ba_Banco_Parametros_Info();

        public Boolean ModificarDB(List<ba_Banco_Parametros_Info> inf, int IdEmpresa)
        {
            try
            {
                return oDat.ModificarDB(inf, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ba_Banco_Parametros_bus) };
            }
        }

        public List<ba_Banco_Parametros_Info> Get_List_Banco_Parametros(int IdEmpresa)
        {
            try
            {
                return oDat.Get_List_Banco_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Banco_Parametros", ex.Message), ex) { EntityType = typeof(ba_Banco_Parametros_bus) };
            }
            
        }
        
        public Boolean ModificarDiarioModif(ba_parametros_Info info) 
        {
            try
            {
               return oDat.ModificarDiarioModif(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDiarioModif", ex.Message), ex) { EntityType = typeof(ba_Banco_Parametros_bus) };
            }

        }

        public ba_parametros_Info Get_Info_parametros(int IdEmpresa)
        {
            try
            {
              return oDat.Get_Info_parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_parametros", ex.Message), ex) { EntityType = typeof(ba_Banco_Parametros_bus) };
            }

        }
    }
}
