using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;

using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
  public  class cxc_conciliacion_det_Bus
    {
      cxc_conciliacion_det_Data oData = new cxc_conciliacion_det_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public Boolean GuardarDB(List<cxc_conciliacion_det_Info> Lst, ref decimal Id, ref string mensaje)
      {
          try
          {
              return oData.GuardarDB(Lst, ref Id, ref mensaje);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_conciliacion_det_Bus) };
          }


      }


      public List<cxc_conciliacion_det_Info> Get_List_conciliacion_det(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
      {
          try
          {
              return oData.Get_List_conciliacion_det(IdEmpresa, IdSucursal, IdConciliacion,ref mensaje);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_conciliacion_det", ex.Message), ex) { EntityType = typeof(cxc_conciliacion_det_Bus) };
          }
      }

    }
}
