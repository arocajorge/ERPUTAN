using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_rpt_SaldoxCta_Data
    {
        string mensaje = "";

        public List<ct_rpt_SaldoxCta_Info> Get_list_rpt_SaldoxCta(int IdEmpresa)
        {
            try
            {
                List<ct_rpt_SaldoxCta_Info> Lista_SaldoxCta = new List<ct_rpt_SaldoxCta_Info>();
                EntitiesDBConta OESaldos = new EntitiesDBConta();
                var lista_item = from C in OESaldos.ct_rpt_SaldoxCta
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in lista_item)
                {
                    ct_rpt_SaldoxCta_Info info = new ct_rpt_SaldoxCta_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCtaCble = item.IdCtaCble;
                    info.sa_Creditos =  item.sa_Creditos;
                    info.sa_Debitos = item.sa_Debitos;
                    info.sa_SaldoInicial = item.sa_SaldoInicial;
                    info.sa_SaldoFinal = item.sa_SaldoFinal;
                    Lista_SaldoxCta.Add(info);
                }
                return (Lista_SaldoxCta);
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

        public Boolean GrabarDB(List<ct_rpt_SaldoxCta_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    GrabarDB(item);
                }
                return true;
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

        public Boolean GrabarDB(ct_rpt_SaldoxCta_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var address = new ct_rpt_SaldoxCta();
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdCtaCble = info.IdCtaCble;
                    address.sa_Creditos = info.sa_Creditos;
                    address.sa_Debitos = info.sa_Debitos;
                    address.sa_SaldoInicial = info.sa_SaldoInicial;
                    address.sa_SaldoFinal = info.sa_SaldoFinal;
                    //contact = address;
                    context.ct_rpt_SaldoxCta.Add(address);
                    context.SaveChanges();
                    context.Dispose();
                }
                return true;
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
      
        public Boolean EliminarDB(List<ct_rpt_SaldoxCta_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    EliminarDB(item);
                }
                return true;
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

        public Boolean EliminarDB(ct_rpt_SaldoxCta_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_rpt_SaldoxCta.FirstOrDefault(dinfo => dinfo.IdEmpresa == info.IdEmpresa && dinfo.IdCtaCble == info.IdCtaCble);
                    if (contact != null)
                    {
                        context.ct_rpt_SaldoxCta.Remove(contact);
                        context.SaveChanges();
                        context.Dispose();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_rpt_SaldoxCta_Info> Get_Saldo_Inicial_x_Cuenta(int IdEmpresa, List<string> listCuentas, DateTime FechaIni ,DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                List<ct_rpt_SaldoxCta_Info> listaSaldo_Ini_x_cuentas = new List<ct_rpt_SaldoxCta_Info>();

                using (EntitiesDBConta BaseConta = new EntitiesDBConta())
                {
                    var TdebitosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                       where Cb.dc_Valor > 0
                                       && Cb.cb_Fecha >= FechaIni && Cb.cb_Fecha<=FechaFin
                                       && listCuentas.Contains(Cb.IdCtaCble)
                                       && Cb.IdEmpresa==IdEmpresa
                                       orderby Cb.IdCtaCble
                                       group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                           into grouping
                                           select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p.dc_Valor) };


                    var TCreditosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                        where Cb.dc_Valor < 0
                                        && Cb.cb_Fecha >= FechaIni && Cb.cb_Fecha <= FechaFin
                                        && listCuentas.Contains(Cb.IdCtaCble)
                                        && Cb.IdEmpresa == IdEmpresa
                                        orderby Cb.IdCtaCble
                                        group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                            into grouping
                                            select new { grouping.Key, totalCreditoxCta = grouping.Sum(p => p.dc_Valor ) };


                    var SaldoIniTdebitosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                       where Cb.dc_Valor > 0
                                       && Cb.cb_Fecha < FechaIni
                                       && listCuentas.Contains(Cb.IdCtaCble)
                                       && Cb.IdEmpresa == IdEmpresa
                                       orderby Cb.IdCtaCble
                                       group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                           into grouping
                                           select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p.dc_Valor) };



                    var SaldoIniTCreditosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                        where Cb.dc_Valor < 0
                                        && Cb.cb_Fecha < FechaIni
                                        && listCuentas.Contains(Cb.IdCtaCble)
                                        && Cb.IdEmpresa == IdEmpresa
                                        orderby Cb.IdCtaCble
                                        group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                            into grouping
                                            select new { grouping.Key, totalCreditoxCta = grouping.Sum(p => p.dc_Valor ) };


                    var ListCuentas = from Cb in BaseConta.ct_plancta
                                      where Cb.IdEmpresa == IdEmpresa
                                      && listCuentas.Contains(Cb.IdCtaCble)
                                      select Cb;

                    double Debito_x_Periodo_cta = 0;
                    double credit_x_Periodo_cta = 0;
                    double SaldoIni_Debito_x_cta = 0;
                    double SaldoIni_credito_x_cta =0;

                    double dSaldoInicial = 0;
                    double dSaldo_x_Periodo = 0;

                    foreach (var itemCta in listCuentas)
                    {
                        
                        SaldoIni_Debito_x_cta =0;


                        if (TdebitosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta) != null)
                        {
                            Debito_x_Periodo_cta = TdebitosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totaldebidoxCta;
                        }

                        if (TCreditosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta) != null)
                        {
                            credit_x_Periodo_cta = TCreditosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totalCreditoxCta;
                        }

                        if (SaldoIniTdebitosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta) != null)
                        {
                            SaldoIni_Debito_x_cta = SaldoIniTdebitosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totaldebidoxCta;
                        }

                        if (SaldoIniTCreditosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta) != null)
                        {
                            SaldoIni_credito_x_cta = SaldoIniTCreditosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totalCreditoxCta;
                        }

                        var InfoCuenta = ListCuentas.FirstOrDefault(v => v.IdEmpresa == IdEmpresa && v.IdCtaCble == itemCta);

                        dSaldoInicial = 0;
                        dSaldo_x_Periodo = 0;
                        
                        ct_rpt_SaldoxCta_Info Info = new ct_rpt_SaldoxCta_Info();

                        Info.IdEmpresa = IdEmpresa;
                        Info.IdCtaCble = itemCta;

                        dSaldoInicial= (InfoCuenta.pc_Naturaleza == "D") ? SaldoIni_Debito_x_cta - Math.Abs(SaldoIni_credito_x_cta) :  Math.Abs(SaldoIni_credito_x_cta) - SaldoIni_Debito_x_cta ;
                        dSaldo_x_Periodo = (InfoCuenta.pc_Naturaleza == "D") ? Debito_x_Periodo_cta - Math.Abs(credit_x_Periodo_cta) : Math.Abs(credit_x_Periodo_cta) - Debito_x_Periodo_cta;

                        Info.sa_SaldoInicial = dSaldoInicial;
                        Info.sa_Debitos = Debito_x_Periodo_cta;
                        Info.sa_Creditos = credit_x_Periodo_cta;
                        Info.sa_SaldoFinal = dSaldoInicial + dSaldo_x_Periodo;
                        listaSaldo_Ini_x_cuentas.Add(Info);
                    }
                }
                return listaSaldo_Ini_x_cuentas;
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

        public ct_rpt_SaldoxCta_Data()
        {
            
        }
    }
}
