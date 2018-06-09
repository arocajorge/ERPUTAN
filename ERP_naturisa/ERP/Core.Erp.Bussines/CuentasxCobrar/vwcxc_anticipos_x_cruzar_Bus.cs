using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;

namespace Core.Erp.Business.CuentasxCobrar
{
  public  class vwcxc_anticipos_x_cruzar_Bus
    {
      vwcxc_anticipos_x_cruzar_Data oData = new vwcxc_anticipos_x_cruzar_Data();
      public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar(vwcxc_anticipos_x_cruzar_Info info)
      {
          try
          {
              return oData.Get_List_anticipos_x_cruzar(info);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_anticipos_x_cruzar_Bus) };
          }
          }
    }
}
