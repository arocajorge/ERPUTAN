using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
  public  class com_solicitud_compra_det_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();
      string mensaje = "";
      
      public Boolean GuardarDB(List<com_solicitud_compra_det_Info> LstInfo)
      {
          try
          {
              return odata.GuardarDB(LstInfo);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
          }
      }

      public Boolean EliminarDB(com_solicitud_compra_Info Info)
      {

          try
          {
              return odata.EliminarDB(Info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
          }
      }

      public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, decimal idsolicitud)
      {

          try
          {
              return odata.Get_list_DetalleLstSolicitudCompra(idempresa, idsucursal,idsolicitud);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
          }
      }


      public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, DateTime FechaIni, DateTime FechaFin,string IdEstadoAprobacion, ref string mensaje)
      {

          try
          {
              return odata.Get_list_DetalleLstSolicitudCompra(idempresa, idsucursal, FechaIni,  FechaFin,IdEstadoAprobacion, ref mensaje);

          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_DetalleLstSolicitudCompra", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
          }
      }

       public Boolean Actualizar_Producto_Creado(int IdEmpresa, int IdSucursal,decimal IdSolicitudCompra,int Secuencia, decimal IdProducto,string nom_producto, ref string mensaje)
      {
          try
          {
              return odata.Actualizar_Producto_Creado(IdEmpresa,IdSucursal,IdSolicitudCompra, Secuencia, IdProducto,nom_producto, ref mensaje);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_Producto_Creado", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
          }
          }

       public Boolean ModificarEstadoAproba_DetSolCom(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto, string IdEstadoAprobacion, ref string mensaje)
       {
           try
           {
                return odata.ModificarEstadoAproba_DetSolCom(IdEmpresa,IdSucursal,IdSolicitudCompra, Secuencia, IdProducto,IdEstadoAprobacion, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoAproba_DetSolCom", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
           }
       }
            
    }
}
