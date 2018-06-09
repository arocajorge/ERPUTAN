using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles
{
    
  public  class ro_Comprobantes_Contables_Bus
    {
      ro_Comprobantes_Contables_Data data = new ro_Comprobantes_Contables_Data();
      public Boolean GuardarDB(ro_Comprobantes_Contables_Info info)
      {

          try
          {
              return data.GuardarDB(info);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Comprobantes_Contables_Bus) };

          }
      }
    }
}
