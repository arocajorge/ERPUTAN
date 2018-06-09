using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class vwba_Cbte_Ban_detallePagos_Data
    {
        string mensaje = "";

        public List<vwba_Cbte_Ban_detallePagos_Info> Get_List_Cbte_Ban_detallePagos(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
        {
            try
            {
                List<vwba_Cbte_Ban_detallePagos_Info> lM = new List<vwba_Cbte_Ban_detallePagos_Info>();
                EntitiesBanco b = new EntitiesBanco();

                var select_ = from T in b.vwba_Cbte_Ban_detallePagos
                              where T.IdEmpresa == IdEmpresa && T.IdCbteCble_cbte == IdCbteCble && T.IdTipocbte_cbte == IdTipocbte
                              select T;

                foreach (var item in select_)
                {
                    vwba_Cbte_Ban_detallePagos_Info dat_ = new vwba_Cbte_Ban_detallePagos_Info();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    dat_.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    dat_.co_fechaOg = item.co_fechaOg;
                    dat_.co_observacion = item.co_observacion;
                    dat_.co_valorpagar =item.co_valorpagar;
                    dat_.pg_MontoAplicado = item.pg_MontoAplicado;
                    dat_.IdProveedor = item.IdProveedor;
                    dat_.IdCbteCble_cbte = item.IdCbteCble_cbte;
                    dat_.IdTipocbte_cbte = item.IdTipocbte_cbte;
                    dat_.pg_saldoAnterior = item.pg_saldoAnterior;
                    dat_.IdCancelacion = item.IdCancelacion;
                    dat_.IdEmpresa_cbte = item.IdEmpresa_cbte;
                    dat_.NFactura = item.NFactura;
                    


                    lM.Add(dat_);
                }
                return (lM);
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

     
        public List<vwba_ordenGiroPendientes_Info> Get_List_PgCheque(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
        {
            try
            {
                 List<vwba_ordenGiroPendientes_Info> lM = new List<vwba_ordenGiroPendientes_Info>();
                    try
                    {
                
                        EntitiesBanco b = new EntitiesBanco();

                        var select_ = from T in b.vwba_Cbte_Ban_detallePagos
                                      where T.IdEmpresa == IdEmpresa && T.IdCbteCble_cbte == IdCbteCble && T.IdTipocbte_cbte == IdTipocbte
                                      select T;

                        foreach (var item in select_)
                        {
                            vwba_ordenGiroPendientes_Info dat_ = new vwba_ordenGiroPendientes_Info();

                            dat_.IdEmpresa = item.IdEmpresa;
                            dat_.IdProveedor = item.IdProveedor;
                            dat_.co_fechaOg = item.co_fechaOg;
                            dat_.co_observacion = item.co_observacion;
                            dat_.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                            dat_.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    
                            dat_.valorAPagar  = Convert.ToDouble(item.co_valorpagar);
                            dat_.TotalPagado = (double)item.co_valorpagar - ((double)item.pg_saldoAnterior - (double)item.pg_MontoAplicado);

                            dat_.saldo = item.pg_saldoAnterior - item.pg_MontoAplicado;
                            dat_.saldo2 = item.pg_saldoAnterior ;
                            dat_.valorAplicado = (decimal)item.pg_MontoAplicado;
                            dat_.Proveedor = item.Proveedor;
                            dat_.NFactura = item.NFactura;
                            dat_.CtaProveedor = item.CtaProveedor;
                            dat_.GiraCheque = item.GiraCheque;
                            dat_.IdCancelacion = item.IdCancelacion;
                            dat_.chek = true;

                            lM.Add(dat_);
                        }
                
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        lM = new List<vwba_ordenGiroPendientes_Info>();
                    }
                    return (lM);
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


        public vwba_Cbte_Ban_detallePagos_Data()
        {
            
        }
    }
}
