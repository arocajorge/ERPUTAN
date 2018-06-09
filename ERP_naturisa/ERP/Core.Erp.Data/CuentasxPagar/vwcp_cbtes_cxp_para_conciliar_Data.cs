using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class vwcp_cbtes_cxp_para_conciliar_Data
    {


        public List<vwcp_cbtes_cxp_para_conciliar_Info> Get_List_cbtes_cxp_para_conciliar(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<vwcp_cbtes_cxp_para_conciliar_Info> Lst = new List<vwcp_cbtes_cxp_para_conciliar_Info>();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in cxp.vwcp_cbtes_cxp_para_conciliar
                                   where q.IdEmpresa == IdEmpresa &&
                                   q.Saldo > 0
                                   select q;

                    foreach (var item in consulta)
                    {
                        vwcp_cbtes_cxp_para_conciliar_Info info = new vwcp_cbtes_cxp_para_conciliar_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.Tipo = item.Tipo;
                        info.IdCbte_cxp = item.IdCbte_cxp;                        
                        info.pr_nombre = item.pr_nombre;
                        info.co_fechaOg = item.co_fechaOg;
                        info.Referencia = item.Referencia;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.co_observacion = item.co_observacion;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.Total_Cancelado = item.Total_Cancelado;
                        info.co_total = Convert.ToDouble(item.co_total);
                        //info.co_valorpagar = Convert.ToDouble(item.co_valorpagar);
                        info.Saldo = Convert.ToDouble(item.Saldo);
                        info.IdProveedor = item.IdProveedor;
                        info.IdPersona = item.IdPersona;
                        info.IdTipoPersona = item.IdTipoPersona;

                        info.Saldo_x_Pagar2 = Convert.ToDouble(item.Saldo);


                        info.IdCtaCble_CXP = item.IdCtaCble_CXP;
                        info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                        
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "",DateTime.Now.Date);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        
        public List<vwcp_cbtes_cxp_para_conciliar_Info> Get_List_cbtes_cxp_para_conciliar(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                List<vwcp_cbtes_cxp_para_conciliar_Info> Lst = new List<vwcp_cbtes_cxp_para_conciliar_Info>();
                //vwcp_cbtes_cxp_para_conciliar_Info info = new vwcp_cbtes_cxp_para_conciliar_Info();
                using (EntitiesCuentasxPagar cxp = new EntitiesCuentasxPagar())
                {
                    var CC = from q in cxp.vwcp_cbtes_cxp_para_conciliar_consulta
                             where q.IdEmpresa == IdEmpresa &&
                             q.IdConciliacion == IdConciliacion
                             select q;
                    
                    foreach (var item in CC)
                    {
                        vwcp_cbtes_cxp_para_conciliar_Info info = new vwcp_cbtes_cxp_para_conciliar_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.Tipo = item.Tipo;
                        info.IdCbte_cxp = item.IdCbte_cxp;                        
                        info.pr_nombre = item.pr_nombre;
                        info.co_fechaOg = item.co_fechaOg;                        
                        info.Referencia = item.Referencia;
                        info.co_FechaFactura = item.co_FechaFactura;
                        info.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info.co_observacion = item.co_observacion;
                        info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info.Total_Cancelado = item.Total_Cancelado;
                        info.co_total = Convert.ToDouble(item.co_total);
                        //info.co_valorpagar = Convert.ToDouble(item.co_valorpagar);
                        info.co_valorpagar = Convert.ToDouble(info.Total_Cancelado);
                        info.Saldo = Convert.ToDouble(item.Saldo);
                        info.IdProveedor = item.IdProveedor;
                        info.Saldo_x_Pagar2 = Convert.ToDouble(item.Saldo);


                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now.Date);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
