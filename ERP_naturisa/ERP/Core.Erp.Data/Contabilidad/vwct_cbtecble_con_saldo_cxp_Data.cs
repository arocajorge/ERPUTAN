using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class vwct_cbtecble_con_saldo_cxp_Data
    {
          public List<vwct_cbtecble_con_saldo_cxp_Info> Get_list_cbtecble_con_saldo_cxp(int IdEmpresa, string tipo, DateTime cb_fechaDesde,
            DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                List<vwct_cbtecble_con_saldo_cxp_Info> Lst = new List<vwct_cbtecble_con_saldo_cxp_Info>();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var consulta = from q in conta.vwct_cbtecble_con_saldo_cxp
                                   where q.IdEmpresa == IdEmpresa
                                   && q.Tipo.Contains(tipo)
                                   && q.cb_Fecha >= cb_fechaDesde
                                   && q.cb_Fecha <= cb_fechaHasta
                                   && q.valor_Saldo_cbte>0
                                   select q;

                    foreach (var item in consulta)
                    {
                        vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
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
                        info.tipo = item.Tipo;
                        info.IdEmpresaOP = item.IdEmpresaOP;
                        info.IdOrdenPagoOP = item.IdOrdenPagoOP;
                        info.SecuenciaOP = item.SecuenciaOP;

                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        info.Beneficiario = item.Beneficiario;
                        info.IdBeneficiario = item.IdBeneficiario;
                        Lst.Add(info);
                    }
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

        public vwct_cbtecble_con_saldo_cxp_Info Get_Info_cbtecble_con_saldo_cxp(int IdEmpresa_op, decimal IdOrdenPago_op ,string tipo, ref string mensaje)
        {
            try
            {
                vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var item = conta.vwct_cbtecble_con_saldo_cxp.FirstOrDefault(q => q.IdEmpresaOP == IdEmpresa_op && q.IdOrdenPagoOP == IdOrdenPago_op && q.Tipo == tipo);
                                             
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
                        info.tipo = item.Tipo;
                        info.IdEmpresaOP = item.IdEmpresaOP;
                        info.IdOrdenPagoOP = item.IdOrdenPagoOP;
                        info.SecuenciaOP = item.SecuenciaOP;

                        info.IdCtaCble = item.IdCtaCble;
                        info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        info.Beneficiario = item.Beneficiario;
                        info.IdBeneficiario = item.IdBeneficiario;
                                           
                }
                return info;
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
