using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_Parametros_x_cheqProtesto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_Parametros_x_cheqProtesto_Data data = new cxc_Parametros_x_cheqProtesto_Data();

        public Boolean GuardarDB(cxc_Parametros_x_cheqProtesto_Info Info)
        {
            try
            {
             return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_Parametros_x_cheqProtesto_Bus) };
            }

        }
        public List<cxc_Parametros_x_cheqProtesto_Info> Get_List_Parametros_x_cheqProtesto(int IdEmpresa)
        {
            try
            {
               return data.Get_List_Parametros_x_cheqProtesto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Parametros_x_cheqProtesto", ex.Message), ex) { EntityType = typeof(cxc_Parametros_x_cheqProtesto_Bus) };
            }

        }

        public cxc_Parametros_x_cheqProtesto_Bus(){}
    }
}
