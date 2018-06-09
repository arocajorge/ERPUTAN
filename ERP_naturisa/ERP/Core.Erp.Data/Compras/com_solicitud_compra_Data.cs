using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
  public  class com_solicitud_compra_Data
    {

      string mensaje = "";

      public decimal GetId(int IdEmpresa,int IdSucursal)
      {
          decimal Id = 0;
          try
          {
              EntitiesCompras contex = new EntitiesCompras();
              var selecte = contex.com_solicitud_compra.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal);

              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in contex.com_solicitud_compra
                                   where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                   select q.IdSolicitudCompra).Max();
                  Id = Convert.ToDecimal(select_em.ToString()) + 1;
              }

              return Id;
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

      public List<com_solicitud_compra_Info> Get_List_solicitud_compra_EstadoApro_SC()
      {
          List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();
          EntitiesCompras OEComp = new EntitiesCompras();
          try
          {
              var Select = from q in OEComp.vwcom_EstadoAprobacion_sol_compra
                           select q;

              foreach (var item in Select)
              {
                  com_solicitud_compra_Info SolCompInfo = new com_solicitud_compra_Info();
                  SolCompInfo.IdTipoCatalogo = item.IdTipoCatalogo;
                  SolCompInfo.Codigo = item.Codigo;
                  SolCompInfo.Id = item.Id;
                  SolCompInfo.descripcion = item.descripcion;
                  SolCompInfo.Orden = Convert.ToInt32(item.Orden);
                  SolCompInfo.name = item.name;
                  SolCompInfo.Estado = item.Estado;

                  Lst.Add(SolCompInfo);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean AnularDB(com_solicitud_compra_Info info,ref string msg)
      {
          try
          {
              using (EntitiesCompras Context = new EntitiesCompras())
              {
                  

                  var contact = Context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa 
                      && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra==info.IdSolicitudCompra);

                  if (contact != null)
                  {

                      contact.Estado = "I";
                      contact.IdEstadoAprobacion = "REP_SOL";
                      contact.FechaHoraAnul = info.FechaHoraAnul;
                      contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;


                      /// PreAprobacion//
                      /// 
                      com_solicitud_compra_det_pre_aprobacion_Data odataPreApro = new com_solicitud_compra_det_pre_aprobacion_Data();
                      List<com_solicitud_compra_det_pre_aprobacion_Info> listPreApro;
                      listPreApro = new List<com_solicitud_compra_det_pre_aprobacion_Info>(odataPreApro.Get_List_solicitud_compra_det_Pre_aprobacion(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra));

                      if (listPreApro.Count() != 0)
                      {
                          odataPreApro.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra);
                      }


                      listPreApro = new List<com_solicitud_compra_det_pre_aprobacion_Info>();
                      /// aprobacion//
                      /// 


                      /// aprobacion//
                      com_solicitud_compra_det_aprobacion_Data odataApro = new com_solicitud_compra_det_aprobacion_Data();
                      com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();
                      List<com_solicitud_compra_det_aprobacion_Info> listApro;
                      listApro = new List<com_solicitud_compra_det_aprobacion_Info>(odataApro.Get_List_solicitud_compra_det_aprobacion(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra));

                      if (listApro.Count() != 0)
                      {
                          odataApro.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra);
                      }


                      listApro = new List<com_solicitud_compra_det_aprobacion_Info>();



                      Context.SaveChanges();
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
              msg=mensaje ;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean GuardarDB(com_solicitud_compra_Info info)
      {
          try
          {
              using (EntitiesCompras Context = new EntitiesCompras())
              {
                    var Address = new com_solicitud_compra();
                 
                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdSucursal = info.IdSucursal;
                    Address.IdSolicitudCompra = info.IdSolicitudCompra = GetId(info.IdEmpresa,info.IdSucursal);
                    Address.NumDocumento = info.NumDocumento;

                    Address.IdComprador = info.IdComprador;
                    Address.IdDepartamento = Convert.ToInt32(info.IdDepartamento);

                    Address.fecha = Convert.ToDateTime(info.fecha.ToShortDateString());
                    Address.plazo = 0;
                    Address.fecha_vtc = Convert.ToDateTime(info.fecha.ToShortDateString());
                    Address.observacion = info.observacion;
                    Address.Estado ="A";

                    Address.IdSolicitante = info.IdSolicitante;
                  
                 
                    Address.Fecha_Transac = info.Fecha_Transac;
                    
                    Address.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    Address.IdUsuarioAprobo = (info.IdUsuarioAprobo == null) ? "" : Convert.ToString(info.IdUsuarioAprobo);
                    Address.MotivoAprobacion = (info.MotivoAprobacion == null) ? "" : Convert.ToString(info.MotivoAprobacion);
                    Address.FechaHoraAprobacion = info.FechaHoraAprobacion; 

                    Context.com_solicitud_compra.Add(Address);
                    Context.SaveChanges();

                  com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();

                  foreach (var item in info.DetSolicitudCompra)
                  {
                      item.IdEmpresa = info.IdEmpresa;
                      item.IdSucursal = info.IdSucursal;
                      item.IdSolicitudCompra = info.IdSolicitudCompra;
                  }

                  odata.GuardarDB(info.DetSolicitudCompra);

                
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
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean ModificarDB(com_solicitud_compra_Info info)
      {
          try
          {

              using (EntitiesCompras context = new EntitiesCompras())
              {
                  var contact = context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra == info.IdSolicitudCompra);


                  if (contact != null)
                  {
                      contact.NumDocumento = info.NumDocumento;
                      contact.IdSolicitante = info.IdSolicitante;
                      contact.IdComprador = info.IdComprador;
                      contact.IdDepartamento = Convert.ToInt32(info.IdDepartamento);
                      contact.fecha = Convert.ToDateTime(info.fecha.ToShortDateString());
                      contact.observacion = info.observacion;
                      contact.Fecha_UltMod = info.Fecha_UltMod;
                      contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                      context.SaveChanges();



                      // consulta detalle PRE aprobacion
                      com_solicitud_compra_det_pre_aprobacion_Data odataPreApro = new com_solicitud_compra_det_pre_aprobacion_Data();
                      List<com_solicitud_compra_det_pre_aprobacion_Info> listPreApro;

                      listPreApro = new List<com_solicitud_compra_det_pre_aprobacion_Info>(odataPreApro.Get_List_solicitud_compra_det_Pre_aprobacion(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra));

                      if (listPreApro.Count() != 0)
                      {
                          // elimino detalle aprobacion
                          odataPreApro.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra);
                      }





                      // consulta detalle aprobacion
                      com_solicitud_compra_det_aprobacion_Data odataApro = new com_solicitud_compra_det_aprobacion_Data();
                      List<com_solicitud_compra_det_aprobacion_Info> listApro;

                      listApro = new List<com_solicitud_compra_det_aprobacion_Info>(odataApro.Get_List_solicitud_compra_det_aprobacion(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra));

                      if (listApro.Count() != 0)
                      {
                          // elimino detalle aprobacion
                          odataApro.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdSolicitudCompra);
                      }

                      // eliminar detalle solicitud                             
                      com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();
                      odata.EliminarDB(info);
                      listApro = new List<com_solicitud_compra_det_aprobacion_Info>();
                      listPreApro = new List<com_solicitud_compra_det_pre_aprobacion_Info>();

                      odata.GuardarDB(info.DetSolicitudCompra);


                      foreach (var item in info.DetSolicitudCompra)
                      {
                          com_solicitud_compra_det_aprobacion_Info liaprobada = new com_solicitud_compra_det_aprobacion_Info();
                          item.IdEmpresa = info.IdEmpresa;
                          item.IdSucursal = info.IdSucursal;
                          item.IdSolicitudCompra = info.IdSolicitudCompra;
                          liaprobada.IdEmpresa = item.IdEmpresa;
                          liaprobada.IdSucursal_SC = item.IdSucursal;
                          liaprobada.IdSolicitudCompra = item.IdSolicitudCompra;
                          liaprobada.Secuencia_SC = item.Secuencia;
                          liaprobada.IdProducto_SC = item.IdProducto;
                          liaprobada.NomProducto_SC = item.NomProducto;
                          liaprobada.Cantidad_aprobada = info.do_Cantidad;
                          liaprobada.IdEstadoAprobacion = info.IdEstadoAprobacion;
                          liaprobada.IdProveedor_SC = info.IdProveedor;
                          liaprobada.IdUsuarioAprueba = info.IdUsuarioAprobo;
                          liaprobada.FechaHoraAprobacion = DateTime.Now;
                          liaprobada.do_observacion = info.observacion;
                          liaprobada.IdUnidadMedida = info.IdUnidadMedida;
                          liaprobada.do_precioCompra = item.Precio;
                          liaprobada.do_porc_des = item.Porc_Descuento;
                          liaprobada.do_descuento = item.Descuento;
                          liaprobada.do_subtotal = item.Subtotal;
                          liaprobada.do_iva = item.Iva;
                          liaprobada.do_total = item.Total;
                          liaprobada.IdCentroCosto = item.IdCentroCosto;
                          liaprobada.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                          liaprobada.IdPunto_cargo = item.IdPunto_cargo;

                          listApro.Add(liaprobada);

                          com_solicitud_compra_det_pre_aprobacion_Info InfoPreAprobada = new com_solicitud_compra_det_pre_aprobacion_Info();
                          InfoPreAprobada.IdEmpresa = item.IdEmpresa;
                          InfoPreAprobada.IdSucursal_SC = item.IdSucursal;
                          InfoPreAprobada.IdSolicitudCompra = item.IdSolicitudCompra;
                          InfoPreAprobada.Secuencia_SC = item.Secuencia;
                          InfoPreAprobada.IdEstadoAprobacion = info.IdEstadoAprobacion;
                          InfoPreAprobada.IdUsuarioAprueba = info.IdUsuarioAprobo;
                          InfoPreAprobada.FechaHoraAprobacion = DateTime.Now;
                          InfoPreAprobada.observacion = "";

                          listPreApro.Add(InfoPreAprobada);

                      }

                      // graba detalle solicitud compra


                      odataApro.GuardarDB(listApro);
                      odataPreApro.GuardarDB(listPreApro);
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDB_EstadoAprobacion(com_solicitud_compra_Info info)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {
                  var contact = context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra == info.IdSolicitudCompra);

                  if (contact != null)
                  {

                      contact.IdEstadoAprobacion = info.IdEstadoAprobacion;
                      contact.IdUsuarioAprobo = (info.IdUsuarioAprobo == null) ? "" : Convert.ToString(info.IdUsuarioAprobo);
                      contact.MotivoAprobacion = (info.MotivoAprobacion == null) ? "" : Convert.ToString(info.MotivoAprobacion);
                      contact.FechaHoraAprobacion = info.FechaHoraAprobacion;
                      context.SaveChanges();
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<com_solicitud_compra_Info> Get_List_solicitud_compra(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin
           ,string IdEstadoAprobacion)
      {
          List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();

          com_ordencompra_local_det_x_com_solicitud_compra_det_Data datDetComp = new com_ordencompra_local_det_x_com_solicitud_compra_det_Data();
          List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lstDetComp = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

          List<string> IdOrdenCompra = new List<string>();
          EntitiesCompras OEComp = new EntitiesCompras();
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

              int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
              int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;


                  var Select = from q in OEComp.vwcom_solicitud_compra
                               where q.IdEmpresa == IdEmpresa
                                && q.fecha <= FechaFin
                                && q.fecha >= FechaIni
                                && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                && q.IdEstadoAprobacion.Contains(IdEstadoAprobacion)
                               select q;

                  foreach (var item in Select)
                  {
                      com_solicitud_compra_Info SoliCompInfo = new com_solicitud_compra_Info();

                      SoliCompInfo.IdEmpresa = item.IdEmpresa;
                      SoliCompInfo.IdSucursal = item.IdSucursal;
                      SoliCompInfo.IdSolicitudCompra = item.IdSolicitudCompra;
                      SoliCompInfo.NumDocumento = item.NumDocumento;
                      SoliCompInfo.IdSolicitante = Convert.ToDecimal(item.IdPersona_Solicita);
                      SoliCompInfo.IdComprador = item.IdComprador;
                      SoliCompInfo.IdDepartamento = item.IdDepartamento;
                      SoliCompInfo.fecha = item.fecha;
                      SoliCompInfo.observacion = item.observacion;
                      SoliCompInfo.Estado = item.Estado;
                      SoliCompInfo.Sucursal = item.Sucursal;
                      SoliCompInfo.Solicitante = item.Solicitante;
                      SoliCompInfo.Comprador = item.Comprador;
                      SoliCompInfo.departamento = item.departamento;
                      SoliCompInfo.IdEstadoAprobacion = item.IdEstadoAprobacion;
                      SoliCompInfo.IdUsuarioAprobo = item.IdUsuarioAprobo;
                      SoliCompInfo.MotivoAprobacion = item.MotivoAprobacion;
                      SoliCompInfo.FechaHoraAprobacion = item.FechaHoraAprobacion;
                      SoliCompInfo.nom_EstadoAprobacion = item.nom_EstadoAprobacion;
                      SoliCompInfo.Mostrar_Icono_Buscar_OC = true;
                      Lst.Add(SoliCompInfo);   
                  }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<com_solicitud_compra_Info> Get_List_Solicitud_x_OC(int IdEmpresa, int IdSucursal, string IdOrdenCompra)
      {
          List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();
          EntitiesCompras OEComp = new EntitiesCompras();
          try
          {

              var Select = from q in OEComp.vwcom_ordencompra_local_det_x_com_solicitud_compra_det
                           where q.scd_IdEmpresa == IdEmpresa
                                 && q.scd_IdSucursal == IdSucursal
                                 && q.oc_NumDocumento == IdOrdenCompra
                           select q;

              foreach (var item in Select)
              {
                  com_solicitud_compra_Info SolicitudInfo = new com_solicitud_compra_Info();
                  SolicitudInfo.IdSolicitudCompra = item.scd_IdSolicitudCompra;

                  Lst.Add(SolicitudInfo);
              }

              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
