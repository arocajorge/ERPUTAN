using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Compras
{
  public  class com_ordencompra_local_det_x_com_solicitud_compra_det_Data
    {
      string mensaje = "";
     
      public Boolean GrabarDB(List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lista, ref string mensaje)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {               
                  foreach (var item in lista)
                  {
                      com_ordencompra_local_det_x_com_solicitud_compra_det address = new com_ordencompra_local_det_x_com_solicitud_compra_det();
                   
                      address.ocd_IdEmpresa = item.ocd_IdEmpresa;
                      address.ocd_IdSucursal = item.ocd_IdSucursal;
                      address.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                      address.ocd_Secuencia = item.ocd_Secuencia;

                      address.scd_IdEmpresa = item.scd_IdEmpresa;
                      address.scd_IdSucursal = item.scd_IdSucursal;
                      address.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                      address.scd_Secuencia = item.scd_Secuencia;

                      if (item.observacion == null)
                      {
                          item.observacion = "";
                      }
                      address.observacion = item.observacion;

                      context.com_ordencompra_local_det_x_com_solicitud_compra_det.Add(address);
                      context.SaveChanges();

                      mensaje = "Grabación Exitosa";
                  }

                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_OrdenCompra(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
      {
          try
          {
              List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> List = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

              EntitiesCompras oEntities = new EntitiesCompras();

                                   
              var select = from q in oEntities.com_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.ocd_IdEmpresa == IdEmpresa && q.ocd_IdSucursal == IdSucursal && q.ocd_IdOrdenCompra == IdOrdenCompra
                           select q;

              foreach (var item in select)
              {
                  com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();
                 
                  info.ocd_IdEmpresa = item.ocd_IdEmpresa;
                  info.ocd_IdSucursal = item.ocd_IdSucursal;
                  info.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                  info.ocd_Secuencia = item.ocd_Secuencia;

                  info.scd_IdEmpresa = item.scd_IdEmpresa;
                  info.scd_IdSucursal = item.scd_IdSucursal;
                  info.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                  info.scd_Secuencia = item.scd_Secuencia;

                  info.observacion = item.observacion;


                  List.Add(info);
              }
              return List;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det(int IdEmpresa)
      {
          try
          {
              List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> List = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

              EntitiesCompras oEntities = new EntitiesCompras();


              var select = from q in oEntities.com_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.ocd_IdEmpresa == IdEmpresa 
                           select q;

              foreach (var item in select)
              {
                  com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                  info.ocd_IdEmpresa = item.ocd_IdEmpresa;
                  info.ocd_IdSucursal = item.ocd_IdSucursal;
                  info.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                  info.ocd_Secuencia = item.ocd_Secuencia;

                  info.scd_IdEmpresa = item.scd_IdEmpresa;
                  info.scd_IdSucursal = item.scd_IdSucursal;
                  info.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                  info.scd_Secuencia = item.scd_Secuencia;

                  info.observacion = item.observacion;


                  List.Add(info);
              }
              return List;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
      {
          try
          {
              List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> List = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

              EntitiesCompras oEntities = new EntitiesCompras();


              var select = from q in oEntities.com_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.scd_IdEmpresa == IdEmpresa && q.scd_IdSucursal == IdSucursal && q.scd_IdSolicitudCompra == IdSolicitudCompra
                           select q;

              foreach (var item in select)
              {
                  com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                  info.ocd_IdEmpresa = item.ocd_IdEmpresa;
                  info.ocd_IdSucursal = item.ocd_IdSucursal;
                  info.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                  info.ocd_Secuencia = item.ocd_Secuencia;

                  info.scd_IdEmpresa = item.scd_IdEmpresa;
                  info.scd_IdSucursal = item.scd_IdSucursal;
                  info.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                  info.scd_Secuencia = item.scd_Secuencia;

                  info.observacion = item.observacion;


                  List.Add(info);
              }
              return List;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia_SC)
      {
          try
          {
              List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> List = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

              EntitiesCompras oEntities = new EntitiesCompras();


              var select = from q in oEntities.com_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.scd_IdEmpresa == IdEmpresa && q.scd_IdSucursal == IdSucursal && q.scd_IdSolicitudCompra == IdSolicitudCompra && q.scd_Secuencia == Secuencia_SC
                           select q;

              foreach (var item in select)
              {
                  com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                  info.ocd_IdEmpresa = item.ocd_IdEmpresa;
                  info.ocd_IdSucursal = item.ocd_IdSucursal;
                  info.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;
                  info.ocd_Secuencia = item.ocd_Secuencia;

                  info.scd_IdEmpresa = item.scd_IdEmpresa;
                  info.scd_IdSucursal = item.scd_IdSucursal;
                  info.scd_IdSolicitudCompra = item.scd_IdSolicitudCompra;
                  info.scd_Secuencia = item.scd_Secuencia;

                  info.observacion = item.observacion;


                  List.Add(info);
              }
              return List;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(List<com_solicitud_compra_det_aprobacion_Info> lista)
      {
          try
          {
              List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> List = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

              EntitiesCompras oEntities = new EntitiesCompras();

              foreach (var item in lista)
              {
                    var select = from q in oEntities.com_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.scd_IdEmpresa == item.IdEmpresa 
                           && q.scd_IdSucursal == item.IdSucursal_SC 
                           && q.scd_IdSolicitudCompra == item.IdSolicitudCompra 
                           && q.scd_Secuencia == item.Secuencia_SC
                           select q;

                    foreach (var item2 in select)
                    {
                        com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();

                        info.ocd_IdEmpresa = item2.ocd_IdEmpresa;
                        info.ocd_IdSucursal = item2.ocd_IdSucursal;
                        info.ocd_IdOrdenCompra = item2.ocd_IdOrdenCompra;
                        info.ocd_Secuencia = item2.ocd_Secuencia;

                        info.scd_IdEmpresa = item2.scd_IdEmpresa;
                        info.scd_IdSucursal = item2.scd_IdSucursal;
                        info.scd_IdSolicitudCompra = item2.scd_IdSolicitudCompra;
                        info.scd_Secuencia = item2.scd_Secuencia;
                        info.observacion = item2.observacion;
                        List.Add(info);
                    }
              }
             
            return List;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean Eliminar_Detalle_OCDxSCD(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, ref string msg)
      {
          try
          {

              using (EntitiesCompras Entity = new EntitiesCompras())
              {
                  int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete com_ordencompra_local_det_x_com_solicitud_compra_det where ocd_IdEmpresa = " + IdEmpresa
                      + " and ocd_IdSucursal = " + IdSucursal
                      + " and ocd_IdOrdenCompra = " + IdOrdenCompra
                      );
              }
              msg = "Guardado con éxito";
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();

              msg = "Error no se guardó " + ex.Message + " ";
             throw new Exception(ex.ToString());
          }


      }


      public Boolean ModificarDB(List<com_ordencompra_local_det_Info> ListDet_Info, ref  string msg)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {

                  foreach (var item in ListDet_Info)
                  {


                      var contact = context.com_ordencompra_local_det.FirstOrDefault(obj => obj.IdOrdenCompra == item.IdOrdenCompra &&
                       obj.IdSucursal == item.IdSucursal && obj.IdEmpresa == item.IdEmpresa && obj.Secuencia == item.Secuencia && obj.IdProducto==item.IdProducto); 

                      if (contact != null)
                      {

                          //contact.do_Cantidad = item.do_Cantidad;
                          //contact.do_precioCompra = item.do_precioCompra;
                          //contact. = Info.Tipo;
                          //contact.IdTerminoPago = Info.IdTerminoPago;
                          
                       
                          //context.SaveChanges();
                          //msg = "Se ha procedido a modificar el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";
                      }
                  }



                  

              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();

              msg = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }


  }
}
