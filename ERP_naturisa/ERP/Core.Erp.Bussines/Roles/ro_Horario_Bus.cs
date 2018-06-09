using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;
// version 23/12/2013 15:19


namespace Core.Erp.Business.Roles
{
   public class ro_Horario_Bus
   {
       #region Declración de Variables
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ro_Horario_Data data = new ro_Horario_Data();
       #endregion

       public Boolean GuardarDB(ro_Horario_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                return data.GuardarDB(Item, ref Id, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Horario_Bus) };
            }
        }

       public Boolean ModificarDB(ro_Horario_Info Info, string msj)
        {
            try
            {
                return data.ModificarDB(Info, msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Horario_Bus) };
            }

        }

        public List<ro_Horario_Info> Get_List_Horario(int IdEmpresa, decimal IdPrestamo)
        {
            try
            {
                 return data.Get_List_Horario(IdEmpresa, IdPrestamo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Horario", ex.Message), ex) { EntityType = typeof(ro_Horario_Bus) };
            }
 
        }

        public List<ro_Horario_Info> Get_List_Horario(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Horario(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Horario", ex.Message), ex) { EntityType = typeof(ro_Horario_Bus) };
            }
        }

        public Boolean AnularDB(ro_Horario_Info info)
        {
            try
            {
                return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Horario_Bus) };
            }

        }

       
    }
}
