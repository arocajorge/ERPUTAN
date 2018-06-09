using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.CuentasxPagar
{
   public class vwcp_orden_pago_con_cancelacion_para_conciliacion_Data
    {
       public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, ref string mensaje)
       {
           try
           {
               List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Lst = new List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info>();
               using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
               {
                   var consulta = from q in cxp.vwcp_orden_pago_con_cancelacion_para_conciliacion
                                  where q.IdEmpresa == IdEmpresa &&
                                  q.Saldo_x_Pagar_OP > 0
                                  select q;

                   foreach (var item in consulta)
                   {
                       vwcp_orden_pago_con_cancelacion_para_conciliacion_Info info = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdTipo_op = item.IdTipo_op;
                       info.Referencia = item.Referencia;
                       info.IdOrdenPago = Convert.ToDecimal(item.IdOrdenPago);
                       info.Secuencia_OP =Convert.ToInt32(item.Secuencia_OP);
                       info.IdTipoPersona = item.IdTipoPersona;
                       info.IdPersona = item.IdPersona;
                       info.IdEntidad = item.IdEntidad;
                       info.Fecha_OP = item.Fecha_OP;
                       info.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                       info.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                       info.Observacion = item.Observacion;
                       info.Nom_Beneficiario = item.Nom_Beneficiario_2;
                       info.Girar_Cheque_a = item.Girar_Cheque_a;
                       info.Valor_a_pagar = item.Valor_a_pagar;
                       info.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                       info.Total_cancelado_OP = item.Total_cancelado_OP;
                       info.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                       info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       info.IdFormaPago = item.IdFormaPago;
                       info.Fecha_Pago = Convert.ToDateTime(item.Fecha_Pago);
                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.IdSubCentro_Costo = item.IdSubCentro_Costo;
                       info.Cbte_cxp = item.Cbte_cxp;
                       //info.Valor_aplicado = item.Valor_aplicado;
                       //info.IdAprobacion = item.IdAprobacion;
                       info.Estado = item.Estado;
                       info.Saldo_x_Pagar2 = item.Saldo_x_Pagar_OP;//DEREK MEJIA 07/03/2014

                       info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                       info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                       info.IdCbteCble_cxp = item.IdCbteCble_cxp;

                       Lst.Add(info);
                   }
               }
               return Lst;
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


       public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
       {
           try
           {
               List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Lst = new List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info>();
               using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
               {
                   var CC = from q in cxp.vwcp_conciliacion_x_orden_pago
                            where q.IdEmpresa == IdEmpresa &&
                            q.IdConciliacion == IdConciliacion
                            select q;

                   foreach (var item in CC)
                   {
                       vwcp_orden_pago_con_cancelacion_para_conciliacion_Info info = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdTipo_op = item.IdTipo_op;
                       info.Referencia = item.Referencia;
                       info.IdOrdenPago = Convert.ToDecimal(item.IdOrdenPago);
                       info.Secuencia_OP = Convert.ToInt32(item.Secuencia_OP);
                       info.IdTipoPersona = item.IdTipoPersona;
                       info.IdPersona = item.IdPersona;
                       info.IdEntidad = item.IdEntidad;
                       info.Fecha_OP = item.Fecha_OP;
                       info.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                       info.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                       info.Observacion = item.Observacion;
                       info.Nom_Beneficiario = item.Nom_Beneficiario_2;
                       info.Girar_Cheque_a = item.Girar_Cheque_a;
                       info.Valor_a_pagar = item.Valor_a_pagar;
                       info.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                       info.Total_cancelado_OP = item.Total_cancelado_OP;

                       info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       info.IdFormaPago = item.IdFormaPago;
                       info.Fecha_Pago = Convert.ToDateTime(item.Fecha_Pago);
                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.IdSubCentro_Costo = item.IdSubCentro_Costo;
                       info.Cbte_cxp = item.Cbte_cxp;
                       info.Valor_aplicado = item.MontoAplicado;
                       info.Saldo_x_Pagar_OP = item.SaldoActual;
                       info.Saldo_x_Pagar2 = item.SaldoAnterior;

                       //info.IdAprobacion = item.IdAprobacion;
                       info.Estado = item.Estado;



                       Lst.Add(info);
                   }
               }
               return Lst;
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
    }
}
