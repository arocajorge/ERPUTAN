﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Contabilidad
{ 
    public class ct_Cbtecble_Data
    {
        string mensaje = "";

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa,ref string MensajeError) 
        {
            try
            {
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble
                                     where C.IdEmpresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble) 
                {
                    ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.IdCbteCble = item.IdCbteCble;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.CodCbteCble = item.CodCbteCble;
                    Cbt.cb_Fecha = Convert.ToDateTime(item.cb_Fecha.ToShortDateString());
                    Cbt.cb_Valor = item.cb_Valor;
                    Cbt.cb_Observacion = item.cb_Observacion;
                    Cbt.Secuencia = Convert.ToDecimal(item.cb_Secuencia);
                    Cbt.Estado = item.cb_Estado;
                    Cbt.Anio = item.cb_Anio;
                    Cbt.Mes = Convert.ToInt32(item.cb_mes);
                    Cbt.IdUsuario = item.IdUsuario;
                    Cbt.IdUsuarioAnu = item.IdUsuarioAnu;
                    Cbt.cb_MotivoAnu = item.cb_MotivoAnu;
                    Cbt.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_FechaAnu);
                    Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_FechaTransac);
                    Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_FechaUltModi);
                    Cbt.Mayorizado = item.cb_Mayorizado;
                    
                    Cbt.IdSucursal = item.IdSucursal;


                    lM.Add(Cbt);
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

        public Boolean ReversoCbteCble(int idempresa, decimal idcbtecble, int idtipocble, int idtipocble_rev, ref decimal idcbtecble_rev,
            ref string msg, string user,string MotivoAnulacion="", string fechaAnu = "")
        {
            try
            {
                string codigoCbte="";

                DateTime _fechaAnu = new DateTime();
                _fechaAnu = fechaAnu==""?DateTime.Now : Convert.ToDateTime(fechaAnu);

                _fechaAnu = Convert.ToDateTime(_fechaAnu.ToShortDateString());

                
                ct_Cbtecble_Info info = new ct_Cbtecble_Info();
                ct_Cbtecble_Info info_cbtecbtes = new ct_Cbtecble_Info();
                EntitiesDBConta OEContabilidad = new EntitiesDBConta();
                var select_cbte = from A in OEContabilidad.ct_cbtecble
                                  where A.IdEmpresa == idempresa && A.IdCbteCble == idcbtecble && A.IdTipoCbte == idtipocble
                                  select A;

                foreach (var item in select_cbte)
                {
                    info = new ct_Cbtecble_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTipoCbte = item.IdTipoCbte;
                    info.IdCbteCble = item.IdCbteCble;
                    info.CodCbteCble = item.CodCbteCble;
                    info.IdPeriodo = item.IdPeriodo;
                    info.cb_Fecha = item.cb_Fecha;
                    info.cb_Valor = item.cb_Valor;
                    info.cb_Observacion = item.cb_Observacion;
                    info.Secuencia = item.cb_Secuencia;
                    info.Estado = "I";
                    info.Anio = item.cb_Anio;
                    info.Mes = item.cb_mes;
                    info.Mayorizado = item.cb_Mayorizado;
                    info.cb_MotivoAnu = MotivoAnulacion;
                    info.cb_FechaAnu = _fechaAnu;
                    info.IdSucursal = item.IdSucursal;

                    //empiezo a realizar una copia al nuevo comprobante
                    info_cbtecbtes = new ct_Cbtecble_Info();
                    info_cbtecbtes.IdEmpresa = item.IdEmpresa;
                    info_cbtecbtes.IdTipoCbte = idtipocble_rev;
                    info_cbtecbtes.IdCbteCble =  0;
                    info_cbtecbtes.CodCbteCble = item.CodCbteCble;
                    info_cbtecbtes.IdPeriodo = item.IdPeriodo;
                    info_cbtecbtes.cb_Fecha = Convert.ToDateTime(Convert.ToDateTime(info.cb_FechaAnu).ToShortDateString());
                    info_cbtecbtes.cb_Valor = item.cb_Valor;
                    info_cbtecbtes.cb_Observacion = 
                        "***REVERSO DEL DIARIO #: " + item.IdCbteCble.ToString() + 
                        ", TIPO COMPROBANTE #: " + item.IdTipoCbte.ToString() + " " + 
                        item.cb_Observacion + " ***";
                    info_cbtecbtes.Secuencia = Get_IdSecuencia(item.IdEmpresa, ref msg);
                    info_cbtecbtes.Estado = item.cb_Estado;
                    info_cbtecbtes.Anio = item.cb_Anio;
                    info_cbtecbtes.Mes = item.cb_mes;
                    info_cbtecbtes.Mayorizado = "N";
                    info_cbtecbtes.IdUsuario = user;
                    info_cbtecbtes.cb_FechaTransac = Convert.ToDateTime(info.cb_FechaAnu);
                    
                    info_cbtecbtes.IdSucursal = item.IdSucursal;

                }

                OEContabilidad = new EntitiesDBConta();

                var select_cbtecble_det = from B in OEContabilidad.ct_cbtecble_det
                                          where B.IdEmpresa == idempresa && B.IdCbteCble == idcbtecble && B.IdTipoCbte == idtipocble
                                          select B;
                //info._cbteCble_det_lista_info(new ct_Cbtecble_det_Info());
                List<ct_Cbtecble_det_Info> lista_cbte = new List<ct_Cbtecble_det_Info>();
                List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                foreach (var item in select_cbtecble_det)
                {
                    ct_Cbtecble_det_Info info_det = new ct_Cbtecble_det_Info();
                    info_det.IdEmpresa = item.IdEmpresa;
                    info_det.IdTipoCbte = item.IdTipoCbte;
                    info_det.IdCbteCble = item.IdCbteCble;
                    info_det.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo != null) ? item.IdCentroCosto_sub_centro_costo.Trim() : null;  
                    info_det.secuencia = item.secuencia;
                    info_det.IdCtaCble = item.IdCtaCble.Trim();
                    info_det.IdCentroCosto = (item.IdCentroCosto != null) ? item.IdCentroCosto.Trim() : null;
                    info_det.dc_Valor = item.dc_Valor;
                    info_det.dc_Observacion = "***REVERSADO***" + item.dc_Observacion.Trim();
                    info_det.dc_Numconciliacion = item.dc_Numconciliacion;
                    info_det.dc_EstaConciliado = item.dc_EstaConciliado;
                    info_det.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    info_det.IdPunto_cargo = item.IdPunto_cargo;
                    info_det.dc_para_conciliar = item.dc_para_conciliar == null ? false : Convert.ToBoolean(item.dc_para_conciliar);
                    lista_cbte.Add(info_det);
                    //

                    //procedo a copiar los detalles de los comprobantes al nuevo para proceder con el reverso
                    ct_Cbtecble_det_Info tmp = new ct_Cbtecble_det_Info();
                    tmp.IdEmpresa = item.IdEmpresa;
                    tmp.IdTipoCbte = idtipocble_rev;
                    tmp.IdCbteCble = idcbtecble; //0;
                    tmp.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo != null) ? item.IdCentroCosto_sub_centro_costo.Trim() : null;  
                    tmp.secuencia = item.secuencia;
                    tmp.IdCtaCble = item.IdCtaCble.Trim();
                    tmp.IdCentroCosto = (item.IdCentroCosto != null) ? item.IdCentroCosto.Trim() : null;
                    tmp.dc_Valor = item.dc_Valor * -1;
                    tmp.dc_Observacion = "***REVERSO***" + item.dc_Observacion.Trim();
                    tmp.dc_Numconciliacion = item.dc_Numconciliacion;
                    tmp.dc_EstaConciliado = item.dc_EstaConciliado;
                    tmp.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    tmp.IdPunto_cargo = item.IdPunto_cargo;
                    lm.Add(tmp);
                }

                info._cbteCble_det_lista_info = lista_cbte;
                info_cbtecbtes._cbteCble_det_lista_info = lm;
                info_cbtecbtes.CodCbteCble = "";

                if (info_cbtecbtes._cbteCble_det_lista_info.Count != 0)
                {
                    if (GrabarDB(info_cbtecbtes, ref idcbtecble_rev, ref codigoCbte, ref msg))
                    {

                        info.cb_Observacion = "**REVERSADO CON EL DIARIO : " + idcbtecble_rev + " Tipo: " + info_cbtecbtes.IdTipoCbte + "**" + info.cb_Observacion;

                        foreach (var item in info._cbteCble_det_lista_info)
                        {
                            item.dc_Observacion = "**REVERSADO CON EL DIARIO : " + idcbtecble_rev + " Tipo: " + info_cbtecbtes.IdTipoCbte + "**" + item.dc_Observacion;


                        }


                        if (ModificarDB(info, ref msg))
                        {
                            msg = "Se procedió a reversar el comprobante contable. " + msg;
                        }
                    }

                    ct_cbtecble_Reversado_Data _dataReversado = new ct_cbtecble_Reversado_Data();
                    ct_cbtecble_Reversado_Info _InfoReversado = new ct_cbtecble_Reversado_Info();

                    _InfoReversado.IdEmpresa = _InfoReversado.IdEmpresa_Anu = idempresa;
                    _InfoReversado.IdCbteCble = idcbtecble;
                    _InfoReversado.IdCbteCble_Anu = idcbtecble_rev;
                    _InfoReversado.IdTipoCbte = idtipocble;
                    _InfoReversado.IdTipoCbte_Anu = idtipocble_rev;
                    _dataReversado.GuardarDB(_InfoReversado);
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
                msg = mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaSaldoInicial(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin,ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.IdEmpresa, cb.IdCbteCble, cb.IdTipoCbte } equals new { cbd.IdEmpresa, cbd.IdCbteCble, cbd.IdTipoCbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.IdEmpresa, cbd.IdCtaCble } equals new { plcta.IdEmpresa, plcta.IdCtaCble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.IdEmpresa, plcta.IdNivelCta } equals new { npl.IdEmpresa, npl.IdNivelCta }
                                     where cb.IdEmpresa == IdEmpresa
                                     && cb.cb_Fecha >= iFechaIni && cb.cb_Fecha <= iFechaFin
                                     orderby cbd.IdCtaCble
                                     select new
                                     {
                                         cb.IdEmpresa,
                                         cb.IdCbteCble,
                                         cb.IdPeriodo,
                                         cb.IdTipoCbte,
                                         cb.cb_Fecha,
                                         cb.cb_Valor,
                                         cb.cb_mes,
                                         cb.cb_Anio,
                                         cb.cb_Estado,
                                         cb.cb_Mayorizado,
                                         cb.CodCbteCble,
                                         cb.cb_para_conciliar,
                                         cbd.dc_Valor,
                                         cbd.IdCentroCosto,
                                         cbd.IdCtaCble,
                                         cbd.secuencia,
                                         cb.cb_Observacion,
                                         cb.IdSucursal,
                                         cbd.dc_Observacion,

                                         plcta.IdCatalogo,
                                         plcta.IdCtaCblePadre,
                                         plcta.IdGrupoCble,
                                         plcta.IdNivelCta,
                                         plcta.pc_Cuenta,
                                         plcta.pc_EsMovimiento,
                                         plcta.pc_Estado,
                                         plcta.pc_Naturaleza,

                                         npl.nv_NumDigitos
                                     };
                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.IdEmpresa;
                    Cbt1.IdTipoCbte = item.IdTipoCbte;
                    Cbt1.IdCbteCble = item.IdCbteCble;
                    Cbt1.IdPeriodo = item.IdPeriodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_Fecha);
                    Cbt1.cb_Valor = item.cb_Valor;
                    Cbt1.Estado = item.cb_Estado;
                    Cbt1.Anio = item.cb_Anio;
                    Cbt1.Mayorizado = item.cb_Mayorizado;
                    Cbt1.cb_Observacion = item.cb_Observacion;
                    
                    Cbt1.IdSucursal = item.IdSucursal;

                    Cbtdt.IdEmpresa = item.IdEmpresa;
                    Cbtdt.dc_Observacion = item.dc_Observacion;
                    Cbtdt.IdCbteCble = item.IdCbteCble;
                    Cbtdt.dc_Valor = item.dc_Valor;
                    Cbtdt.IdCentroCosto = item.IdCentroCosto;
                    Cbtdt.IdCtaCble = item.IdCtaCble;
                    Cbtdt.secuencia = item.secuencia;

                    pli.IdCtaCble = item.IdCtaCble;
                    pli.IdCtaCblePadre = item.IdCtaCblePadre;
                    pli.IdEmpresa = item.IdEmpresa;
                    pli.IdGrupoCble = item.IdGrupoCble;
                    pli.IdNivelCta = item.IdNivelCta;
                    pli.pc_Cuenta = item.pc_Cuenta;
                    pli.pc_Cuenta2 = item.IdCtaCble + " - " + item.pc_Cuenta;
                    pli.pc_EsMovimiento = item.pc_EsMovimiento;
                    pli.pc_Estado = item.pc_Estado;
                    pli.pc_Naturaleza = item.pc_Naturaleza;

                    plNi.IdEmpresa = item.IdEmpresa;
                    plNi.IdNivelCta = item.IdNivelCta;
                    plNi.nv_NumDigitos = item.nv_NumDigitos;

                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
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

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, int IdCbteCble1, string CodCbteCble1, string IdTipoCbte1, string observacion, string IdUsuario,ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from C in OECbtecble_Info.ct_cbtecble
                                     where C.IdEmpresa == IdEmpresa
                                     && C.cb_Fecha >= iFechaIni && C.cb_Fecha <= iFechaFin
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdTipoCbte = item.IdTipoCbte;
                    Cbt.IdCbteCble = item.IdCbteCble;
                    Cbt.IdPeriodo = item.IdPeriodo;
                    Cbt.cb_Fecha = Convert.ToDateTime(item.cb_Fecha);
                    Cbt.cb_Valor = item.cb_Valor;
                    Cbt.cb_Observacion = item.cb_Observacion;
                    Cbt.Secuencia = Convert.ToDecimal(item.cb_Secuencia);
                    Cbt.Estado = item.cb_Estado;
                    Cbt.Anio = item.cb_Anio;
                    Cbt.Mes = Convert.ToInt32(item.cb_mes);
                    Cbt.IdUsuario = item.IdUsuario;
                    Cbt.IdUsuarioAnu = item.IdUsuarioAnu;
                    Cbt.cb_MotivoAnu = item.cb_MotivoAnu;
                    Cbt.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_FechaAnu);
                    Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_FechaTransac);
                    Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_FechaUltModi);
                    Cbt.Mayorizado = item.cb_Mayorizado;
                    
                    Cbt.IdSucursal = item.IdSucursal;

                    lM.Add(Cbt);
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

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, decimal IdCbteCbleIni, decimal IdCbteCbleFin, int IdTipoCbteIni, int IdTipoCbteFin,  ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                
                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select a.IdEmpresa, a.IdTipoCbte, a.IdCbteCble, a.IdPeriodo, a.CodCbteCble, a.cb_Fecha, a.cb_Valor,"
                                +" a.cb_Observacion, a.cb_Secuencia, a.cb_Anio, a.cb_mes, cb_para_conciliar, cb_Mayorizado, IdSucursal, b.tc_TipoCbte"
                                +" from ct_cbtecble as a left join"
                                +" ct_cbtecble_tipo as b on a.IdEmpresa = b.IdEmpresa and a.IdTipoCbte = b.IdTipoCbte"
                                + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.cb_Fecha between DATEFROMPARTS(" + iFechaIni.Year.ToString() + "," + iFechaIni.Month.ToString() + "," + iFechaIni.Day.ToString() + ") and DATEFROMPARTS(" + iFechaFin.Year.ToString() + "," + iFechaFin.Month.ToString() + "," + iFechaFin.Day.ToString() + ")";
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lM.Add(new ct_Cbtecble_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdTipoCbte = Convert.ToInt32(reader["IdTipoCbte"]),
                            IdCbteCble = Convert.ToDecimal(reader["IdCbteCble"]),
                            IdPeriodo = Convert.ToInt32(reader["IdPeriodo"]),
                            CodCbteCble = Convert.ToString(reader["CodCbteCble"]),
                            cb_Fecha = Convert.ToDateTime(reader["cb_Fecha"]),
                            cb_Valor = Convert.ToDouble(reader["cb_Valor"]),
                            cb_Observacion = Convert.ToString(reader["cb_Observacion"]),
                            Secuencia = Convert.ToDecimal(reader["cb_Secuencia"]),
                            Anio = Convert.ToInt32(reader["cb_Anio"]),
                            Mes = Convert.ToInt32(reader["cb_mes"]),
                            Mayorizado = Convert.ToString(reader["cb_Mayorizado"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            tipoCTCB = Convert.ToString(reader["tc_TipoCbte"])
                        });
                    }
                    reader.Close();
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

        public decimal Get_IdCbteCble(int idempresa, int idTipoCbte,ref string MensajeError)
        {
            try
            {
                decimal IdcbteCble = 1;
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select IdEmpresa, IdTipoCbte, max(IdCbteCble) IdCbteCble "
                                        +" from ct_cbtecble"
                                        +" where IdEmpresa = "+idempresa.ToString()+" and IdTipoCbte = "+idTipoCbte.ToString()
                                        +" group by IdEmpresa, IdTipoCbte ";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        IdcbteCble = (reader["IdCbteCble"] == DBNull.Value ? 1 : (Convert.ToDecimal(reader["IdCbteCble"]) + 1));
                    }
                }
                return IdcbteCble;
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

        public decimal Get_IdSecuencia(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                /*
                decimal Idsecuencia;
                EntitiesDBConta OECbtecble = new EntitiesDBConta();


                var selecte = OECbtecble.ct_cbtecble.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Idsecuencia = 1;
                }
                else
                {
                    var selectCbtecble = (from CbtCble in OECbtecble.ct_cbtecble
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.cb_Secuencia).Count();
                    Idsecuencia = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return Idsecuencia;
                 * */
                return 1;
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

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_Pendientes_ParaMayorizacion(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.IdEmpresa, cb.IdCbteCble, cb.IdTipoCbte } equals new { cbd.IdEmpresa, cbd.IdCbteCble, cbd.IdTipoCbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.IdEmpresa, cbd.IdCtaCble } equals new { plcta.IdEmpresa, plcta.IdCtaCble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.IdEmpresa, plcta.IdNivelCta } equals new { npl.IdEmpresa, npl.IdNivelCta }
                                     where cb.IdEmpresa == IdEmpresa
                                     && cb.cb_Fecha >= iFechaIni && cb.cb_Fecha <= iFechaFin
                                     && cb.cb_Mayorizado == "N"
                                     orderby cbd.IdCtaCble
                                     select new
                                     {
                                         cb.IdEmpresa,
                                         cb.IdCbteCble,
                                         cb.IdPeriodo,
                                         cb.IdTipoCbte,
                                         cb.cb_Fecha,
                                         cb.cb_Valor,
                                         cb.cb_mes,
                                         cb.cb_Anio,
                                         cb.cb_Estado,
                                         cb.cb_Mayorizado,
                                         cb.CodCbteCble,
                                         cb.cb_para_conciliar,
                                         cb.IdSucursal,
                                         cbd.dc_Valor,
                                         cbd.IdCentroCosto,
                                         cbd.IdCtaCble,
                                         cbd.secuencia,
                                         cb.cb_Observacion,
                                         cbd.dc_Observacion,
                                         plcta.IdCatalogo,
                                         plcta.IdCtaCblePadre,
                                         plcta.IdGrupoCble,
                                         plcta.IdNivelCta,
                                         plcta.pc_Cuenta,
                                         plcta.pc_EsMovimiento,
                                         plcta.pc_Estado,
                                         plcta.pc_Naturaleza,
                                         npl.nv_NumDigitos
                                     };
                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.IdEmpresa;
                    Cbt1.IdTipoCbte = item.IdTipoCbte;
                    Cbt1.IdCbteCble = item.IdCbteCble;
                    Cbt1.IdPeriodo = item.IdPeriodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_Fecha);
                    Cbt1.cb_Valor = item.cb_Valor;
                    Cbt1.Estado = item.cb_Estado;
                    Cbt1.Anio = item.cb_Anio;
                    Cbt1.Mayorizado = item.cb_Mayorizado;
                    Cbt1.cb_Observacion = item.cb_Observacion;
                    
                    Cbt1.IdSucursal = item.IdSucursal;

                    Cbtdt.IdEmpresa = item.IdEmpresa;
                    Cbtdt.dc_Observacion = item.dc_Observacion;
                    Cbtdt.IdCbteCble = item.IdCbteCble;
                    Cbtdt.dc_Valor = item.dc_Valor;
                    Cbtdt.IdCentroCosto = item.IdCentroCosto;
                    Cbtdt.IdCtaCble = item.IdCtaCble;
                    Cbtdt.secuencia = item.secuencia;

                    pli.IdCtaCble = item.IdCtaCble;
                    pli.IdCtaCblePadre = item.IdCtaCblePadre;
                    pli.IdEmpresa = item.IdEmpresa;
                    pli.IdGrupoCble = item.IdGrupoCble;
                    pli.IdNivelCta = item.IdNivelCta;
                    pli.pc_Cuenta = item.pc_Cuenta;
                    pli.pc_Cuenta2 = item.IdCtaCble + " - " + item.pc_Cuenta;
                    pli.pc_EsMovimiento = item.pc_EsMovimiento;
                    pli.pc_Estado = item.pc_Estado;
                    pli.pc_Naturaleza = item.pc_Naturaleza;

                    plNi.IdEmpresa = item.IdEmpresa;
                    plNi.IdNivelCta = item.IdNivelCta;
                    plNi.nv_NumDigitos = item.nv_NumDigitos;

                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
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

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaMayorizar(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
            try
            {

                iFechaIni = Convert.ToDateTime(iFechaIni.ToShortDateString());
                iFechaFin = Convert.ToDateTime(iFechaFin.ToShortDateString());

                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();
                var selectCbtecble = from cb in OECbtecble_Info.ct_cbtecble
                                     join cbd in OECbtecble_Info.ct_cbtecble_det on
                                     new { cb.IdEmpresa, cb.IdCbteCble, cb.IdTipoCbte } equals new { cbd.IdEmpresa, cbd.IdCbteCble, cbd.IdTipoCbte }
                                     join plcta in OECbtecble_Info.ct_plancta on
                                     new { cbd.IdEmpresa, cbd.IdCtaCble } equals new { plcta.IdEmpresa, plcta.IdCtaCble }
                                     join npl in OECbtecble_Info.ct_plancta_nivel on
                                     new { plcta.IdEmpresa, plcta.IdNivelCta } equals new { npl.IdEmpresa, npl.IdNivelCta }
                                     where cb.IdEmpresa == IdEmpresa
                                     && cb.cb_Fecha >= iFechaIni && cb.cb_Fecha <= iFechaFin
                                     orderby cbd.IdCtaCble
                                     select new
                                     {
                                         cb.IdEmpresa,
                                         cb.IdCbteCble,
                                         cb.IdPeriodo,
                                         cb.IdTipoCbte,
                                         cb.cb_Fecha,
                                         cb.cb_Valor,
                                         cb.cb_mes,
                                         cb.cb_Anio,
                                         cb.cb_Estado,
                                         cb.cb_Mayorizado,
                                         cb.CodCbteCble,
                                         cb.IdSucursal,
                                         cb.cb_para_conciliar,
                                         cbd.dc_Valor,
                                         cbd.IdCentroCosto,
                                         cbd.IdCtaCble,
                                         cbd.secuencia,
                                         cb.cb_Observacion,
                                         cbd.dc_Observacion,
                                         plcta.IdCatalogo,
                                         plcta.IdCtaCblePadre,
                                         plcta.IdGrupoCble,
                                         plcta.IdNivelCta,
                                         plcta.pc_Cuenta,
                                         plcta.pc_EsMovimiento,
                                         plcta.pc_Estado,
                                         plcta.pc_Naturaleza,
                                         npl.nv_NumDigitos
                                     };
                foreach (var item in selectCbtecble)
                {
                    ct_Cbtecble_Info Cbt1 = new ct_Cbtecble_Info();
                    ct_Cbtecble_det_Info Cbtdt = new ct_Cbtecble_det_Info();
                    ct_Plancta_Info pli = new ct_Plancta_Info();
                    ct_Plancta_nivel_Info plNi = new ct_Plancta_nivel_Info();
                    Cbt1.IdEmpresa = item.IdEmpresa;
                    Cbt1.IdTipoCbte = item.IdTipoCbte;
                    Cbt1.IdCbteCble = item.IdCbteCble;
                    Cbt1.IdPeriodo = item.IdPeriodo;
                    Cbt1.cb_Fecha = Convert.ToDateTime(item.cb_Fecha);
                    Cbt1.cb_Valor = item.cb_Valor;
                    Cbt1.Estado = item.cb_Estado;
                    Cbt1.Anio = item.cb_Anio;
                    Cbt1.Mayorizado = item.cb_Mayorizado;
                    Cbt1.cb_Observacion = item.cb_Observacion;
                    
                    Cbt1.IdSucursal = item.IdSucursal;

                    Cbtdt.IdEmpresa = item.IdEmpresa;
                    Cbtdt.dc_Observacion = item.dc_Observacion;
                    Cbtdt.IdCbteCble = item.IdCbteCble;
                    Cbtdt.dc_Valor = item.dc_Valor;
                    Cbtdt.IdCentroCosto = item.IdCentroCosto;
                    Cbtdt.IdCtaCble = item.IdCtaCble;
                    Cbtdt.secuencia = item.secuencia;

                    pli.IdCtaCble = item.IdCtaCble;
                    pli.IdCtaCblePadre = item.IdCtaCblePadre;
                    pli.IdEmpresa = item.IdEmpresa;
                    pli.IdGrupoCble = item.IdGrupoCble;
                    pli.IdNivelCta = item.IdNivelCta;
                    pli.pc_Cuenta = item.pc_Cuenta;
                    pli.pc_Cuenta2 = item.IdCtaCble + " - " + item.pc_Cuenta;
                    pli.pc_EsMovimiento = item.pc_EsMovimiento;
                    pli.pc_Estado = item.pc_Estado;
                    pli.pc_Naturaleza = item.pc_Naturaleza;

                    plNi.IdEmpresa = item.IdEmpresa;
                    plNi.IdNivelCta = item.IdNivelCta;
                    plNi.nv_NumDigitos = item.nv_NumDigitos;

                    Cbt1._cbteCble_det_info = Cbtdt;
                    Cbt1._cbteCble_det_info._Plancta_Info = pli;
                    Cbt1._cbteCble_det_info._Plancta_Info._Plancta_nivel_Info = plNi;

                    lM.Add(Cbt1);
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

        public Boolean ModificarDB(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> listadetalle = new List<ct_Cbtecble_det_Info>();
                listadetalle = _CbteCbleInfo._cbteCble_det_lista_info;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble && tbCbteCble.IdTipoCbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                        contact.cb_Anio = _CbteCbleInfo.cb_Fecha.Year;
                        contact.cb_Estado = _CbteCbleInfo.Estado;
                        contact.IdUsuarioUltModi = (_CbteCbleInfo.IdUsuarioUltModi != "") ? _CbteCbleInfo.IdUsuarioUltModi : _CbteCbleInfo.IdUsuario;
                        contact.cb_Fecha = _CbteCbleInfo.cb_Fecha;
                        contact.cb_FechaUltModi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        contact.cb_Mayorizado = "N";
                        contact.cb_mes = _CbteCbleInfo.cb_Fecha.Month;
                        contact.cb_Observacion = _CbteCbleInfo.cb_Observacion;
                        contact.cb_Secuencia = _CbteCbleInfo.Secuencia;
                        contact.cb_Valor = _CbteCbleInfo.cb_Valor;
                        
                        contact.IdSucursal = _CbteCbleInfo.IdSucursal;
                        context.SaveChanges();
                    }
                }

                ct_Cbtecble_det_Data _CbteCble_Det_Data = new ct_Cbtecble_det_Data();
                using(EntitiesDBConta EntCbteCbleDet = new EntitiesDBConta())
                {
                    EntCbteCbleDet.SetCommandTimeOut(3000);

                    var sql = EntCbteCbleDet.ct_cbtecble_det.Where(C => C.IdEmpresa == _CbteCbleInfo.IdEmpresa
                              && C.IdCbteCble == _CbteCbleInfo.IdCbteCble
                              && C.IdTipoCbte == _CbteCbleInfo.IdTipoCbte).ToList();

                    foreach (var item in sql)
                    {
                        EntCbteCbleDet.ct_cbtecble_det.Remove(item);
                    }
                    EntCbteCbleDet.SaveChanges();
                    ct_Cbtecble_det_Data data = new ct_Cbtecble_det_Data();

                    int sec = 0;
                    foreach (var reg in listadetalle)
                    {
                        sec = sec+1;
                        reg.secuencia = sec;
                        reg.IdCbteCble = _CbteCbleInfo.IdCbteCble;
                        reg.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                        data.GrabarDB(reg, ref MensajeError);
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
                mensaje = ex.InnerException + " " + ex.Message;
                MensajeError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Modificar_cabecera(ct_Cbtecble_Info _CbteCbleInfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble && tbCbteCble.IdTipoCbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                        contact.cb_Anio = _CbteCbleInfo.cb_Fecha.Year;
                        contact.cb_Estado = _CbteCbleInfo.Estado;
                        contact.IdUsuarioUltModi = (_CbteCbleInfo.IdUsuarioUltModi != "") ? _CbteCbleInfo.IdUsuarioUltModi : _CbteCbleInfo.IdUsuario;
                        contact.cb_Fecha = _CbteCbleInfo.cb_Fecha;
                        contact.cb_FechaUltModi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        contact.cb_Mayorizado = "N";
                        contact.cb_mes = _CbteCbleInfo.cb_Fecha.Month;
                        contact.cb_Observacion = _CbteCbleInfo.cb_Observacion;
                        contact.cb_Secuencia = _CbteCbleInfo.Secuencia;
                        contact.cb_Valor = _CbteCbleInfo.cb_Valor;
                        
                        contact.IdSucursal = _CbteCbleInfo.IdSucursal;
                        context.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Actualizar_Observacion(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> listadetalle = new List<ct_Cbtecble_det_Info>();
                listadetalle = _CbteCbleInfo._cbteCble_det_lista_info;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_cbtecble.FirstOrDefault(tbCbteCble => tbCbteCble.IdEmpresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.IdCbteCble == _CbteCbleInfo.IdCbteCble && tbCbteCble.IdTipoCbte == _CbteCbleInfo.IdTipoCbte);

                    if (contact != null)
                    {
                       contact.cb_Observacion = _CbteCbleInfo.cb_Observacion;
                        context.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                MensajeError = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_Info _CbteCbleInfo, ref decimal IdCbteCble, ref string cod_CbteCble, ref string MensajeError)
        {
            try
            {
                try
                {

                    string codigo_CbteCble = "";
                    using (EntitiesDBConta context = new EntitiesDBConta())
                    {
                        context.SetCommandTimeOut(3000);
                        
                            var address = new ct_cbtecble();
                            address.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                            address.IdCbteCble = IdCbteCble = _CbteCbleInfo.IdCbteCble = Get_IdCbteCble(_CbteCbleInfo.IdEmpresa, _CbteCbleInfo.IdTipoCbte, ref MensajeError);
                            address.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;

                            codigo_CbteCble = (_CbteCbleInfo.CodCbteCble == null || _CbteCbleInfo.CodCbteCble == "") ? address.IdCbteCble.ToString() : _CbteCbleInfo.CodCbteCble;

                            address.CodCbteCble = codigo_CbteCble;

                            address.IdPeriodo = _CbteCbleInfo.IdPeriodo;
                            address.cb_Fecha = Convert.ToDateTime(_CbteCbleInfo.cb_Fecha.ToShortDateString());
                            address.cb_Valor = _CbteCbleInfo.cb_Valor;
                            address.cb_Observacion = (_CbteCbleInfo.cb_Observacion == null) ? "" : _CbteCbleInfo.cb_Observacion;
                            address.cb_Secuencia = Get_IdSecuencia(_CbteCbleInfo.IdEmpresa, ref MensajeError);
                            address.cb_Estado = _CbteCbleInfo.Estado;
                            address.cb_Anio = _CbteCbleInfo.cb_Fecha.Year;
                            address.cb_mes = Convert.ToByte(_CbteCbleInfo.cb_Fecha.Month);
                            address.IdUsuario = (_CbteCbleInfo.IdUsuario == null) ? "" : _CbteCbleInfo.IdUsuario;
                            address.IdSucursal = _CbteCbleInfo.IdSucursal;
                            address.cb_FechaTransac = DateTime.Now;
                            address.cb_Mayorizado = _CbteCbleInfo.Mayorizado;
                            address.cb_para_conciliar = false;


                            context.ct_cbtecble.Add(new ct_cbtecble
                            {
                                IdEmpresa = _CbteCbleInfo.IdEmpresa,
                                IdCbteCble = IdCbteCble = _CbteCbleInfo.IdCbteCble = Get_IdCbteCble(_CbteCbleInfo.IdEmpresa, _CbteCbleInfo.IdTipoCbte, ref MensajeError),
                                IdTipoCbte = _CbteCbleInfo.IdTipoCbte,
                                CodCbteCble = (_CbteCbleInfo.CodCbteCble == null || _CbteCbleInfo.CodCbteCble == "") ? IdCbteCble.ToString() : _CbteCbleInfo.CodCbteCble,
                                IdPeriodo = _CbteCbleInfo.IdPeriodo,
                                cb_Fecha = Convert.ToDateTime(_CbteCbleInfo.cb_Fecha.ToShortDateString()),
                                cb_Valor = _CbteCbleInfo.cb_Valor,
                                cb_Observacion = (_CbteCbleInfo.cb_Observacion == null) ? "" : _CbteCbleInfo.cb_Observacion,
                                cb_Secuencia = Get_IdSecuencia(_CbteCbleInfo.IdEmpresa, ref MensajeError),
                                cb_Estado = _CbteCbleInfo.Estado,
                                cb_Anio = _CbteCbleInfo.cb_Fecha.Year,
                                cb_mes = Convert.ToByte(_CbteCbleInfo.cb_Fecha.Month),
                                IdUsuario = (_CbteCbleInfo.IdUsuario == null) ? "" : _CbteCbleInfo.IdUsuario,
                                IdSucursal = _CbteCbleInfo.IdSucursal,
                                cb_FechaTransac = DateTime.Now,
                                cb_Mayorizado = _CbteCbleInfo.Mayorizado,
                                cb_para_conciliar = false,
                            });


                            context.SaveChanges();

                            ct_Cbtecble_det_Data _CbteCble_Det_Data = new ct_Cbtecble_det_Data();
                            string obser = "";
                            int sec = 1;
                            foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                            {
                                obser = "";
                                item.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                                item.IdCbteCble = _CbteCbleInfo.IdCbteCble;
                                item.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                                item.dc_Observacion = item.dc_Observacion == null ? "" : item.dc_Observacion;
                                if (item.dc_Observacion.Length == 0)
                                {
                                    obser = address.cb_Observacion;
                                }
                                else
                                {
                                    obser = item.dc_Observacion;
                                }
                                item.dc_Observacion = obser;
                                item.secuencia = sec;
                                sec = sec + 1;
                                _CbteCble_Det_Data.GrabarDB(item, ref MensajeError);
                            }
                    }
                    MensajeError = "Grabado exitosamente el Cbte#" + IdCbteCble;
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string mensaje = "";
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    context.Database.ExecuteSqlCommand("delete ct_cbtecble_det where IdEmpresa = " + _CbteCbleInfo.IdEmpresa + " and IdCbteCble = " + _CbteCbleInfo.IdCbteCble + " and IdTipoCbte=" + _CbteCbleInfo.IdTipoCbte);
                    context.Database.ExecuteSqlCommand("delete ct_cbtecble where IdEmpresa = " + _CbteCbleInfo.IdEmpresa + " and IdCbteCble = " + _CbteCbleInfo.IdCbteCble + " and IdTipoCbte=" + _CbteCbleInfo.IdTipoCbte);

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

        public ct_Cbtecble_Info Get_Info_CbteCble(int IdEmpresa, int IdTipoCbte, decimal IdCbteCbl, ref string MensajeError) 
        {
            try
            {
                ct_Cbtecble_Info Cbt = new ct_Cbtecble_Info();
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var select = from var in context.ct_cbtecble
                                 where var.IdEmpresa == IdEmpresa 
                                 && var.IdTipoCbte == IdTipoCbte
                                 && var.IdCbteCble == IdCbteCbl
                                 select var;

                    foreach (var item in select)
                    {
                        Cbt.IdEmpresa = item.IdEmpresa;
                        Cbt.IdTipoCbte = item.IdTipoCbte;
                        Cbt.IdCbteCble = item.IdCbteCble;
                        Cbt.IdPeriodo = item.IdPeriodo;
                        Cbt.CodCbteCble = item.CodCbteCble;
                        Cbt.cb_Fecha = Convert.ToDateTime(item.cb_Fecha.ToShortDateString());
                        Cbt.cb_Valor = item.cb_Valor;
                        Cbt.cb_Valor = item.cb_Valor;
                        Cbt.cb_Observacion = item.cb_Observacion;
                        Cbt.Secuencia = Convert.ToDecimal(item.cb_Secuencia);
                        Cbt.Estado = item.cb_Estado;
                        Cbt.Anio = item.cb_Anio;
                        Cbt.Mes = Convert.ToInt32(item.cb_mes);
                        Cbt.IdUsuario = item.IdUsuario;
                        Cbt.IdUsuarioAnu = item.IdUsuarioAnu;
                        Cbt.cb_MotivoAnu = item.cb_MotivoAnu;
                        Cbt.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Cbt.cb_FechaAnu = Convert.ToDateTime(item.cb_FechaAnu);
                        Cbt.cb_FechaTransac = Convert.ToDateTime(item.cb_FechaTransac);
                        Cbt.cb_FechaUltModi = Convert.ToDateTime(item.cb_FechaUltModi);
                        Cbt.Mayorizado = item.cb_Mayorizado;
                        
                        Cbt.IdSucursal = item.IdSucursal;
                    }
              
               }
                return Cbt;

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
     
        public decimal Get_Numeros_Cbtes_no_Contabilizados(int IdEmpresa, DateTime fecha_Ini,DateTime fecha_Fin, ref string MensajeError)
        {

            try
            {
                decimal Num_cbtes;

                fecha_Ini = Convert.ToDateTime(fecha_Ini.ToShortDateString());
                fecha_Fin = Convert.ToDateTime(fecha_Fin.ToShortDateString());


                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var select = (from CbtCble in OECbtecble.ct_cbtecble
                              where CbtCble.IdEmpresa == IdEmpresa
                              && CbtCble.cb_Fecha >= fecha_Ini && CbtCble.cb_Fecha <= fecha_Fin 
                              && CbtCble.cb_Mayorizado.ToUpper() =="N" 
                              select CbtCble.cb_Secuencia).Count();


                Num_cbtes = Convert.ToDecimal(select.ToString());

                return Num_cbtes;


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

        public DateTime Get_fecha_min_cbtes_no_Mayorizado(int IdEmpresa, DateTime fecha_Ini, DateTime fecha_fin, ref string MensajeError)
        {

            try
            {

                DateTime fecha_min;


                fecha_Ini = Convert.ToDateTime(fecha_Ini.ToShortDateString());
                fecha_fin = Convert.ToDateTime(fecha_fin.ToShortDateString());


                EntitiesDBConta OECbtecble = new EntitiesDBConta();

                var select = (from CbtCble in OECbtecble.ct_cbtecble
                              where CbtCble.IdEmpresa == IdEmpresa
                              && CbtCble.cb_Fecha >= fecha_Ini && CbtCble.cb_Fecha <= fecha_fin
                              && CbtCble.cb_Mayorizado.ToUpper() == "N"
                              select CbtCble.cb_Fecha).Min();

                fecha_min = Convert.ToDateTime(select.ToString());

                return fecha_min;


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

        public List<XCONTA_Rpt023> GetList(int IdEmpresa, string IdCentroCosto, int Nivel, DateTime FechaFin, string IdUsuario, string Balance, bool MostrarSaldo0)
        {
            try
            {
                List<XCONTA_Rpt023> Lista = new List<XCONTA_Rpt023>();
                int Anio = FechaFin.Year;
                DateTime FechaIni = new DateTime(Anio, 1, 1);
                FechaFin = FechaFin.Date;
                using (EntitiesDBConta db = new EntitiesDBConta())
                {
                    //GET PLAN DE CUENTAS
                    var lst_plancta = (from q in db.ct_plancta
                                       join c in db.ct_grupocble
                                       on q.IdGrupoCble equals c.IdGrupoCble
                                       where q.IdEmpresa == IdEmpresa
                                       && c.gc_estado_financiero == Balance
                                       select new
                                        {
                                            IdCtaCble = q.IdCtaCble,
                                            IdCtaCblePadre = q.IdCtaCblePadre,
                                            NombreCuenta = q.pc_Cuenta,
                                            Signo = c.gc_signo_operacion,
                                            Nivel = q.IdNivelCta,
                                            pc_Naturaleza = q.pc_Naturaleza
                                        }).ToList();

                    //GET LISTADO SUBCENTROS
                    var lst_centro = (from c in db.ct_centro_costo                                         
                                         where c.IdEmpresa == IdEmpresa && c.IdCentroCosto == IdCentroCosto
                                         select new
                                         {
                                             IdEmpresa = c.IdEmpresa,
                                             IdCentroCosto = c.IdCentroCosto,
                                             NombreCentroCosto = c.Centro_costo,
                                         }).ToList();


                    //RECORRO LISTAS PARA CREAR PLANTILLA INICIAL DE PLAN DE CUENTAS X SUBCENTROS
                    lst_centro.ForEach(q =>
                    {
                        lst_plancta.ForEach(c =>
                        {
                            db.ct_spCONTA_Rpt023.Add( new ct_spCONTA_Rpt023
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdCentroCosto = q.IdCentroCosto,
                                NombreCentroCosto = q.NombreCentroCosto,
                                NombreCuenta = c.NombreCuenta,
                                IdCtaCble = c.IdCtaCble,
                                IdCtaCblePadre = c.IdCtaCblePadre,
                                Naturaleza = c.pc_Naturaleza,
                                NivelCuenta = c.Nivel,
                                EsCuentaMovimiento = false,
                                IdUsuario = IdUsuario,
                                
                                //OBTENGO EL VALOR DE LA CUENTA CONTABLE POR EL SUBCENTRO
                                Saldo = 0,
                                SaldoNaturaleza = 0,
                            });
                        });
                    });

                    db.SaveChanges();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
      
        public ct_Cbtecble_Data() 
        {
        
        }
    }

    public class XCONTA_Rpt023
    {
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string NombreCentroCosto { get; set; }
        public string NombreSubCentroCosto { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCblePadre { get; set; }
        public string NombreCuenta { get; set; }
        public int? Signo { get; set; }
        public double? Saldo { get; set; }

        public int Nivel { get; set; }
    }
}
