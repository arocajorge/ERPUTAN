using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
   public class vwcp_Anticipos_para_Conciliar_Data
    {
       public List<vwcp_Anticipos_para_Conciliar_Info> Get_list_Anticipos_para_Conciliar(int IdEmpresa, string tipo, DateTime cb_fechaDesde,
    DateTime cb_fechaHasta, ref string mensaje)
       {
           try
           {
               List<vwcp_Anticipos_para_Conciliar_Info> Lst = new List<vwcp_Anticipos_para_Conciliar_Info>();
               using (EntitiesCuentasxPagar OEnti_cxp = new EntitiesCuentasxPagar())
               {
                   var consulta = from q in OEnti_cxp.vwcp_Anticipos_para_Conciliar
                                  where q.IdEmpresaOP == IdEmpresa
                                  && q.tipo.Contains(tipo)
                                  && q.Fecha >= cb_fechaDesde
                                  && q.Fecha <= cb_fechaHasta
                                  && q.valor_saldo_cbte> 0
                                  select q;

                   foreach (var item in consulta)
                   {
                       vwcp_Anticipos_para_Conciliar_Info info = new vwcp_Anticipos_para_Conciliar_Info();
                       info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                       info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                       info.IdTipocbte_cxp = item.IdTipoCbte_cxp;
                       info.Fecha = item.Fecha;
                       info.Observacion = item.Observacion;
                       info.referencia = item.referencia;
                       info.tc_TipoCbte = item.tc_TipoCbte;
                       info.Valor_cbte = item.Valor_cbte;
                       info.Valor_cancelado = item.Valor_cancelado;
                       info.valor_Saldo_cbte = item.valor_saldo_cbte;
                       info.tipo = item.tipo;
                       info.IdEmpresaOP = item.IdEmpresaOP;
                       info.IdOrdenPagoOP = item.IdOrdenPagoOP;
                       info.SecuenciaOP = item.SecuenciaOP;

                       info.IdCtaCble = item.IdCtaCble;
                       info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                       info.Beneficiario = item.Beneficiario;
                       info.IdProveedor = item.IdProveedor;
                       info.IdPersona = item.IdPersona;
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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
