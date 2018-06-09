using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_parametros_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_parametros_Data data = new ba_parametros_Data();

        public ba_parametros_Info Get_List_parametros(int IdEmpresa)
        {
            try
            {
            return data.Get_List_parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_parametros", ex.Message), ex) { EntityType = typeof(ba_parametros_Bus) };
            }

        }





        public Boolean ModificarDB(ba_parametros_Info inf, int IdEmpresa)
        {
            try
            {
                return data.ModificarDB(inf, IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ba_parametros_Bus) };
            }
        }

        public List<ba_parametros_Info> Get_List_Banco_otros_Parametro(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Banco_otros_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Banco_otros_Parametro", ex.Message), ex) { EntityType = typeof(ba_parametros_Bus) };
            }

        }

        public Boolean ModificarDiarioModif(ba_parametros_Info info)
        {
            try
            {
                return data.ModificarDiarioModif(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDiarioModif", ex.Message), ex) { EntityType = typeof(ba_parametros_Bus) };
            }

        }

        public ba_parametros_Info Get_Info_Banco_Otros_Parametros(int IdEmpresa)
        {
            try
            {
                return data.Get_Info_Banco_Otros_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Banco_Otros_Parametros", ex.Message), ex) { EntityType = typeof(ba_parametros_Bus) };
            }

        }



    }
}
