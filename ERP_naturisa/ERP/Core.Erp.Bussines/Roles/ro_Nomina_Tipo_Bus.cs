using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Nomina_Tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Nomina_Tipo_Data data = new ro_Nomina_Tipo_Data();
        public ro_Nomina_Tipo_Info Get_Info_Nomina_Tipo(int idempresa, int idtipo)
        {
            try
            {
                
                return data.Get_Info_Nomina_Tipo(idempresa,idtipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Nomina_Tipo", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipo_Bus) };
            }

        }
        public List<ro_Nomina_Tipo_Info> Get_List_Nomina_Tipo(int idempresa)
        {
            try
            {
                return data.Get_List_Nomina_Tipo(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Nomina_Tipo", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipo_Bus) };
            }

        }
        public Boolean GrabarDB(ro_Nomina_Tipo_Info Info, ref int idtipo, ref  string msg)
        {
            try
            {
                    return data.GrabarDB(Info,ref idtipo ,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipo_Bus) };

            }


        }
        public Boolean AnularDB(ro_Nomina_Tipo_Info Info, ref  string msg)
        {
            try
            {
                return data.AnularDB(Info,  ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipo_Bus) };

            } 

        }
        public Boolean ModificaDB(ro_Nomina_Tipo_Info Info, ref  string msg)
        {
            try
            {
                return data.ModificaDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificaDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipo_Bus) };

            }

        }
    


    }
}
