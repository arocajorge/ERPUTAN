using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Parametros_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Parametros_Data data = new ro_Parametros_Data();
        public List<ro_Parametros_Info> Get_List_Parametros(int IdEmpresa)
        {
            try
            {
               return data.Get_List_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Parametros", ex.Message), ex) { EntityType = typeof(ro_Parametros_Bus) };
            }

        }
        public ro_Parametros_Info Get_Parametros(int IdEmpresa)
        {
            try
            {
                return data.Get_Parametros(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Parametros", ex.Message), ex) { EntityType = typeof(ro_Parametros_Bus) };
            }

        }


        public Boolean grabarSBasico(int idempresa, double Sbasico)
        {
            try
            {
                    return data.grabarSBasico(idempresa, Sbasico);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarSBasico", ex.Message), ex) { EntityType = typeof(ro_Parametros_Bus) };
            }

        }




        public Boolean GrabarBD(ro_Parametros_Info info, ref string msg)
        {
            try
            {
                return data.GrabarBD(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Parametros_Bus) };
            }

        }



    }
}
