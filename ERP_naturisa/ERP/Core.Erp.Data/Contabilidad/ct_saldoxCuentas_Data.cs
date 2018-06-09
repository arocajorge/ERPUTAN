using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{

   public  class ct_saldoxCuentas_Data
    {
       string mensaje = "";

       public List<ct_SaldoxCuentas_Info> Get_list_SaldoxCuentas_x_Periodo_ParaEliminar(int IdEmpresa, int AnioF, int IdPeriodo)
       {
           try
           {
               List<ct_SaldoxCuentas_Info> listaSaldoxMovi = new List<ct_SaldoxCuentas_Info>();
               EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();
               
               var select= from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas 
                            where A.IdEmpresa == IdEmpresa
                            && A.IdAnioF >= AnioF
                            && A.IdPeriodo >= IdPeriodo
                            select A;

               foreach (var item in select)
               {
                   ct_SaldoxCuentas_Info osam = new ct_SaldoxCuentas_Info();
                   osam.IdAnioF = item.IdAnioF;
                   osam.IdCtaCble = item.IdCtaCble.Trim();
                   osam.IdEmpresa = item.IdEmpresa;
                   osam.IdPeriodo = item.IdPeriodo;
                   osam.sc_credito_mes = item.sc_credito_mes;
                   osam.sc_debito_mes = item.sc_debito_mes;
                   osam.sc_saldo_acum = item.sc_saldo_acum;
                   osam.sc_saldo_anterior = item.sc_saldo_anterior;
                   osam.sc_saldo_mes = item.sc_saldo_mes;
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

       public List<ct_SaldoxCuentas_Info> Get_list_SaldoxCuentas_x_Periodo(int IdEmpresa, int AnioF, int IdPeriodo)
       {
           try
           {
               List<ct_SaldoxCuentas_Info> listaSaldoxMovi = new List<ct_SaldoxCuentas_Info>();
               EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta();

               var select= from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas 
                            where A.IdEmpresa == IdEmpresa
                            && A.IdAnioF == AnioF
                            && A.IdPeriodo == IdPeriodo
                            select A;

               foreach (var item in select)
               {
                   ct_SaldoxCuentas_Info osam = new ct_SaldoxCuentas_Info();
                   osam.IdAnioF = item.IdAnioF;
                   osam.IdCtaCble = item.IdCtaCble.Trim();
                   osam.IdEmpresa = item.IdEmpresa;
                   osam.IdPeriodo = item.IdPeriodo;
                   osam.sc_credito_mes = item.sc_credito_mes;
                   osam.sc_debito_mes = item.sc_debito_mes;
                   osam.sc_saldo_acum = item.sc_saldo_acum;
                   osam.sc_saldo_anterior = item.sc_saldo_anterior;
                   osam.sc_saldo_mes = item.sc_saldo_mes;
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

       public Boolean GrabarDB(List<ct_SaldoxCuentas_Info > ListSaldoxCta,ref string MensajeError)
       {
           string UltRegistro = "";
           try
           {
               

               using (EntitiesDBConta context = new EntitiesDBConta())// crea una direccionn al entities
               {

            
                       foreach (var item in ListSaldoxCta)
                       {

                           var address = new ct_saldoxCuentas();
                           address.IdEmpresa = item.IdEmpresa;
                           address.IdPeriodo = item.IdPeriodo;
                           address.IdAnioF = item.IdAnioF;
                           address.IdCtaCble = item.IdCtaCble;
                           address.sc_credito_mes = item.sc_credito_mes;
                           address.sc_debito_mes = item.sc_debito_mes;
                           address.sc_saldo_mes = item.sc_saldo_mes;
                           address.sc_saldo_acum = item.sc_saldo_acum;
                           address.sc_saldo_anterior = item.sc_saldo_anterior;
                           address.IdNivel =Convert.ToByte(item.IdNivel);
                           //contact = address;
                           context.ct_saldoxCuentas.Add(address);
                           context.SaveChanges();

                           UltRegistro = "IdEmpr:" + item.IdEmpresa + " IdPerido" + item.IdPeriodo + " Anio:" + item.IdAnioF
                               + " cta:" + item.IdCtaCble + " CreAc:" + item.sc_credito_acum + " credMes:" + item.sc_credito_mes
                                + " debMes:" + item.sc_debito_mes + " SaldoAcu:" + item.sc_saldo_acum
                               + " SaldoAnt:" + item.sc_saldo_anterior + " Nivel:" + item.IdNivel;
                       }   
               }
               return true;
           }
           catch (Exception ex)
           {
               MensajeError = ex.InnerException + " " + ex.Message;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString() + " " + UltRegistro, "", MensajeError, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(ct_SaldoxCuentas_Info ItemSaldoxCuenta)
       {

           try
           {

            using (EntitiesDBConta context = new EntitiesDBConta())
               {
                   var contact = context.ct_saldoxCuentas.FirstOrDefault(dinfo => dinfo.IdEmpresa == ItemSaldoxCuenta.IdEmpresa
                       && dinfo.IdPeriodo == ItemSaldoxCuenta.IdPeriodo && dinfo.IdCtaCble == ItemSaldoxCuenta.IdCtaCble);

                   if (contact != null)
                   {
                       context.ct_saldoxCuentas.Remove(contact);
                       context.SaveChanges();
                       context.Dispose();
                   }
               return true;
               }
              
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

       public Boolean EliminarDB_Registros_despues_del_periodo(int idempresa, int idPeriodo,ref string mensaje)
       {

           try
           {

               using (EntitiesDBConta Entity = new EntitiesDBConta())
               {
                   int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete ct_saldoxCuentas where IdEmpresa = " + idempresa
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


       public Boolean EliminarDB_SaldoxCuentas(List<ct_SaldoxCuentas_Info> ListSaldoxCuenta )
       {
           try
           {
               foreach (var item in ListSaldoxCuenta)
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


       public List<ct_SaldoxCuentas_Info> Get_Mayorizar_y_Optener_SaldoxCuentas(int IdEmpresa,DateTime FechaIni,DateTime FechaFin, string idusuario,Boolean Considerar_Asiento_cierre, string pc , ref string MensajeError)
       {
           try
           {

               List<ct_SaldoxCuentas_Info> listaSaldoxMovi = new List<ct_SaldoxCuentas_Info>();

               using (EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta())
               {
                   
                   
               }

               using (EntitiesDBConta OEsaldoxCuentas_Movi = new EntitiesDBConta())
               {

                   var select = from A in OEsaldoxCuentas_Movi.ct_saldoxCuentas_TMP 
                                where A.IdEmpresa == IdEmpresa
                                select A;

                   foreach (var item in select)
                   {
                       ct_SaldoxCuentas_Info osam = new ct_SaldoxCuentas_Info();



                       osam.IdEmpresa = item.IdEmpresa;
                       osam.IdAnioF = item.IdAnioF;
                       osam.IdPeriodo = item.IdPeriodo;
                       osam.IdCtaCble = item.IdCtaCble;
                       osam.IdNivel = item.IdNivel;
                       osam.sc_saldo_anterior = item.sc_saldo_anterior;
                       osam.sc_debito_mes = item.sc_debito_mes;
                       osam.sc_credito_mes = item.sc_credito_mes;
                       osam.sc_saldo_acum = item.sc_saldo_acum;
                       osam.sc_saldo_mes = item.sc_saldo_mes;

              
                       listaSaldoxMovi.Add(osam);
                   }

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


       public List<ct_SaldoxCuentas_Info> Get_Saldo_Inicial_x_Cuenta(int IdEmpresa, List<string> listCuentas, DateTime FechaCorte,  ref string MensajeError)
       {
           try
           {

               List<ct_SaldoxCuentas_Info> listaSaldo_Ini_x_cuentas = new List<ct_SaldoxCuentas_Info>();



               using (EntitiesDBConta BaseConta = new EntitiesDBConta())
               {


                   var TdebitosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                      where Cb.dc_Valor > 0
                                      && Cb.cb_Fecha <= FechaCorte
                                      && listCuentas.Contains(Cb.IdCtaCble)
                                      orderby Cb.IdCtaCble
                                      group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                          into grouping
                                          select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p.dc_Valor) };


                   var TCreditosxCta = from Cb in BaseConta.vwct_cbtecble_det
                                      where Cb.dc_Valor < 0
                                      && Cb.cb_Fecha <= FechaCorte
                                      && listCuentas.Contains(Cb.IdCtaCble)
                                      orderby Cb.IdCtaCble
                                      group Cb by new { Cb.IdEmpresa, Cb.IdCtaCble }
                                          into grouping
                                          select new { grouping.Key, totalCreditoxCta = grouping.Sum(p => p.dc_Valor*-1) };





                   foreach (var itemCta in listCuentas)
                   {
                       double Debito_x_cta = TdebitosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totaldebidoxCta;
                       double credito_x_cta = TCreditosxCta.FirstOrDefault(v => v.Key.IdCtaCble == itemCta).totalCreditoxCta;


                       ct_SaldoxCuentas_Info Info= new ct_SaldoxCuentas_Info();

                       Info.IdEmpresa = IdEmpresa;
                       Info.IdCtaCble = itemCta;
                       Info.sc_debito_acum = Debito_x_cta;
                       Info.sc_credito_acum = credito_x_cta;
                       Info.sc_saldo_acum = Debito_x_cta - credito_x_cta;


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


       public ct_saldoxCuentas_Data()
       {
          
       }
    }
}
