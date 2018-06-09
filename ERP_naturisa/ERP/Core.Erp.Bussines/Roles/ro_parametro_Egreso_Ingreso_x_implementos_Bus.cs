using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles
{
  public  class ro_parametro_Egreso_Ingreso_x_implementos_Bus
  {    tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_area_Data odata = new ro_area_Data();
      ro_parametro_Egreso_Ingreso_x_implementos_Data data = new ro_parametro_Egreso_Ingreso_x_implementos_Data();
      public Boolean GuardarDB(ro_parametro_Egreso_Ingreso_x_implementos_Info Info)
      {
          try
          {
              return data.GuardarDB(Info);

          }
          catch (Exception ex)
          {
             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };
          }
      }

      public ro_parametro_Egreso_Ingreso_x_implementos_Info Get_Info_Parametr(int IdEmpresa)
      {
          try
          {
              return data.Get_Info_Parametr(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Parametr", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };
          }
      }

    }
}
