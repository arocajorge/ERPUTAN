using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_TablaSectorial_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_TablaSectorial_Data odata = new ro_TablaSectorial_Data();
        
        public Boolean GuardarDB(ref ro_TablaSectorial_Info Info)
        {
            try
            {
                return odata.GuardarDB(ref  Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
        public List<ro_TablaSectorial_Info> ConsultaGeneral()
        {
            try
            {
                return odata.Get_List_TablaSectorial();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
        public ro_TablaSectorial_Info ObtenerObjeto(int IdCodSectorial)
        {
            try
            {
                return odata.Get_Info_TablaSectorial(IdCodSectorial);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
        public Boolean ModificarDB(ro_TablaSectorial_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
        public Boolean AnularDB(ro_TablaSectorial_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
        public int getId(int IdCodSectorial)
        {
            try
            {
                ro_TablaSectorial_Data data = new ro_TablaSectorial_Data();
                return data.getId(IdCodSectorial);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }
        }


        public List<Info.General.tb_banco_Info> ObtenerObjeto()
        {
            try
            {
             throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_TablaSectorial_Bus) };
            }

        }
    }
}
