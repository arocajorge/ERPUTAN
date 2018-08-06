using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_giro_Data
    {
        string mensaje = "";

        public List<cp_orden_giro_consulta_Info> 
            
            

            Get_List_orden_giro(int IdEmpresa, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                F_inicio = F_inicio.Date;
                F_fin = F_fin.Date;
                List<cp_orden_giro_consulta_Info> lM;
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    db.SetCommandTimeOut(3000);
                    lM = (from q in db.vwcp_orden_giro_consulta
                          where q.IdEmpresa == IdEmpresa
                          && F_inicio <= q.co_fechaOg && q.co_fechaOg <= F_fin
                          select new cp_orden_giro_consulta_Info
                          {
                              IdEmpresa = q.IdEmpresa,
                              IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                              IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                              co_factura = q.co_factura,
                              co_fechaOg = q.co_fechaOg,
                              co_FechaFactura = q.co_FechaFactura,
                              co_observacion = q.co_observacion,
                              co_subtotal_iva = q.co_subtotal_iva,
                              co_subtotal_siniva = q.co_subtotal_siniva,
                              co_valoriva = q.co_valoriva,
                              co_baseImponible = q.co_baseImponible,
                              Estado = q.Estado,
                              Total_Retencion = q.re_valor_retencion,
                              saldo = q.saldo,
                              co_total = q.co_total,
                              re_NumRetencion = q.NumRetencion,
                              IdTipoFlujo = q.IdTipoFlujo,

                              pr_nombre = q.pe_nombreCompleto,
                              descripcion_clas_prove = q.descripcion_clas_prove,
                              Estado_Cancelacion = q.saldo <= 0 ? "PAGADO" : "PENDIENTE"
                          }).ToList();
                }

                #region Consulta anterior
                /*
                var select_ = (from T in Base.vwcp_orden_giro_x_Pagos_saldo
                               join P in Base.cp_proveedor on new { T.IdProveedor, T.IdEmpresa } equals new { P.IdProveedor, P.IdEmpresa }
                               join C in Base.cp_proveedor_clase on new { P.IdEmpresa, P.IdClaseProveedor } equals new { C.IdEmpresa, C.IdClaseProveedor}
                               where T.IdEmpresa == IdEmpresa
                               && T.co_fechaOg >= F_inicio && T.co_fechaOg <= F_fin
                               orderby T.IdCbteCble_Ogiro descending
                               select new
                               {
                                   T.em_nombre,
                                   T.IdEmpresa,
                                   T.IdCbteCble_Ogiro,
                                   T.IdTipoCbte_Ogiro,
                                   T.IdOrden_giro_Tipo,
                                   T.IdProveedor,
                                   T.co_fechaOg,
                                   T.co_serie,
                                   T.co_factura,
                                   T.co_FechaFactura,
                                   T.co_FechaFactura_vct,
                                   T.co_plazo,
                                   T.co_observacion,
                                   T.co_subtotal_iva,
                                   T.co_subtotal_siniva,
                                   T.co_baseImponible,
                                   T.co_Por_iva,
                                   T.co_valoriva,
                                   T.IdCod_ICE,
                                   T.co_Ice_base,
                                   T.co_Ice_por,
                                   T.co_Ice_valor,
                                   T.co_Serv_por,
                                   T.co_Serv_valor,
                                   T.co_OtroValor_a_descontar,
                                   T.co_OtroValor_a_Sumar,
                                   T.co_BaseSeguro,
                                   T.co_total,
                                   T.co_valorpagar,
                                   T.co_vaCoa,
                                   // T.IdAutorizacion,
                                   T.IdIden_credito,
                                   T.IdCod_101,
                                   T.IdTipoServicio,
                                   T.IdCtaCble_Gasto,
                                   T.IdUsuario,
                                   T.Fecha_Transac,
                                   T.Estado,
                                   T.IdUsuarioUltMod,
                                   T.Fecha_UltMod,
                                   T.IdUsuarioUltAnu,
                                   T.MotivoAnu,
                                   T.nom_pc,
                                   T.ip,
                                   T.Fecha_UltAnu,
                                   P.pr_nombre,
                                   T.IdCtaCble_IVA,
                                   T.co_retencionManual,
                                   T.SaldoOG,
                                   T.IdCbteCble_Anulacion,
                                   T.IdTipoCbte_Anulacion,
                                   T.IdCentroCosto,
                                   T.IdSucursal,
                                   T.tc_TipoCbte,
                                   T.IdTipoFlujo,
                                   T.TipoFlujo,
                                   T.PagoLocExt,
                                   T.PaisPago,
                                   T.ConvenioTributacion,
                                   T.PagoSujetoRetencion,
                                   T.co_FechaContabilizacion,
                                   T.BseImpNoObjDeIva,
                                   //  T.Id_Num_Autorizacion,
                                   T.fecha_autorizacion,
                                   T.Num_Autorizacion,
                                   T.Num_Autorizacion_Imprenta,
                                   P.IdCtaCble_CXP,
                                   T.IdEmpresa_ret,
                                   T.IdRetencion,
                                   T.re_serie,
                                   T.re_NumRetencion,
                                   T.re_EstaImpresa,
                                   T.co_propina,
                                   T.co_IRBPNR,
                                   T.Estado_Cancelacion,
                                   T.Total_Retencion,
                                   T.cp_es_comprobante_electronico,
                                   C.IdClaseProveedor,
                                   C.descripcion_clas_prove,
                                   T.Tipodoc_a_Modificar,
                                    T.estable_a_Modificar,
                                    T.ptoEmi_a_Modificar,
                                    T.num_docu_Modificar,
                                    T.aut_doc_Modificar,
                                    T.Tiene_ingresos,
                                    T.IdTipoMovi,
                                   T.En_conciliacion 
                               }
                              );
                foreach (var item in select_)
                {
                    cp_orden_giro_Info dat = new cp_orden_giro_Info();

                    dat.InfoProveedor.descripcion_clas_prove = item.descripcion_clas_prove;
                    dat.InfoProveedor.IdClaseProveedor = item.IdClaseProveedor;

                    dat.co_FechaContabilizacion = item.co_FechaContabilizacion;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = item.co_FechaFactura.Date;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct;

                    dat.co_plazo = item.co_plazo;
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.co_Ice_base = item.co_Ice_base;
                    dat.co_Ice_por = item.co_Ice_por;
                    dat.co_Ice_valor = item.co_Ice_valor;
                    dat.co_Serv_por = item.co_Serv_por;
                    dat.co_Serv_valor = item.co_Serv_valor;
                    dat.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                    dat.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                    dat.co_BaseSeguro = item.co_BaseSeguro;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.co_total = item.co_total;
                    dat.saldo = item.SaldoOG;
                    dat.co_valorpagar = item.co_valorpagar;

                    dat.co_vaCoa = item.co_vaCoa;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdCod_101 = item.IdCod_101;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.InfoProveedor.pr_nombre = item.pr_nombre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.co_retencionManual = item.co_retencionManual;
                    dat.En_conciliacion = item.En_conciliacion == null ? false : Convert.ToBoolean(item.En_conciliacion);
                    dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat.nomEmpresa = item.em_nombre;
                    dat.IdCentroCosto=item.IdCentroCosto;
                    dat.tc_TipoCbte = item.tc_TipoCbte;
                    dat.IdSucursal =  item.IdSucursal;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.TipoFlujo = item.TipoFlujo;
                    dat.PagoLocExt= item.PagoLocExt;
                    dat.PaisPago= item.PaisPago;
                    dat.ConvenioTributacion  = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.BseImpNoObjDeIva = item.BseImpNoObjDeIva;
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                    dat.Num_Autorizacion = item.Num_Autorizacion;
                    dat.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;
                    dat.IdCtaCble_CXP = item.IdCtaCble_CXP;
                    dat.IdEmpresa_ret = item.IdEmpresa_ret;
                    dat.IdRetencion = item.IdRetencion;
                    dat.re_serie = item.re_serie;
                    dat.re_NumRetencion = item.re_NumRetencion;
                    dat.re_EstaImpresa = item.re_EstaImpresa;
                    dat.co_propina = item.co_propina;
                    dat.co_IRBPNR = item.co_IRBPNR;                    
                    dat.Estado_Cancelacion = item.Estado_Cancelacion;
                    dat.Total_Retencion = item.Total_Retencion;
                    dat.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                    dat.Tipodoc_a_Modificar = item.Tipodoc_a_Modificar;
                    dat.estable_a_Modificar = item.estable_a_Modificar;
                    dat.ptoEmi_a_Modificar = item.ptoEmi_a_Modificar;
                    dat.num_docu_Modificar = item.num_docu_Modificar;
                    dat.aut_doc_Modificar = item.aut_doc_Modificar;
                    dat.Tiene_ingresos = item.Tiene_ingresos;

                    lM.Add(dat);
                }
                 * */
                #endregion
                
                return (lM);
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

        public List<cp_orden_giro_Info> Get_List_orden_giro_x_Pagar(int IdEmpresa, bool Mostrar_fact_conci_caja, ref string mensaje)
        {
            try
            {
                
                List<cp_orden_giro_Info> lM = new List<cp_orden_giro_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();
                IQueryable<vwcp_orden_giro_x_pagar> select_;
                if (!Mostrar_fact_conci_caja)
                {
                    select_ = from T in Base.vwcp_orden_giro_x_pagar
                              where T.IdEmpresa == IdEmpresa
                              && T.Saldo_OG != 0
                              && T.Estado == "A"
                              && T.en_conci_caja == false
                              orderby T.IdCbteCble_Ogiro descending
                              select T;
                } 
                else
                    select_ = from T in Base.vwcp_orden_giro_x_pagar                            
                               where T.IdEmpresa == IdEmpresa  
                               && T.Saldo_OG != 0    
                               && T.Estado=="A"
                               orderby T.IdCbteCble_Ogiro descending
                              select T;
                                                   
                foreach (var item in select_)
                {
                    cp_orden_giro_Info dat = new cp_orden_giro_Info();
                   
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = item.co_FechaFactura.Date;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct == null ? DateTime.Now.Date : Convert.ToDateTime(item.co_FechaFactura_vct);
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;                
                    dat.co_total = item.co_total;
                    dat.co_valorpagar = item.co_valorpagar;                   
                    dat.InfoProveedor.pr_nombre = item.nom_proveedor;                             
                    dat.tc_TipoCbte = item.tc_TipoCbte;
                    dat.IdSucursal = item.IdSucursal;
                    dat.nom_tipo_Documento=item.nom_tipo_Documento;
                    dat.tc_TipoCbte = item.tc_TipoCbte;
                    dat.IdTipo_op = item.IdTipo_op;
                    dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    dat.cod_Documento = item.cod_Documento;
                    dat.IdEstadoAprobacion_aux = item.IdEstadoAprobacion;
                    dat.cod_Documento = item.cod_Documento;
                    dat.nom_flujo = item.nom_flujo;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct == null ? DateTime.Now.Date : Convert.ToDateTime(item.co_FechaFactura_vct);
                    dat.IdPersona = item.IdPersona;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.Total_Pagado = item.Total_Pagado;
                    dat.Saldo_OG = item.Saldo_OG == null ? 0 : Convert.ToDouble(item.Saldo_OG);
                    dat.Saldo_OG_AUX = item.Saldo_OG == null ? 0 : Convert.ToDouble(item.Saldo_OG);
                    dat.InfoProveedor.pr_nombre = item.nom_proveedor;

                    

                    dat.Referencia = item.cod_Documento + "-" + item.co_serie + "-" + item.co_factura;

                    TimeSpan ts = Convert.ToDateTime(item.co_FechaFactura_vct == null ? DateTime.Now.Date : Convert.ToDateTime(item.co_FechaFactura_vct)) - Convert.ToDateTime(DateTime.Now);
                    int dias = ts.Days;
                    //Info cuota
                    dat.Info_cuotas_x_doc.Valor_cuota = item.Valor_cuota;
                    dat.Info_cuotas_x_doc.IdCuota = item.IdCuota == null ? 0 : Convert.ToDecimal(item.IdCuota);
                    dat.Info_cuotas_x_doc.Secuencia = item.Secuencia == null ? 0 : Convert.ToInt32(item.Secuencia);

                    dat.Dias_Vencidos = dias;


                    if (dias < 0) //Por vencer
                    {
                        dat.Tipo_Vcto = Cl_Enumeradores.eTipoVencimiento_x_OG.VENCIDO;
                      
                    }
                    if (dias == 0) //normal
                    {
                        dat.Tipo_Vcto = Cl_Enumeradores.eTipoVencimiento_x_OG.VENCE_HOY;
                       
                    }
                    if (dias > 0) // vencido
                    {
                        dat.Tipo_Vcto = Cl_Enumeradores.eTipoVencimiento_x_OG.X_VENCER;
                    }

                    lM.Add(dat);
                }
                return (lM);
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

        public cp_orden_giro_Info Get_Info_orden_giro(cp_orden_giro_Info info)
        {
            try
            {
                cp_orden_giro_Info infOgiro = new cp_orden_giro_Info();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                var select=  from Ogrio in Base.cp_orden_giro
                             where Ogrio.IdEmpresa==info.IdEmpresa
                             && Ogrio.IdCbteCble_Ogiro==info.IdCbteCble_Ogiro 
                             && Ogrio.IdTipoCbte_Ogiro==info.IdTipoCbte_Ogiro
                             select Ogrio;

                        foreach (var item in select)
                        {
                            infOgiro.IdEmpresa = item.IdEmpresa;
                            infOgiro.co_FechaContabilizacion = item.co_FechaContabilizacion;
                            infOgiro.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                            infOgiro.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                            infOgiro.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                            infOgiro.IdProveedor = item.IdProveedor;
                            infOgiro.co_fechaOg = item.co_fechaOg;
                            infOgiro.co_serie = item.co_serie;
                            infOgiro.co_factura = item.co_factura;
                            infOgiro.co_FechaFactura = item.co_FechaFactura.Date;
                            infOgiro.co_FechaFactura_vct = item.co_FechaFactura_vct;
                            infOgiro.co_plazo = item.co_plazo;
                            infOgiro.co_observacion = item.co_observacion;
                            infOgiro.co_subtotal_iva = item.co_subtotal_iva;
                            infOgiro.co_subtotal_siniva = item.co_subtotal_siniva;
                            infOgiro.co_baseImponible = item.co_baseImponible;
                            infOgiro.co_Por_iva = item.co_Por_iva;
                            infOgiro.co_valoriva = item.co_valoriva;
                            infOgiro.IdCod_ICE = item.IdCod_ICE;
                            infOgiro.co_Ice_base = item.co_Ice_base;
                            infOgiro.co_Ice_por = item.co_Ice_por;
                            infOgiro.co_Ice_valor = item.co_Ice_valor;
                            infOgiro.co_Serv_por = item.co_Serv_por;
                            infOgiro.co_Serv_valor = item.co_Serv_valor;
                            infOgiro.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                            infOgiro.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                            infOgiro.co_BaseSeguro = item.co_BaseSeguro;
                            infOgiro.co_total = item.co_total;
                            infOgiro.co_valorpagar = item.co_valorpagar;
                            infOgiro.co_vaCoa = item.co_vaCoa;
                          //  infOgiro.IdAutorizacion = item.IdAutorizacion;
                            infOgiro.IdIden_credito = item.IdIden_credito;
                            infOgiro.IdCod_101 = item.IdCod_101;
                            infOgiro.IdTipoServicio = item.IdTipoServicio;
                            infOgiro.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                            infOgiro.IdUsuario = item.IdUsuario;
                            infOgiro.Fecha_Transac = item.Fecha_Transac;
                            infOgiro.Estado = item.Estado;
                            infOgiro.IdUsuarioUltMod = item.IdUsuarioUltMod;
                            infOgiro.Fecha_UltMod = item.Fecha_UltMod;
                            infOgiro.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                            infOgiro.MotivoAnu = item.MotivoAnu;
                            infOgiro.nom_pc = item.nom_pc;
                            infOgiro.ip = item.ip;                   
                            infOgiro.IdCtaCble_IVA = item.IdCtaCble_IVA;
                            infOgiro.co_retencionManual = item.co_retencionManual;                  
                            infOgiro.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                            infOgiro.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;                          
                            infOgiro.IdCentroCosto = item.IdCentroCosto;                     
                            infOgiro.IdSucursal = item.IdSucursal;
                            infOgiro.IdTipoFlujo = item.IdTipoFlujo;                           
                            infOgiro.PagoLocExt = item.PagoLocExt;
                            infOgiro.PaisPago = item.PaisPago;
                            infOgiro.ConvenioTributacion = item.ConvenioTributacion;
                            infOgiro.PagoSujetoRetencion = item.PagoSujetoRetencion;
                            infOgiro.BseImpNoObjDeIva = item.BseImpNoObjDeIva;

                          //  infOgiro.Id_Num_Autorizacion = item.Id_Num_Autorizacion;
                            infOgiro.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                            infOgiro.es_retencion_electronica = item.es_retencion_electronica;
                            //para saber si es comprobante electrónico o no
                            infOgiro.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                            infOgiro.Tipodoc_a_Modificar= item.Tipodoc_a_Modificar;
                            infOgiro.estable_a_Modificar= item.estable_a_Modificar;
                            infOgiro.ptoEmi_a_Modificar= item.ptoEmi_a_Modificar;
                            infOgiro.num_docu_Modificar= item.num_docu_Modificar;
                            infOgiro.aut_doc_Modificar = item.aut_doc_Modificar;


                            //Campo de tipo de movimiento cuando se crea desde conciliacion de caja
                            infOgiro.IdTipoMovi = item.IdTipoMovi;
                        }
                        return infOgiro;	    		
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

        public cp_orden_giro_Info Get_Info_orden_giro(int IdEmpresa ,int IdTipoCbte_Ogiro,decimal IdCbteCble_Ogiro)
        {
            try
            {
                cp_orden_giro_Info infOgiro = new cp_orden_giro_Info();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                var select = from Ogrio in Base.cp_orden_giro
                             where Ogrio.IdEmpresa == IdEmpresa
                             && Ogrio.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                             && Ogrio.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                             select Ogrio;

                foreach (var item in select)
                {
                    infOgiro.IdEmpresa = item.IdEmpresa;
                    infOgiro.co_FechaContabilizacion = item.co_FechaContabilizacion;
                    infOgiro.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    infOgiro.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    infOgiro.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    infOgiro.IdProveedor = item.IdProveedor;
                    infOgiro.co_fechaOg = item.co_fechaOg;
                    infOgiro.co_serie = item.co_serie;
                    infOgiro.co_factura = item.co_factura;
                    infOgiro.co_FechaFactura = item.co_FechaFactura.Date;
                    infOgiro.co_FechaFactura_vct = item.co_FechaFactura_vct;
                    infOgiro.co_plazo = item.co_plazo;
                    infOgiro.co_observacion = item.co_observacion;
                    infOgiro.co_subtotal_iva = item.co_subtotal_iva;
                    infOgiro.co_subtotal_siniva = item.co_subtotal_siniva;
                    infOgiro.co_baseImponible = item.co_baseImponible;
                    infOgiro.co_Por_iva = item.co_Por_iva;
                    infOgiro.co_valoriva = item.co_valoriva;
                    infOgiro.IdCod_ICE = item.IdCod_ICE;
                    infOgiro.co_Ice_base = item.co_Ice_base;
                    infOgiro.co_Ice_por = item.co_Ice_por;
                    infOgiro.co_Ice_valor = item.co_Ice_valor;
                    infOgiro.co_Serv_por = item.co_Serv_por;
                    infOgiro.co_Serv_valor = item.co_Serv_valor;
                    infOgiro.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                    infOgiro.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                    infOgiro.co_BaseSeguro = item.co_BaseSeguro;
                    infOgiro.co_total = item.co_total;
                    infOgiro.co_valorpagar = item.co_valorpagar;
                    infOgiro.co_vaCoa = item.co_vaCoa;
                    infOgiro.IdIden_credito = item.IdIden_credito;
                    infOgiro.IdCod_101 = item.IdCod_101;
                    infOgiro.IdTipoServicio = item.IdTipoServicio;
                    infOgiro.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    infOgiro.IdUsuario = item.IdUsuario;
                    infOgiro.Fecha_Transac = item.Fecha_Transac;
                    infOgiro.Estado = item.Estado;
                    infOgiro.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    infOgiro.Fecha_UltMod = item.Fecha_UltMod;
                    infOgiro.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    infOgiro.MotivoAnu = item.MotivoAnu;
                    infOgiro.nom_pc = item.nom_pc;
                    infOgiro.ip = item.ip;
                    infOgiro.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    infOgiro.co_retencionManual = item.co_retencionManual;
                    infOgiro.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    infOgiro.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    infOgiro.IdCentroCosto = item.IdCentroCosto;
                    infOgiro.IdSucursal = item.IdSucursal;
                    infOgiro.IdTipoFlujo = item.IdTipoFlujo;
                    infOgiro.PagoLocExt = item.PagoLocExt;
                    infOgiro.PaisPago = item.PaisPago;
                    infOgiro.ConvenioTributacion = item.ConvenioTributacion;
                    infOgiro.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    infOgiro.BseImpNoObjDeIva = item.BseImpNoObjDeIva;
                    infOgiro.Num_Autorizacion = item.Num_Autorizacion;
                    
                    infOgiro.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                    //para saber si es comprobante electrónico o no
                    infOgiro.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                    infOgiro.Tipodoc_a_Modificar = item.Tipodoc_a_Modificar;
                    infOgiro.estable_a_Modificar = item.estable_a_Modificar;
                    infOgiro.ptoEmi_a_Modificar = item.ptoEmi_a_Modificar;
                    infOgiro.num_docu_Modificar = item.num_docu_Modificar;
                    infOgiro.aut_doc_Modificar = item.aut_doc_Modificar;

                    //Campo de tipo de movimiento cuando se crea desde conciliacion de caja
                    infOgiro.IdTipoMovi = item.IdTipoMovi;
                }
                return infOgiro;
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

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, int anio, int mes)
        {
            try
            {
                List<cp_orden_giro_Info> lM = new List<cp_orden_giro_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                  var select_ = (from T in Base.vwcp_orden_giro_x_Pagos_saldo
                                 join P in Base.cp_proveedor on new { T.IdProveedor, T.IdEmpresa } equals new { P.IdProveedor, P.IdEmpresa } 
                                where T.IdEmpresa == IdEmpresa
                                 && T.co_fechaOg.Year == anio && T.co_fechaOg.Month == mes
                                 select new
                                 {
                                     T.em_nombre,
                                     T.IdEmpresa,
                                     T.IdCbteCble_Ogiro,
                                     T.IdTipoCbte_Ogiro,
                                     T.IdOrden_giro_Tipo,
                                     T.IdProveedor,
                                     T.co_fechaOg,
                                     T.co_serie,
                                     T.co_factura,
                                     T.co_FechaFactura,
                                     T.co_FechaFactura_vct,
                                     T.co_plazo,
                                     T.co_observacion,
                                     T.co_subtotal_iva,
                                     T.co_subtotal_siniva,
                                     T.co_baseImponible,
                                     T.co_Por_iva,
                                     T.co_valoriva,
                                     T.IdCod_ICE,
                                     T.co_Ice_base,
                                     T.co_Ice_por,
                                     T.co_Ice_valor,
                                     T.co_Serv_por,
                                     T.co_Serv_valor,
                                     T.co_OtroValor_a_descontar,
                                     T.co_OtroValor_a_Sumar,
                                     T.co_BaseSeguro,
                                     T.co_total,
                                     T.co_valorpagar,
                                     T.co_vaCoa,
                                    // T.IdAutorizacion,
                                     T.IdIden_credito,
                                     T.IdCod_101,
                                     T.IdTipoServicio,
                                     T.IdCtaCble_Gasto,
                                     T.IdUsuario,
                                     T.Fecha_Transac,
                                     T.Estado,
                                     T.IdUsuarioUltMod,
                                     T.Fecha_UltMod,
                                     T.IdUsuarioUltAnu,
                                     T.MotivoAnu,
                                     T.nom_pc,
                                     T.ip,
                                     T.Fecha_UltAnu,
                                     P.pr_nombre,
                                     T.IdCtaCble_IVA,
                                     T.co_retencionManual,
                                     T.SaldoOG,
                                     T.IdCbteCble_Anulacion,
                                     T.IdTipoCbte_Anulacion,
                                     T.IdCentroCosto ,
                                     T.IdSucursal,
                                     T.IdTipoFlujo ,
                                     T.TipoFlujo,
                                     T.PagoLocExt,
                                     T.PaisPago,
                                     T.ConvenioTributacion,
                                     T.PagoSujetoRetencion ,
                                     T.co_FechaContabilizacion,
                                     T.BseImpNoObjDeIva,
                                     T.fecha_autorizacion,
                                     T.Num_Autorizacion,
                                     T.Num_Autorizacion_Imprenta,
                                     T.Estado_Cancelacion,
                                     T.Total_Retencion,
                                     T.cp_es_comprobante_electronico,
                                     T.Tipodoc_a_Modificar,
                                     T.estable_a_Modificar,
                                     T.ptoEmi_a_Modificar,
                                     T.num_docu_Modificar,
                                     T.aut_doc_Modificar 
                                 }
                                );

                foreach (var item in select_)
                {
                    cp_orden_giro_Info dat = new cp_orden_giro_Info();
                    dat.co_FechaContabilizacion = item.co_FechaContabilizacion;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = Convert.ToDateTime(item.co_FechaFactura.ToShortDateString()) ;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct;
                    dat.co_plazo = item.co_plazo;
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.co_Ice_base = item.co_Ice_base;
                    dat.co_Ice_por = item.co_Ice_por;
                    dat.co_Ice_valor = item.co_Ice_valor;
                    dat.co_Serv_por = item.co_Serv_por;
                    dat.co_Serv_valor = item.co_Serv_valor;
                    dat.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                    dat.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                    dat.co_BaseSeguro = item.co_BaseSeguro;
                    dat.co_total = item.co_total;
                    dat.co_valorpagar = item.co_valorpagar;
                    dat.co_vaCoa = item.co_vaCoa;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdCod_101 = item.IdCod_101;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.InfoProveedor.pr_nombre = item.pr_nombre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.co_retencionManual = item.co_retencionManual;
                    dat.saldo = (item.SaldoOG);
                    dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat.nomEmpresa = item.em_nombre;
                    dat.IdCentroCosto=item.IdCentroCosto  ;
                    dat.IdSucursal=item.IdSucursal;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.TipoFlujo = item.TipoFlujo;
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.BseImpNoObjDeIva = item.BseImpNoObjDeIva;
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                    dat.Num_Autorizacion = item.Num_Autorizacion;
                    dat.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;
                    dat.Estado_Cancelacion = item.Estado_Cancelacion;
                    dat.Total_Retencion = item.Total_Retencion;
                    //para saber si es comprobante electrónico o no
                    dat.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                    dat.Tipodoc_a_Modificar = item.Tipodoc_a_Modificar;
                    dat.estable_a_Modificar = item.estable_a_Modificar;
                    dat.ptoEmi_a_Modificar = item.ptoEmi_a_Modificar;
                    dat.num_docu_Modificar = item.num_docu_Modificar;
                    dat.aut_doc_Modificar = item.aut_doc_Modificar;

                    lM.Add(dat);
                }
                return(lM);
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_SRI(int IdEmpresa, int anio, int mes)
        {
            try
            {
                string msg = "";
                List<cp_orden_giro_Info> lM = new List<cp_orden_giro_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();
                
                var select_ = from T in Base.vwcp_orden_giro_SRI
                              where T.IdEmpresa == IdEmpresa
                               && T.co_FechaContabilizacion.Value.Year == anio
                               && T.co_FechaContabilizacion.Value.Month == mes
                              && T.co_vaCoa == "S"
                              select T;




                foreach (var item in select_)
                {
                    cp_orden_giro_Info dat = new cp_orden_giro_Info();
                    dat.co_FechaContabilizacion = item.co_FechaContabilizacion;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = Convert.ToDateTime(item.co_FechaFactura.ToShortDateString());
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct;

                    dat.Num_Autorizacion = item.Num_Autorizacion;

                    
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.co_Ice_base = item.co_Ice_base;
                    dat.co_Ice_por = item.co_Ice_por;
                    dat.co_Ice_valor = item.co_Ice_valor;
                    dat.co_Serv_por = item.co_Serv_por;
                    dat.co_Serv_valor = item.co_Serv_valor;
                    
                    dat.co_total = item.co_total;
                    
                    dat.co_vaCoa = item.co_vaCoa;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdCod_101 = item.IdCod_101;
                    
                    
                    dat.Estado = item.Estado;

                    
                    //dat.co_retencionManual = item.co_retencionManual;
                    
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;

                    dat.InfoProveedor.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    dat.InfoProveedor.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    dat.InfoProveedor.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    dat.InfoProveedor.IdProveedor = item.IdProveedor;
                    dat.InfoProveedor.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                    dat.InfoProveedor.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);
                    //para saber si es comprobante electrónico o no
                    dat.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                    if (item.IdOrden_giro_Tipo == "05")
                    {
                        dat.Tipodoc_a_Modificar = item.Tipodoc_a_Modificar;
                        dat.estable_a_Modificar = item.estable_a_Modificar;
                        dat.ptoEmi_a_Modificar = item.ptoEmi_a_Modificar;
                        dat.num_docu_Modificar = item.num_docu_Modificar;
                        dat.aut_doc_Modificar = item.aut_doc_Modificar;
                    }

                    lM.Add(dat);

                    //break;
                }


                return (lM);
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

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, decimal IdOrdenGiro)
        {
            try
            {
                List<cp_orden_giro_Info> lM = new List<cp_orden_giro_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();
                ct_Cbtecble_det_Data Cbt_D = new ct_Cbtecble_det_Data();
                cp_retencion_det_Data ret_D = new cp_retencion_det_Data();

                var select_ = from T in Base.vwcp_orden_giro_x_Pagos_saldo
                              join P in Base.cp_proveedor on new { T.IdProveedor, T.IdEmpresa } equals new { P.IdProveedor, P.IdEmpresa }
                              join A in Base.cp_orden_giro on new { T.IdEmpresa, T.IdCbteCble_Ogiro } equals new { A.IdEmpresa, A.IdCbteCble_Ogiro }
                              join Co in Base.cp_codigo_SRI.DefaultIfEmpty() on new { } equals new { }

                              where T.IdEmpresa == IdEmpresa
                              && T.IdCbteCble_Ogiro == IdOrdenGiro
                              && Co.IdCodigo_SRI == A.IdIden_credito

                              select new
                              {
                                  T.IdEmpresa,
                                  T.IdCbteCble_Ogiro,
                                  T.IdTipoCbte_Ogiro,
                                  T.IdOrden_giro_Tipo,
                                  T.IdProveedor,
                                  T.co_fechaOg,
                                  T.co_serie,
                                  T.co_factura,
                                  T.co_FechaFactura,
                                  T.co_FechaFactura_vct,
                                  T.co_plazo,
                                  T.co_observacion,
                                  T.co_subtotal_iva,
                                  T.co_subtotal_siniva,
                                  T.co_baseImponible,
                                  T.co_Por_iva,
                                  T.co_valoriva,
                                  T.IdCod_ICE,
                                  T.co_Ice_base,
                                  T.co_Ice_por,
                                  T.co_Ice_valor,
                                  T.co_Serv_por,
                                  T.co_Serv_valor,
                                  T.co_OtroValor_a_descontar,
                                  T.co_OtroValor_a_Sumar,
                                  T.co_BaseSeguro,
                                  T.co_total,
                                  T.co_valorpagar,
                                  T.co_vaCoa,
                                  //  T.IdAutorizacion,
                                  T.IdIden_credito,
                                  T.IdCod_101,
                                  T.IdTipoServicio,
                                  T.IdCtaCble_Gasto,
                                  T.IdUsuario,
                                  T.Fecha_Transac,
                                  T.Estado,
                                  T.IdUsuarioUltMod,
                                  T.Fecha_UltMod,
                                  T.IdUsuarioUltAnu,
                                  T.MotivoAnu,
                                  T.nom_pc,
                                  T.ip,
                                  T.Fecha_UltAnu,
                                  P.pr_nombre,
                                  T.IdCtaCble_IVA,
                                  T.co_retencionManual,
                                  T.SaldoOG,
                                  //   C.nAutorizacion,
                                  T.em_nombre,
                                  Co.co_descripcion,
                                  Co.co_porRetencion,
                                  T.IdCentroCosto,
                                  T.IdSucursal,
                                  T.IdTipoFlujo,
                                  T.TipoFlujo,
                                  T.PagoLocExt,
                                  T.PaisPago,
                                  T.ConvenioTributacion,
                                  T.PagoSujetoRetencion,
                                  T.co_FechaContabilizacion,
                                  T.BseImpNoObjDeIva,
                                  //  T.Id_Num_Autorizacion,
                                  T.fecha_autorizacion,
                                  T.Num_Autorizacion,
                                  T.Num_Autorizacion_Imprenta,
                                  T.Estado_Cancelacion,
                                  T.cp_es_comprobante_electronico
                              };

                foreach (var item in select_)
                {
                    cp_orden_giro_Info dat = new cp_orden_giro_Info();
                    dat.co_FechaContabilizacion = item.co_FechaContabilizacion;
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = item.co_FechaFactura.Date;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct;
                    dat.co_plazo = item.co_plazo;
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.co_Ice_base = item.co_Ice_base;
                    dat.co_Ice_por = item.co_Ice_por;
                    dat.co_Ice_valor = item.co_Ice_valor;
                    dat.co_Serv_por = item.co_Serv_por;
                    dat.co_Serv_valor = item.co_Serv_valor;
                    dat.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                    dat.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                    dat.co_BaseSeguro = item.co_BaseSeguro;
                    dat.co_total = item.co_total;
                    dat.co_valorpagar = item.co_valorpagar;
                    dat.co_vaCoa = item.co_vaCoa;
                    //    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdCod_101 = item.IdCod_101;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.InfoProveedor.pr_nombre = item.pr_nombre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.co_retencionManual = item.co_retencionManual;
                    dat.saldo = (item.SaldoOG);

                    dat.nomEmpresa = item.em_nombre;
                    dat.sIdCredito = item.co_porRetencion + " " + item.co_descripcion;
                    string MensajeError = "";
                    dat.Info_CbteCble_x_OG._cbteCble_det_lista_info = Cbt_D.Get_list_Cbtecble_det(item.IdEmpresa, item.IdTipoCbte_Ogiro, item.IdCbteCble_Ogiro, ref MensajeError);


                    dat.Info_Retencion.ListDetalle = ret_D.Get_List_retencion_det_x_Report(item.IdEmpresa,
                    item.IdCbteCble_Ogiro, item.IdTipoCbte_Ogiro).FindAll(c => c.re_Porcen_retencion != 0);

                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.IdSucursal = item.IdSucursal;
                    dat.TipoFlujo = item.TipoFlujo;
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.BseImpNoObjDeIva = item.BseImpNoObjDeIva;

                    //  dat.Id_Num_Autorizacion = item.Id_Num_Autorizacion;
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);


                    dat.Num_Autorizacion = item.Num_Autorizacion;
                    dat.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;
                    dat.Estado_Cancelacion = item.Estado_Cancelacion;
                    //para saber si es comprobante electrónico o no
                    dat.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;
                    lM.Add(dat);
                }
                return (lM);
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

        public Boolean Generar_OrdenPago_x_Faxtura(cp_orden_giro_Info info_og,DateTime Fecha_OP, ref string mensaje)
        {
            try
            {
                cp_orden_pago_Info cab_op = new cp_orden_pago_Info();

                //cabecera op
                cab_op.IdEmpresa = info_og.IdEmpresa;
                cab_op.Observacion = info_og.co_observacion;
                cab_op.IdTipo_op = info_og.IdTipo_op;              
                cab_op.IdEntidad = info_og.IdProveedor;
                cab_op.Fecha = Fecha_OP.Date;
                cab_op.Fecha_Pago = Fecha_OP.Date;
                cab_op.IdFormaPago = info_og.IdFormaPago; 
                cab_op.IdPersona = info_og.IdPersona;
                cab_op.IdTipo_Persona = "PROVEE";
                cab_op.IdBanco = info_og.IdBanco;
                cab_op.IdEstadoAprobacion = info_og.IdEstadoAprobacion;
                cab_op.IdTipoFlujo = info_og.IdTipoFlujo;
                cab_op.IdUsuario = info_og.IdUsuario;
                cab_op.nom_pc = info_og.nom_pc;
                cab_op.ip = info_og.ip;

                // detalle op
                cp_orden_pago_det_Info det_op = new cp_orden_pago_det_Info();
                det_op.IdEmpresa = info_og.IdEmpresa;

                det_op.IdEmpresa_cxp = info_og.IdEmpresa;
                det_op.IdCbteCble_cxp = info_og.IdCbteCble_Ogiro;
                det_op.IdTipoCbte_cxp = info_og.IdTipoCbte_Ogiro;
                det_op.Valor_a_pagar = info_og.Valor_a_Pagar;
                det_op.Referencia = info_og.Referencia;
                det_op.IdFormaPago = info_og.IdFormaPago;
                det_op.Idbanco= info_og.IdBanco;
                det_op.Fecha_Pago = Fecha_OP;
                det_op.IdEstadoAprobacion = info_og.IdEstadoAprobacion;

                cab_op.Detalle.Add(det_op);

                cp_orden_pago_Data odata = new cp_orden_pago_Data();

                decimal Id=0;

                if (odata.GuardaDB(cab_op, ref Id, ref mensaje))
                {
                    if (info_og.Info_cuotas_x_doc.Cancela_cuota)
                    {
                        cp_cuotas_x_doc_det_Data oData_cuota = new cp_cuotas_x_doc_det_Data();
                        cp_cuotas_x_doc_det_Info info_cuota = new cp_cuotas_x_doc_det_Info();

                        info_cuota.IdEmpresa = info_og.IdEmpresa;
                        info_cuota.IdCuota = info_og.Info_cuotas_x_doc.IdCuota;
                        info_cuota.Secuencia = info_og.Info_cuotas_x_doc.Secuencia;

                        foreach (var item in cab_op.Detalle)
                        {
                            info_cuota.IdEmpresa_op = item.IdEmpresa;
                            info_cuota.IdOrdenPago = Id;
                            info_cuota.Secuencia_op = item.Secuencia;
                        }

                        oData_cuota.ModificarDB_campos_op(info_cuota);
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(cp_orden_giro_Info item, ref string mensaje)
        {
            try
            {                             
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    var dat = new cp_orden_giro();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    dat.IdProveedor = item.IdProveedor;
                    dat.co_fechaOg = item.co_fechaOg.Date;
                    dat.co_FechaContabilizacion = (item.co_FechaContabilizacion == null) ? item.co_fechaOg :
                        Convert.ToDateTime(item.co_FechaContabilizacion).Date;
                    dat.co_serie = item.co_serie;
                    dat.co_factura = item.co_factura;
                    dat.co_FechaFactura = item.co_FechaFactura.Date;
                    dat.co_FechaFactura_vct = item.co_FechaFactura_vct.Date;
                    dat.co_plazo = item.co_plazo;
                    dat.co_observacion = item.co_observacion;
                    dat.co_subtotal_iva = item.co_subtotal_iva;
                    dat.co_subtotal_siniva = item.co_subtotal_siniva;
                    dat.co_baseImponible = item.co_baseImponible;
                    dat.co_Por_iva = item.co_Por_iva;
                    dat.co_valoriva = item.co_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.co_Ice_base = item.co_Ice_base;
                    dat.co_Ice_por = item.co_Ice_por;
                    dat.co_Ice_valor = item.co_Ice_valor;
                    dat.co_Serv_por = item.co_Serv_por;
                    dat.co_Serv_valor = item.co_Serv_valor;
                    dat.co_OtroValor_a_descontar = item.co_OtroValor_a_descontar;
                    dat.co_OtroValor_a_Sumar = item.co_OtroValor_a_Sumar;
                    dat.co_BaseSeguro = item.co_BaseSeguro;
                    dat.co_total = item.co_total;
                    dat.co_valorpagar = item.co_valorpagar;

                    dat.co_vaCoa = (item.co_vaCoa == null || item.co_vaCoa == "") ? "S" : item.co_vaCoa;
                  //  dat.IdAutorizacion = item.IdAutorizacion;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdCod_101 = item.IdCod_101;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    dat.IdUsuario =item.IdUsuario;
                    dat.IdUsuarioUltMod = (item.IdUsuario == null) ? "" : item.IdUsuario;
                    dat.Fecha_Transac = DateTime.Now;
                    dat.Estado = "A";
                 
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.co_retencionManual = item.co_retencionManual;
                    dat.IdCentroCosto = (item.IdCentroCosto == "") ? null : item.IdCentroCosto;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.IdSucursal = item.IdSucursal;

                    dat.PagoLocExt=item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.BseImpNoObjDeIva = item.BseImpNoObjDeIva;
                    dat.fecha_autorizacion = Convert.ToDateTime(item.co_fechaOg.ToShortDateString());

                    dat.Num_Autorizacion = item.Num_Autorizacion;
                    dat.Num_Autorizacion_Imprenta = item.Num_Autorizacion_Imprenta;

                    dat.co_propina = item.co_propina;
                    dat.co_IRBPNR = item.co_IRBPNR;
                    //para saber si es comprobante electrónico o no
                    dat.cp_es_comprobante_electronico = item.cp_es_comprobante_electronico;

                    dat.Tipodoc_a_Modificar = item.Tipodoc_a_Modificar;
                    dat.estable_a_Modificar = item.estable_a_Modificar;
                    dat.ptoEmi_a_Modificar = item.ptoEmi_a_Modificar;
                    dat.num_docu_Modificar = item.num_docu_Modificar;
                    dat.aut_doc_Modificar = item.aut_doc_Modificar;


                    //Campo donde se guarda el tipo de movimiento al ser creado desde caja chica
                    dat.IdTipoMovi = item.IdTipoMovi;
                    context.cp_orden_giro.Add(dat);
                    context.SaveChanges();        
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro.First(minfo => minfo.IdEmpresa == info.IdEmpresa  && minfo.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro && minfo.IdTipoCbte_Ogiro==info.IdTipoCbte_Ogiro );


                    contact.IdOrden_giro_Tipo = info.IdOrden_giro_Tipo;
                    contact.IdProveedor = info.IdProveedor;
                    contact.co_fechaOg = info.co_fechaOg;
                    contact.co_serie = info.co_serie;
                    contact.co_factura = info.co_factura;
                    contact.co_FechaContabilizacion = info.co_FechaContabilizacion;
                    contact.co_FechaFactura = info.co_FechaFactura.Date;
                    contact.co_FechaFactura_vct = info.co_FechaFactura_vct;
                    contact.co_plazo = info.co_plazo;
                    contact.co_observacion = info.co_observacion;
                    contact.co_subtotal_iva = info.co_subtotal_iva;
                    contact.co_subtotal_siniva = info.co_subtotal_siniva;
                    contact.co_baseImponible = info.co_baseImponible;
                    contact.co_Por_iva = info.co_Por_iva;
                    contact.co_valoriva = info.co_valoriva;
                    contact.IdCod_ICE = info.IdCod_ICE == 0 ? null : info.IdCod_ICE;
                    contact.co_Ice_base = info.co_Ice_base;
                    contact.co_Ice_por = info.co_Ice_por;
                    contact.co_Ice_valor = info.co_Ice_valor;
                    contact.co_Serv_por = info.co_Serv_por;
                    contact.co_Serv_valor = info.co_Serv_valor;
                    contact.co_OtroValor_a_descontar = info.co_OtroValor_a_descontar;
                    contact.co_OtroValor_a_Sumar = info.co_OtroValor_a_Sumar;
                    contact.co_BaseSeguro = info.co_BaseSeguro;
                    contact.co_total = info.co_total;
                    contact.co_valorpagar = info.co_valorpagar;
                    contact.co_vaCoa = info.co_vaCoa;
                  //  contact.IdAutorizacion = info.IdAutorizacion;
                    contact.IdIden_credito = info.IdIden_credito;
                    contact.IdCod_101 = info.IdCod_101;
                    contact.IdTipoServicio = info.IdTipoServicio;
                    contact.IdCtaCble_Gasto = info.IdCtaCble_Gasto;
                    contact.IdCtaCble_IVA = info.IdCtaCble_IVA;
                    contact.Estado = info.Estado;
                    contact.co_retencionManual = info.co_retencionManual;
                    contact.IdCentroCosto = info.IdCentroCosto;
                    contact.IdTipoFlujo = info.IdTipoFlujo;
                    contact.IdSucursal =  info.IdSucursal;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;

                    contact.PagoLocExt = info.PagoLocExt;
                    contact.PaisPago = info.PaisPago==""? null :info.PaisPago;
                    contact.ConvenioTributacion = info.ConvenioTributacion;
                    contact.PagoSujetoRetencion = info.PagoSujetoRetencion;
                    contact.BseImpNoObjDeIva = info.BseImpNoObjDeIva;

                    //contact.Id_Num_Autorizacion = info.Id_Num_Autorizacion;
                    contact.fecha_autorizacion = info.fecha_autorizacion;


                    contact.Num_Autorizacion = info.Num_Autorizacion;
                    contact.Num_Autorizacion_Imprenta = info.Num_Autorizacion_Imprenta;

                    contact.co_propina = info.co_propina;
                    contact.co_IRBPNR = info.co_IRBPNR;
                    contact.IdTipoMovi = info.IdTipoMovi;
                    //para saber si es comprobante electrónico o no
                    contact.cp_es_comprobante_electronico = info.cp_es_comprobante_electronico;


                    contact.Tipodoc_a_Modificar = info.Tipodoc_a_Modificar;
                    contact.estable_a_Modificar = info.estable_a_Modificar;
                    contact.ptoEmi_a_Modificar = info.ptoEmi_a_Modificar;
                    contact.num_docu_Modificar = info.num_docu_Modificar;
                    contact.aut_doc_Modificar = info.aut_doc_Modificar;



                    context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_proceso_cerrado(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro && minfo.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro);

                    if (contact != null)
                    {
                        contact.co_FechaFactura_vct = info.co_FechaFactura_vct;
                        contact.co_plazo = info.co_plazo;
                        contact.co_observacion = info.co_observacion;
                        contact.IdTipoFlujo = info.IdTipoFlujo;
                        contact.IdTipoMovi = info.IdTipoMovi;
                        contact.IdIden_credito = info.IdIden_credito;
                        contact.IdOrden_giro_Tipo = info.IdOrden_giro_Tipo;
                        contact.Num_Autorizacion = info.Num_Autorizacion;
                        contact.co_vaCoa = info.co_vaCoa;
                        contact.co_serie = info.co_serie;
                        
                        contact.PagoLocExt = info.PagoLocExt;
                        contact.PaisPago = info.PaisPago == "" ? null : info.PaisPago;
                        contact.ConvenioTributacion = info.ConvenioTributacion;
                        contact.PagoSujetoRetencion = info.PagoSujetoRetencion;

                        contact.Tipodoc_a_Modificar = info.Tipodoc_a_Modificar;
                        contact.estable_a_Modificar = info.estable_a_Modificar;
                        contact.ptoEmi_a_Modificar = info.ptoEmi_a_Modificar;
                        contact.num_docu_Modificar = info.num_docu_Modificar;
                        contact.aut_doc_Modificar = info.aut_doc_Modificar;

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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_ValorRetencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, double valorRetencion, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdCbteCble_Ogiro == IdCbteCble_Ogiro && minfo.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro);
                    if (contact != null)
                    {
                        contact.co_valorpagar = contact.co_valorpagar - valorRetencion;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(cp_orden_giro_Info info,ref string msg2)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro && minfo.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro);

                    contact.Estado = "I";
                    contact.co_observacion = "**ANULADO** " + contact.co_observacion;
                    contact.MotivoAnu = info.MotivoAnu;
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    contact.IdCbteCble_Anulacion=info.IdCbteCble_Anulacion;
                    contact.IdTipoCbte_Anulacion=info.IdTipoCbte_Anulacion;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msg2 = mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VericarNumDocumento(int IdEmpresa ,decimal IdProveedor, string tipoDocumento ,string Serie ,string NumDocumento, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                    
                    mensaje = "";
                    Existe = false;

                    EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

                    var select_ = from t in B.cp_orden_giro
                                  where t.co_factura == NumDocumento.Trim() 
                                  && t.IdOrden_giro_Tipo == tipoDocumento.Trim() 
                                  && t.IdProveedor == IdProveedor 
                                  && t.IdEmpresa == IdEmpresa
                                  && t.co_serie == Serie
                                  && t.Estado=="A"
                                  select t;


                    foreach (var item in select_)
                    {
                        
                            mensaje = mensaje + " " + item.IdCbteCble_Ogiro;
                            Existe = true;
                        
                    }
            
                    return Existe;
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
        
        public decimal GetNDocumentoXTipo(String CodTipoDocumento,int IdEmpresa)
        {
            try
            {
                decimal NDocumento;
                EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar();

                var q = from C in base_.cp_orden_giro
                        where C.IdEmpresa == IdEmpresa && C.IdOrden_giro_Tipo == CodTipoDocumento
                        select C;

                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in base_.cp_orden_giro
                                   where t.IdEmpresa == IdEmpresa && t.IdOrden_giro_Tipo == CodTipoDocumento
                                   select t.co_factura).Max();
                    NDocumento = Convert.ToDecimal(select_) + 1;
                    return NDocumento;
                }
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

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, string co_Factura) 
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {
                               
                    var result = from q in Entity.cp_orden_giro
                                 where q.IdEmpresa == IdEmpresa 
                                 && q.IdProveedor == IdProveedor 
                                 && co_Factura == q.co_factura
                               
                                 select q;

                    if (result.Count() != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }                
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

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, String co_serie, String co_Factura)
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {

                    if (String.IsNullOrEmpty(co_Factura) && String.IsNullOrEmpty(co_serie))
                    {
                        return false;
                    }

                    if (String.IsNullOrEmpty(co_Factura) || String.IsNullOrEmpty(co_serie))
                    {
                        return false;
                    }


                    co_serie = co_serie.Trim();
                    co_Factura = co_Factura.Trim();
                    var result = from q in Entity.cp_orden_giro
                                 where q.IdEmpresa == IdEmpresa && q.IdProveedor == IdProveedor && co_Factura == q.co_factura
                                 && q.co_serie == co_serie
                                 && q.Estado == "A"
                                 select q;

                    if (result.Count() != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }
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

        public Boolean Modificar_tipo_flujo(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble, Nullable<decimal> IdTipoFlujo)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_orden_giro Entity = Context.cp_orden_giro.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdTipoCbte_Ogiro == IdTipoCbte_OG && q.IdCbteCble_Ogiro == IdCbteCble);
                    if (Entity!=null)
                    {
                        Entity.IdTipoFlujo = IdTipoFlujo;
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
                throw new Exception(ex.ToString());
            }
        }

        public cp_orden_giro_Data(){}
    }
}

