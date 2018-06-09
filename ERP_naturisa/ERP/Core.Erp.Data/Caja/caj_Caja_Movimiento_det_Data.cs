using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Caja;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Caja
{
   public class caj_Caja_Movimiento_det_Data
    {
       public List<vwcaj_Caja_Movimiento_det_cancelado_Info> Get_list_Caja_Movimiento_det_cancelado(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
       {
           List<vwcaj_Caja_Movimiento_det_cancelado_Info> Listado = new List<vwcaj_Caja_Movimiento_det_cancelado_Info>();
           try
           {
               EntitiesCaja db = new EntitiesCaja();

               var select_ = from T in db.vwcaj_Caja_Movimiento_det_cancelado
                             where T.IdEmpresa == IdEmpresa && T.IdCbteCble == IdCbteCble && T.IdTipocbte == IdTipocbte
                             select T;


               foreach (var item in select_)
               {
                   vwcaj_Caja_Movimiento_det_cancelado_Info dat = new vwcaj_Caja_Movimiento_det_cancelado_Info();
                   dat.IdEmpresa = item.IdEmpresa;
                   dat.IdCbteCble = item.IdCbteCble;
                   dat.IdTipocbte = item.IdTipocbte;
                   dat.Secuencia = item.Secuencia;
                   dat.IdCobro_tipo = item.IdCobro_tipo;
                   dat.cr_fecha = item.cr_fecha;
                   dat.cr_Valor = item.cr_Valor;
                   dat.cr_Banco = item.cr_Banco;
                   dat.cr_cuenta = item.cr_cuenta;
                   dat.cr_NumDocumento = item.cr_NumDocumento;
                   dat.cr_fechaDocu = item.cr_fechaDocu;
                   dat.IdOrdenPago_OP = item.IdOrdenPago_OP;
                   dat.IdEmpresa_OP = item.IdEmpresa_OP;
                   dat.IdTipo_op = item.IdTipo_op;
                   dat.Referencia = item.Referencia;
                   dat.IdOrdenPago = item.IdOrdenPago;
                   dat.Secuencia_OP = item.Secuencia_OP;
                   dat.IdTipoPersona = item.IdTipoPersona;
                   dat.IdPersona = item.IdPersona;
                   dat.IdEntidad = item.IdEntidad;
                   dat.Fecha_OP = item.Fecha_OP;
                   dat.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                   dat.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                   dat.Observacion = item.Observacion;
                   dat.Nom_Beneficiario = item.Nom_Beneficiario;
                   dat.Girar_Cheque_a = item.Girar_Cheque_a;
                   dat.Valor_a_pagar = item.Valor_a_pagar;
                   dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                   dat.Total_cancelado_OP = item.Total_cancelado_OP;
                   dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                   dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                   dat.IdFormaPago = item.IdFormaPago;
                   dat.Fecha_Pago = item.Fecha_Pago;
                   dat.IdCtaCble = item.IdCtaCble;
                   dat.IdCentroCosto = item.IdCentroCosto;
                   dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                   dat.Cbte_cxp = item.Cbte_cxp;
                   dat.Estado = item.Estado;
                   dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                   dat.IdCentroCosto = item.IdCentroCosto;
                   dat.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   dat.IdTipoFlujo = item.IdTipoFlujo;
                   
                   
                   
                   Listado.Add(dat);
               }
               return Listado;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.ToString());
           }
       }

       public List<caj_Caja_Movimiento_det_Info> Get_listDetalle(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
       {
           List<caj_Caja_Movimiento_det_Info> lM = new List<caj_Caja_Movimiento_det_Info>();
           EntitiesCaja db = new EntitiesCaja();
           try
           {

               var select_ = from T in db.caj_Caja_Movimiento_det

                             where T.IdEmpresa == IdEmpresa && T.IdCbteCble == IdCbteCble && T.IdTipocbte == IdTipocbte
                             select T;

               foreach (var item in select_)
               {
                   caj_Caja_Movimiento_det_Info dat = new caj_Caja_Movimiento_det_Info();
                   dat.IdEmpresa = item.IdEmpresa;
                   dat.IdCbteCble = item.IdCbteCble;
                   dat.IdTipocbte = item.IdTipocbte;
                   dat.Secuencia = item.Secuencia;
                   dat.cr_fecha = item.cr_fecha;
                   dat.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu);
                   dat.cr_NumDocumento = item.cr_NumDocumento;
                   dat.cr_Valor = item.cr_Valor;
                   dat.IdCobro_tipo = item.IdCobro_tipo != null ? item.IdCobro_tipo.TrimEnd() : item.IdCobro_tipo;
                   dat.cr_Banco = item.cr_Banco;
                   dat.cr_cuenta = item.cr_cuenta;
                   dat.IdCentroCosto = item.IdCentroCosto;
                   dat.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                   dat.IdTipoFlujo = item.IdTipoFlujo;
                   lM.Add(dat);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);

               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GrabarDB(List<caj_Caja_Movimiento_det_Info> Lista, ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja context = new EntitiesCaja())
               {
                   int c = 1;
                   foreach (var item in Lista)
                   {
                       EntitiesCaja adr = new EntitiesCaja();
                       caj_Caja_Movimiento_det address = new caj_Caja_Movimiento_det();

                       address.IdEmpresa = item.IdEmpresa;
                       address.IdOrdenPago_OP = item.IdOrdenPago;
                       address.cr_Valor = item.cr_Valor;
                       address.Secuencia = c;
                       address.IdTipocbte = item.IdTipocbte;
                       address.IdCobro_tipo = item.IdCobro_tipo;
                       address.cr_fecha = item.cr_fecha;
                       address.cr_Banco = item.cr_Banco;
                       address.cr_cuenta = item.cr_cuenta;
                       address.cr_fechaDocu = item.cr_fechaDocu;
                       address.cr_NumDocumento = item.cr_NumDocumento;
                       address.IdCbteCble = item.IdCbteCble;
                       address.IdEmpresa_OP = item.IdEmpresa_OP;
                       address.IdCentroCosto = item.IdCentroCosto;
                       address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       address.IdTipoFlujo = item.IdTipoFlujo;

                      
                       context.caj_Caja_Movimiento_det.Add(address);
                       context.SaveChanges();
                       ++c;
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(List<caj_Caja_Movimiento_det_Info> Lista, ref string MensajeError)
       {
           try
           {
               int IdEmpresa = 0; decimal IdCbteCble = 0; int IdTipocbte = 0;
               foreach (var item in Lista)
               {
                   IdEmpresa = item.IdEmpresa;
                   IdCbteCble = item.IdCbteCble;
                   IdTipocbte = item.IdTipocbte;
               }
               List<caj_Caja_Movimiento_det_Info> listaAux = new List<caj_Caja_Movimiento_det_Info>();
               listaAux = Get_listDetalle(IdEmpresa, IdCbteCble, IdTipocbte, ref MensajeError);

               using (EntitiesCaja context = new EntitiesCaja())
               {
                   foreach (var item in listaAux)
                   {
                       var contact = context.caj_Caja_Movimiento_det.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.IdCbteCble == IdCbteCble && cot.IdTipocbte == IdTipocbte);
                       if (contact != null)
                       {
                           context.caj_Caja_Movimiento_det.Remove(contact);
                           context.SaveChanges();
                       }
                   }
               }
               return GrabarDB(Lista, ref MensajeError);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       

       public Boolean ModificarDB_IdOP_x_Det(int IdEmpresa_Caj , decimal IdCbteCble_Caj, int IdTipocbte_Caj ,int Secuencia_caj, int IdEmpresa_OP,decimal IdOrdenPago,  ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja context = new EntitiesCaja())
               {

                   var contact = context.caj_Caja_Movimiento_det.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa_Caj
                       && cot.IdCbteCble == IdCbteCble_Caj
                       && cot.IdTipocbte == IdTipocbte_Caj
                       && cot.Secuencia == Secuencia_caj);

                   if (contact != null)
                   {
                    contact.IdOrdenPago_OP = IdOrdenPago;
                    contact.IdEmpresa_OP = IdEmpresa_OP;
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(caj_Caja_Movimiento_det_Info info, ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja caja = new EntitiesCaja())
               {
                   var elim = caja.caj_Caja_Movimiento_det.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdCbteCble == info.IdCbteCble
                       && v.IdTipocbte == info.IdTipocbte);

                   if (elim != null)
                   {
                       caja.caj_Caja_Movimiento_det.Remove(elim);
                       caja.SaveChanges();
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
    }
}
