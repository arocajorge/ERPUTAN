using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;

using Core.Erp.Business.General;
using Core.Erp.Info.Importacion;


namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Data odata = new cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Data();

        public Boolean GuardarDB(cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Info Info,  ref string msg)
        {
            try
            {
                Boolean res = true;
                res = odata.GuardarDB(Info,  ref msg);
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
            }
        }


    }
}
