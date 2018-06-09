using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
  public  class fa_devol_venta_det_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      fa_devol_venta_det_Data oData = new fa_devol_venta_det_Data();

      public Boolean GuardarDB(List<fa_devol_venta_det_Info> Lista, ref string msg)
      {
          try
          {
              return oData.GuardarDB(Lista, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetalle", ex.Message), ex) { EntityType = typeof(fa_devol_venta_det_Bus) };
          }

      }


      public List<fa_devol_venta_det_Info> Get_List_devol_venta_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion)
      {
          try
          {
              return oData.Get_List_devol_venta_det(IdEmpresa,IdSucursal, IdBodega, IdDevolucion);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDetalle", ex.Message), ex) { EntityType = typeof(fa_devol_venta_det_Bus) };
          }
      }


      public Boolean ModificarDB(List<fa_devol_venta_det_Info> Lista, fa_devol_venta_Info info)
      {
          try
          {
              return oData.ModificarDB(Lista, info);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDetalle", ex.Message), ex) { EntityType = typeof(fa_devol_venta_det_Bus) };
          }
      }
    }
}
