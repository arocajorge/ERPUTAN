using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_saldoxCuentas_Movi_Data
    {
        string mensaje = "";
        
        ct_saldoxCuentas_Movi_Info saldoxCuentas_MoviLista = new ct_saldoxCuentas_Movi_Info();

        public List<ct_saldoxCuentas_Movi_Info> Get_list_saldoxCuentas_Movi_x_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
        {
            try
            {
                List<ct_saldoxCuentas_Movi_Info> listaSaldoxMovi = new List<ct_saldoxCuentas_Movi_Info>();
                EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();

                var select = from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas_Movi
                             where A.IdEmpresa == IdEmpresa
                             && A.IdAnioF == AnioF
                             && A.IdPeriodo == IdPeriodo
                             select A;

                foreach (var item in select)
                {
                    ct_saldoxCuentas_Movi_Info osam = new ct_saldoxCuentas_Movi_Info();
                    osam.IdAnioF = item.IdAnioF;
                    osam.IdCtaCble = item.IdCtaCble.Trim();
                    osam.IdCtaCblePadre = item.IdCtaCblePadre.Trim();
                    osam.IdEmpresa = item.IdEmpresa;
                    osam.IdPeriodo = item.IdPeriodo;
                    osam.sc_credito_mes = item.sc_credito_mes;
                    osam.sc_debito_mes = item.sc_debito_mes;
                    osam.sc_saldo_acum = item.sc_saldo_acum;
                    osam.sc_saldo_anterior = item.sc_saldo_anterior;
                    osam.sc_saldo_mes = item.sc_saldo_mes;
                    listaSaldoxMovi.Add(osam);
                }
                List<ct_Plancta_Info> listPlanCtas = new List<ct_Plancta_Info>();
                ct_Plancta_Data plB = new ct_Plancta_Data();
                listPlanCtas = plB.Get_List_Plancta(IdEmpresa, ref mensaje);

                List<ct_Grupocble_Info> listGrupoCble = new List<ct_Grupocble_Info>();
                ct_Grupocble_Data GCD = new ct_Grupocble_Data();
                listGrupoCble = GCD.Get_list_Grupocble();

                var ListasSaldosxCtasMovi = from Lctas in listaSaldoxMovi
                                            join pl in listPlanCtas on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { pl.IdEmpresa, pl.IdCtaCble }
                                            join grc in listGrupoCble on new { pl.IdGrupoCble } equals new { grc.IdGrupoCble }

                                            select Lctas;
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
                
        public List<ct_saldoxCuentas_Movi_Info> Get_list_saldoxCuentas_Movi_SinCtasIngEgrex_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
        {
            try
            {
                List<ct_saldoxCuentas_Movi_Info> listaSaldoxMovi = new List<ct_saldoxCuentas_Movi_Info>();
                List<ct_saldoxCuentas_Movi_Info> listaSaldoxMoviResult = new List<ct_saldoxCuentas_Movi_Info>();

                EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();

                var select = from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas_Movi
                             where A.IdEmpresa == IdEmpresa
                             && A.IdAnioF == AnioF
                             && A.IdPeriodo == IdPeriodo
                             select A;

                foreach (var item in select)
                {
                    ct_saldoxCuentas_Movi_Info osam = new ct_saldoxCuentas_Movi_Info();
                    osam.IdAnioF = item.IdAnioF;
                    osam.IdCtaCble = item.IdCtaCble.Trim();
                    osam.IdCtaCblePadre = item.IdCtaCblePadre.Trim();
                    osam.IdEmpresa = item.IdEmpresa;
                    osam.IdPeriodo = item.IdPeriodo;
                    osam.sc_credito_mes = item.sc_credito_mes;
                    osam.sc_debito_mes = item.sc_debito_mes;
                    osam.sc_saldo_acum = item.sc_saldo_acum;
                    osam.sc_saldo_anterior = item.sc_saldo_anterior;
                    osam.sc_saldo_mes = item.sc_saldo_mes;

                    listaSaldoxMovi.Add(osam);
                }

                List<ct_Plancta_Info> listPlanCtas = new List<ct_Plancta_Info>();
                ct_Plancta_Data plB = new ct_Plancta_Data();
                listPlanCtas = plB.Get_List_Plancta(IdEmpresa, ref mensaje);

                List<ct_Grupocble_Info> listGrupoCble = new List<ct_Grupocble_Info>();
                ct_Grupocble_Data GCD = new ct_Grupocble_Data();
                listGrupoCble = GCD.Get_list_Grupocble();

                var listaSaldoxMoviResultAux = from Lctas in listaSaldoxMovi
                                               join pl in listPlanCtas on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { pl.IdEmpresa, pl.IdCtaCble }
                                               join grc in listGrupoCble on new { pl.IdGrupoCble } equals new { grc.IdGrupoCble }
                                               where grc.gc_estado_financiero.Contains("ER")
                                               select Lctas;

                foreach (var item in listaSaldoxMoviResultAux)
                {
                    ct_saldoxCuentas_Movi_Info osam = new ct_saldoxCuentas_Movi_Info();
                    osam.IdAnioF = item.IdAnioF;
                    osam.IdCtaCble = item.IdCtaCble.Trim();
                    osam.IdCtaCblePadre = item.IdCtaCblePadre.Trim();
                    osam.IdEmpresa = item.IdEmpresa;
                    osam.IdPeriodo = item.IdPeriodo;
                    osam.sc_credito_mes = item.sc_credito_mes;
                    osam.sc_debito_mes = item.sc_debito_mes;
                    osam.sc_saldo_acum = item.sc_saldo_acum;
                    osam.sc_saldo_anterior = item.sc_saldo_anterior;
                    osam.sc_saldo_mes = item.sc_saldo_mes;
                    listaSaldoxMoviResult.Add(osam);
                }
                return listaSaldoxMoviResult;
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

        public Boolean Get_ExisteRegistros_SaldoMensualxCta(int IdEmpresa, int AnioF, int IdPeriodo, String IdCtaCble)
        {
            try
            {
                Boolean existeReg;

                existeReg = false;
                List<ct_saldoxCuentas_Movi_Info> lM = new List<ct_saldoxCuentas_Movi_Info>();
                EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();


                var select = from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas_Movi
                             where A.IdEmpresa == IdEmpresa
                             && A.IdAnioF == AnioF
                             && A.IdCtaCble == IdCtaCble
                             && A.IdPeriodo == IdPeriodo
                             select A;

                foreach (var item in select)
                {
                    existeReg = true;
                    break;
                }

                return existeReg;

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
        
        public Boolean EliminarDB_RegSaldoxCuentas_Movi(ct_saldoxCuentas_Movi_Info ItemSaldoActualizado)
        {

            try
            {

                using (EntitiesDBConta context = new EntitiesDBConta())
                {

                    var contact = context.ct_saldoxCuentas_Movi.First(dinfo => dinfo.IdEmpresa == ItemSaldoActualizado.IdEmpresa
                         && dinfo.IdPeriodo == ItemSaldoActualizado.IdPeriodo && dinfo.IdCtaCble == ItemSaldoActualizado.IdCtaCble);

                    context.ct_saldoxCuentas_Movi.Remove(contact);
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


        public Boolean EliminarDB_Registros_despues_del_periodo(int idempresa, int idPeriodo,ref string msg)
        {
            try
            {
                using (EntitiesDBConta Entity = new EntitiesDBConta())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete ct_saldoxCuentas_Movi where IdEmpresa = " + idempresa
                        + " and IdPeriodo >= " + idPeriodo);
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
                msg = mensaje;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean EliminarDB_SaldoxCuentas_Movi(List<ct_saldoxCuentas_Movi_Info> ListaSaldoActualizados)
        {
            try
            {
                int idempresa = 0;
                int idPeriodo = 0;

                foreach (var item in ListaSaldoActualizados)
                {
                    EliminarDB_RegSaldoxCuentas_Movi(item);
                    idempresa = item.IdEmpresa;
                    idPeriodo = item.IdPeriodo;
                }


                using (EntitiesDBConta Entity = new EntitiesDBConta())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete ct_saldoxCuentas_Movi_tmp where IdEmpresa = " + idempresa
                        + " and IdPeriodo >= " + idPeriodo);
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

        public Boolean GrabarDB(List<ct_saldoxCuentas_Movi_Info> ListSaldoMovi)
        {
            try
            {
                if (ListSaldoMovi.ToList().Count > 0)
                {

                    using (EntitiesDBConta context = new EntitiesDBConta())
                    {

                        foreach (var item in ListSaldoMovi)
                        {

                            var address = new ct_saldoxCuentas_Movi_tmp();
                            address.IdEmpresa = item.IdEmpresa;
                            address.IdPeriodo = item.IdPeriodo;
                            address.IdAnioF = item.IdAnioF;
                            address.IdCtaCble = item.IdCtaCble;
                            address.IdCtaCblePadre = item.IdCtaCblePadre;
                            address.sc_credito_mes = Math.Round(item.sc_credito_mes, 2);
                            address.sc_debito_mes = Math.Round(item.sc_debito_mes, 2);
                            address.sc_saldo_acum = Math.Round(item.sc_saldo_acum, 2);
                            address.sc_saldo_anterior = Math.Round(item.sc_saldo_anterior, 2);
                            context.ct_saldoxCuentas_Movi_tmp.Add(address);
                            context.SaveChanges();
                        }
                       
                        context.Dispose();
                    }
                    using (EntitiesDBConta context = new EntitiesDBConta())// crea una direccionn al entities
                    {

                        foreach (var item in ListSaldoMovi)
                        {

                            var address = new ct_saldoxCuentas_Movi();
                            address.IdEmpresa = item.IdEmpresa;
                            address.IdPeriodo = item.IdPeriodo;
                            address.IdAnioF = item.IdAnioF;
                            address.IdCtaCble = item.IdCtaCble;
                            address.IdCtaCblePadre = item.IdCtaCblePadre;
                            address.sc_credito_mes = Math.Round(item.sc_credito_mes, 2);
                            address.sc_debito_mes = Math.Round(item.sc_debito_mes, 2);
                            address.sc_saldo_acum = Math.Round(item.sc_saldo_acum, 2);
                            address.sc_saldo_anterior = Math.Round(item.sc_saldo_anterior, 2);
                            address.sc_saldo_mes = Math.Round(item.sc_saldo_mes, 2);
                            //contact = address;
                            context.ct_saldoxCuentas_Movi.Add(address);
                            context.SaveChanges();
                        }
                       
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

        public ct_saldoxCuentas_Movi_Data()
        {
            
        }
    }
}

