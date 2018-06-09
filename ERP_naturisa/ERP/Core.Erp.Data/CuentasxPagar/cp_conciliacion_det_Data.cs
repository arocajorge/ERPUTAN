using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_conciliacion_det_Data
    {
        string mensaje = "";
        public List<cp_conciliacion_det_Info> Get_List_conciliacion_det(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<cp_conciliacion_det_Info> Lst = new List<cp_conciliacion_det_Info>();
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var Consulta = from q in CxP.cp_conciliacion_det
                                   where q.IdEmpresa == IdEmpresa &&
                                   q.IdConciliacion == IdConciliacion
                                   select q;

                    foreach (var item in Consulta)
                    {
                        cp_conciliacion_det_Info Info = new cp_conciliacion_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdConciliacion = item.IdConciliacion;
                        Info.Secuencia = item.Secuencia;
                        Info.MontoAplicado = item.MontoAplicado;
                        Info.SaldoAnterior = item.SaldoAnterior;
                        Info.SaldoActual = item.SaldoActual;
                        Info.Observacion = item.Observacion;                       
                        Info.fechaTransaccion = item.fechaTransaccion;
                        Lst.Add(Info);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<cp_conciliacion_det_Info> Info) {
            try
            {
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    foreach (var item in Info)
                    {
                        cp_conciliacion_det Data = new cp_conciliacion_det();
                        Data.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        Data.IdConciliacion = item.IdConciliacion;
                        Data.Secuencia = item.Secuencia;
                        Data.IdEmpresa_op = item.IdEmpresa_op;
                        Data.IdOrdenPago_op = item.IdOrdenPago_op;
                        Data.Secuencia_op = item.Secuencia_op;
                        Data.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        Data.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        Data.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        Data.IdEmpresa_pago = item.IdEmpresa_pago;
                        Data.IdTipoCbte_pago = Convert.ToInt32(item.IdTipoCbte_pago);
                        Data.IdCbteCble_pago = Convert.ToDecimal(item.IdCbteCble_pago);
                        Data.MontoAplicado = item.MontoAplicado;
                        Data.SaldoAnterior = item.SaldoAnterior;
                        Data.SaldoActual = item.SaldoActual;
                        Data.Observacion = item.Observacion;                  
                        Data.fechaTransaccion = item.fechaTransaccion;
                        CxP.cp_conciliacion_det.Add(Data);
                        CxP.SaveChanges();
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

        public List<cp_conciliacion_det_Info> Get_List_Conciliacion_x_cbte_cble(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<cp_conciliacion_det_Info> Lst = new List<cp_conciliacion_det_Info>();
                using (EntitiesDBConta CxP = new EntitiesDBConta())
                {
                    var consulta = from q in CxP.vwct_cbtecble_con_saldo_cxp_consulta
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdConciliacion == IdConciliacion                                 
                                   select q;

                    foreach (var item in consulta)
                    {
                        cp_conciliacion_det_Info info = new cp_conciliacion_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCbteCble = item.IdCbteCble;
                        info.IdTipocbte = item.IdTipocbte;
                        info.cb_Fecha = item.cb_Fecha;
                        info.cb_Observacion = item.cb_Observacion;
                        info.referencia = item.referencia;
                        info.tc_TipoCbte = item.tc_TipoCbte;
                        info.Valor_cbte = item.Valor_cbte;                        
                        info.Valor_cancelado_cbte = item.Valor_cancelado_cbte;                        
                        info.valor_Saldo_cbte = item.valor_Saldo_cbte;
                        info.Tipo = item.Tipo;

                        info.Beneficiario = item.Beneficiario;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
