using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Contabilidad;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Info.Caja;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Caja;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;


namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_conciliacion_caja_Bus
   {
       caj_parametro_Bus bus_parametro_caja_bus = new caj_parametro_Bus();
       caj_parametro_Info info_parametro_caja = new Info.Caja.caj_parametro_Info();

        caj_Caja_Movimiento_Bus Bus_Caja= new caj_Caja_Movimiento_Bus();
        cp_conciliacion_Caja_det_x_ValeCaja_Bus bus_detalle_x_movimiento_caja = new cp_conciliacion_Caja_det_x_ValeCaja_Bus();
        caj_Caja_Movimiento_Tipo_Bus bus_mov_caja = new caj_Caja_Movimiento_Tipo_Bus();
        caj_Caja_Movimiento_Tipo_Info info_mov = new caj_Caja_Movimiento_Tipo_Info();
        ct_Cbtecble_Bus bus_comprobantes_contables = new Contabilidad.ct_Cbtecble_Bus();
       cp_orden_pago_det_Info Info_DetOrdenPago = new cp_orden_pago_det_Info();
       cp_orden_pago_Bus Bus_OrdenPago = new cp_orden_pago_Bus();
       cp_orden_pago_cancelaciones_Bus bus_OrdenCan = new cp_orden_pago_cancelaciones_Bus();
       tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
       cp_orden_pago_formapago_Bus Bus_FormaPago = new cp_orden_pago_formapago_Bus();
       cp_conciliacion_caja_Data data_Conciliacion_caja = new cp_conciliacion_caja_Data();
       cp_orden_pago_tipo_x_empresa_Bus Bus_EstadoOP = new cp_orden_pago_tipo_x_empresa_Bus();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       cp_conciliacion_Caja_det_Bus bus_conciliacion_det = new cp_conciliacion_Caja_det_Bus();
       cp_conciliacion_Caja_det_Ing_Caja_Bus bus_conci_ingresos = new cp_conciliacion_Caja_det_Ing_Caja_Bus();
       ct_Cbtecble_Bus Bus_CbteCble_B = new ct_Cbtecble_Bus();
       cp_orden_giro_Bus Bus_OrdenGiro_B = new cp_orden_giro_Bus();
       cp_retencion_Bus Bus_Retenccion = new cp_retencion_Bus();
       
       string MensajeError = "";

       public Boolean GrabarDB(cp_conciliacion_caja_Info Info_Conciliacion, ref string mensaje)
       {
           try
           {
               #region Variables
               Boolean res = true;
               decimal IdConciliacion_Caja_GB = 0;
               decimal idOrdenPAgo = 0;
               decimal idCbteCble = 0;

               List<tb_Sucursal_Info> ListSucursalOP = new List<tb_Sucursal_Info>();
               tb_Sucursal_Info IteSucursalOP = new tb_Sucursal_Info();
               cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
               caj_Caja_Movimiento_Tipo_Bus Bus_Tipo_Movi_Caj = new caj_Caja_Movimiento_Tipo_Bus();
               cp_parametros_Bus Bus_Param_cxp = new cp_parametros_Bus();
               cp_parametros_Info Info_Param_cxp = new cp_parametros_Info();
               #endregion
               ListSucursalOP = Bus_Sucursal.Get_List_Sucursal(Info_Conciliacion.IdEmpresa);
               IteSucursalOP = ListSucursalOP.First();

               Info_Param_cxp = Bus_Param_cxp.Get_Info_parametros(Info_Conciliacion.IdEmpresa);


               #region ================================GRABO CABECERA================================
               if (Info_Conciliacion.IdConciliacion_Caja != 0)
               {
                   res = ModificarDB_valores(Info_Conciliacion, ref MensajeError);
                   IdConciliacion_Caja_GB = Info_Conciliacion.IdConciliacion_Caja;
                   if (res == false)
                   {
                       res = false;
                       mensaje = "Error al Actualizar los valores de la cabecera : " + MensajeError;
                       return false;
                   }
               }
               else
               {
                   res = data_Conciliacion_caja.GrabarDB(Info_Conciliacion, ref IdConciliacion_Caja_GB, ref mensaje);
                   if (res == false)
                   {
                       res = false;
                       mensaje = "Error al Grabar los valores de la cabecera : " + MensajeError;
                       return false;
                   }
               }
               #endregion

               #region ================================GRABO LISTA ORDEN GIRO========================
               if (Info_Conciliacion.Detalle_x_FP.Count != 0)
               {
                   IdConciliacion_Caja_GB = Info_Conciliacion.IdConciliacion_Caja;

                   foreach (var item in Info_Conciliacion.Detalle_x_FP)//Inicio Foreach
                   {
                       if (!item.Esta_en_base)//si no esta en base grabo en la tabla intermedia
                       {
                           #region CREO ORDEN DE GIRO ---- Deshabilitado xq acepta notas de débito
                           if (item.IdCbteCble_Ogiro == 0)
                           {
                               /*
                               cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
                               caj_Caja_Movimiento_Tipo_Info Info_Tipo_Movi_Caj = new caj_Caja_Movimiento_Tipo_Info();

                               item.Info_Orden_Giro.co_fechaOg = Convert.ToDateTime(Info_Conciliacion.Fecha);
                               item.IdEmpresa = Info_Conciliacion.IdEmpresa;
                               item.Info_Orden_Giro.IdSucursal = IteSucursalOP.IdSucursal;

                               item.Info_Orden_Giro.co_observacion = "Conci. Caj.#: " + Info_Conciliacion.IdConciliacion_Caja + " - " + item.Info_Orden_Giro.co_observacion;
                               item.Info_Orden_Giro.Info_CbteCble_x_OG.cb_Observacion = "Conci. Caj.#: " + Info_Conciliacion.IdConciliacion_Caja + " - " + item.Info_Orden_Giro.Info_CbteCble_x_OG.cb_Observacion;

                               InfoProveedor = BusProveedor.Get_Info_Proveedor_Solo_CtasCbles(item.IdEmpresa, item.Info_Orden_Giro.IdProveedor);
                               Info_Tipo_Movi_Caj = Bus_Tipo_Movi_Caj.Get_Info_Movimiento_Tipo(item.IdTipoMovi, Info_Conciliacion.IdEmpresa, ref mensaje);

                               item.Info_Orden_Giro.IdTipoCbte_Ogiro = Info_Param_cxp.pa_TipoCbte_OG;
                               item.Info_Orden_Giro.IdCtaCble_IVA = Info_Param_cxp.pa_ctacble_iva;
                               item.Info_Orden_Giro.IdCtaCble_CXP = InfoProveedor.IdCtaCble_CXP;
                               item.Info_Orden_Giro.IdCtaCble_Gasto = (Info_Tipo_Movi_Caj.IdCtaCble == "" || Info_Tipo_Movi_Caj.IdCtaCble == null) ? InfoProveedor.IdCtaCble_Gasto : Info_Tipo_Movi_Caj.IdCtaCble;
                               item.Info_Orden_Giro.IdCtaCble_Gasto = (item.Info_Orden_Giro.IdCtaCble_Gasto == "" || item.Info_Orden_Giro.IdCtaCble_Gasto == null) ? Info_Param_cxp.pa_ctacble_deudora : item.Info_Orden_Giro.IdCtaCble_Gasto;
                               #endregion

                               #region CONTABILIZO
                               ct_Cbtecble_Info Info_Cbte_cble_x_FP = new ct_Cbtecble_Info();
                               Info_Cbte_cble_x_FP = Get_CbteCble_Info_X_Conciliacion_det_FP(item);
                               item.Info_Orden_Giro.Info_CbteCble_x_OG = Info_Cbte_cble_x_FP;
                               item.Info_Orden_Giro.IdEmpresa = item.IdEmpresa;
                               item.Info_Orden_Giro.IdUsuario = param.IdUsuario;
                               Grabar_cbte_cble_x_FP(item.Info_Orden_Giro, Info_Conciliacion, ref mensaje);
                                */
                           }
                               #endregion

                           #region GRABO OG X CONCI
                           item.IdConciliacion_Caja = Info_Conciliacion.IdConciliacion_Caja;
                           bus_conciliacion_det.GrabarDB(item, ref MensajeError);
                           #endregion
                       }
                       else //caso contrario modifico el valor a aplicar
                       {
                           bus_conciliacion_det.ModificarDB(item, ref MensajeError);
                       }
                       if (Info_Conciliacion.IdEstadoCierre == "EST_CIE_CER")
                       {
                           if (item.IdOrdenPago_OP==null)//Si no tiene una op este registro, la creo
                           {
                               
                               if (item.Tipo_documento == "N/D")
                               {
                                   Get_Orden_Pago_x_ND(item.IdEmpresa_OGiro, item.IdTipoCbte_Ogiro, item.IdCbteCble_Ogiro, ref MensajeError, Info_Conciliacion,
    item.Valor_a_aplicar);
                               }
                               else
                               {
                                   Get_Orden_Pago_x_FP(item.IdEmpresa_OGiro, item.IdTipoCbte_Ogiro, item.IdCbteCble_Ogiro, ref MensajeError, Info_Conciliacion, item.Valor_a_aplicar);
                               }
                           }
                       }
                   }//Fin Foreach
               }
               #endregion

               #region ================================GRABO LISTA VALE CAJA=========================
               if (Info_Conciliacion.Detalle_x_ValeCaja.Count() > 0)
               {
                   string MensajeError = "";
                   decimal comprobante_contable = 0;
                   info_parametro_caja = bus_parametro_caja_bus.Get_Info_Parametro(Info_Conciliacion.IdEmpresa);
                   foreach (var item in Info_Conciliacion.Detalle_x_ValeCaja)
                   {
                       if (!item.Esta_en_base)
                       {
                           caj_Caja_Movimiento_Info movimiento_caja_info = new Info.Caja.caj_Caja_Movimiento_Info();
                           movimiento_caja_info.IdEmpresa = item.IdEmpresa;
                           movimiento_caja_info.IdCtaCble = comprobante_contable.ToString();
                           int IdTipocbte = movimiento_caja_info.IdTipocbte = Convert.ToInt32(info_parametro_caja.IdTipoCbteCble_MoviCaja_Egr);
                           movimiento_caja_info.IdSucursal = item.IdSucursal;
                           movimiento_caja_info.CodMoviCaja = "EGRESO_X_VALE_CAJA";

                           movimiento_caja_info.IdEntidad = item.IdEntidad;
                           movimiento_caja_info.IdPersona = item.IdPersona;
                           movimiento_caja_info.IdBeneficiario = item.IdBeneficiario;
                           movimiento_caja_info.IdTipo_Persona = item.IdTipo_Persona;

                           movimiento_caja_info.cm_Signo = "-";
                           movimiento_caja_info.cm_beneficiario = item.cm_beneficiario;
                           movimiento_caja_info.cm_valor = item.cm_valor;
                           movimiento_caja_info.IdTipoMovi = item.IdTipoMovi;
                           movimiento_caja_info.cm_observacion = "Conci. caj # " + IdConciliacion_Caja_GB.ToString() +" "+ item.cm_observacion;
                           movimiento_caja_info.IdCaja = Info_Conciliacion.IdCaja;
                           movimiento_caja_info.IdPeriodo = (item.Fecha.Year * 100) + item.Fecha.Month;
                           movimiento_caja_info.cm_fecha = item.Fecha;
                           movimiento_caja_info.Fecha_Transac = DateTime.Now;
                           movimiento_caja_info.IdUsuario = item.IdUsuario;
                           movimiento_caja_info.Estado = "A";                           
                           movimiento_caja_info.IdPunto_cargo = item.IdPunto_cargo;
                           movimiento_caja_info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                           movimiento_caja_info.IdTipoFlujo = Info_Conciliacion.IdTipoFlujo;
                           // le agrego el objeto del comprobante contable 
                           ct_Cbtecble_Info comprobante_contable_info = new ct_Cbtecble_Info();
                           // traer los datos de las ceuntas de tipop movimiento
                           info_mov = bus_mov_caja.Get_Info_Movimiento_Tipo(item.IdTipoMovi, item.IdEmpresa, ref MensajeError);
                           item.IdCtaCble_Tipo_Mov = info_mov.IdCtaCble;
                           comprobante_contable_info = Get_CbteCble_Info_X_Conciliacion_det_ValeCaja(item, Info_Conciliacion, ref IdTipocbte);
                           movimiento_caja_info.Info_CbteCble_x_Caja_Movi = comprobante_contable_info;
                           // llenar el objeto de movimiento detalle
                           caj_Caja_Movimiento_det_Info info_movimiento_Detalle = new Info.Caja.caj_Caja_Movimiento_det_Info();
                           info_movimiento_Detalle.IdEmpresa = item.IdEmpresa;
                           info_movimiento_Detalle.IdCbteCble = 0;
                           info_movimiento_Detalle.IdTipocbte = IdTipocbte;
                           info_movimiento_Detalle.Secuencia = item.Secuencia;
                           info_movimiento_Detalle.cr_fecha = item.Fecha;
                           info_movimiento_Detalle.cr_Valor = item.cm_valor;
                           movimiento_caja_info.list_Caja_Movi_det.Add(info_movimiento_Detalle);
                           res = Bus_Caja.GrabarDB(ref movimiento_caja_info, ref MensajeError);
                           if (res)
                           {
                               // guardar los id por movimiento de vale de caja
                               cp_conciliacion_Caja_det_x_ValeCaja_Info info_vale_caja = new cp_conciliacion_Caja_det_x_ValeCaja_Info();
                               info_vale_caja.IdEmpresa = item.IdEmpresa;
                               info_vale_caja.IdConciliacion_Caja = Info_Conciliacion.IdConciliacion_Caja;
                               info_vale_caja.Secuencia = item.Secuencia;
                               info_vale_caja.IdEmpresa_movcaja = movimiento_caja_info.IdEmpresa;
                               info_vale_caja.IdCbteCble_movcaja = Convert.ToInt32(movimiento_caja_info.IdCbteCble);
                               info_vale_caja.IdCtaCble = movimiento_caja_info.Info_CbteCble_x_Caja_Movi._cbteCble_det_lista_info.FirstOrDefault().IdCtaCble;
                               info_vale_caja.IdTipocbte_movcaja = IdTipocbte;
                               info_vale_caja.IdCtaCble = item.IdCtaCble_Tipo_Mov;
                               info_vale_caja.IdPunto_cargo = item.IdPunto_cargo;
                               info_vale_caja.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                               res = bus_detalle_x_movimiento_caja.GrabarDB(info_vale_caja, ref MensajeError);
                           }
                       }
                   }
               }
               #endregion

               #region================================GRABO INGRESOS POR CONCILIACION ==============
               if (Info_Conciliacion.IdEstadoCierre == "EST_CIE_CER")
               {
                   if (Info_Conciliacion.Detalle_x_Ingresos.Count != 0)
                   {
                       foreach (var item in Info_Conciliacion.Detalle_x_Ingresos)
                       {
                           item.IdEmpresa = Info_Conciliacion.IdEmpresa;
                           item.IdConciliacion_Caja = Info_Conciliacion.IdConciliacion_Caja;
                       }
                       bus_conci_ingresos.GuardarDB(Info_Conciliacion.Detalle_x_Ingresos);
                   }
               }
               #endregion

               #region================================GRABO ORDEN DE PAGO===========================
               if (Info_Conciliacion.IdEstadoCierre == "EST_CIE_CER")
               {
                   if (Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja != null)
                   {
                       if (Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdEmpresa != 0)
                       {
                           if (Info_Conciliacion.IdOrdenPago_op==null)
                           {
                               if (Bus_CbteCble_B.GrabarDB(Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP, ref idCbteCble, ref MensajeError))//Grabo diario
                               {
                                   foreach (var item in Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Detalle)
                                   {
                                       //Inserto los ID del diario a pagar con la OP
                                       item.IdEmpresa_cxp = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP.IdEmpresa;
                                       item.IdTipoCbte_cxp = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP.IdTipoCbte;
                                       item.IdCbteCble_cxp = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP.IdCbteCble;
                                   }
                                   if (Bus_OrdenPago.GuardaDB(Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja, ref idOrdenPAgo, ref MensajeError))//Grabo orden de pago
                                   {
                                       //Inserto los ID de la orden de pago en la cabecera de la conciliacion
                                       Info_Conciliacion.IdEmpresa_op = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdEmpresa;
                                       Info_Conciliacion.IdOrdenPago_op = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdOrdenPago;
                                       ModificarDB(Info_Conciliacion, ref MensajeError);
                                   }
                               }
                           }
                       }
                   }
               }
               #endregion

               return res;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       private Boolean Grabar_cbte_cble_x_FP(cp_orden_giro_Info Info_Orden_Giro, cp_conciliacion_caja_Info info_Conci_caja, ref string msgError)
       {
           try
           {
               decimal IdColciliacion_Caja = info_Conci_caja.IdConciliacion_Caja;
               decimal idCbteCble = 0;
               bool res = false;


                   if (Bus_OrdenGiro_B.GrabarDB(Info_Orden_Giro,ref idCbteCble, ref msgError))
                   {
                       // grabar cp_conciliacion_Caja_det
                       cp_conciliacion_Caja_det_Info info_detalle = new cp_conciliacion_Caja_det_Info();
                       cp_conciliacion_Caja_det_Data data = new cp_conciliacion_Caja_det_Data();
                       info_detalle.IdEmpresa = Info_Orden_Giro.Info_CbteCble_x_OG.IdEmpresa;
                       info_detalle.IdConciliacion_Caja = IdColciliacion_Caja;
                       info_detalle.Secuencia = 1;
                       info_detalle.IdEmpresa_OGiro = Info_Orden_Giro.IdEmpresa;
                       info_detalle.IdCbteCble_Ogiro = idCbteCble;
                       info_detalle.IdTipoCbte_Ogiro = Info_Orden_Giro.IdTipoCbte_Ogiro;
                       info_detalle.IdTipoMovi =Convert.ToInt32( Info_Orden_Giro.IdOrden_giro_Tipo);
                       info_detalle.IdCentroCosto = Info_Orden_Giro.IdCentroCosto;
                       info_detalle.IdUsuario = Info_Orden_Giro.Info_CbteCble_x_OG.IdUsuario;
                       res=  data.GrabarDB(info_detalle, ref msgError);
                   }
                   else
                   {
                       msgError = "Error al Grabar Factura Proveedor : " + msgError;
                       res = false;
                       return false;
                   }
              

               return res;
           }
           catch (Exception ex)
           {
               
               throw;
           }

       }

       private ct_Cbtecble_Info Get_CbteCble_Info_X_Conciliacion_det_FP(cp_conciliacion_Caja_det_Info concili_det_FP_Info)
       {

           try
           {
               ct_Cbtecble_Info Info = new ct_Cbtecble_Info();

               Info.IdEmpresa = concili_det_FP_Info.IdEmpresa;
               Info.IdCbteCble = 0;
               Info.IdTipoCbte = concili_det_FP_Info.Info_Orden_Giro.IdTipoCbte_Ogiro;
               Info.cb_Fecha = concili_det_FP_Info.Info_Orden_Giro.co_fechaOg;
               Info.Anio = Info.cb_Fecha.Year;
               Info.cb_Observacion = concili_det_FP_Info.Info_Orden_Giro.co_observacion;
               
               Info.cb_Valor = concili_det_FP_Info.Info_Orden_Giro.co_total;
               Info.Estado = "A";
               Info.IdPeriodo = (Info.cb_Fecha.Year * 100) + Info.cb_Fecha.Month;
               Info.IdSucursal = 1;
               Info.IdUsuario = concili_det_FP_Info.IdUsuario;
               Info.Mayorizado = "N";
               Info.Mes = Info.cb_Fecha.Month;

               //gastos al debe
               //iva al debe
               // cxp proveedor al haber 

               //gastos debito
               ct_Cbtecble_det_Info Info_det_x_Gastos = new ct_Cbtecble_det_Info();
               Info_det_x_Gastos.IdEmpresa = Info.IdEmpresa;
               Info_det_x_Gastos.IdTipoCbte = Info.IdTipoCbte;
               Info_det_x_Gastos.IdCbteCble = 0;
               Info_det_x_Gastos.dc_EstaConciliado = "N";
               Info_det_x_Gastos.dc_Numconciliacion = 0;
               Info_det_x_Gastos.dc_Observacion = "Gastos x cxp " + Info.cb_Observacion;
               Info_det_x_Gastos.dc_Valor = concili_det_FP_Info.Info_Orden_Giro.co_baseImponible;
               Info_det_x_Gastos.IdCtaCble = concili_det_FP_Info.Info_Orden_Giro.IdCtaCble_Gasto;
               Info_det_x_Gastos.IdCentroCosto = concili_det_FP_Info.IdCentroCosto;
               Info_det_x_Gastos.IdCentroCosto_sub_centro_costo = concili_det_FP_Info.IdCentroCosto_sub_centro_costo;
               Info_det_x_Gastos.IdPunto_cargo = concili_det_FP_Info.IdPunto_cargo;
               Info_det_x_Gastos.secuencia = 1;


               //Iva debito
               ct_Cbtecble_det_Info Info_det_x_Iva = new ct_Cbtecble_det_Info();
               Info_det_x_Iva.IdEmpresa = Info.IdEmpresa;
               Info_det_x_Iva.IdTipoCbte = Info.IdTipoCbte;
               Info_det_x_Iva.IdCbteCble = 0;
               Info_det_x_Iva.dc_EstaConciliado = "N";
               Info_det_x_Iva.dc_Numconciliacion = 0;
               Info_det_x_Iva.dc_Observacion = "Iva cxp " + Info.cb_Observacion;
               Info_det_x_Iva.dc_Valor = concili_det_FP_Info.Info_Orden_Giro.co_valoriva;
               Info_det_x_Iva.IdCtaCble = concili_det_FP_Info.Info_Orden_Giro.IdCtaCble_IVA;
               Info_det_x_Iva.IdCentroCosto = concili_det_FP_Info.IdCentroCosto;
               Info_det_x_Iva.IdCentroCosto_sub_centro_costo = concili_det_FP_Info.IdCentroCosto_sub_centro_costo;
               Info_det_x_Iva.IdPunto_cargo = concili_det_FP_Info.IdPunto_cargo;
               Info_det_x_Iva.secuencia = 2;


               //CXP Credito
               ct_Cbtecble_det_Info Info_det_x_cxp_provee= new ct_Cbtecble_det_Info();
               Info_det_x_cxp_provee.IdEmpresa = Info.IdEmpresa;
               Info_det_x_cxp_provee.IdTipoCbte = Info.IdTipoCbte;
               Info_det_x_cxp_provee.IdCbteCble = 0;
               Info_det_x_cxp_provee.dc_EstaConciliado = "N";
               Info_det_x_cxp_provee.dc_Numconciliacion = 0;
               Info_det_x_cxp_provee.dc_Observacion = "Iva cxp " + Info.cb_Observacion;
               Info_det_x_cxp_provee.dc_Valor = concili_det_FP_Info.Info_Orden_Giro.co_total*-1;
               Info_det_x_cxp_provee.IdCtaCble = concili_det_FP_Info.Info_Orden_Giro.IdCtaCble_CXP;
               Info_det_x_cxp_provee.IdCentroCosto = concili_det_FP_Info.IdCentroCosto;
               Info_det_x_cxp_provee.IdCentroCosto_sub_centro_costo = concili_det_FP_Info.IdCentroCosto_sub_centro_costo;
               Info_det_x_cxp_provee.IdPunto_cargo = concili_det_FP_Info.IdPunto_cargo;
               Info_det_x_cxp_provee.secuencia = 3;

               Info._cbteCble_det_lista_info.Add(Info_det_x_cxp_provee);
               Info._cbteCble_det_lista_info.Add(Info_det_x_Iva);
               Info._cbteCble_det_lista_info.Add(Info_det_x_Gastos);
               
               
               return Info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
               
           }
       }
       
       private ct_Cbtecble_Info Get_CbteCble_Info_X_Conciliacion_det_ValeCaja(cp_conciliacion_Caja_det_Info concili_det_Vale_Caja_Info,cp_conciliacion_caja_Info info_conci , ref int IdTipoCbte)
       {

           try
           {
               ct_Cbtecble_Info Info = new ct_Cbtecble_Info();

               Info.IdEmpresa = concili_det_Vale_Caja_Info.IdEmpresa;
               Info.IdCbteCble = 0;
               Info.IdTipoCbte = IdTipoCbte;
               Info.cb_Fecha = concili_det_Vale_Caja_Info.Fecha;
               Info.Anio = Info.cb_Fecha.Year;
               Info.cb_Observacion = concili_det_Vale_Caja_Info.cm_observacion;
               
               Info.cb_Valor = concili_det_Vale_Caja_Info.cm_valor;
               Info.Estado = "A";
               Info.IdPeriodo = (Info.cb_Fecha.Year * 100) + Info.cb_Fecha.Month;
               Info.IdSucursal = 1;
               Info.IdUsuario = concili_det_Vale_Caja_Info.IdUsuario;
               Info.Mayorizado = "N";
               Info.Mes = Info.cb_Fecha.Month;

               

               //gastos debito
               ct_Cbtecble_det_Info Info_det_x_Gastos = new ct_Cbtecble_det_Info();
               Info_det_x_Gastos.IdEmpresa = Info.IdEmpresa;
               Info_det_x_Gastos.IdTipoCbte = IdTipoCbte;
               Info_det_x_Gastos.IdCbteCble = 0;
               Info_det_x_Gastos.dc_EstaConciliado = "N";
               Info_det_x_Gastos.dc_Numconciliacion = 0;
               Info_det_x_Gastos.dc_Observacion = Info.cb_Observacion;
               Info_det_x_Gastos.dc_Valor = concili_det_Vale_Caja_Info.cm_valor;
               Info_det_x_Gastos.IdCtaCble =concili_det_Vale_Caja_Info.IdCtaCble_Tipo_Mov;//*************************************************************************************;
               Info_det_x_Gastos.IdCentroCosto = concili_det_Vale_Caja_Info.IdCentroCosto;
               Info_det_x_Gastos.IdCentroCosto_sub_centro_costo = concili_det_Vale_Caja_Info.IdCentroCosto_sub_centro_costo;
               Info_det_x_Gastos.IdPunto_cargo_grupo = concili_det_Vale_Caja_Info.IdPunto_cargo_grupo;
               Info_det_x_Gastos.IdPunto_cargo = concili_det_Vale_Caja_Info.IdPunto_cargo;
               Info_det_x_Gastos.secuencia = 1;

               //CXP Credito
               ct_Cbtecble_det_Info Info_det_x_cxp_provee = new ct_Cbtecble_det_Info();
               Info_det_x_cxp_provee.IdEmpresa = Info.IdEmpresa;
               Info_det_x_cxp_provee.IdTipoCbte = IdTipoCbte;
               Info_det_x_cxp_provee.IdCbteCble = 0;
               Info_det_x_cxp_provee.dc_EstaConciliado = "N";
               Info_det_x_cxp_provee.dc_Numconciliacion = 0;
               Info_det_x_cxp_provee.dc_Observacion = Info.cb_Observacion;
               Info_det_x_cxp_provee.dc_Valor = concili_det_Vale_Caja_Info.cm_valor * -1;
               Info_det_x_cxp_provee.IdCtaCble = concili_det_Vale_Caja_Info.IdCtaCble_caja;//*****************************************************************************
               //Info_det_x_cxp_provee.IdCentroCosto = concili_det_Vale_Caja_Info.IdCentroCosto;
               //Info_det_x_cxp_provee.IdCentroCosto_sub_centro_costo = concili_det_Vale_Caja_Info.IdCentroCosto_sub_centro_costo;
               //Info_det_x_cxp_provee.IdPunto_cargo_grupo = info_conci.IdPunto_cargo_grupo;
               //Info_det_x_cxp_provee.IdPunto_cargo = info_conci.IdPunto_cargo;
               Info_det_x_cxp_provee.secuencia = 2;

               Info._cbteCble_det_lista_info.Add(Info_det_x_cxp_provee);
               Info._cbteCble_det_lista_info.Add(Info_det_x_Gastos);




               return Info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };

           }
       }

       public string Eliminar_facturas_o_vales(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, string TipoCbte, bool Eliminar_desvincular )
       {
           try
           {
               return data_Conciliacion_caja.Eliminar_facturas_o_vales(IdEmpresa, IdTipoCbte, IdCbteCble, TipoCbte, Eliminar_desvincular);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };

           }
       }

       public Boolean ModificarDB(cp_conciliacion_caja_Info Info, ref string msg)
       {
           try
           {
               return data_Conciliacion_caja.ModificarDB(Info, ref  msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }          
       }

       public Boolean ModificarDB_valores(cp_conciliacion_caja_Info Info, ref string msg)
       {
           try
           {
               return data_Conciliacion_caja.ModificarDB_valores(Info, ref  msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB_valores", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       public Boolean ModificarDB_campos_mov_caj(cp_conciliacion_caja_Info Info, ref string msg)
       {
           try
           {
               return data_Conciliacion_caja.ModificarDB_campos_mov_caj(Info, ref  msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB_valores", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       private bool Get_Orden_Pago_x_ND(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref string mensaje, cp_conciliacion_caja_Info info_conci, decimal Valor_a_pagar)
       {
           try
           {
               #region Variables
               decimal NumConciliacion_Caja = info_conci.IdConciliacion_Caja;
               string IdUsuario;
               DateTime Fecha;
               decimal idOrdenPAgo;
               Boolean res = true;
               decimal Id = 0;
               int IdEmpresa_int = param.IdEmpresa;
               string mensaj = "";
               cp_parametros_Info info_param = new cp_parametros_Info();
               cp_parametros_Bus bus_param = new cp_parametros_Bus();
               cp_nota_DebCre_Info info_ND = new cp_nota_DebCre_Info();               
               cp_orden_pago_Info Info_OrdenPago = new cp_orden_pago_Info();
               ct_Cbtecble_Info info_Cbtecble = new ct_Cbtecble_Info();
               ct_Cbtecble_det_Bus bus_Cbtecble_det = new Contabilidad.ct_Cbtecble_det_Bus();
               cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();
               cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
               ct_Periodo_Info info_periodo = new ct_Periodo_Info();
               ct_Periodo_Bus bus_periodo = new Contabilidad.ct_Periodo_Bus();
               cp_nota_DebCre_Bus bus_nota_cred = new cp_nota_DebCre_Bus();
               cp_nota_DebCre_Info notaCr_I = new cp_nota_DebCre_Info();
               List<cp_orden_pago_formapago_Info> ListForPagoOP = new List<cp_orden_pago_formapago_Info>();
               cp_orden_pago_formapago_Info ItePagoOP = new cp_orden_pago_formapago_Info();
               List<cp_orden_pago_tipo_x_empresa_Info> ListEstadoOP = new List<cp_orden_pago_tipo_x_empresa_Info>();
               cp_orden_pago_tipo_x_empresa_Info IteEstadoOP = new cp_orden_pago_tipo_x_empresa_Info();
               #endregion

               info_param = bus_param.Get_Info_parametros(param.IdEmpresa);
               info_ND = bus_nota_cred.Get_Info_nota_DebCre(IdEmpresa, IdCbteCble, IdTipoCbte);
               info_Cbtecble._cbteCble_det_lista_info = bus_Cbtecble_det.Get_list_Cbtecble_det(info_ND.IdEmpresa, info_ND.IdTipoCbte_Nota, info_ND.IdCbteCble_Nota, ref MensajeError);
               info_proveedor = bus_proveedor.Get_Info_Proveedor(info_ND.IdEmpresa, info_ND.IdProveedor);
               info_periodo = bus_periodo.Get_Info_Periodo(param.IdEmpresa, DateTime.Now, ref MensajeError);               
               ListForPagoOP = Bus_FormaPago.Get_List_orden_pago_formapago();
               ItePagoOP = ListForPagoOP.First();
               ListEstadoOP = Bus_EstadoOP.Get_List_orden_pago_tipo_x_empresa(info_ND.IdEmpresa);
               IteEstadoOP = ListEstadoOP.First(item => item.IdTipo_op == "FACT_PROVEE" && item.IdEmpresa == info_ND.IdEmpresa);

               #region GENERO ORDEN DE PAGO
               Info_OrdenPago.IdEmpresa = info_ND.IdEmpresa;
               Info_OrdenPago.Observacion = "OP x Cance. " + "/ ND # " + info_ND.IdCbteCble_Nota
                   + " x conci. caja #" + NumConciliacion_Caja;
               Info_OrdenPago.IdTipo_op = "FACT_PROVEE";
               Info_OrdenPago.IdTipo_Persona = "PROVEE";

               Info_OrdenPago.IdPersona = info_proveedor.IdPersona;
               Info_OrdenPago.IdEntidad = info_ND.IdProveedor;
               Info_OrdenPago.IdProveedor = info_ND.IdProveedor;
               Info_OrdenPago.Fecha = DateTime.Now;

               Info_OrdenPago.IdEstadoAprobacion = IteEstadoOP.IdEstadoAprobacion;
               Info_OrdenPago.IdFormaPago = ItePagoOP.IdFormaPago;
               Info_OrdenPago.Fecha_Pago = DateTime.Now;
               Info_OrdenPago.IdBanco = null;
               Info_OrdenPago.Estado = "A";
               Info_OrdenPago.IdUsuario = info_ND.IdUsuario;
               Info_OrdenPago.nom_pc = info_ND.nom_pc;
               Info_OrdenPago.ip = info_ND.ip;
               Info_OrdenPago.Detalle = new List<cp_orden_pago_det_Info>();

               //Detalle de Orden de Pago
               Info_DetOrdenPago.IdEmpresa = info_ND.IdEmpresa;
               Info_DetOrdenPago.IdOrdenPago = Id;
               Info_DetOrdenPago.IdEmpresa_cxp = info_ND.IdEmpresa;
               Info_DetOrdenPago.IdCbteCble_cxp = info_ND.IdCbteCble_Nota;
               Info_DetOrdenPago.IdTipoCbte_cxp = info_ND.IdTipoCbte_Nota;
               Info_DetOrdenPago.Valor_a_pagar = (double)Valor_a_pagar;
               Info_DetOrdenPago.Referencia = null;
               Info_DetOrdenPago.IdFormaPago = ItePagoOP.IdFormaPago;
               Info_DetOrdenPago.IdEstadoAprobacion = IteEstadoOP.IdEstadoAprobacion;
               Info_DetOrdenPago.Fecha_Pago = DateTime.Now;
               Info_DetOrdenPago.Idbanco = null;
               Info_DetOrdenPago.IdUsuario_Aproba = param.IdUsuario;
               Info_DetOrdenPago.fecha_hora_Aproba = info_ND.cn_fecha;
               Info_DetOrdenPago.Motivo_aproba = Info_OrdenPago.Observacion;

               Info_OrdenPago.Detalle.Add(Info_DetOrdenPago);
               #endregion

               if (Bus_OrdenPago.GuardaDB(Info_OrdenPago, ref Id, ref mensaj))
               {
                   Info_DetOrdenPago.IdOrdenPago = Id;
                   idOrdenPAgo = Info_DetOrdenPago.IdOrdenPago;

                   if (!bus_conciliacion_det.ModificarOP(info_conci.IdEmpresa, info_conci.IdConciliacion_Caja, IdEmpresa, IdCbteCble, IdTipoCbte, Info_DetOrdenPago.IdEmpresa, Info_DetOrdenPago.IdOrdenPago))
                       return false;

                   #region GENERO NOTA DE CREDITO PARA CANCELAR FP
                   notaCr_I.IdEmpresa = param.IdEmpresa;
                   notaCr_I.cn_baseImponible = 0;
                   notaCr_I.cn_BaseSeguro = 0;
                   notaCr_I.cn_fecha = DateTime.Now.Date;
                   notaCr_I.cn_Fecha_vcto = DateTime.Now.Date;
                   notaCr_I.Fecha_contable = DateTime.Now.Date;
                   notaCr_I.fecha_autorizacion = DateTime.Now;
                   notaCr_I.cn_Ice_base = 0;
                   notaCr_I.cn_Ice_por = 0;
                   notaCr_I.cn_Ice_valor = 0;
                   notaCr_I.cn_observacion = "Cruce con OP #" + Info_OrdenPago.IdOrdenPago +
                       " x Conciliación # " + NumConciliacion_Caja + " x Cbte #" + info_ND.IdCbteCble_Nota + " descripción: " + info_ND.cn_observacion;
                   //Inicio Valores
                   notaCr_I.cn_Por_iva = info_ND.cn_Por_iva;
                   notaCr_I.cn_valoriva = 0;
                   notaCr_I.cn_subtotal_iva = 0;
                   notaCr_I.cn_subtotal_siniva = (double)Valor_a_pagar;
                   notaCr_I.cn_total = Valor_a_pagar;
                   //Fin Valores
                   notaCr_I.cn_vaCoa = "N";
                   notaCr_I.Estado = "A";
                   notaCr_I.Fecha_Transac = param.Fecha_Transac;
                   notaCr_I.Fecha_UltMod = param.Fecha_Transac;
                   notaCr_I.IdProveedor = Info_OrdenPago.IdProveedor;
                   notaCr_I.IdUsuario = param.IdUsuario;
                   notaCr_I.IdUsuarioUltAnu = param.IdUsuario;
                   notaCr_I.IdUsuarioUltMod = param.IdUsuario;
                   notaCr_I.ip = param.ip;
                   notaCr_I.MotivoAnu = "";
                   notaCr_I.nom_pc = param.nom_pc;
                   notaCr_I.cn_tipoLocacion = "";
                   notaCr_I.cn_Nota = "";
                   notaCr_I.DebCre = "C";
                   notaCr_I.IdSucursal = info_ND.IdSucursal;
                   notaCr_I.PagoLocExt = "LOC";
                   notaCr_I.PaisPago = "";
                   notaCr_I.ConvenioTributacion = "NA";
                   notaCr_I.PagoSujetoRetencion = "NA";
                   notaCr_I.IdTipoNota = "T_TIP_NOTA_INT";
                   notaCr_I.IdTipoFlujo = 1;
                   #endregion

                   #region GENERO DIARIO DE NOTA DE CREDITO
                   ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
                   //cabecera de diario
                   CbteCble_I.IdEmpresa = param.IdEmpresa;
                   CbteCble_I.IdTipoCbte = (int)info_param.pa_TipoCbte_NC;
                   CbteCble_I.IdCbteCble = 0;
                   CbteCble_I.CodCbteCble = "";
                   CbteCble_I.IdPeriodo = info_periodo.IdPeriodo;
                   CbteCble_I.cb_Fecha = DateTime.Now;
                   CbteCble_I.cb_Valor = (double)Valor_a_pagar;
                   CbteCble_I.cb_Observacion = notaCr_I.cn_observacion;
                   CbteCble_I.Secuencia = 1;
                   CbteCble_I.Estado = "A";
                   CbteCble_I.Anio = DateTime.Now.Year;
                   CbteCble_I.Mes = DateTime.Now.Month;
                   CbteCble_I.IdUsuario = param.IdUsuario;
                   CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                   CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                   CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                   CbteCble_I.Mayorizado = "N";
                   CbteCble_I.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                   //detalle del debe
                   CbteCble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                   ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                   debe.IdEmpresa = param.IdEmpresa;
                   debe.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                   debe.IdTipoCbte = CbteCble_I.IdTipoCbte;
                   debe.dc_Observacion = CbteCble_I.cb_Observacion;
                   debe.dc_Valor = (double)Valor_a_pagar * -1;
                   debe.IdCtaCble = info_conci.IdCtaCble;
                   debe.IdPunto_cargo = info_conci.IdPunto_cargo;
                   debe.IdPunto_cargo_grupo = info_conci.IdPunto_cargo_grupo;
                   CbteCble_I._cbteCble_det_lista_info.Add(debe);
                   //detalle del haber                   
                    ct_Cbtecble_det_Info cbte = new ct_Cbtecble_det_Info();
                    cbte.IdEmpresa = param.IdEmpresa;
                    cbte.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                    cbte.IdTipoCbte = CbteCble_I.IdTipoCbte;
                    cbte.dc_Observacion = CbteCble_I.cb_Observacion;
                    cbte.dc_Valor = (double)Valor_a_pagar;
                    cbte.IdCtaCble = cbte.IdCtaCble = info_Cbtecble._cbteCble_det_lista_info.FirstOrDefault(q => q.dc_Valor < 0).IdCtaCble;
                    CbteCble_I._cbteCble_det_lista_info.Add(cbte);
                     
                   notaCr_I.Info_CbteCble_X_Nota = CbteCble_I;
                   #endregion

                   if (bus_nota_cred.GrabarDB(notaCr_I, ref MensajeError))
                   {
                       #region GENERO ORDEN DE CANCELACION POR LA NOTA DE CREDITO
                       cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                       // Orden de cancelación
                       info_ordenCan.IdEmpresa = Info_OrdenPago.IdEmpresa;
                       info_ordenCan.IdEmpresa_op = Info_OrdenPago.IdEmpresa;
                       info_ordenCan.IdOrdenPago_op = Id;
                       info_ordenCan.Secuencia_op = Info_OrdenPago.Detalle.FirstOrDefault().Secuencia;
                       info_ordenCan.IdEmpresa_op_padre = null;
                       info_ordenCan.IdOrdenPago_op_padre = null;
                       info_ordenCan.Secuencia_op_padre = null;
                       info_ordenCan.IdEmpresa_cxp = info_ND.IdEmpresa;
                       info_ordenCan.IdTipoCbte_cxp = info_ND.IdTipoCbte_Nota;
                       info_ordenCan.IdCbteCble_cxp = info_ND.IdCbteCble_Nota;
                       info_ordenCan.IdEmpresa_pago = notaCr_I.IdEmpresa;
                       info_ordenCan.IdTipoCbte_pago = notaCr_I.IdTipoCbte_Nota;
                       info_ordenCan.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;

                       info_ordenCan.MontoAplicado = (double)Valor_a_pagar;
                       info_ordenCan.SaldoAnterior = (double)Valor_a_pagar;
                       info_ordenCan.SaldoActual = 0;
                       info_ordenCan.Observacion = "Cance. OP # " + Info_OrdenPago.IdOrdenPago + " según Conci. caja # " + NumConciliacion_Caja + " con NC # " + notaCr_I.IdCbteCble_Nota;
                       bus_OrdenCan.GuardarDB(info_ordenCan, IdEmpresa_int, ref MensajeError);
                       #endregion
                   }
               }
               else
               {
                   mensaj = "Error al Generar Orden de Pago: " + MensajeError;
                   return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarOrdenPago", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       private bool Get_Orden_Pago_x_FP(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref string mensaje, cp_conciliacion_caja_Info info_conci, decimal Valor_a_pagar)
       {
           try
           {
                #region Variables
               decimal NumConciliacion_Caja = info_conci.IdConciliacion_Caja;
;
                string IdUsuario;
                DateTime Fecha;
                decimal idOrdenPAgo;
                Boolean res = true;
                decimal Id = 0;
                int IdEmpresa_int = param.IdEmpresa;
                string mensaj = "";
                cp_parametros_Info info_param = new cp_parametros_Info();
                cp_parametros_Bus bus_param = new cp_parametros_Bus();
                cp_orden_giro_Info Info_Orden_Giro = new cp_orden_giro_Info();
                cp_orden_pago_Info Info_OrdenPago = new cp_orden_pago_Info();
                ct_Cbtecble_Info info_Cbtecble = new ct_Cbtecble_Info();
                ct_Cbtecble_det_Bus bus_Cbtecble_det = new Contabilidad.ct_Cbtecble_det_Bus();
                cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
                ct_Periodo_Info info_periodo = new ct_Periodo_Info();
                ct_Periodo_Bus bus_periodo = new Contabilidad.ct_Periodo_Bus();
                cp_nota_DebCre_Bus bus_nota_cred = new cp_nota_DebCre_Bus();
                cp_nota_DebCre_Info notaCr_I = new cp_nota_DebCre_Info();
                List<cp_orden_pago_formapago_Info> ListForPagoOP = new List<cp_orden_pago_formapago_Info>();
                cp_orden_pago_formapago_Info ItePagoOP = new cp_orden_pago_formapago_Info();
                List<cp_orden_pago_tipo_x_empresa_Info> ListEstadoOP = new List<cp_orden_pago_tipo_x_empresa_Info>();
                cp_orden_pago_tipo_x_empresa_Info IteEstadoOP = new cp_orden_pago_tipo_x_empresa_Info();
                #endregion
            
               info_param = bus_param.Get_Info_parametros(param.IdEmpresa);               
               Info_Orden_Giro = Bus_OrdenGiro_B.Get_Info_orden_giro(IdEmpresa, IdTipoCbte, IdCbteCble);
               info_Cbtecble._cbteCble_det_lista_info = bus_Cbtecble_det.Get_list_Cbtecble_det(Info_Orden_Giro.IdEmpresa, Info_Orden_Giro.IdTipoCbte_Ogiro, Info_Orden_Giro.IdCbteCble_Ogiro, ref MensajeError);
               info_proveedor = bus_proveedor.Get_Info_Proveedor(Info_Orden_Giro.IdEmpresa, Info_Orden_Giro.IdProveedor);
               info_periodo = bus_periodo.Get_Info_Periodo(param.IdEmpresa, DateTime.Now, ref MensajeError);               
               ListForPagoOP = Bus_FormaPago.Get_List_orden_pago_formapago();
               ItePagoOP = ListForPagoOP.First();
               ListEstadoOP = Bus_EstadoOP.Get_List_orden_pago_tipo_x_empresa(Info_Orden_Giro.IdEmpresa);
               IteEstadoOP = ListEstadoOP.First(item => item.IdTipo_op == "FACT_PROVEE" && item.IdEmpresa == Info_Orden_Giro.IdEmpresa);

               #region GENERO ORDEN DE PAGO
               Info_OrdenPago.IdEmpresa = Info_Orden_Giro.IdEmpresa;
               Info_OrdenPago.Observacion = "OP x Cance. " + "/ FP # " + Info_Orden_Giro.IdCbteCble_Ogiro
                   + " x conci. caja #" + NumConciliacion_Caja;
               Info_OrdenPago.IdTipo_op = "FACT_PROVEE";
               Info_OrdenPago.IdTipo_Persona = "PROVEE";

               Info_OrdenPago.IdPersona = info_proveedor.IdPersona;
               Info_OrdenPago.IdEntidad = Info_Orden_Giro.IdProveedor;
               Info_OrdenPago.IdProveedor = Info_Orden_Giro.IdProveedor;
               Info_OrdenPago.Fecha = DateTime.Now;

               Info_OrdenPago.IdEstadoAprobacion = IteEstadoOP.IdEstadoAprobacion;
               Info_OrdenPago.IdFormaPago = ItePagoOP.IdFormaPago;
               Info_OrdenPago.Fecha_Pago = DateTime.Now;
               Info_OrdenPago.IdBanco = null;
               Info_OrdenPago.Estado = "A";
               Info_OrdenPago.IdUsuario = Info_Orden_Giro.IdUsuario;
               Info_OrdenPago.nom_pc = Info_Orden_Giro.nom_pc;
               Info_OrdenPago.ip = Info_Orden_Giro.ip;
               Info_OrdenPago.Detalle = new List<cp_orden_pago_det_Info>();

               //Detalle de Orden de Pago
               Info_DetOrdenPago.IdEmpresa = Info_Orden_Giro.IdEmpresa;
               Info_DetOrdenPago.IdOrdenPago = Id;
               Info_DetOrdenPago.IdEmpresa_cxp = Info_Orden_Giro.IdEmpresa;
               Info_DetOrdenPago.IdCbteCble_cxp = Info_Orden_Giro.IdCbteCble_Ogiro;
               Info_DetOrdenPago.IdTipoCbte_cxp = Info_Orden_Giro.IdTipoCbte_Ogiro;
               Info_DetOrdenPago.Valor_a_pagar = (double)Valor_a_pagar;
               Info_DetOrdenPago.Referencia = null;
               Info_DetOrdenPago.IdFormaPago = ItePagoOP.IdFormaPago;
               Info_DetOrdenPago.IdEstadoAprobacion = IteEstadoOP.IdEstadoAprobacion;
               Info_DetOrdenPago.Fecha_Pago = DateTime.Now;
               Info_DetOrdenPago.Idbanco = null;
               Info_DetOrdenPago.IdUsuario_Aproba = param.IdUsuario;
               Info_DetOrdenPago.fecha_hora_Aproba = Info_Orden_Giro.co_FechaFactura;
               Info_DetOrdenPago.Motivo_aproba = Info_OrdenPago.Observacion;

               Info_OrdenPago.Detalle.Add(Info_DetOrdenPago);
               #endregion

               if (Bus_OrdenPago.GuardaDB(Info_OrdenPago, ref Id, ref mensaj))
               {
                   Info_DetOrdenPago.IdOrdenPago = Id;
                   idOrdenPAgo = Info_DetOrdenPago.IdOrdenPago;

                   if (!bus_conciliacion_det.ModificarOP(info_conci.IdEmpresa, info_conci.IdConciliacion_Caja, IdEmpresa, IdCbteCble, IdTipoCbte, Info_DetOrdenPago.IdEmpresa, Info_DetOrdenPago.IdOrdenPago))
                       return false;

                   #region GENERO NOTA DE CREDITO PARA CANCELAR FP
                   notaCr_I.IdEmpresa = param.IdEmpresa;
                   notaCr_I.cn_baseImponible = 0;
                   notaCr_I.cn_BaseSeguro = 0;
                   notaCr_I.cn_fecha = Convert.ToDateTime(info_conci.Fecha_fin);
                   notaCr_I.cn_Fecha_vcto = Convert.ToDateTime(info_conci.Fecha_fin);
                   notaCr_I.Fecha_contable = Convert.ToDateTime(info_conci.Fecha_fin);
                   notaCr_I.fecha_autorizacion = Convert.ToDateTime(info_conci.Fecha_fin);
                   notaCr_I.cn_Ice_base = 0;
                   notaCr_I.cn_Ice_por = 0;
                   notaCr_I.cn_Ice_valor = 0;
                   notaCr_I.cn_observacion = "NC x Cruce con OP #" + Info_OrdenPago.IdOrdenPago +
                       " x Conciliación # " + NumConciliacion_Caja + " x Cbte #" + Info_Orden_Giro.IdCbteCble_Ogiro + " descripción: " + Info_Orden_Giro.co_observacion;
                   //Inicio Valores
                   notaCr_I.cn_Por_iva = Info_Orden_Giro.co_Por_iva;
                   notaCr_I.cn_valoriva = 0;
                   notaCr_I.cn_subtotal_iva = 0;
                   notaCr_I.cn_subtotal_siniva = (double)Valor_a_pagar;
                   notaCr_I.cn_total = Valor_a_pagar;
                   //Fin Valores
                   notaCr_I.cn_vaCoa = "N";
                   notaCr_I.Estado = "A";
                   notaCr_I.Fecha_Transac = param.Fecha_Transac;
                   notaCr_I.Fecha_UltMod = param.Fecha_Transac;
                   notaCr_I.IdProveedor = Info_OrdenPago.IdProveedor;
                   notaCr_I.IdUsuario = param.IdUsuario;
                   notaCr_I.IdUsuarioUltAnu = param.IdUsuario;
                   notaCr_I.IdUsuarioUltMod = param.IdUsuario;
                   notaCr_I.ip = param.ip;
                   notaCr_I.MotivoAnu = "";
                   notaCr_I.nom_pc = param.nom_pc;
                   notaCr_I.cn_tipoLocacion = "";
                   notaCr_I.cn_Nota = "";
                   notaCr_I.DebCre = "C";
                   notaCr_I.IdSucursal = Info_Orden_Giro.IdSucursal;
                   notaCr_I.PagoLocExt = "LOC";
                   notaCr_I.PaisPago = "";
                   notaCr_I.ConvenioTributacion = "NA";
                   notaCr_I.PagoSujetoRetencion = "NA";
                   notaCr_I.IdTipoNota = "T_TIP_NOTA_INT";
                   notaCr_I.IdTipoFlujo = 1;
                   #endregion

                   #region GENERO DIARIO DE NOTA DE CREDITO
                   ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
                   //cabecera de diario
                   CbteCble_I.IdEmpresa = param.IdEmpresa;
                   CbteCble_I.IdTipoCbte = (int)info_param.pa_TipoCbte_NC;
                   CbteCble_I.IdCbteCble = 0;
                   CbteCble_I.CodCbteCble = "";
                   CbteCble_I.IdPeriodo = info_periodo.IdPeriodo;
                   CbteCble_I.cb_Fecha = Convert.ToDateTime(info_conci.Fecha_fin);
                   CbteCble_I.cb_Valor = (double)Valor_a_pagar;
                   CbteCble_I.cb_Observacion = notaCr_I.cn_observacion;
                   CbteCble_I.Secuencia = 1;
                   CbteCble_I.Estado = "A";
                   CbteCble_I.Anio = DateTime.Now.Year;
                   CbteCble_I.Mes = DateTime.Now.Month;
                   CbteCble_I.IdUsuario = param.IdUsuario;
                   CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                   CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                   CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                   CbteCble_I.Mayorizado = "N";
                   CbteCble_I.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                   //detalle del debe
                   CbteCble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                   ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                   debe.IdEmpresa = param.IdEmpresa;
                   debe.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                   debe.IdTipoCbte = CbteCble_I.IdTipoCbte;
                   debe.dc_Observacion = CbteCble_I.cb_Observacion;
                   debe.dc_Valor = (double)Valor_a_pagar*-1;
                   debe.IdCtaCble = info_conci.IdCtaCble;
                   debe.IdPunto_cargo = info_conci.IdPunto_cargo;
                   debe.IdPunto_cargo_grupo = info_conci.IdPunto_cargo_grupo;
                   CbteCble_I._cbteCble_det_lista_info.Add(debe);
                   //detalle del haber

                   ct_Cbtecble_det_Info cbte = new ct_Cbtecble_det_Info();
                   cbte.IdEmpresa = param.IdEmpresa;
                   cbte.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                   cbte.IdTipoCbte = CbteCble_I.IdTipoCbte;
                   cbte.dc_Observacion = CbteCble_I.cb_Observacion;
                   cbte.dc_Valor = (double)Valor_a_pagar;
                   cbte.IdCtaCble = info_Cbtecble._cbteCble_det_lista_info.FirstOrDefault(q=>q.dc_Valor<0).IdCtaCble;
                   CbteCble_I._cbteCble_det_lista_info.Add(cbte);


                   notaCr_I.Info_CbteCble_X_Nota = CbteCble_I;
                   #endregion

                   if (bus_nota_cred.GrabarDB(notaCr_I, ref MensajeError))
                   {
                       #region GENERO ORDEN DE CANCELACION POR LA NOTA DE CREDITO
                       cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                       // Orden de cancelación
                       info_ordenCan.IdEmpresa = Info_OrdenPago.IdEmpresa;
                       info_ordenCan.IdEmpresa_op = Info_OrdenPago.IdEmpresa;
                       info_ordenCan.IdOrdenPago_op = Id;
                       info_ordenCan.Secuencia_op = Info_OrdenPago.Detalle.FirstOrDefault().Secuencia;
                       info_ordenCan.IdEmpresa_op_padre = null;
                       info_ordenCan.IdOrdenPago_op_padre = null;
                       info_ordenCan.Secuencia_op_padre = null;
                       info_ordenCan.IdEmpresa_cxp = Info_Orden_Giro.IdEmpresa;
                       info_ordenCan.IdTipoCbte_cxp = Info_Orden_Giro.IdTipoCbte_Ogiro;
                       info_ordenCan.IdCbteCble_cxp = Info_Orden_Giro.IdCbteCble_Ogiro;
                       info_ordenCan.IdEmpresa_pago = notaCr_I.IdEmpresa;
                       info_ordenCan.IdTipoCbte_pago = notaCr_I.IdTipoCbte_Nota;
                       info_ordenCan.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;

                       info_ordenCan.MontoAplicado = (double)Valor_a_pagar;
                       info_ordenCan.SaldoAnterior = (double)Valor_a_pagar;
                       info_ordenCan.SaldoActual = 0;
                       info_ordenCan.Observacion = "Cance. OP # " + Info_OrdenPago.IdOrdenPago + " según Conci. caja # " + NumConciliacion_Caja + " con NC # " + notaCr_I.IdCbteCble_Nota;
                       bus_OrdenCan.GuardarDB(info_ordenCan, IdEmpresa_int, ref MensajeError);
                       #endregion
                   }
               }
               else
               {
                   mensaj = "Error al Generar Orden de Pago: " + MensajeError;
                   return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarOrdenPago", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       private caj_Caja_Movimiento_Info Get_Caja_Movi_x_Item_conciliacion(cp_conciliacion_Caja_det_x_ValeCaja_Info Info_conciliacion_caja_det_x_Val
           , ref string mensaje, ref decimal NumConciliacion_Caja )
        {
           try
           {

                        Boolean res = true;
               
                        caj_Caja_Movimiento_Info InfoCab_Caja = new caj_Caja_Movimiento_Info();



                        InfoCab_Caja.CodMoviCaja = "EGRCAJXCONCAJA";
                        InfoCab_Caja.cm_observacion = "Egreso de Caja por conciliacion de caja # " + NumConciliacion_Caja + " Del proveedor: "
                            + Info_conciliacion_caja_det_x_Val.Info_Caja_Movi.cm_observacion + " Segun observación " 
                            + Info_conciliacion_caja_det_x_Val.Info_Caja_Movi.cm_observacion;

                        InfoCab_Caja = Info_conciliacion_caja_det_x_Val.Info_Caja_Movi;
                        InfoCab_Caja.Info_CbteCble_x_Caja_Movi = Info_conciliacion_caja_det_x_Val.Info_Caja_Movi.Info_CbteCble_x_Caja_Movi;

                        if (Bus_Caja.GrabarDB(ref InfoCab_Caja, ref  MensajeError))
                       {
                           
                       }
                       else
                       {
                           mensaje = "Error al Generar Egresos de Caja: " + MensajeError;
                           res = false;               
                       }



                       return InfoCab_Caja;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarEgresos", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       public void GenerarRpt(int IdEmpresa, decimal IdConciliacion_Caja, string IdUsuario, string nom_pc)
       {
           try 
           { 
               data_Conciliacion_caja.GenerarRpt(IdEmpresa, IdConciliacion_Caja, IdUsuario, nom_pc); 
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GenerarRpt", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       public List<cp_conciliacion_caja_Info> Get_List_Conciliacion_Caja(int IdEmpresa, DateTime FDesde, DateTime FHasta)
       {
           try
           {
               return data_Conciliacion_caja.Get_List_Conciliacion_Caja(IdEmpresa,FDesde,FHasta);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_Caja", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       public bool Crear_ingreso_x_reposicion(cp_conciliacion_caja_Info info_conci, ref string error)
       {
           try
           {
               bool res = false;
               caj_Caja_Movimiento_Info movimiento_caja_info = new Info.Caja.caj_Caja_Movimiento_Info();
               info_parametro_caja = bus_parametro_caja_bus.Get_Info_Parametro(param.IdEmpresa);
               if (info_parametro_caja.IdTipo_movi_ing_x_reposicion == null)
               {
                   error = "Los parámetros para realizar el ingreso por reposición automático no están completos, por favor revise el tipo de movimiento para reposición de caja";
                   return false;
               }
               movimiento_caja_info.IdEmpresa = param.IdEmpresa;
               movimiento_caja_info.IdCtaCble = info_conci.IdCtaCble;
               movimiento_caja_info.IdSucursal = 1;
               movimiento_caja_info.CodMoviCaja = "INGRESO_X_REPOSICION";

               cp_orden_pago_Info info_op = new cp_orden_pago_Info();
               cp_orden_pago_Bus bus_op = new cp_orden_pago_Bus();
               info_op = bus_op.Get_Info_orden_pago(info_conci.IdEmpresa, Convert.ToDecimal(info_conci.IdOrdenPago_op), ref error);
               if (info_op.IdEmpresa == 0)
               {
                   error = "La conciliación # "+info_conci.IdConciliacion_Caja.ToString()+" no tiene una OP relacionada";
                   return false;
               }
               
               movimiento_caja_info.IdEntidad = info_op.IdEntidad;
               movimiento_caja_info.IdPersona = info_op.IdPersona;
               movimiento_caja_info.IdBeneficiario = info_op.IdTipo_Persona + "-" + info_op.IdPersona.ToString() + "-" + info_op.IdEntidad.ToString();
               movimiento_caja_info.IdTipo_Persona = info_op.IdTipo_Persona;
               movimiento_caja_info.cm_beneficiario = "REPOSICION_CONCI_CAJA # "+info_conci.IdConciliacion_Caja.ToString();
               
               movimiento_caja_info.cm_Signo = "+";

               movimiento_caja_info.cm_valor = Convert.ToDouble(info_conci.Valor_pagado);
               movimiento_caja_info.IdTipoMovi = info_parametro_caja.IdTipo_movi_ing_x_reposicion;//Programar en base
               movimiento_caja_info.cm_observacion = "Conci. caj # " + info_conci.IdConciliacion_Caja.ToString() + " INGRESO_X_REPOSICION " + info_conci.Observacion;
               movimiento_caja_info.IdCaja = info_conci.IdCaja;
               movimiento_caja_info.IdPeriodo = (Convert.ToDateTime(info_conci.Fecha).Date.Year * 100) + Convert.ToDateTime(info_conci.Fecha).Date.Month;
               movimiento_caja_info.cm_fecha = Convert.ToDateTime(info_conci.Fecha).Date;
               movimiento_caja_info.Fecha_Transac = DateTime.Now;
               movimiento_caja_info.IdUsuario = param.IdUsuario;
               movimiento_caja_info.Estado = "A";
               movimiento_caja_info.IdTipoFlujo = null;

               #region Región comprobante
               ct_Cbtecble_Info Info_cbte = new ct_Cbtecble_Info();
               Info_cbte.IdEmpresa = info_conci.IdEmpresa;
               Info_cbte.IdCbteCble = 0;
               Info_cbte.IdTipoCbte = info_parametro_caja.IdTipoCbteCble_MoviCaja_Ing;
               Info_cbte.cb_Fecha = Convert.ToDateTime(info_conci.Fecha);
               Info_cbte.Anio = Info_cbte.cb_Fecha.Year;
               Info_cbte.cb_Observacion = "Cbte x reposición de caja chica x conciliación # " + info_conci.IdConciliacion_Caja.ToString() + " " + info_conci.Observacion;

               Info_cbte.cb_Valor = Convert.ToDouble(info_conci.Valor_pagado);
               Info_cbte.Estado = "A";
               Info_cbte.IdPeriodo = (Info_cbte.cb_Fecha.Year * 100) + Info_cbte.cb_Fecha.Month;
               Info_cbte.IdSucursal = 1;
               Info_cbte.IdUsuario = info_conci.IdUsuario;
               Info_cbte.Mayorizado = "N";
               Info_cbte.Mes = Info_cbte.cb_Fecha.Month;

               //gastos debito
               ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
               debe.IdEmpresa = Info_cbte.IdEmpresa;
               debe.IdTipoCbte = info_parametro_caja.IdTipoCbteCble_MoviCaja_Ing;
               debe.IdCbteCble = 0;
               debe.dc_EstaConciliado = "N";
               debe.dc_Numconciliacion = 0;
               debe.dc_Observacion = Info_cbte.cb_Observacion;
               debe.dc_Valor = Convert.ToDouble(info_conci.Valor_pagado);
               debe.IdCtaCble = info_conci.IdCtaCble;//*************************************************************************************;
               debe.secuencia = 1;

               //CXP Credito
               ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
               haber.IdEmpresa = Info_cbte.IdEmpresa;
               haber.IdTipoCbte = info_parametro_caja.IdTipoCbteCble_MoviCaja_Ing;
               haber.IdCbteCble = 0;
               haber.dc_EstaConciliado = "N";
               haber.dc_Numconciliacion = 0;
               haber.dc_Observacion = Info_cbte.cb_Observacion;
               haber.dc_Valor = Convert.ToDouble(info_conci.Valor_pagado) * -1;
               haber.IdCtaCble = info_conci.IdCtaCble;//*****************************************************************************
               haber.secuencia = 2;

               Info_cbte._cbteCble_det_lista_info.Add(debe);
               Info_cbte._cbteCble_det_lista_info.Add(haber);

               #endregion

               movimiento_caja_info.Info_CbteCble_x_Caja_Movi = Info_cbte;
               // llenar el objeto de movimiento detalle
               caj_Caja_Movimiento_det_Info info_movimiento_Detalle = new Info.Caja.caj_Caja_Movimiento_det_Info();
               info_movimiento_Detalle.IdEmpresa = Info_cbte.IdEmpresa;
               info_movimiento_Detalle.IdCbteCble = 0;
               info_movimiento_Detalle.IdTipocbte = Info_cbte.IdTipoCbte;
               info_movimiento_Detalle.IdCobro_tipo = "EFEC";
               info_movimiento_Detalle.Secuencia = 1;
               info_movimiento_Detalle.cr_fecha = Convert.ToDateTime(info_conci.Fecha);
               info_movimiento_Detalle.cr_Valor = Convert.ToDouble(info_conci.Valor_pagado);
               movimiento_caja_info.list_Caja_Movi_det.Add(info_movimiento_Detalle);

               if (Bus_Caja.GrabarDB(ref movimiento_caja_info, ref error))
               {
                   info_conci.IdEmpresa_mov_caj = movimiento_caja_info.IdEmpresa;
                   info_conci.IdTipoCbte_mov_caj = movimiento_caja_info.IdTipocbte;
                   info_conci.IdCbteCble_mov_caj = movimiento_caja_info.IdCbteCble;

                   res = ModificarDB_campos_mov_caj(info_conci, ref MensajeError);
               }
               return res;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_Caja", ex.Message), ex) { EntityType = typeof(cp_conciliacion_caja_Bus) };
           }
       }

       public cp_conciliacion_caja_Bus(){}
    }
}
