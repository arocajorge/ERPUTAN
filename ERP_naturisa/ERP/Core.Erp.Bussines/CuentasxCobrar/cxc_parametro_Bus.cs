using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{//06052013//
    public class cxc_parametro_Bus
    {
        cxc_parametro_Data data = new cxc_parametro_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public cxc_parametro_Info Get_Info_parametro(int IdEmpresa)
        {
            try
            {
              return data.Get_Info_parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_parametro", ex.Message), ex) { EntityType = typeof(cxc_parametro_Bus) };
            }

        }

        public Boolean GuardarDB(cxc_parametro_Info Info)
        {
            try
            {
             return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_parametro_Bus) };
            }

        }
    }
}
