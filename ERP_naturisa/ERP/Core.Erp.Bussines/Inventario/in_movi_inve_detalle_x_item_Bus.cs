using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
  public  class in_movi_inve_detalle_x_item_Bus
    {
      in_movi_inve_detalle_x_item_Data oData = new in_movi_inve_detalle_x_item_Data();

      public Boolean GrabarDB(List<in_movi_inve_detalle_Info> List_Movi_Inven_det)
      {
          try
          {
              string mensaje = "";
              int Sec_R = 1;
              foreach (in_movi_inve_detalle_Info item in List_Movi_Inven_det)
              {
                  double Cant_R = Math.Abs(item.dm_cantidad);
                  Sec_R = 1;
                  double Unidad = 0;
                  while (Cant_R > 0)
                  {
                      in_movi_inve_detalle_x_item_Info info = new in_movi_inve_detalle_x_item_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdSucursal = item.IdSucursal;
                      info.IdBodega = item.IdBodega;
                      info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                      info.IdNumMovi = item.IdNumMovi;
                      info.Secuencia = item.Secuencia;                      
                      info.Secuencia_reg = Sec_R;
                      info.IdProducto = item.IdProducto;
                      if (item.mv_tipo_movi == "+")
                      {
                          info.codigo_reg = "E" + info.IdEmpresa + "S" + info.IdSucursal + "B" + info.IdBodega + "T" +
                              info.IdMovi_inven_tipo + "N" + info.IdNumMovi + "S" + info.Secuencia + "SR" + info.Secuencia_reg;
                          if (Cant_R < 1)
                          {
                              Unidad = Cant_R;
                          }
                          if (Cant_R >= 1)
                          {
                              Unidad = item.mv_tipo_movi == "+" ? 1 : -1;
                          }
                      }
                      if (item.mv_tipo_movi == "-")
                      {
                          in_movi_inve_detalle_x_item_Info ingreso = new in_movi_inve_detalle_x_item_Info();
                          ingreso = Get_info_disponible(info);
                          info.codigo_reg = ingreso.codigo_reg;                          
                          if (Cant_R < ingreso.cantidad)
                          {
                              Unidad = - Cant_R;
                          }
                          if (Cant_R >= ingreso.cantidad)
                          {
                              Unidad = -ingreso.cantidad;
                          }
                      }
                      info.cantidad = Unidad;
                      Unidad = Math.Abs(Unidad);
                      Cant_R = Cant_R - Unidad;
                      if (info.cantidad == 0)
                          break;
                      if (!oData.GuardarDB(info, ref mensaje))
                          throw new Exception(mensaje);
                      Sec_R++;
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_item_Bus) };
          }
      }

      public in_movi_inve_detalle_x_item_Info Get_info_disponible(in_movi_inve_detalle_x_item_Info Movi)
      {
          try
          {
              return oData.Get_info_disponible(Movi);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_disponible", ex.Message), ex) { EntityType = typeof(in_movi_inve_detalle_x_item_Bus) };
          }
      }
    }
}
