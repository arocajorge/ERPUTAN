using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_modulo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_modulo_Data data = new tb_modulo_Data();


        public Boolean GuardarDB(tb_modulo_Info Info)
        {
            try
            {
                    return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };
                
            }

        }

        public List<tb_modulo_Info> Get_list_Modulo()
        {
            try
            {
                return data.Get_list_Modulo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };
                
            }

        }

        public List<tb_modulo_Info> Get_list_Modulo(Boolean Se_Cierra)
        {
            try
            {
                return data.Get_list_Modulo(Se_Cierra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Modulo", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };

            }
        }

        public List<tb_modulo_Info> Get_list_Modulo(string codModulo)
        {
            try
            {
                return data.Get_list_Modulo(codModulo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getLikeModulos", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };
                
            }

        }

        public tb_modulo_Info Get_Info_Modulo(string CodModulo)
        {
            try
            {
                  return data.Get_Info_Modulo(CodModulo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };
                
            }

        }
        
        public Boolean ModificarDB(tb_modulo_Info info)
        {
            try
            {
             return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_modulo_Bus) };
                
            }

        }

        public tb_modulo_Bus()
        {
           
        }
    }
}
