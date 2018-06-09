using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class vwcxc_cobros_x_cheque_deposito_Data
    {
        string mensaje = "";
        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositar(int IdEmpresa)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> lM = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                EntitiesCuentas_x_Cobrar db = new EntitiesCuentas_x_Cobrar();

                var select_ = (from T in db.vwcxc_cobros_x_cheque_deposito
                               where T.IdEmpresa == IdEmpresa 
                               && T.Banco_deposito == null
                               select T
                               );

                foreach (var item in select_)
                {
                    vwcxc_cobros_x_cheque_deposito_Info dat = new vwcxc_cobros_x_cheque_deposito_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.Sucursal = item.Sucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCliente = item.IdCliente;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.TipoCobro = item.TipoCobro;
                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    dat.Fecha = item.Fecha;
                    dat.FechaCobro = item.FechaCobro;
                    dat.Banco_del_cheq = item.Banco_del_cheq;
                    dat.Cuenta = item.Cuenta;
                    dat.Num_Cheq = item.Num_Cheq;
                    dat.TotalCobro = item.TotalCobro;
                    dat.mcj_IdCbteCble = item.mcj_IdCbteCble;
                    dat.mcj_IdTipocbte = item.mcj_IdTipocbte;
                    dat.IdCaja = item.IdCaja;
                    dat.CodCaja = item.CodCaja;
                    dat.ba_IdCbteCble = item.ba_IdCbteCble;
                    dat.ba_IdTipocbte = item.ba_IdTipocbte;
                    dat.Fecha_dep = item.FechaCobro;
                    dat.IdBanco_dep = item.IdBanco_dep;
                    dat.Banco_deposito = item.Banco_deposito;
                    dat.Cliente = item.Cliente;

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositados(int IdEmpresa)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> lM = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                EntitiesCuentas_x_Cobrar db = new EntitiesCuentas_x_Cobrar();

                var select_ = (from T in db.vwcxc_cobros_x_cheque_deposito
                               where T.IdEmpresa == IdEmpresa 
                               && T.Banco_deposito != null
                               select T
                               );

                foreach (var item in select_)
                {
                    vwcxc_cobros_x_cheque_deposito_Info dat = new vwcxc_cobros_x_cheque_deposito_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdSucursal = item.IdSucursal;
                    dat.Sucursal = item.Sucursal;
                    dat.IdCobro = item.IdCobro;
                    dat.IdCliente = item.IdCliente;
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.TipoCobro = item.TipoCobro;
                    dat.IdEstadoCobro = item.IdEstadoCobro;
                    dat.Fecha = item.Fecha;
                    dat.FechaCobro = item.FechaCobro;
                    dat.Banco_del_cheq = item.Banco_del_cheq;
                    dat.Cuenta = item.Cuenta;
                    dat.Num_Cheq = item.Num_Cheq;
                    dat.TotalCobro = item.TotalCobro;
                    dat.mcj_IdCbteCble = item.mcj_IdCbteCble;
                    dat.mcj_IdTipocbte = item.mcj_IdTipocbte;
                    dat.IdCaja = item.IdCaja;
                    dat.CodCaja = item.CodCaja;
                    dat.ba_IdCbteCble = item.ba_IdCbteCble;
                    dat.ba_IdTipocbte = item.ba_IdTipocbte;
                    dat.Fecha_dep = item.FechaCobro;
                    dat.IdBanco_dep = item.IdBanco_dep;
                    dat.Banco_deposito = item.Banco_deposito;
                    dat.Cliente = item.Cliente;

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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcxc_cobros_x_cheque_deposito_Info> Get_List_cobros_x_cheque_deposito_x_Depositar(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin, string IdCobro, int IdSucursal)
        {
            try
            {
                List<vwcxc_cobros_x_cheque_deposito_Info> lM = new List<vwcxc_cobros_x_cheque_deposito_Info>();
                EntitiesCuentas_x_Cobrar db = new EntitiesCuentas_x_Cobrar();
                
                if (IdSucursal == 0 && IdSucursal==null)
                {
                    var select_ = (from T in db.vwcxc_cobros_x_cheque_deposito
                                   where T.IdEmpresa == IdEmpresa 
                                   && T.Banco_deposito == null 
                                   && T.Fecha > FechaInicio && T.Fecha < FechaFin 
                                   && T.IdEstadoCobro == IdCobro
                                   select T
                                   );

                    foreach (var item in select_)
                    {
                        vwcxc_cobros_x_cheque_deposito_Info dat = new vwcxc_cobros_x_cheque_deposito_Info();

                        dat.IdEmpresa = item.IdEmpresa;
                        dat.IdSucursal = item.IdSucursal;
                        dat.Sucursal = item.Sucursal;
                        dat.IdCobro = item.IdCobro;
                        dat.IdCliente = item.IdCliente;
                        dat.IdCobro_tipo = item.IdCobro_tipo;
                        dat.TipoCobro = item.TipoCobro;
                        dat.IdEstadoCobro = item.IdEstadoCobro;
                        dat.Fecha = item.Fecha;
                        dat.FechaCobro = item.FechaCobro;
                        dat.Banco_del_cheq = item.Banco_del_cheq;
                        dat.Cuenta = item.Cuenta;
                        dat.Num_Cheq = item.Num_Cheq;
                        dat.TotalCobro = item.TotalCobro;
                        dat.mcj_IdCbteCble = item.mcj_IdCbteCble;
                        dat.mcj_IdTipocbte = item.mcj_IdTipocbte;
                        dat.IdCaja = item.IdCaja;
                        dat.CodCaja = item.CodCaja;
                        dat.ba_IdCbteCble = item.ba_IdCbteCble;
                        dat.ba_IdTipocbte = item.ba_IdTipocbte;
                        dat.Fecha_dep = item.FechaCobro;
                        dat.IdBanco_dep = item.IdBanco_dep;
                        dat.Banco_deposito = item.Banco_deposito;
                        dat.Cliente = item.Cliente;

                        lM.Add(dat);

                    }
                }
                else
                {

                    var select_ = (from T in db.vwcxc_cobros_x_cheque_deposito
                                   where T.IdEmpresa == IdEmpresa 
                                   &&  (T.FechaCobro  >= FechaInicio && T.FechaCobro  <= FechaFin )
                                   && T.IdEstadoCobro == IdCobro 
                                   && T.IdSucursal == IdSucursal
                                   select T
                                   );

                    foreach (var item in select_)
                    {
                        vwcxc_cobros_x_cheque_deposito_Info dat = new vwcxc_cobros_x_cheque_deposito_Info();

                        dat.IdEmpresa = item.IdEmpresa;
                        dat.IdSucursal = item.IdSucursal;
                        dat.Sucursal = item.Sucursal;
                        dat.IdCobro = item.IdCobro;
                        dat.IdCliente = item.IdCliente;
                        dat.IdCobro_tipo = item.IdCobro_tipo;
                        dat.TipoCobro = item.TipoCobro;
                        dat.IdEstadoCobro = item.IdEstadoCobro;
                        dat.Fecha = item.Fecha;
                        dat.FechaCobro = item.FechaCobro;
                        dat.Banco_del_cheq = item.Banco_del_cheq;
                        dat.Cuenta = item.Cuenta;
                        dat.Num_Cheq = item.Num_Cheq;
                        dat.TotalCobro = item.TotalCobro;
                        dat.mcj_IdCbteCble = item.mcj_IdCbteCble;
                        dat.mcj_IdTipocbte = item.mcj_IdTipocbte;
                        dat.IdCaja = item.IdCaja;
                        dat.CodCaja = item.CodCaja;
                        dat.ba_IdCbteCble = item.ba_IdCbteCble;
                        dat.ba_IdTipocbte = item.ba_IdTipocbte;
                        dat.Fecha_dep = item.FechaCobro;
                        dat.IdBanco_dep = item.IdBanco_dep;
                        dat.Banco_deposito = item.Banco_deposito;
                        dat.Cliente = item.Cliente;

                        lM.Add(dat);

                    }
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
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
