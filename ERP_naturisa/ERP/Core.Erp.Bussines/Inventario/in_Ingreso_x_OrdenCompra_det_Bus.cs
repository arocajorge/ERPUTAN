using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
  public  class in_Ingreso_x_OrdenCompra_det_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";

      in_Ingreso_x_OrdenCompra_det_Data odata = new in_Ingreso_x_OrdenCompra_det_Data();


      public List<in_Ingreso_x_OrdenCompra_det_Info> Get_List_Ingreso_x_OrdenCompra_det(int Idempresa, decimal IdIngreso_x_oc)
      {
          try
          {
              return odata.Get_List_Ingreso_x_OrdenCompra_det(Idempresa, IdIngreso_x_oc);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngxOrdCompDet", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_det_Bus) };


          }
      }

      public List<in_Ingreso_x_OrdenCompra_det_Info> Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(int IdEmpresa, decimal IdProveedor)
      {
          try
          {
              return odata.Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(IdEmpresa, IdProveedor);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta_IngxOrdComDet_x_Prov", ex.Message), ex) { EntityType = typeof(in_Ingreso_x_OrdenCompra_det_Bus) };

          }
      
      }




    }
}
