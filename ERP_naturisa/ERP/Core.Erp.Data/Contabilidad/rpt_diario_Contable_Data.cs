using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class rpt_diario_Contable_Data
    {
        string mensaje = "";
        public List<Vwct_rpt_comprobantecontable_Info> Get_list_rpt_comprobantecontable(int IdEmpresa, int IdTipoCbate, decimal IdCbteCble) 
        {
            try
            {
                List<Vwct_rpt_comprobantecontable_Info> lst = new List<Vwct_rpt_comprobantecontable_Info>();
                EntitiesDBConta Conta = new EntitiesDBConta();

                var Consulta = from var in Conta.vwct_ComprobanteContable
                               where var.IdEmpresa == IdEmpresa && var.IdTipoCbte == IdTipoCbate && var.IdCbteCble == IdCbteCble
                               select var;

                foreach (var item in Consulta)
                {
                    Vwct_rpt_comprobantecontable_Info obj = new Vwct_rpt_comprobantecontable_Info();
                    obj.IdEmpresa = item.IdEmpresa;
                    obj.IdTipoCbte = item.IdTipoCbte;
                    obj.IdCbteCble = item.IdCbteCble;
                    obj.CodCbteCble = item.CodCbteCble;
                    obj.IdPeriodo = item.IdPeriodo;
                    obj.cb_Fecha = item.cb_Fecha;
                    obj.cb_Valor = item.cb_Valor;
                    obj.cb_Observacion = item.cb_Observacion;
                    obj.cb_Estado = item.cb_Estado;
                    obj.cb_Anio = item.cb_Anio;
                    obj.cb_mes = item.cb_mes;
                    obj.secuencia = item.secuencia;
                    obj.IdCtaCble = item.IdCtaCble;
                    obj.dc_Valor = item.dc_Valor;
                    obj.dc_Observacion = item.dc_Observacion;
                    obj.pc_Cuenta = item.pc_Cuenta;
                    obj.Debito = item.debe;
                    obj.Credito = item.Cred;
                    obj.tc_TipoCbte = item.tc_TipoCbte;
                    lst.Add(obj);
                }
               
                return lst;
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
