using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{

    public class vwba_ordenGiroPendientes_Data
    {
        string mensaje = "";

        public List<vwba_ordenGiroPendientes_Info> Get_List_ordenGiroPendientes(int IdEmpresa)
        {
            try
            {
                List<vwba_ordenGiroPendientes_Info> lM = new List<vwba_ordenGiroPendientes_Info>();
                EntitiesBanco b = new EntitiesBanco();

                var select_ = from T in b.vwba_ordenGiroPendientes                               
                              where T.IdEmpresa == IdEmpresa  && T.saldo>0.0 
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
                    dat_.valorAPagar = Convert.ToDouble(item.valorAPagar);
                    dat_.TotalPagado = item.TotalPagado;
                    dat_.saldo = item.saldo;
                    dat_.saldo2 = item.saldo;
                    dat_.valorAplicado = 0;
                    dat_.NFactura = item.NFactura;
                    dat_.Proveedor = item.Proveedor;
                    dat_.CtaProveedor=item.CtaProveedor;
                    dat_.GiraCheque = item.GiraCheque;


                    dat_.chek = false;
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

        public List<vwba_ordenGiroPendientes_Info> Get_List_ordenGiroPendientes(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<vwba_ordenGiroPendientes_Info> lM = new List<vwba_ordenGiroPendientes_Info>();
                EntitiesBanco b = new EntitiesBanco();

                var select_ = from T in b.vwba_ordenGiroPendientes
                              where T.IdEmpresa == IdEmpresa && T.IdProveedor==IdProveedor && T.saldo > 0.0
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
                    dat_.valorAPagar = item.valorAPagar;
                    dat_.TotalPagado = item.TotalPagado;
                    dat_.saldo = item.saldo;
                    dat_.saldo2 = item.saldo;
                    dat_.valorAplicado = 0;
                    dat_.NFactura = item.NFactura;
                    dat_.Proveedor = item.Proveedor;
                   
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

        public vwba_ordenGiroPendientes_Data()
        {
           
        }
    }
}
