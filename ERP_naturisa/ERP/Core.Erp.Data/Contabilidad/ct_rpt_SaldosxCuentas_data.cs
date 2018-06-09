using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Contabilidad
{
    public class ct_rpt_SaldosxCuentas_data
    {
        string mensaje = "";
        public ct_rpt_SaldosxCuentas_data() { }


        public List<ct_rpt_SaldosxCuentas_Info> Get_list_rpt_SaldosxCuentas(int IdEmpresa, int AnioF, int IdPeriodo, List<string> TipoEstadoFinanciero, int NivelInicial)
        { 
            try
            {
                byte[] logo=null;
                string speriodo = "";

                List<ct_rpt_SaldosxCuentas_Info> listaSaldoxMovi = new List<ct_rpt_SaldosxCuentas_Info>();
                EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();


                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where C.IdEmpresa == IdEmpresa
                                    select C;                

                    foreach (var item2 in selectEmpresa)
                    {
                        logo = item2.em_logo;
                    }


                    var select = from A in OEsaldoxCuentas_Movi.vwct_SaldosxCuentas
                                 join per in OEsaldoxCuentas_Movi.vwct_periodo on new { A.IdEmpresa, A.IdPeriodo } equals new { per.IdEmpresa, per.IdPeriodo }
                                 where A.IdEmpresa == IdEmpresa
                                 && A.IdAnioF == AnioF
                                 && A.IdPeriodo == IdPeriodo
                                 && TipoEstadoFinanciero.Contains( A.gc_estado_financiero )
                                 && A.IdNivel <= NivelInicial
                                 select new
                                 {
                                     A.gc_estado_financiero,
                                     A.gc_GrupoCble,
                                     A.gc_Orden,
                                     A.IdAnioF,
                                     A.IdCtaCble,
                                     A.IdCtaCblePadre
                                     ,
                                     A.IdEmpresa,
                                     A.IdGrupoCble,
                                     A.IdNivel,
                                     A.IdPeriodo,
                                     A.pc_Cuenta,
                                     A.pc_Naturaleza,
                                     A.sc_credito_acum
                                     ,
                                     A.sc_credito_mes,
                                     A.sc_debito_acum,
                                     A.sc_debito_mes,
                                     A.sc_saldo_acum,
                                     A.sc_saldo_anterior,
                                     A.sc_saldoPeriodo
                                     ,
                                     A.SIdPeriodo,
                                     per.idMes,
                                     per.Nemonico,
                                     per.pe_mes,
                                     per.smes
                                 };

                foreach (var item in select)
                {
                    ct_rpt_SaldosxCuentas_Info osam = new ct_rpt_SaldosxCuentas_Info();
                    osam.IdAnioFiscal = item.IdAnioF;
                    osam.IdCtaCble = item.IdCtaCble.Trim();
                    osam.IdEmpresa = item.IdEmpresa;
                    osam.IdPeriodo = item.IdPeriodo;

                    osam.credito_acumulado = item.sc_credito_acum;
                    osam.debito_acumulado = item.sc_debito_acum;
                    

                    osam.credito_mes = item.sc_credito_mes;
                    osam.debito_mes = item.sc_debito_mes;

                    osam.saldo_acumulado = item.sc_saldo_acum;
                    osam.Saldo_anterior = item.sc_saldo_anterior;
                    osam.saldo_periodo = item.sc_saldoPeriodo;


                    osam.EstadoFinanciero = item.gc_estado_financiero;
                    osam.GrupoCble = item.gc_GrupoCble;
                    osam.IdCtaCblePadre = item.IdCtaCblePadre;
                    osam.Naturaleza = item.pc_Naturaleza;
                    osam.Nivel = item.IdNivel;
                    osam.NomCtaCble = item.pc_Cuenta;
                    osam.Orden = item.gc_Orden;
                    osam.SIdPeriodo = item.SIdPeriodo;
                    
                    osam.em_logo = logo;
                    osam.NomPeriodo = item.IdAnioF.ToString()+"-"+ item.smes;


                    listaSaldoxMovi.Add(osam);
                }

                return listaSaldoxMovi;

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

        public List<ct_rpt_SaldosxCuentas_Info> Get_list_rpt_SaldosxCuentas(int IdEmpresa, int AnioF, List<string> TipoEstadoFinanciero, int NivelInicial)
        {



            try
            {
                byte[] logo = null;
                string speriodo = "";



                List<ct_rpt_SaldosxCuentas_Info> listaSaldoxMovi = new List<ct_rpt_SaldosxCuentas_Info>();
                EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();


                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_empresa
                                    where C.IdEmpresa == IdEmpresa
                                    select C;

                foreach (var item2 in selectEmpresa)
                {
                    logo = item2.em_logo;
                }

                var select = from A in OEsaldoxCuentas_Movi.vwct_SaldosxCuentas
                             join per in OEsaldoxCuentas_Movi.vwct_periodo on new { A.IdEmpresa, A.IdPeriodo } equals new { per.IdEmpresa, per.IdPeriodo }
                             where A.IdEmpresa == IdEmpresa
                             && A.IdAnioF == AnioF
                             && TipoEstadoFinanciero.Contains(A.gc_estado_financiero)
                             && A.IdNivel <= NivelInicial
                             select new
                             {
                                 A.gc_estado_financiero,
                                 A.gc_GrupoCble,
                                 A.gc_Orden,
                                 A.IdAnioF,
                                 A.IdCtaCble,
                                 A.IdCtaCblePadre
                                 ,
                                 A.IdEmpresa,
                                 A.IdGrupoCble,
                                 A.IdNivel,
                                 A.IdPeriodo,
                                 A.pc_Cuenta,
                                 A.pc_Naturaleza,
                                 A.sc_credito_acum
                                 ,
                                 A.sc_credito_mes,
                                 A.sc_debito_acum,
                                 A.sc_debito_mes,
                                 A.sc_saldo_acum,
                                 A.sc_saldo_anterior,
                                 A.sc_saldoPeriodo
                                 ,
                                 A.SIdPeriodo,
                                 per.idMes,
                                 per.Nemonico,
                                 per.pe_mes,
                                 per.smes
                             };



                foreach (var item in select)
                {
                    ct_rpt_SaldosxCuentas_Info osam = new ct_rpt_SaldosxCuentas_Info();
                    osam.IdAnioFiscal = item.IdAnioF;
                    osam.IdCtaCble = item.IdCtaCble.Trim();
                    osam.IdEmpresa = item.IdEmpresa;
                    osam.IdPeriodo = item.IdPeriodo;

                    osam.credito_acumulado = item.sc_credito_acum;
                    osam.debito_acumulado = item.sc_debito_acum;


                    osam.credito_mes = item.sc_credito_mes;
                    osam.debito_mes = item.sc_debito_mes;

                    osam.saldo_acumulado = item.sc_saldo_acum;
                    osam.Saldo_anterior = item.sc_saldo_anterior;
                    osam.saldo_periodo = item.sc_saldoPeriodo;


                    osam.EstadoFinanciero = item.gc_estado_financiero;
                    osam.GrupoCble = item.gc_GrupoCble;
                    osam.IdCtaCblePadre = item.IdCtaCblePadre;
                    osam.Naturaleza = item.pc_Naturaleza;
                    osam.Nivel = item.IdNivel;
                    osam.NomCtaCble = item.pc_Cuenta;
                    osam.Orden = item.gc_Orden;
                    osam.SIdPeriodo = item.SIdPeriodo;

                    osam.em_logo = logo;
                    osam.NomPeriodo = item.IdAnioF.ToString() + "-" + item.smes;
                    listaSaldoxMovi.Add(osam);
                }
                return listaSaldoxMovi;
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
