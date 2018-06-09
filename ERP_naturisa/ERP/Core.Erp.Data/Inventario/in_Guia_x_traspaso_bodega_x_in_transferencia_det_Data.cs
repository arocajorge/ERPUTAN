using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Inventario
{
  public  class in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data
    {
      string mensaje = "";
      public bool Guardar(List< in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista_transf)
      {
          try
          {
              using (EntitiesInventario Context = new EntitiesInventario())
              {


                  foreach (var item in Lista_transf)
                  {
                      var Address = new in_Guia_x_traspaso_bodega_x_in_transferencia_det();

                      Address.IdEmpresa = item.IdEmpresa;
                      Address.IdEmpresa_tras = item.IdEmpresa;
                      Address.IdGuia = item.IdGuia;

                      Address.IdSucursalOrigen = item.IdSucursalOrigen;
                      Address.IdBodegaOrigen = item.IdBodegaOrigen;
                      Address.IdTransferencia = item.IdTransferencia;
                      Address.dt_secuencia = item.dt_secuencia;
                      Address.cantidad = item.cantidad;
                      if (item.observacion != "")
                      {
                          Address.observacion = item.observacion;
                      }
                      else
                      {
                          Address.observacion = "Transferencia";
                      }


                      Context.in_Guia_x_traspaso_bodega_x_in_transferencia_det.Add(Address);
                      Context.SaveChanges();
                      
                  }
                 
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(mensaje);
          }
      }



      public bool Eliminar(in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info Info)
      {
          try
          {
              using (EntitiesInventario db = new EntitiesInventario())
              {
                  db.Database.ExecuteSqlCommand("delete from in_Guia_x_traspaso_bodega_x_in_transferencia_det where IdEmpresa =" + Info.IdEmpresa
                     + " AND IdGuia=" + Info.IdGuia
                     
                    
                     );
              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(mensaje);
          }
      }



      public bool Anular(List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista_transf)
      {
          try
          {
              using (EntitiesInventario Context = new EntitiesInventario())
              {


                  foreach (var item in Lista_transf)
                  {
                      var contact = Context.in_Guia_x_traspaso_bodega_x_in_transferencia_det.First(obj => 
                                obj.IdEmpresa_tras == item.IdEmpresa_tras &&
                                obj.IdEmpresa == item.IdEmpresa &&
                                obj.IdGuia==item.IdGuia &&
                                obj.dt_secuencia==item.dt_secuencia && 
                                obj.IdTransferencia==item.IdTransferencia);

                                 contact.cantidad = 0;

                                 Context.SaveChanges();
                        

                  }
                 
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(mensaje);
          }
      }




      public List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Get_lista(int idEmpresa, int idGuia)
      {
          try
          {
              List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info> Lista = new List<in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info>();

              EntitiesInventario Oentities = new EntitiesInventario();
              var select = from q in Oentities.vwin_in_Guia_x_traspaso_bodega_x_in_transferencia_det
                           where q.IdEmpresa == idEmpresa
                           && q.IdGuia == idGuia
                           select q;

              foreach (var item in select)
              {
                  in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info info = new in_Guia_x_traspaso_bodega_x_in_transferencia_det_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdBodegaOrigen = item.IdBodegaOrigen;
                  info.IdSucursalOrigen = item.IdSucursalOrigen;
                  info.IdEmpresa_tras = item.IdEmpresa_tras;
                  info.pr_descripcion = item.pr_descripcion;
                  info.Sucursal_Destino = item.Su_Descripcion;
                  info.bo_Descripcion_origen = item.bo_Descripcion;
                  info.observacion = item.observacion;
                  info.cantidad = item.cantidad;
                  info.dt_cantidad = item.dt_cantidad;
                  info.bo_Descripcion_destino = item.bo_Descripcion;
                  info.IdTransferencia = item.IdTransferencia;
                  info.diferencia =Convert.ToDecimal(Convert.ToDecimal( item.dt_cantidad) -Convert.ToDecimal( item.cantidad));
                  info.check = true;
                  info.dt_secuencia = item.dt_secuencia;
                  info.IdGuia = item.IdGuia==null ? 0 :(int)item.IdGuia;
                  Lista.Add(info); ;
              }

              return Lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(mensaje);
          }
      }


    }
}
