using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles
{
  public  class ro_dias_Bus
  {
      ro_dias_Data Data = new ro_dias_Data();

      public List<ro_dias_Info> Get_Dias()
      {
          try
          {
              return Data.Get_Dias();

          }
          catch (Exception ex)
          {
              
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Dias", ex.Message), ex) { EntityType = typeof(ro_contrato_bus) };

          }

      }
    }
}
