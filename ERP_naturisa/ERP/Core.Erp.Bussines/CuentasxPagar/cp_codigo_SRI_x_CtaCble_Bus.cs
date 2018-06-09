using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_codigo_SRI_x_CtaCble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_codigo_SRI_x_CtaCble_Data data = new cp_codigo_SRI_x_CtaCble_Data();


        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble() {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        
        }

        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa)
        {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }

        }


        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa, int IdCodigo_SRI)
        {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble(IdEmpresa, IdCodigo_SRI);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }


        public cp_codigo_SRI_x_CtaCble_Info GetInfo_codigo_SRI_x_CtaCble(int IdEmpresa, int IdCodigo_SRI)
        {
            try
            {
                return data.GetInfo_codigo_SRI_x_CtaCble(IdCodigo_SRI, IdEmpresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfo_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }


        public Boolean GuardarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                return data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }

        }

        public Boolean ModificarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }

    }
}
