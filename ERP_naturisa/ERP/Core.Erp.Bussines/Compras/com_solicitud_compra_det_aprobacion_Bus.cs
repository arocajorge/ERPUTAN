using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Compras
{
   public class com_solicitud_compra_det_aprobacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_solicitud_compra_det_aprobacion_Data odata = new com_solicitud_compra_det_aprobacion_Data();
        string mensaje = "";

       public Boolean GuardarDB(List<com_solicitud_compra_det_aprobacion_Info> LstInfo, ref string msg)
       {
           try
           {
               Boolean res = true;
               string validaMotivo = "";
               if (Validar_objeto_AprobSolComp(LstInfo,validaMotivo, ref msg))
               {
                    odata.GuardarDB(LstInfo);
               }
               else
               {
                   res = false;
               }

               return res;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
             
           }
       }

       public List<com_solicitud_compra_det_aprobacion_Info> Get_List_solicitud_compra_det_aprobacion(int idempresa, int idSucursal, decimal idSoliComp)
       {
           try
           {
               return odata.Get_List_solicitud_compra_det_aprobacion(idempresa, idSucursal, idSoliComp);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
           }
       
       }

       public Boolean Validar_objeto_AprobSolComp(List<com_solicitud_compra_det_aprobacion_Info> lista, string validaMotivo, ref string msg)
       {
           try
           {
               int cont = 0;

               if (lista.Count == 0)
               {
                   msg = "El Detalle no tiene items que grabar o No hay Items Selecionados";
                   return false;
               }
               else
               {
                   foreach (var item in lista)
                   {
                       if (item.Checked == true)
                       {
                           cont = cont + 1;                                                     
                       }
                   }
                   if (cont == 0)
                   {
                       msg = "No hay items seleccionados";
                       return false;
                   }
               }

             if (lista.Count() != 0)
               {
                   foreach (var item in lista)
                   {
                       if (item.IdEstadoAprobacion == null || item.IdEstadoAprobacion =="")
                       {
                           msg = "No existe Estado de Aprobación";
                           return false;
                       }
                   }                          
               }

               //valida estado 
             if (lista.Count() != 0)
             {
                                
                 //foreach (var item in lista)
                 //{

                 //    if (item.Graba_Estado == "S" || item.Graba_Estado == "T")
                 //     {

                 //         if (item.Checked_Estado==false)
                 //         {
                 //             msg = "Debe seleccionar el Estado de Aprobación";
                 //             return false;
                 //         }
                     
                 //    }
                    
                 //}
             }
           
               if (validaMotivo=="S")
               {
                  int cont2 = 0;
                  if (lista.Count() != 0)
                  {
                      foreach (var item in lista)
                      {
                          if (item.Checked == true && item.IdProveedor_SC == 0 && item.IdEstadoAprobacion == "APR_SOL")
                          {
                              cont2 = cont2 + 1;
                          }
                      }
                    
                      if (cont2 > 0)
                      {
                          msg = "Seleccione el proveedor a los items Aprobados";
                          return false;
                      }

                      int cont3 = 0;                  
                      foreach (var item in lista)
                      {
                          if (item.Checked == true && item.IdMotivo == 0 && item.IdEstadoAprobacion == "APR_SOL")
                          {
                              cont3 = cont3 + 1;
                          }
                      }
                 
                      if (cont3 > 0)
                      {
                          msg = "Seleccione el Motivo a los items Aprobados";
                          return false;
                      }

                      int cont4 = 0;                  
                      foreach (var item in lista)
                      {
                          if (item.Checked == true && item.do_precioCompra == 0 && item.IdEstadoAprobacion == "APR_SOL")
                          {
                              cont4 = cont4 + 1;
                          }
                      }
                     
                      if (cont4 > 0)
                      {
                          msg = "Ingrese el precio a los items Aprobados";
                          return false;
                      }
                  }
              
              }
                           
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_AprobSolComp", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
           }
       }


       public Boolean Actualizar_EstadoReproba(List<com_solicitud_compra_det_aprobacion_Info> LstInfo, List<com_solicitud_compra_det_aprobacion_Info> lstSol_Genera_OC, string validaMotivo, ref string msg)
       {
           try
           {
              Boolean res = true;
              if (Validar_objeto_AprobSolComp(LstInfo,validaMotivo, ref msg))
               {
                   odata.Actualizar_EstadoReproba(LstInfo, ref msg);

                   if (validaMotivo=="S")
                  {
                      #region Genera Orden Compra
                      //Generar Orden Compra

                      var Query = from q in lstSol_Genera_OC
                                  group q by new
                                  {
                                      q.IdSucursal_x_OC,
                                      q.IdProveedor_SC,
                                      q.IdMotivo
                                  }
                                      into grouping
                                      select new { grouping.Key, grouping };
                      foreach (var grp in Query)
                      {
                          if (grp.Key.IdProveedor_SC != 0 && grp.Key.IdMotivo != 0 && grp.Key.IdSucursal_x_OC !=0)
                          {
                              List<com_solicitud_compra_det_aprobacion_Info> listSolxItemSaldo = new List<com_solicitud_compra_det_aprobacion_Info>();
                              foreach (var item in grp.grouping)
                              {
                                  if (item.Checked == true && item.IdEstadoAprobacion == "APR_SOL" && item.IdEstadoPreAprobacion == "APR_SOL")
                                  {
                                      com_solicitud_compra_det_aprobacion_Info info = new com_solicitud_compra_det_aprobacion_Info();

                                      info.Checked = item.Checked;
                                      info.IdEmpresa = item.IdEmpresa;
                                      info.IdSucursal_SC = item.IdSucursal_SC;
                                      info.IdSucursal_x_OC = item.IdSucursal_x_OC;

                                      info.fecha = item.fecha;
                                      info.Solicitante = item.Solicitante;
                                      info.IdComprador = item.IdComprador;
                                      info.IdComprador = item.IdComprador;
                                      info.IdPersona_Solicita = item.IdPersona_Solicita;
                                      info.IdDepartamento = item.IdDepartamento;
                                      info.IdProveedor = Convert.ToDecimal(item.IdProveedor_SC);

                                      info.IdMotivo = item.IdMotivo;
                                      info.IdSolicitudCompra = item.IdSolicitudCompra;
                                      info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                                      info.Secuencia = item.Secuencia_SC;

                                      info.observacion = item.observacion;

                                      //detalle

                                      info.IdProducto_SC = item.IdProducto_SC;
                                      info.NomProducto_SC = item.NomProducto_SC;
                                      info.Cantidad_aprobada = item.Cantidad_aprobada;

                                      info.IdCentroCosto = item.IdCentroCosto;
                                      info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                                      info.IdPunto_cargo = item.IdPunto_cargo;
                                      info.IdUnidadMedida = item.IdUnidadMedida;

                                      //nuevo
                                      info.do_precioCompra = item.do_precioCompra;
                                      info.do_porc_des = item.do_porc_des;
                                      info.do_descuento = item.do_descuento;
                                      info.do_subtotal = item.do_subtotal;
                                      info.do_iva = item.do_iva;
                                      info.do_total = item.do_total;
                                      info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                                      info.do_observacion = item.do_observacion;

                                      info.IdEstadoPreAprobacion = item.IdEstadoPreAprobacion;

                                      listSolxItemSaldo.Add(info);

                                  }
                              }

                              com_ordencompra_local_Info infOrdCom = new com_ordencompra_local_Info();
                              decimal id = 0;
                              // string msg = "";

                              var groupByProv = listSolxItemSaldo.GroupBy(proveedor => proveedor.IdProveedor);
                              List<com_solicitud_compra_det_aprobacion_Info> lista;

                              foreach (var item in groupByProv)
                              {
                                  var listaAux = item.ToList().FindAll(q => q.Checked == true && q.IdEstadoAprobacion == "APR_SOL" && q.IdEstadoPreAprobacion == "APR_SOL");

                                  if (listaAux.Count() == 0)
                                  {
                                  }
                                  else
                                  {
                                      lista = new List<com_solicitud_compra_det_aprobacion_Info>();
                                      lista = listaAux.ToList();

                                      // cabecera Orden Compra
                                      int x;
                                      x = 1;

                                      foreach (var item2 in lista)
                                      {
                                          while (x <= 1)
                                          {
                                              infOrdCom = new com_ordencompra_local_Info();

                                              infOrdCom.IdEmpresa = item2.IdEmpresa;
                                              infOrdCom.IdProveedor = item2.IdProveedor;
                                              infOrdCom.Tipo = "LOCAL";
                                              infOrdCom.IdTerminoPago = null;
                                              infOrdCom.oc_plazo = 0;
                                              infOrdCom.oc_fecha = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                                              infOrdCom.oc_flete = 0;
                                              infOrdCom.oc_observacion = item2.observacion;
                                              infOrdCom.Estado = "A";
                                              infOrdCom.oc_fechaVencimiento = item2.fecha;
                                              com_parametro_Bus Bus_ParamCompra = new com_parametro_Bus();
                                              com_parametro_Info InfoComDev = new com_parametro_Info();
                                              InfoComDev = Bus_ParamCompra.Get_Info_parametro(item2.IdEmpresa);
                                              infOrdCom.IdEstadoAprobacion_cat = InfoComDev.IdEstadoAprobacion_OC;
                                              infOrdCom.Solicitante = item2.Solicitante;
                                              infOrdCom.IdComprador = item2.IdComprador;
                                              infOrdCom.AfectaCosto = "N";
                                              infOrdCom.IdSolicitante = item2.IdPersona_Solicita;
                                              infOrdCom.IdEstadoRecepcion_cat = "PEN";
                                              infOrdCom.IdDepartamento = item2.IdDepartamento;
                                              cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                                              infOrdCom.IdUsuario = param.IdUsuario;
                                              com_parametro_Bus bus_param = new com_parametro_Bus();
                                              List<com_parametro_Info> listParam = new List<com_parametro_Info>();
                                              listParam = bus_param.Get_List_parametro(item2.IdEmpresa);
                                              var itemParam = listParam.FirstOrDefault(q => q.IdEmpresa == item2.IdEmpresa);
                                              
                                              //infOrdCom.IdSucursal = itemParam.IdSucursal_x_Aprob_x_SolComp;

                                              infOrdCom.IdSucursal = item2.IdSucursal_x_OC;


                                              infOrdCom.IdMotivo = item2.IdMotivo;

                                              x = x + 1;
                                          }
                                      }

                                      // detalle orden compra
                                      List<com_ordencompra_local_det_Info> listDetOrdComp = new List<com_ordencompra_local_det_Info>();
                                      foreach (var item3 in lista)
                                      {
                                          com_ordencompra_local_det_Info infoDet_Oc = new com_ordencompra_local_det_Info();

                                          infoDet_Oc.IdSucursal = item3.IdSucursal_x_OC;
                                          infoDet_Oc.IdProducto = Convert.ToDecimal(item3.IdProducto_SC);
                                          infoDet_Oc.do_Cantidad = item3.Cantidad_aprobada;
                                          infoDet_Oc.do_Costeado = "N";
                                          infoDet_Oc.do_peso = 0;
                                          infoDet_Oc.do_precioCompra = item3.do_precioCompra;
                                          infoDet_Oc.do_porc_des = item3.do_porc_des;
                                          infoDet_Oc.do_descuento = item3.do_descuento;
                                          infoDet_Oc.do_subtotal = item3.do_subtotal;
                                          infoDet_Oc.do_iva = item3.do_iva;
                                          infoDet_Oc.do_total = item3.do_total;
                                          infoDet_Oc.IdCod_Impuesto = item3.IdCod_Impuesto_Iva;
                                          infoDet_Oc.do_observacion = item3.do_observacion;
                                          infoDet_Oc.IdPunto_cargo = item3.IdPunto_cargo;
                                          infoDet_Oc.IdCentroCosto = item3.IdCentroCosto;
                                          infoDet_Oc.IdCentroCosto_sub_centro_costo = item3.IdCentroCosto_sub_centro_costo;
                                          infoDet_Oc.IdUnidadMedida = item3.IdUnidadMedida;

                                          listDetOrdComp.Add(infoDet_Oc);
                                      }

                                      // detalle solicitud compra
                                      List<com_solicitud_compra_det_Info> listDetSoliciComp = new List<com_solicitud_compra_det_Info>();


                                      foreach (var item3 in lista)
                                      {
                                          com_solicitud_compra_det_Info infoDetSolCom = new com_solicitud_compra_det_Info();

                                          infoDetSolCom.IdEmpresa = item3.IdEmpresa;
                                          infoDetSolCom.IdSucursal = item3.IdSucursal_SC;
                                          infoDetSolCom.IdSolicitudCompra = item3.IdSolicitudCompra;
                                          infoDetSolCom.Secuencia = item3.Secuencia;
                                          infoDetSolCom.IdProducto = item3.IdProducto_SC;
                                          infoDetSolCom.do_Cantidad = item3.Cantidad_aprobada;
                                          infoDetSolCom.NomProducto = item3.NomProducto_SC;
                                          infoDetSolCom.IdPunto_cargo = item3.IdPunto_cargo;
                                          infoDetSolCom.IdCentroCosto = item3.IdCentroCosto;
                                          infoDetSolCom.IdCentroCosto_sub_centro_costo = item3.IdCentroCosto_sub_centro_costo;
                                          infoDetSolCom.do_observacion = item3.do_observacion;
                                          infoDetSolCom.IdUnidadMedida = item3.IdUnidadMedida;

                                          listDetSoliciComp.Add(infoDetSolCom);
                                      }

                                      // grabar orden de compra

                                      com_ordencompra_local_Bus bus_OrdComp = new com_ordencompra_local_Bus();

                                      infOrdCom.listDetalle = listDetOrdComp;

                                      infOrdCom.listDetSoliciComp = listDetSoliciComp;

                                      if (bus_OrdComp.GuardarDB(infOrdCom, ref id, ref msg))
                                      {
                                          msg="Se ha procedido a grabar el registro de la Orden/Compra #: " + id.ToString() + " exitosamente.";                                     
                                      }
                                      else
                                      {
                                          msg = "Error al grabar OC. " + msg ;
                                      }
                                  }
                              }
                          }
                      }
                      #endregion                                   
                  }

                  
               }
                 else
                {
                  res = false;
              
                }
              return res;              
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_EstadoReproba", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
           }
       }

       public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
       {
           try
           {
               return odata.EliminarDB(IdEmpresa, IdSucursal, IdSolicitudCompra);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
           }
       }


       public Boolean Actualizar_Producto_Creado_Det_Aproba(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto,string nom_producto, ref string mensaje)
       {
           try
           {
               return odata.Actualizar_Producto_Creado_Det_Aproba(IdEmpresa,  IdSucursal,  IdSolicitudCompra, Secuencia,  IdProducto,nom_producto, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_Producto_Creado_Det_Aproba", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_aprobacion_Bus) };
           }

       }

    }
}
