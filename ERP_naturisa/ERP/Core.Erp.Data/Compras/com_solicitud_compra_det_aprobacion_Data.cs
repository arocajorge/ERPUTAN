using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
   public class com_solicitud_compra_det_aprobacion_Data
    {
       string mensaje = "";
            
       public Boolean GuardarDB(List<com_solicitud_compra_det_aprobacion_Info> LstInfo)
       {
           try
           {
               
               foreach (var item in LstInfo)
               {
                   using (EntitiesCompras Context = new EntitiesCompras())
                   {
                       
                       var Address = new com_solicitud_compra_det_aprobacion();

                       Address.IdEmpresa = item.IdEmpresa;
                       Address.IdSucursal_SC = item.IdSucursal_SC;
                       Address.IdSolicitudCompra = item.IdSolicitudCompra;
                       Address.Secuencia_SC = item.Secuencia_SC;
                       Address.IdProducto_SC = item.IdProducto_SC == 0 ? null : item.IdProducto_SC;
                       Address.NomProducto_SC = item.NomProducto_SC;
                       Address.Cantidad_aprobada =0;
                       Address.IdEstadoAprobacion = item.IdEstadoAprobacion;                
                       Address.IdProveedor_SC = item.IdProveedor_SC == 0 ? null : item.IdProveedor_SC;
                       Address.IdUsuarioAprueba = item.IdUsuarioAprueba;
                       Address.FechaHoraAprobacion = item.FechaHoraAprobacion;
                       Address.observacion = item.observacion;
                       Address.IdUnidadMedida = item.IdUnidadMedida;
                       Address.do_precioCompra=item.do_precioCompra;
                       Address.do_porc_des = item.do_porc_des;
                       Address.do_descuento = item.do_descuento;
                       Address.do_subtotal = item.do_subtotal;
                       Address.do_iva = item.do_iva;
                       Address.do_total = item.do_total;
                       Address.IdCentroCosto = item.IdCentroCosto;
                       Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       Address.IdPunto_cargo = item.IdPunto_cargo == 0 ? null : item.IdPunto_cargo;
                       Address.do_observacion = item.do_observacion;

                       Context.com_solicitud_compra_det_aprobacion.Add(Address);
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
               throw new Exception(ex.ToString());
           }
       }

       public List<com_solicitud_compra_det_aprobacion_Info> Get_List_solicitud_compra_det_aprobacion(int IdEmpresa, int IdSurcursal, decimal IdSoliComp)
       {
           List<com_solicitud_compra_det_aprobacion_Info> Lst = new List<com_solicitud_compra_det_aprobacion_Info>();
           EntitiesCompras oEnti = new EntitiesCompras();
           try
           {
               var Query = from q in oEnti.vwcom_solicitud_compra_det_aprobacion 
                           where q.IdEmpresa == IdEmpresa 
                           && q.IdSucursal_SC == IdSurcursal 
                           && q.IdSolicitudCompra == IdSoliComp
                           select q;



               foreach (var item in Query)
               {
                    com_solicitud_compra_det_aprobacion_Info Obj = new com_solicitud_compra_det_aprobacion_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdSucursal_SC = item.IdSucursal_SC;
                   Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                   Obj.Secuencia_SC = item.Secuencia_SC;
                   Obj.IdProducto_SC = Convert.ToDecimal(item.IdProducto_SC);
                   Obj.NomProducto_SC = item.NomProducto_SC;
                   Obj.Cantidad_aprobada = item.Cantidad_aprobada;
                   Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;
                   Obj.IdProveedor_SC = item.IdProveedor_SC;
                   Obj.Nom_Proveedor_SC = item.Nom_Proveedor_SC;

                   Obj.IdUsuarioAprueba = item.IdUsuarioAprueba;
                   Obj.FechaHoraAprobacion = Convert.ToDateTime(item.FechaHoraAprobacion);
                   Obj.do_observacion = item.observacion;

                   Obj.IdUnidadMedida = item.IdUnidadMedida;

                   Obj.do_precioCompra = Convert.ToDouble(item.do_precioCompra);
                   Obj.do_porc_des =  Convert.ToDouble(item.do_porc_des);
                   Obj.do_descuento =  Convert.ToDouble(item.do_descuento);
                   Obj.do_subtotal =  Convert.ToDouble(item.do_subtotal);
                   Obj.do_iva =  Convert.ToDouble(item.do_iva);
                   Obj.do_total = Convert.ToDouble( item.do_total);
                   Obj.IdCentroCosto = item.IdCentroCosto;
                   Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   Obj.IdPunto_cargo = Convert.ToInt32( item.IdPunto_cargo);
                   Obj.do_observacion = item.do_observacion;
             
                   Lst.Add(Obj);
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

       public Boolean Actualizar_EstadoReproba(List<com_solicitud_compra_det_aprobacion_Info> LstInfo, ref string msg)
       {
           try
           {             
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   foreach (var item in LstInfo)
                   {
                       var registro = context.com_solicitud_compra_det_aprobacion.FirstOrDefault
                           (A => A.IdEmpresa == item.IdEmpresa &&
                               A.IdSucursal_SC == item.IdSucursal_SC
                               && A.IdSolicitudCompra==item.IdSolicitudCompra
                               && A.Secuencia_SC == item.Secuencia_SC
                               && A.IdProducto_SC==item.IdProducto_SC);

                       if (registro != null)
                       {

                           if (item.Graba_Estado == "S")
                           {
                               registro.IdEstadoAprobacion = item.IdEstadoAprobacion;
                           }

                           if (item.Graba_Estado == "N" || item.Graba_Estado == "T")
                           {
                               if (item.Graba_Estado == "N")
                               {
                                   registro.IdEstadoAprobacion = item.IdEstadoAprobacion_AUX;
                               }
                               if (item.Graba_Estado == "T")
                               {
                                   registro.IdEstadoAprobacion = item.IdEstadoAprobacion;
                               }

                               registro.IdProveedor_SC = item.IdProveedor_SC == 0 ? null : item.IdProveedor_SC;
                               registro.Cantidad_aprobada = item.Cantidad_aprobada;
                               registro.IdUnidadMedida = item.IdUnidadMedida;

                               registro.do_precioCompra = item.do_precioCompra;
                               registro.do_porc_des = item.do_porc_des;
                               registro.do_descuento = item.do_descuento;
                               registro.do_subtotal = item.do_subtotal;
                               registro.do_iva = item.do_iva;
                               registro.do_total = item.do_total;
                               //registro.do_ManejaIva = item.do_ManejaIva;
                               registro.IdCentroCosto = item.IdCentroCosto;
                               registro.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                               registro.IdPunto_cargo = (item.IdPunto_cargo == 0) ? null : item.IdPunto_cargo;
                               registro.do_observacion = item.do_observacion;
                               registro.IdEstadoPreAprobacion = item.IdEstadoPreAprobacion;
                           }

                           context.SaveChanges();
                       }
                   }
               }
               msg = "Actualización Estado Reprobación OK";
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

               msg = "Error al Actualizar Estado Reprobación " + ex.Message + " ";
               throw new Exception(ex.ToString());
           }


       }


       public Boolean Actualizar_EstadoPreAprobacion(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia_SC, string IdEstadoPreAprobacion, ref string msg)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                       var registro = context.com_solicitud_compra_det_aprobacion.FirstOrDefault
                           (A => A.IdEmpresa == IdEmpresa &&
                               A.IdSucursal_SC == IdSucursal
                               && A.IdSolicitudCompra == IdSolicitudCompra
                               && A.Secuencia_SC == Secuencia_SC);

                       if (registro != null)
                       {
                           registro.IdEstadoPreAprobacion = IdEstadoPreAprobacion;
                           context.SaveChanges();
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
               msg = "Error al Actualizar Estado Reprobación " + ex.Message + " ";
               throw new Exception(ex.ToString());
           }
       }



       public Boolean Actualizar_CantidadAprobada(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia_SC, double Cantidad_aprobada)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var registro = context.com_solicitud_compra_det_aprobacion.FirstOrDefault
                       (A => A.IdEmpresa == IdEmpresa &&
                           A.IdSucursal_SC == IdSucursal
                           && A.IdSolicitudCompra == IdSolicitudCompra
                           && A.Secuencia_SC == Secuencia_SC);

                   if (registro != null)
                   {
                       registro.Cantidad_aprobada = Cantidad_aprobada;
                       context.SaveChanges();
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
               throw new Exception(ex.ToString());
           }
       }


       public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
       {
           try
           {

               EntitiesCompras Oent = new EntitiesCompras();

               var Consulta = Oent.Database.ExecuteSqlCommand("delete from com_solicitud_compra_det_aprobacion where IdEmpresa = " + IdEmpresa + " and IdSucursal_SC =" + IdSucursal + " and IdSolicitudCompra= " + IdSolicitudCompra + "");

               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Actualizar_Producto_Creado_Det_Aproba(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto,string nom_producto, ref string mensaje)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_solicitud_compra_det_aprobacion.FirstOrDefault(VProdu => VProdu.IdEmpresa == IdEmpresa && VProdu.IdSolicitudCompra == IdSolicitudCompra && VProdu.IdSucursal_SC == IdSucursal && VProdu.Secuencia_SC == Secuencia);

                   if (contact != null)
                   {
                       contact.IdProducto_SC = IdProducto;
                       contact.NomProducto_SC = nom_producto;

                       context.SaveChanges();

                       mensaje = "Se ha procedido a Actualizar la Información Exitosamente...";
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
               throw new Exception(ex.ToString());
           }
       }
    }
}
