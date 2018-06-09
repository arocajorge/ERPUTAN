using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_rpt_MovxCta_Data
    {
        string mensaje = "";
        public List<ct_rpt_MovxCta_Info> Get_list_rpt_MovxCta(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                List<ct_rpt_MovxCta_Info> Lista_MovxCta = new List<ct_rpt_MovxCta_Info>();
                EntitiesDBConta OESaldos = new EntitiesDBConta();
                var lista_item = from C in OESaldos.ct_rpt_MovxCta
                                    where C.IdEmpresa == IdEmpresa
                                    && C.IdPeriodo==IdPeriodo
                                    select C;
                foreach (var item in lista_item)
                {
                    ct_rpt_MovxCta_Info info = new ct_rpt_MovxCta_Info();
                    info.Idempresa = item.IdEmpresa;
                    info.IdPeriodo = item.IdPeriodo;
                    info.IdCtaCble = item.IdCtaCble;
                    info.FechaCbte = Convert.ToDateTime(item.FechaCbte);
                    info.IdCbteCble = item.IdCbteCble;
                    info.CodCbteCble = item.CodCbteCble;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdTipoCbte = item.IdTipoCbte;
                    info.sTipoCbte = item.sTipoCbte;
                    info.Observacion = item.Observacion;
                    info.Debito = item.Debito;
                    info.Credito = item.Credito;
                    info.Saldo = item.Saldo;
                    info.IdUsuario = item.IdUsuario;
                    info.Nom_Pc = item.Nom_Pc;

                    Lista_MovxCta.Add(info);
                }
                return (Lista_MovxCta);
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

        public List<ct_rpt_MovxCta_Info> Get_list_rpt_MovxCta(int IdEmpresa)
        {
            try
            {
                List<ct_rpt_MovxCta_Info> Lista_MovxCta = new List<ct_rpt_MovxCta_Info>();
                EntitiesDBConta OESaldos = new EntitiesDBConta();
                var lista_item = from C in OESaldos.ct_rpt_MovxCta
                                 where C.IdEmpresa == IdEmpresa
                                 select C;
                foreach (var item in lista_item)
                {
                    ct_rpt_MovxCta_Info info = new ct_rpt_MovxCta_Info();
                    info.Idempresa = item.IdEmpresa;
                    info.IdPeriodo = item.IdPeriodo;
                    info.IdCtaCble = item.IdCtaCble;
                    info.FechaCbte = Convert.ToDateTime(item.FechaCbte);
                    info.IdCbteCble = item.IdCbteCble;
                    info.CodCbteCble = item.CodCbteCble;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdTipoCbte = item.IdTipoCbte;
                    info.sTipoCbte = item.sTipoCbte;
                    info.Observacion = item.Observacion;
                    info.Debito = item.Debito;
                    info.Credito = item.Credito;
                    info.Saldo = item.Saldo;
                    info.IdUsuario = item.IdUsuario;
                    info.Nom_Pc = item.Nom_Pc;

                    Lista_MovxCta.Add(info);
                }
                return (Lista_MovxCta);
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


        #region metodo de grabar
        public Boolean GrabarDB(List<ct_rpt_MovxCta_Info> Lista)
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

        public Boolean GrabarDB(ct_rpt_MovxCta_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    ct_rpt_MovxCta address = new ct_rpt_MovxCta();

                    address.IdEmpresa = info.Idempresa;
                    address.CodCbteCble = info.CodCbteCble;
                    address.FechaCbte = info.FechaCbte;
                    address.Observacion = info.Observacion;
                    address.Debito = info.Debito;
                    address.Credito = info.Credito;
                    address.Saldo = info.Saldo;
                    address.IdCtaCble = info.IdCtaCble;
                    address.IdCentroCosto = info.IdCentroCosto;
                    address.IdPeriodo = info.IdPeriodo;
                    address.IdTipoCbte = Convert.ToByte(info.IdTipoCbte);
                    address.IdCbteCble = info.IdCbteCble;
                    address.sTipoCbte = info.sTipoCbte;
                    address.IdUsuario = info.IdUsuario ;
                    address.Nom_Pc = info.Nom_Pc;

                    context.ct_rpt_MovxCta.Add(address);
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
        #endregion

        #region metodo eliminar
        public Boolean EliminarDB(List<ct_rpt_MovxCta_Info> Lista)
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

        public Boolean EliminarDB(ct_rpt_MovxCta_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_rpt_MovxCta.FirstOrDefault(dinfo => dinfo.IdEmpresa == info.Idempresa);
                    if (contact != null)
                    {
                        context.ct_rpt_MovxCta.Remove(contact);
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
        #endregion


        public List<ct_rpt_MovxCta_Info> Get_list_rpt_MovxCta(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin)
        {
            try
            {
                List<ct_rpt_MovxCta_Info> lM = new List<ct_rpt_MovxCta_Info>();
                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var selectCbtecble = from cbtecble in OECbtecble.ct_cbtecble
                                     join cbtecble_det in OECbtecble.ct_cbtecble_det on
                                     new { cbtecble.IdEmpresa, cbtecble.IdCbteCble, cbtecble.IdTipoCbte } equals new { cbtecble_det.IdEmpresa, cbtecble_det.IdCbteCble, cbtecble_det.IdTipoCbte }
                                     join ctacble in OECbtecble.ct_rpt_SaldoxCta on
                                     new { cbtecble_det.IdEmpresa, cbtecble_det.IdCtaCble } equals new { ctacble.IdEmpresa, ctacble.IdCtaCble }
                                     join cbtecble_tipo in OECbtecble.ct_cbtecble_tipo on
                                     new { cbtecble.IdTipoCbte } equals new { cbtecble_tipo.IdTipoCbte }
                                     

                                     where cbtecble.IdEmpresa == IdEmpresa
                                            && cbtecble.cb_Fecha >= iFechaIni && cbtecble.cb_Fecha <= iFechaFin
                                     orderby cbtecble_det.IdCtaCble, cbtecble.cb_Fecha
                                     select new
                                     {
                                         cbtecble.IdEmpresa,
                                         cbtecble.CodCbteCble,
                                         cbtecble.cb_Fecha,
                                         cbtecble.cb_Observacion,
                                         cbtecble.IdPeriodo,
                                         cbtecble.IdTipoCbte,

                                         cbtecble_tipo.tc_TipoCbte,

                                         cbtecble_det.IdCbteCble,
                                         cbtecble_det.dc_Observacion,
                                         cbtecble_det.dc_Valor,
                                         cbtecble_det.IdCtaCble,
                                         cbtecble_det.IdCentroCosto,

                                         ctacble.sa_SaldoInicial,
                                         ctacble.sa_SaldoFinal
                                     };

                string idCtaCbleAux="";
                string idCtaCble="";
                double  saldo = 0;


                foreach (var item in selectCbtecble)
                {
                    ct_rpt_MovxCta_Info info = new ct_rpt_MovxCta_Info();

                    idCtaCble = item.IdCtaCble.Trim();

                    if (idCtaCble != idCtaCbleAux)
                    { 
                        idCtaCbleAux=idCtaCble;
                        saldo = item.sa_SaldoInicial;
                    }


                    info.Idempresa = item.IdEmpresa;
                    info.IdCbteCble = item.IdCbteCble;
                    info.CodCbteCble = item.CodCbteCble;
                    info.IdPeriodo = item.IdPeriodo;
                    info.IdTipoCbte = item.IdTipoCbte;
                    info.sTipoCbte = item.tc_TipoCbte;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Debito = (item.dc_Valor > 0) ? item.dc_Valor : 0;
                    info.Credito = (item.dc_Valor < 0) ? item.dc_Valor * -1 : 0;
                    
                    saldo = saldo + (item.dc_Valor);
                    info.Saldo = saldo;
                  
                    info.FechaCbte = item.cb_Fecha;
                    info.Observacion = item.dc_Observacion;
                    lM.Add(info);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }

        }

        public List<ct_rpt_MovxCta_Info> Get_list_rpt_MovxCta(int IdEmpresa, List<string> listaCtas, DateTime iFechaIni, DateTime iFechaFin)
        {
            try
            {
                List<ct_rpt_MovxCta_Info> lM = new List<ct_rpt_MovxCta_Info>();
                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var selectCbtecble = from cbtecble in OECbtecble.ct_cbtecble
                                     join cbtecble_det in OECbtecble.ct_cbtecble_det on
                                     new { cbtecble.IdEmpresa, cbtecble.IdCbteCble, cbtecble.IdTipoCbte } equals new { cbtecble_det.IdEmpresa, cbtecble_det.IdCbteCble, cbtecble_det.IdTipoCbte }
                                     join ctacble in OECbtecble.ct_rpt_SaldoxCta on
                                     new { cbtecble_det.IdEmpresa, cbtecble_det.IdCtaCble } equals new { ctacble.IdEmpresa, ctacble.IdCtaCble }
                                     join cbtecble_tipo in OECbtecble.ct_cbtecble_tipo on
                                     new { cbtecble.IdTipoCbte } equals new { cbtecble_tipo.IdTipoCbte }
                                     where cbtecble.IdEmpresa == IdEmpresa
                                            && cbtecble.cb_Fecha >= iFechaIni && cbtecble.cb_Fecha <= iFechaFin
                                            && listaCtas.Contains(cbtecble_det.IdCtaCble)
                                     orderby cbtecble_det.IdCtaCble, cbtecble.cb_Fecha
                                     select new
                                     {
                                         cbtecble.IdEmpresa,
                                         cbtecble.CodCbteCble,
                                         cbtecble.cb_Fecha,
                                         cbtecble.cb_Observacion,
                                         cbtecble.IdPeriodo,
                                         cbtecble.IdTipoCbte,

                                         cbtecble_tipo.tc_TipoCbte,

                                         cbtecble_det.IdCbteCble,
                                         cbtecble_det.dc_Observacion,
                                         cbtecble_det.dc_Valor,
                                         cbtecble_det.IdCtaCble,
                                         cbtecble_det.IdCentroCosto,

                                         ctacble.sa_SaldoInicial,
                                         ctacble.sa_SaldoFinal
                                     };

                string idCtaCbleAux = "";
                string idCtaCble = "";
                double saldo = 0;


                foreach (var item in selectCbtecble)
                {
                    ct_rpt_MovxCta_Info info = new ct_rpt_MovxCta_Info();

                    idCtaCble = item.IdCtaCble.Trim();

                    if (idCtaCble != idCtaCbleAux)
                    {
                        idCtaCbleAux = idCtaCble;
                        saldo = item.sa_SaldoInicial;
                    }


                    info.Idempresa = item.IdEmpresa;
                    info.IdCbteCble = item.IdCbteCble;
                    info.CodCbteCble = item.CodCbteCble;
                    info.IdPeriodo = item.IdPeriodo;
                    info.IdTipoCbte = item.IdTipoCbte;
                    info.sTipoCbte = item.tc_TipoCbte;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Debito = (item.dc_Valor > 0) ? item.dc_Valor : 0;
                    info.Credito = (item.dc_Valor < 0) ? item.dc_Valor * -1 : 0;

                    saldo = saldo + (item.dc_Valor);
                    info.Saldo = saldo;

                    info.FechaCbte = item.cb_Fecha;
                    info.Observacion = item.dc_Observacion;
                    lM.Add(info);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_rpt_MovxCta_Data()
        {
            
        }
    }
}
