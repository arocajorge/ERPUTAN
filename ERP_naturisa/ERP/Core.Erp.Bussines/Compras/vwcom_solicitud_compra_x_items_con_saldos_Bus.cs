using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
  public  class vwcom_solicitud_compra_x_items_con_saldos_Bus
    {

      vwcom_solicitud_compra_x_items_con_saldos_Data odata = new vwcom_solicitud_compra_x_items_con_saldos_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";


      public List<vwcom_solicitud_compra_x_items_con_saldos_Info> Get_List_SoliComxItemSaldos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,
          string IdEstadoAprobacion,string IdEstadoPreAprobacion , int IdSucursal, decimal IdComprador)
      {

          try
          {
              return odata.Get_List_SoliComxItemSaldos(IdEmpresa, FechaIni, FechaFin, IdEstadoAprobacion,IdEstadoPreAprobacion, IdSucursal, IdComprador);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_SoliComxItemSaldos", ex.Message), ex) { EntityType = typeof(vwcom_solicitud_compra_x_items_con_saldos_Bus) };
          }
      }
    }
}
