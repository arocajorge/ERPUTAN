using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_turno_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_turno_Data data = new ro_turno_Data();

        public List<ro_turno_Info> ConsListTurno(int idempresa) 
        {
            try
            {
                return data.Get_List_Turno(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsListTurno", ex.Message), ex) { EntityType = typeof(ro_turno_Bus) };
            }
   
        
        }
        public Boolean GuardarTurno(ro_turno_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                return data.GuardarDB(Item, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarTurno", ex.Message), ex) { EntityType = typeof(ro_turno_Bus) };
            }
            
            
        }
        public Boolean ModificarTurno(ro_turno_Info Info, string msj)
        {
            try
            {

                return data.ModificarDB(Info, msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarTurno", ex.Message), ex) { EntityType = typeof(ro_turno_Bus) };
            }
            
           
        }
         public Boolean AnularTurno(ro_turno_Info Info, ref string msj)
        {
            try
            {
                return data.AnularDB(Info, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularTurno", ex.Message), ex) { EntityType = typeof(ro_turno_Bus) };
            }
             
             
            
        }
    }
}
