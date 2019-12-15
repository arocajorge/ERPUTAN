using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;

using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_Aprobacion_Ing_Bod_x_OC_Bus
    {
      string mensaje = "";
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      cp_Aprobacion_Ing_Bod_x_OC_Data odata = new cp_Aprobacion_Ing_Bod_x_OC_Data();
      cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus_Det = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
  
      public Boolean GuardarDB(cp_Aprobacion_Ing_Bod_x_OC_Info Info, ref decimal id, ref string msg)
      {
          try
          {
              Boolean res = true;
              
              if (Validar_objeto_AprobIngEgrxOC(Info, ref msg))
              {
                  //cabecera
                  res = odata.GuardarDB(Info, ref id, ref msg);

                if(res==false)
                {
                    return res;
                }

                Info.IdAprobacion = id;
               
                if (res = Generar_Orden_Giro(Info, ref msg))
                 {
                     if (res == false)
                     {
                         return res;
                     }
                     else
                     {
                         //Info.IdEmpresa_Ogiro = 2;
                         //Info.IdCbteCble_Ogiro = 170;
                         //Info.IdTipoCbte_Ogiro = 7;
                        // actualizar campos cp_aprobacion
                         res=odata.ModificarDB(Info, ref msg);
                         if (res == false)
                         {
                             return res;
                         }

                         // grabar tabla intermedia cp_orden_giro_x_com_ordencompra_local_det
                         int sec = 1;                         
                         foreach (var item in Info.listDetalle)
                         {
                             cp_orden_giro_x_com_ordencompra_local_det_Info info = new cp_orden_giro_x_com_ordencompra_local_det_Info();

                             info.IdEmpresa_Ogiro = Convert.ToInt32(Info.IdEmpresa_Ogiro);
                             info.IdCbteCble_Ogiro = Convert.ToDecimal(Info.IdCbteCble_Ogiro);
                             info.IdTipoCbte_Ogiro = Convert.ToInt32(Info.IdTipoCbte_Ogiro);
                             
                             info.IdEmpresa_OC = item.IdEmpresa_Ing_Egr_Inv;
                             info.IdSucursal_OC = item.IdSucursal_OC;
                             info.IdOrdenCompra = item.IdOrdenCompra;
                             info.Secuencia_OC = item.Secuencia_OC;
                             info.Secuencia_reg = sec;
                             sec++;
                             string msje = "";
                             cp_orden_giro_x_com_ordencompra_local_det_Bus bus = new cp_orden_giro_x_com_ordencompra_local_det_Bus();
                             if (bus.GrabarDB(info, ref msje))
                             { 
                             
                             }                          
                         }
                     

                     }                                                       
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
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }           
      }

      public Boolean ModificarDB(cp_Aprobacion_Ing_Bod_x_OC_Info info, ref string msg)
      {

          try
          {
              return odata.ModificarDB(info, ref msg);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }
      
      }

      public Boolean EliminarDB(int IdEmpresa, decimal IdAprobacion, string IdUsuario, string MotivoAnula, ref string msg)
      {
          try
          {
              #region Guaarda las aprobaciones eliminadas en otra tabla
              //para extraer los datos antes de eliminar
              cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
              cp_Aprobacion_Ing_Bod_x_OC_Bus Bus_Info = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
              List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Lista_Info = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
              cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus_info_detalle = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();

              info = Bus_Info.Get_Info_Aprobacion_Ing_Bod_x_OC(IdEmpresa, IdAprobacion);
              info.listDetalle = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();

              Lista_Info = Bus_info_detalle.Get_List_Aprobacion_Ing_Bod_x_OC_det(IdEmpresa, IdAprobacion);
              info.listDetalle = Lista_Info;
              /*
              //para guargar en la tabla cp_Aprobacion_Ing_Bod_x_OC_Eliminados cabecera y detalle
              cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Info Info_Eliminado = new cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Info();
              cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Bus bus_Aprobar_Eliminado = new cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Bus();
              List<cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info> Lista = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info>();
              */
              bool respuesta = true;
              /*
              Info_Eliminado.IdEmpresa = info.IdEmpresa;
              Info_Eliminado.IdAprobacion = info.IdAprobacion;
              Info_Eliminado.Fecha_aprobacion = info.Fecha_aprobacion;
              Info_Eliminado.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
              Info_Eliminado.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
              Info_Eliminado.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
              Info_Eliminado.IdOrden_giro_Tipo = info.IdOrden_giro_Tipo;
              Info_Eliminado.IdIden_credito = info.IdIden_credito;
              Info_Eliminado.IdProveedor = info.IdProveedor;
              Info_Eliminado.Observacion = info.Observacion;
              Info_Eliminado.Serie = info.Serie;
              Info_Eliminado.Serie2 = info.Serie2;
              Info_Eliminado.num_documento = info.num_documento;
              Info_Eliminado.num_auto_Proveedor = info.num_auto_Proveedor;
              Info_Eliminado.num_auto_Imprenta = info.num_auto_Imprenta;
              Info_Eliminado.Fecha_Factura = info.Fecha_Factura;
              Info_Eliminado.co_subtotal_iva = info.co_subtotal_iva;
              Info_Eliminado.co_subtotal_siniva = info.co_subtotal_siniva;
              Info_Eliminado.Descuento = info.Descuento;
              Info_Eliminado.co_baseImponible = info.co_baseImponible;
              Info_Eliminado.co_Por_iva = info.co_Por_iva;
              Info_Eliminado.co_valoriva = info.co_valoriva;
              Info_Eliminado.co_total = info.co_total;
              Info_Eliminado.co_plazo = info.co_plazo;
              Info_Eliminado.Fecha_Anulacion = DateTime.Now;
              Info_Eliminado.IdUsuario_Anu = IdUsuario;
              Info_Eliminado.Motivo_Anu = MotivoAnula;
              Info_Eliminado.listDetalle = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info>();

              foreach (var item in info.listDetalle)
              {
                  cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info Eliminado = new cp_Aprobacion_Ing_Bod_x_OC_det_Eliminados_Info();
                  Eliminado.IdEmpresa = item.IdEmpresa;
                  Eliminado.IdAprobacion = item.IdAprobacion;
                  Eliminado.Secuencia = item.Secuencia;
                  Eliminado.IdEmpresa_Ing_Egr_Inv = item.IdEmpresa_Ing_Egr_Inv;
                  Eliminado.IdSucursal_Ing_Egr_Inv = item.IdSucursal_Ing_Egr_Inv;
                  Eliminado.IdNumMovi_Ing_Egr_Inv = item.IdNumMovi_Ing_Egr_Inv;
                  Eliminado.Secuencia_Ing_Egr_Inv = item.Secuencia_Ing_Egr_Inv;
                  Eliminado.Cantidad = item.Cantidad;
                  Eliminado.Costo_uni = item.Costo_uni;
                  Eliminado.Descuento = item.Descuento;
                  Eliminado.SubTotal = item.SubTotal;
                  Eliminado.PorIva = item.PorIva;
                  Eliminado.valor_Iva = item.valor_Iva;
                  Eliminado.Total = item.Total;
                  Eliminado.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                  Eliminado.IdCtaCble_IVA = item.IdCtaCble_IVA;
                  Eliminado.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo;
                  Eliminado.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo;
                  Eliminado.IdMovi_inven_tipo_Ing_Egr_Inv = item.IdMovi_inven_tipo_Ing_Egr_Inv;
                  Lista.Add(Eliminado);
              }
              Info_Eliminado.listDetalle = Lista;

              respuesta = bus_Aprobar_Eliminado.GuardarDB(Info_Eliminado, ref msg);
              */
              #endregion

              if (respuesta)
              {
                  respuesta = odata.EliminarDB(info.IdEmpresa, info.IdAprobacion, ref msg);
              }
              else
              {
                  msg = "No se pudo eliminar la aprobación seleccionada, favor comuniquese con sistemas";
                  respuesta = false;
              }
              return respuesta;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }
      }

      public Boolean VerificarNumDocumento(int IdEmpresa, string serie, string serie2, string numDocu,decimal IdProveedor, ref string mensaj)
      {
          try
          {
              return odata.VerificarNumDocumento(IdEmpresa, serie, serie2,numDocu,IdProveedor, ref mensaj);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }
      
      
      }

      public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> get_OG_x_Cta_Cble(List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstDet_OG)
      {
          try
          {
              List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstDet_OG_Agrupado = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();

              var select = from ing_ in lstDet_OG
                                 group ing_ by new
                                 {
                                     ing_.IdCtaCble_Gasto,
                                     IdCentro_Costo_x_Gasto_x_cxp = ing_.IdCentro_Costo,
                                     IdCentroCosto_sub_centro_costo_cxp = ing_.IdCentroCosto_sub_centro_costo,
                                     IdPunto_cargo_grupo = ing_.IdPunto_cargo_grupo,
                                     IdPunto_cargo = ing_.IdPunto_cargo
                                 }
                                     into grouping
                                     select new
                                     {
                                         grouping.Key,
                                         Total = grouping.Sum(q => q.Total),
                                         Subtotal = grouping.Sum(q => q.SubTotal)
                                     };

              foreach (var item in select)
              {
                  cp_Aprobacion_Ing_Bod_x_OC_det_Info info = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
                  info.IdCtaCble_Gasto = item.Key.IdCtaCble_Gasto ;
                  info.IdCentro_Costo = item.Key.IdCentro_Costo_x_Gasto_x_cxp;
                  info.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo_cxp;
                  info.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                  info.IdPunto_cargo = item.Key.IdPunto_cargo;
                  info.Total = item.Total;
                  info.SubTotal = item.Subtotal;
                  lstDet_OG_Agrupado.Add(info);
              }
              return lstDet_OG_Agrupado;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }
      }

      public Boolean Generar_Orden_Giro(cp_Aprobacion_Ing_Bod_x_OC_Info Info,ref string msg)
      {
          try
          {
              List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstDet_OG = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
              cp_parametros_Data data_cpParam = new cp_parametros_Data();
              cp_parametros_Info info_cpParam = new cp_parametros_Info();
              info_cpParam = data_cpParam.Get_Info_parametros(Info.IdEmpresa);

              if (Info.IdCbteCble_Ogiro != 0 && Info.IdCbteCble_Ogiro != null)
                  return true;

              #region Generar Info ct_Cbtecble
              //cabecera
              ct_Cbtecble_Info info_CbteCble = new ct_Cbtecble_Info();
              info_CbteCble.IdEmpresa = Info.IdEmpresa;
              info_CbteCble.IdTipoCbte = info_cpParam.pa_TipoCbte_OG;
              info_CbteCble.IdPeriodo = Convert.ToInt32(Info.Fecha_Factura.ToString("yyyyMM"));
              info_CbteCble.cb_Fecha = (Info.co_FechaContabilizacion == null) ? Info.Fecha_Factura : Convert.ToDateTime(Info.co_FechaContabilizacion);
              info_CbteCble.cb_Valor = Info.co_total;
              info_CbteCble.cb_Observacion = Info.Observacion == "" ? "Diario generado con # Aprobación Ing. a Bod. por O/C: " + Info.IdAprobacion + ", con Tipo Comprabante #: " + info_cpParam.pa_TipoCbte_OG + " y Fecha Aprobación: " + Info.Fecha_aprobacion + "" : Info.Observacion;
              info_CbteCble.Secuencia = 0;
              info_CbteCble.Estado = "A";
              info_CbteCble.Anio = Info.Fecha_Factura.Year;
              info_CbteCble.Mes = Info.Fecha_Factura.Month;
              info_CbteCble.Mayorizado = "N";
              info_CbteCble.IdSucursal = Info.IdSucursal ?? 1;
              //detalle
              List<ct_Cbtecble_det_Info> lista = new List<ct_Cbtecble_det_Info>();
              int Secuencia = 0;
              lstDet_OG =  get_OG_x_Cta_Cble(Info.listDetalle); 

              foreach (var item in lstDet_OG)
              {// gastos
                  ct_Cbtecble_det_Info InfoGasto = new ct_Cbtecble_det_Info();
                  Secuencia = Secuencia + 1;
                  InfoGasto.IdEmpresa = Info.IdEmpresa;
                  InfoGasto.IdTipoCbte = info_cpParam.pa_TipoCbte_OG;
                  InfoGasto.secuencia = Secuencia;
                  InfoGasto.IdCtaCble = item.IdCtaCble_Gasto;
                  
                  InfoGasto.IdCentroCosto = item.IdCentro_Costo;
                  InfoGasto.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  InfoGasto.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  InfoGasto.IdPunto_cargo = item.IdPunto_cargo;

                  InfoGasto.dc_Valor =item.SubTotal;
                  InfoGasto.dc_Observacion = Info.Observacion == "" ? "Diario generado con # Aprobación Ing. a Bod. por O/C: " + Info.IdAprobacion + ", con Tipo Comprabante #: " + info_cpParam.pa_TipoCbte_OG + " y Fecha Aprobación: " + Info.Fecha_aprobacion + "" : Info.Observacion;
                  InfoGasto.dc_Numconciliacion = null;
                  InfoGasto.dc_EstaConciliado = null;
                  lista.Add(InfoGasto);
              }
              

              if (Info.co_valoriva > 0)
              {
                  ct_Cbtecble_det_Info InfoIva = new ct_Cbtecble_det_Info();

                  InfoIva.IdEmpresa = Info.IdEmpresa;
                  InfoIva.IdTipoCbte = info_cpParam.pa_TipoCbte_OG;
                  InfoIva.secuencia = Secuencia + 2;
                  InfoIva.IdCtaCble = Info.pa_ctacble_iva.Trim();
                  //InfoIva.IdCentroCosto = null;
                  //InfoIva.IdCentroCosto_sub_centro_costo = null;
                  InfoIva.dc_Valor = Info.co_valoriva;
                  InfoIva.dc_Observacion = Info.Observacion == "" ? "Diario generado con # Aprobación Ing. a Bod. por O/C: " + Info.IdAprobacion + ", con Tipo Comprabante #: " + info_cpParam.pa_TipoCbte_OG + " y Fecha Aprobación: " + Info.Fecha_aprobacion + "" : Info.Observacion;
                  InfoIva.dc_Numconciliacion = null;
                  InfoIva.dc_EstaConciliado = null;
                  lista.Add(InfoIva);
              }

              ct_Cbtecble_det_Info InfoCXP = new ct_Cbtecble_det_Info();
              InfoCXP.IdEmpresa = Info.IdEmpresa;
              InfoCXP.IdTipoCbte = info_cpParam.pa_TipoCbte_OG;
              InfoCXP.secuencia = Secuencia + 1;
              InfoCXP.IdCtaCble = Info.IdCtaCble_CXP.Trim();
              //InfoCXP.IdCentroCosto = Info.IdCentroCosoto_CXP;
              //InfoCXP.IdCentroCosto_sub_centro_costo = null;
              InfoCXP.dc_Valor = Info.co_total * -1;
              InfoCXP.dc_Observacion = Info.Observacion == "" ? "Diario generado con # Aprobación Ing. a Bod. por O/C: " + Info.IdAprobacion + ", con Tipo Comprabante #: " + info_cpParam.pa_TipoCbte_OG + " y Fecha Aprobación: " + Info.Fecha_aprobacion + "" : Info.Observacion;
              InfoCXP.dc_Numconciliacion = null;
              InfoCXP.dc_EstaConciliado = null;
              lista.Add(InfoCXP);

              info_CbteCble._cbteCble_det_lista_info = lista;

              //grabar diario

              #endregion

              #region Genere cp_orden_giro_Info y graba Orden Giro


              //Generar Info cp_orden_giro
              cp_orden_giro_Info Info_Ogiro = new cp_orden_giro_Info();
              Info_Ogiro.IdEmpresa = Info.IdEmpresa;
              Info_Ogiro.IdTipoCbte_Ogiro = info_cpParam.pa_TipoCbte_OG;
              Info_Ogiro.IdOrden_giro_Tipo = Info.IdOrden_giro_Tipo;
              Info_Ogiro.IdProveedor = Info.IdProveedor;
              Info_Ogiro.co_fechaOg = Info.Fecha_aprobacion;
              Info_Ogiro.co_FechaFactura = Info.Fecha_Factura;
              Info_Ogiro.co_FechaFactura_vct = Info.Fecha_vcto;              
              Info_Ogiro.co_plazo = Info.co_plazo;
              Info_Ogiro.co_FechaContabilizacion = (Info.co_FechaContabilizacion == null) ? Info.Fecha_Factura : Info.co_FechaContabilizacion;
              Info_Ogiro.co_serie = Info.Serie+"-"+Info.Serie2;
              Info_Ogiro.Num_Autorizacion = Info.num_auto_Proveedor;
              Info_Ogiro.co_factura = Info.num_documento;
              Info_Ogiro.co_observacion = Info.Observacion;              
              Info_Ogiro.co_subtotal_iva = Info.co_subtotal_iva;
              Info_Ogiro.co_subtotal_siniva = Info.co_subtotal_siniva;
              Info_Ogiro.co_baseImponible = Info.co_baseImponible;
              Info_Ogiro.co_Por_iva = Info.co_Por_iva;
              Info_Ogiro.co_valoriva = Info.co_valoriva;
              Info_Ogiro.IdCod_ICE = 866;//NO APLICA
              Info_Ogiro.co_Ice_base = 0;
              Info_Ogiro.co_Ice_por = 0;
              Info_Ogiro.co_Ice_valor = 0;
              Info_Ogiro.co_Serv_valor = 0;
              Info_Ogiro.co_Serv_por = 0;
              Info_Ogiro.co_OtroValor_a_descontar = 0;
              Info_Ogiro.co_OtroValor_a_Sumar = 0;
              Info_Ogiro.co_BaseSeguro = 0;
              Info_Ogiro.co_total = Info.co_total;
              Info_Ogiro.co_valorpagar = Info.co_total;
              Info_Ogiro.co_vaCoa = "S";
              Info_Ogiro.IdIden_credito = Info.IdIden_credito;
              Info_Ogiro.IdCod_101 = 837;//No Aplica
              Info_Ogiro.IdTipoFlujo = Info.IdTipoFlujo;
              Info_Ogiro.IdTipoServicio = "BIEN";
              Info_Ogiro.IdCtaCble_Gasto = Info.IdCtaCble_Gasto;

              Info_Ogiro.IdCtaCble_IVA = Info.co_valoriva > 0 ? Info.pa_ctacble_iva.Trim() : null;
              Info_Ogiro.Estado = "A";

              Info_Ogiro.IdUsuario = "";          
              Info_Ogiro.Fecha_Transac = DateTime.Now;
             
              Info_Ogiro.IdUsuarioUltMod = "";          
              Info_Ogiro.Fecha_UltMod = null;             
              Info_Ogiro.IdUsuarioUltAnu = null;           
              Info_Ogiro.MotivoAnu = null;
              Info_Ogiro.nom_pc = "";            
              Info_Ogiro.Fecha_UltAnu = null;           
              Info_Ogiro.ip = "";
             
              Info_Ogiro.co_retencionManual = "S";
              Info_Ogiro.IdCbteCble_Anulacion = null;
              Info_Ogiro.IdTipoCbte_Anulacion = null;
              Info_Ogiro.IdCentroCosto = null;
              Info_Ogiro.IdSucursal = Info.IdSucursal;
              Info_Ogiro.PagoLocExt = "LOC";
              Info_Ogiro.PaisPago = null;
              Info_Ogiro.ConvenioTributacion = "NO";
              Info_Ogiro.PagoSujetoRetencion = "NO";
              Info_Ogiro.BseImpNoObjDeIva = 0;

              Info_Ogiro.Num_Autorizacion_Imprenta = Info.num_auto_Imprenta;
              
              Info_Ogiro.fecha_autorizacion = Info.fecha_autorizacion;

              //verificar Id_Num_Autorizacion
              cp_Autorizacion_x_Doc_x_Pag_Data data_NumAuto = new cp_Autorizacion_x_Doc_x_Pag_Data();
              string msge = "";
              if (!data_NumAuto.Verificar_NumAutorizacion_Ogiro(Info.num_auto_Proveedor, ref msge))
              {
                  //grabar
                  cp_Autorizacion_x_Doc_x_Pag_Info info = new cp_Autorizacion_x_Doc_x_Pag_Info();
                  info.Id_Num_Autorizacion = Info.num_auto_Proveedor;
                  
                  data_NumAuto.GuardarDB(info, ref msge);

                  Info_Ogiro.Num_Autorizacion = Info.num_auto_Proveedor;
              }

              cp_orden_giro_Bus BusOrdenGiro_B = new cp_orden_giro_Bus();
              List<cp_reembolso_Info> lst_reembolso = null;
              List<cp_orden_giro_pagos_sri_Info> lst_formasPagoSRI = null;
              cp_retencion_Info InfoRetencion = null;
              ct_Cbtecble_Info InfoCbteCble_x_Ret = null;
              
              string es_332_333_334 = "";

              List<cp_orden_giro_x_imp_ordencompra_ext_Info> LisImportacion = null;
              List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC = null;
              decimal idCbteCble = 0;

              Info_Ogiro.Info_CbteCble_x_OG=info_CbteCble;
              Info_Ogiro.lst_reembolso=lst_reembolso;
              Info_Ogiro.lst_formasPagoSRI=lst_formasPagoSRI;
              Info_Ogiro.Info_Retencion=InfoRetencion;

              if (Info_Ogiro.Info_Retencion != null)
              {
                  Info_Ogiro.Info_Retencion.Info_CbteCble_x_RT = InfoCbteCble_x_Ret;
              }
              Info_Ogiro.LisImportacion=LisImportacion;
              Info_Ogiro.LstImportacionOC=LstImportacionOC;             


              if (BusOrdenGiro_B.ExisteFacturaPorProveedor(Info_Ogiro.IdEmpresa,Info_Ogiro.IdProveedor,Info_Ogiro.co_serie,Info_Ogiro.co_factura))
              {

                      if (BusOrdenGiro_B.ModificarDB(Info_Ogiro,  ref msg))
                      {
                          Info.IdEmpresa_Ogiro = Info_Ogiro.IdEmpresa;
                          Info.IdCbteCble_Ogiro = Info_Ogiro.IdCbteCble_Ogiro;
                          Info.IdTipoCbte_Ogiro = Info_Ogiro.IdTipoCbte_Ogiro;
                      }
              }
              else
              {
                      if (BusOrdenGiro_B.GrabarDB(Info_Ogiro, ref idCbteCble, ref msg))
                      {

                          Info.IdEmpresa_Ogiro = Info_Ogiro.IdEmpresa;
                          Info.IdCbteCble_Ogiro = Info_Ogiro.IdCbteCble_Ogiro;
                          Info.IdTipoCbte_Ogiro = Info_Ogiro.IdTipoCbte_Ogiro;
                      }
              }
              

              #endregion


              return true;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_Orden_Giro", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }               
      }

      public Boolean Validar_objeto_AprobIngEgrxOC(cp_Aprobacion_Ing_Bod_x_OC_Info Info, ref string msg)
      {

          try
          {
              if (Info.IdEmpresa == 0 || Info.IdProveedor== 0 || Info.IdProveedor == 0 )
              {
                  msg = "las variables estan en cero... IdEmpresa == 0 || IdSucursal == 0 || IdProveedor == 0";
                  return false;
              }

               Info.Observacion= Info.Observacion==null?"":Info.Observacion;

               if ((Info.Serie == null || Info.Serie == "") || (Info.Serie2 == null || Info.Serie2 == "" ))
              {
                  msg = "Ingrese la Serie";
                  return false;
              }
                if (Info.num_documento == null || Info.num_documento == "" )
              {
                  msg = "Ingrese el Número de la Factura";
                  return false;
              }

                if (Info.num_auto_Proveedor == null || Info.num_auto_Proveedor == "" )
              {
                  msg = "Ingrese el Número Autorización del Proveedor";
                  return false;
              }

               

               if (Info.Fecha_Factura== null)
              {
                  msg = "Ingrese la Fecha de la Factura";
                  return false;
              }

               if (Info.IdOrden_giro_Tipo == null || Info.IdOrden_giro_Tipo == "")
               {
                   msg = "Ingrese el Tipo de Documento";
                   return false;
               }

               if (Info.IdIden_credito == 0)
               {
                   msg = "Ingrese el Sustento Tributario";
                   return false;
               }

               if (Info.listDetalle.Count == 0)
               {
                   msg = "El Detalle no tiene items q grabar o no ha seleccionado Items";
                   return false;
               }
                          
            


               foreach (var item in Info.listDetalle)
               {
                   if (String.IsNullOrEmpty(item.IdCtaCble_Gasto))
                   {
                       msg = "Ingrese la Cta. Contable de Gasto del siguiente registro OC#" + item.IdOrdenCompra + " Ing#" + item.IdNumMovi_Ing_Egr_Inv;
                       return false;
                   }
               }
                
               if (String.IsNullOrEmpty(Info.IdCtaCble_CXP))
               {
                   cp_parametros_Data data_cpParam = new cp_parametros_Data();
                   cp_parametros_Info info_cpParam = new cp_parametros_Info();
                   info_cpParam = data_cpParam.Get_Info_parametros(Info.IdEmpresa);

                   if (!String.IsNullOrEmpty(info_cpParam.pa_ctacble_Proveedores_default))
                   {
                       Info.IdCtaCble_CXP = info_cpParam.pa_ctacble_Proveedores_default;
                   }
                   else
                   {
                       msg = "Ingrese la Cta. Contable del Proveedor";
                       return false;
                   }
                                                      
               }

               if (Info.listDetalle.Sum(q=>q.valor_Iva)> 0 && String.IsNullOrEmpty(Info.pa_ctacble_iva))
               {
                   msg = "Ingrese la Cta. Contable del Iva";
                   return false;
               }
                  
              return true;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_objeto_AprobIngEgrxOC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }

      }

      public List<cp_Aprobacion_Ing_Bod_x_OC_Info> Get_List_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
      {
          try
          {
              return odata.Get_List_Aprobacion_Ing_Bod_x_OC(IdEmpresa, FechaIni, FechaFin);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }          
      }

      public cp_Aprobacion_Ing_Bod_x_OC_Info Get_Info_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, decimal IdAprobacion)
      {
          try
          {
              return odata.Get_Info_Aprobacion_Ing_Bod_x_OC(IdEmpresa, IdAprobacion);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }      
      }

      public cp_Aprobacion_Ing_Bod_x_OC_Info Get_Info_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble_OG)
      {
          try
          {
              return odata.Get_Info_Aprobacion_Ing_Bod_x_OC(IdEmpresa, IdTipoCbte_OG, IdCbteCble_OG);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Aprobacion_Ing_Bod_x_OC", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
          }     
      }

       public  cp_Aprobacion_Ing_Bod_x_OC_Bus(){}
    }
}
