using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Conciliacion_Data
    {
        string mensaje = "";

        public List<vwba_TransaccionesAConciliar_Info> Get_List_Transacciones_x_Conciliar(int IdEmpresa, string IdCtaCble, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> lM = new List<vwba_TransaccionesAConciliar_Info>();
                EntitiesBanco b = new EntitiesBanco();


                var select_ = from T in b.vwba_TransaccionesAConciliar
                              where T.IdEmpresa == IdEmpresa && T.IdCtaCble == IdCtaCble
                               && T.cb_Fecha <= F_fin
                               && T.@checked==0
                               && T.IdConciliacion==0
                              select T;
                foreach (var item in select_)
                {
                    vwba_TransaccionesAConciliar_Info dat_ = new vwba_TransaccionesAConciliar_Info();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdConciliacion = item.IdConciliacion;
                    dat_.IdBanco = item.IdBanco;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.dc_Observacion = item.dc_Observacion;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.nom_IdTipoCbte = item.nom_IdTipoCbte;
                    dat_.dc_Valor = item.dc_Valor;
                    dat_.fechaConciliacion = item.fechaConciliacion;
                    dat_.Estado = item.IdEstado_Concil_Cat;
                    dat_.SecuenciaCbteCble = item.secuencia;
                    dat_.cb_Cheque = item.cb_Cheque;

                    dat_.IdTipocbte =Convert.ToInt32( item.IdTipoCbte);
                    if (item.@checked == 1)
                    {
                        dat_.chk = true;
                    }
                    else
                    {
                        dat_.chk = false;
                    }

                    dat_.IdCbteCble = item.IdCbteCble;
                    if (item.dc_Valor <= 0) 
                    {
                        dat_.Tipo = "-";
                        dat_.dc_Valor = dat_.dc_Valor * -1;
                    }
                    else
                    {
                        dat_.Tipo = "+";
                    }
                    dat_.chk = false;

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

        public List<vwba_TransaccionesAConciliar_Info> Get_List_Transacciones_x_Conciliar(int IdEmpresa, string IdCtaCble, DateTime F_inicio, DateTime F_fin, int IdConciliacion, int IdBanco)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> lM = new List<vwba_TransaccionesAConciliar_Info>();
                EntitiesBanco b = new EntitiesBanco();


                var select_ = from T in b.vwba_TransaccionesAConciliar
                              where T.IdEmpresa == IdEmpresa && T.IdCtaCble == IdCtaCble
                              && T.IdBanco == IdBanco 
                              && T.cb_Fecha <= F_fin
                              && (T.IdConciliacion == IdConciliacion
                              || T.IdConciliacion == 0)
                              select T;
                

                foreach (var item in select_)
                {
                    vwba_TransaccionesAConciliar_Info dat_ = new vwba_TransaccionesAConciliar_Info();                 
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdConciliacion = item.IdConciliacion;
                    dat_.IdBanco = item.IdBanco;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.dc_Observacion = item.dc_Observacion;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.nom_IdTipoCbte = item.nom_IdTipoCbte;
                    dat_.dc_Valor = item.dc_Valor;
                    dat_.fechaConciliacion = item.fechaConciliacion;
                    dat_.Estado = item.IdEstado_Concil_Cat;
                    dat_.IdTipocbte = item.IdTipoCbte;
                    dat_.SecuenciaCbteCble = item.secuencia;
                    dat_.nom_IdTipoCbte = item.nom_IdTipoCbte;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.co_SaldoBanco_anterior = item.co_SaldoBanco_anterior;
                    if (item.@checked == 1)
                    {
                        dat_.chk = true;
                    }
                    else
                    {
                        dat_.chk = false;
                    }

                    dat_.IdCbteCble = item.IdCbteCble;
                    if (item.dc_Valor <= 0)
                    {
                        dat_.Tipo = "-";
                        dat_.dc_Valor = dat_.dc_Valor * -1;

                    }
                    else
                    {
                        dat_.Tipo = "+";
                    }
                   

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

        public List<ba_Conciliacion_Info> Get_List_Conciliacion(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                int IdPeriodo_ini = Convert.ToInt32(Fecha_ini.Date.Year.ToString() + Fecha_ini.Date.Month.ToString("00"));
                int IdPeriodo_fin = Convert.ToInt32(Fecha_fin.Date.Year.ToString() + Fecha_fin.Date.Month.ToString("00"));

                
                List<ba_Conciliacion_Info> lM = new List<ba_Conciliacion_Info>();
                EntitiesBanco db = new EntitiesBanco();

                var select_ = from T in db.ba_Conciliacion
                              join q in db.ba_Banco_Cuenta
                              on new { T.IdEmpresa, T.IdBanco } equals new { q.IdEmpresa, q.IdBanco }
                              where T.IdEmpresa == IdEmpresa
                              && IdPeriodo_ini <= T.IdPeriodo
                              && T.IdPeriodo <= IdPeriodo_fin
                              select new
                              {
                                  T.IdEmpresa,
                                  T.IdConciliacion,
                                  T.IdBanco,
                                  T.IdPeriodo,
                                  T.co_Fecha,
                                  T.co_SaldoContable_MesAnt,
                                  T.co_totalIng,
                                  T.co_totalEgr,
                                  T.co_SaldoContable_MesAct,
                                  T.co_SaldoBanco_EstCta,
                                  T.co_Cant_Cheque,
                                  T.co_Cant_Deposito,
                                  T.co_Cant_NC,
                                  T.co_Cant_ND,
                                  T.co_TotalCheque,
                                  T.co_TotalDepositos,
                                  T.co_totalNC,
                                  T.co_TotalND,
                                  T.Estado,
                                  T.IdUsuario,
                                  T.IdUsuario_Anu,
                                  T.IdUsuarioUltMod,
                                  T.Fecha_Transac,
                                  T.Fecha_UltMod,
                                  T.FechaAnulacion,
                                  T.ip,
                                  T.nom_pc,
                                  T.MotivoAnulacion,
                                  T.co_Cant_OtrosIng,
                                  T.co_TotalOtrosIng,
                                  T.co_Cant_OtrosEgr,
                                  T.co_TotalOtrosEgr,
                                  T.co_Observacion,
                                  q.ba_descripcion,
                                  T.IdEstado_Concil_Cat,
                                  T.co_SaldoBanco_anterior
                              };


                foreach (var item in select_)
                {
                    ba_Conciliacion_Info dat = new ba_Conciliacion_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdConciliacion= item.IdConciliacion;
                    dat.IdBanco = item.IdBanco;
                    dat.IdPeriodo = item.IdPeriodo;
                    dat.co_Fecha = item.co_Fecha;
                    dat.co_SaldoContable_MesAnt = item.co_SaldoContable_MesAnt;
                    dat.co_totalIng = item.co_totalIng;
                    dat.co_totalEgr= item.co_totalEgr;
                    dat.co_SaldoContable_MesAct= item.co_SaldoContable_MesAct;
                    dat.co_SaldoBanco_EstCta= item.co_SaldoBanco_EstCta;
                    dat.co_Cant_Cheque = item.co_Cant_Cheque;
                    dat.co_Cant_Deposito = item.co_Cant_Deposito;
                    dat.co_Cant_NC = item.co_Cant_NC;
                    dat.co_Cant_ND = item.co_Cant_ND;
                    dat.co_Cant_OtrosIng = item.co_Cant_OtrosIng;
                    dat.co_TotalOtrosIng = item.co_TotalOtrosIng;
                    dat.co_Cant_OtrosEgr = item.co_Cant_OtrosEgr;
                    dat.co_TotalOtrosEgr = item.co_TotalOtrosEgr;
                    dat.co_TotalCheque = item.co_TotalCheque;
                    dat.co_TotalDepositos= item.co_TotalDepositos;
                    dat.co_totalNC = item.co_totalNC;
                    dat.co_TotalND = item.co_TotalND;
                    dat.Estado= item.Estado;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.MotivoAnulacion = item.MotivoAnulacion;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.FechaAnulacion = item.FechaAnulacion;
                    dat.ba_descripcion = item.ba_descripcion;
                    dat.Estado_Conciliacion = item.IdEstado_Concil_Cat;
                    dat.co_SaldoBanco_anterior = item.co_SaldoBanco_anterior;
                   
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal  Id;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_Conciliacion
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from T in base_.ba_Conciliacion
                                   where T.IdEmpresa == IdEmpresa
                                   select T.IdConciliacion).Max();
                    Id = select_ + 1;
                    return Id;
                }
            }
            catch (Exception ex )
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

        public Boolean GrabarDB(ba_Conciliacion_Info info, ref decimal IdConciliacion, ref string msg)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();


                    var address = new ba_Conciliacion();

                    IdConciliacion = GetId(info.IdEmpresa);
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdConciliacion = IdConciliacion;
                    address.IdBanco = info.IdBanco;
                    address.IdPeriodo = info.IdPeriodo;
                    address.co_Fecha = info.co_Fecha;
                    address.co_SaldoContable_MesAnt = info.co_SaldoContable_MesAnt;
                    address.co_totalIng = info.co_totalIng;
                    address.co_totalEgr = info.co_totalEgr;
                    address.co_SaldoContable_MesAct = info.co_SaldoContable_MesAct;
                    address.co_SaldoBanco_EstCta = info.co_SaldoBanco_EstCta;
                    address.co_Cant_Cheque = info.co_Cant_Cheque;
                    address.co_Cant_Deposito = info.co_Cant_Deposito;
                    address.co_Cant_NC = info.co_Cant_NC;
                    address.co_Cant_ND = info.co_Cant_ND;
                    address.co_Cant_OtrosIng = info.co_Cant_OtrosIng;
                    address.co_TotalOtrosIng = info.co_TotalOtrosIng;
                    address.co_Cant_OtrosEgr = info.co_Cant_OtrosEgr;
                    address.co_TotalOtrosEgr = info.co_TotalOtrosEgr;
                    address.co_TotalCheque = info.co_TotalCheque;
                    address.co_TotalDepositos = info.co_TotalDepositos;
                    address.co_totalNC = info.co_totalNC;
                    address.co_TotalND = info.co_TotalND;
                    address.Estado = info.Estado;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.ip = info.ip;
                    address.nom_pc = info.nom_pc;
                    address.IdEstado_Concil_Cat = info.Estado_Conciliacion;
                    address.co_Observacion = info.co_Observacion;
                    address.co_SaldoBanco_anterior = info.co_SaldoBanco_anterior;
                    context.ba_Conciliacion.Add(address);
                    context.SaveChanges();

                    //GUARDA LA LISTA DE CONCILIADOS
                    ba_Conciliacion_det_IngEgr_Data ConciIngEgr_D = new ba_Conciliacion_det_IngEgr_Data();
                    int secuencia = 0;
                    foreach (var item in info.LstConciliadas)
                    {
                       // if (item.chk)
                        {
                            secuencia += 1;
                            item.secuencia = secuencia;
                            item.IdEmpresa = info.IdEmpresa;
                            item.IdConciliacion = IdConciliacion;

                            ConciIngEgr_D.GrabarDB(item);
                        }
                    }
                    msg = "Se ha procedido a generar el id de la Conciliación #: " + IdConciliacion.ToString() + " exitosamente.";
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
                msg = "Mensaje de error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(ba_Conciliacion_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Conciliacion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion);
                    if (contact != null)
                    {
                        contact.IdBanco = info.IdBanco;
                        contact.IdPeriodo = info.IdPeriodo;
                        contact.co_Fecha = info.co_Fecha;
                        
                        contact.co_totalIng = info.co_totalIng;
                        contact.co_totalEgr = info.co_totalEgr;
                        
                        contact.co_SaldoContable_MesAct = info.co_SaldoContable_MesAct;
                        contact.co_SaldoBanco_EstCta = info.co_SaldoBanco_EstCta;

                        contact.co_Cant_Cheque = info.co_Cant_Cheque;
                        contact.co_Cant_Deposito = info.co_Cant_Deposito;
                        contact.co_Cant_NC = info.co_Cant_NC;
                        if (info.Estado_Conciliacion == null)
                            info.Estado_Conciliacion = "X_CONCILIAR";
                        contact.co_Cant_ND = info.co_Cant_ND;
                        contact.co_Cant_OtrosIng = info.co_Cant_OtrosIng;
                        contact.co_TotalOtrosIng = info.co_TotalOtrosIng;
                        contact.co_Cant_OtrosEgr = info.co_Cant_OtrosEgr;
                        contact.co_TotalOtrosEgr = info.co_TotalOtrosEgr;
                        contact.co_TotalCheque = info.co_TotalCheque;
                        contact.co_TotalDepositos = info.co_TotalDepositos;
                        contact.co_totalNC = info.co_totalNC;
                        contact.co_TotalND = info.co_TotalND;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdEstado_Concil_Cat = info.Estado_Conciliacion;
                        contact.co_Observacion = info.co_Observacion;
                        contact.co_SaldoBanco_anterior = info.co_SaldoBanco_anterior;
                        context.SaveChanges();
                        //GUARDA LA LISTA DE CONCILIADOS
                        ba_Conciliacion_det_IngEgr_Data ConciIngEgr_D = new ba_Conciliacion_det_IngEgr_Data();

                        ConciIngEgr_D.EliminarDB(info.IdEmpresa, Convert.ToInt32(info.IdConciliacion));

                        int secuencia = 0;
                        foreach (var item in info.LstConciliadas)
                        {
                            //if (item.chk)
                            {
                                secuencia += 1;
                                item.secuencia = secuencia;
                                item.IdEmpresa = info.IdEmpresa;
                                item.IdConciliacion = info.IdConciliacion;
                                item.tipo_IngEgr = item.Tipo;
                                ConciIngEgr_D.GrabarDB(item);    
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Se decidió eliminar por completo de la base para asegurar consistencia de registros aprobado por RICARDO YANZA                      
        /// </summary>
        public Boolean EliminarDB(ba_Conciliacion_Info info)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    Context.Database.ExecuteSqlCommand("delete ba_Conciliacion where IdEmpresa = " + info.IdEmpresa + " and IdConciliacion = " + info.IdConciliacion);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ba_Conciliacion_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    /* Se decidió eliminar por completo de la base para asegurar consistencia de registros
                     * Aprobado por RICARDO YANZA
                     */ 
                    var contact = context.ba_Conciliacion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.FechaAnulacion = info.FechaAnulacion;
                        contact.IdUsuario_Anu = info.IdUsuario_Anu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public ba_Conciliacion_Info Get_Info_Conciliacion_x_Rpt(int IdEmpresa, int IdConciliacion)
        {
            try
            {
                ba_Conciliacion_Info datos = new ba_Conciliacion_Info();
                ba_Conciliacion_det_IngEgr_Data Concili_D = new ba_Conciliacion_det_IngEgr_Data();
                ba_Conciliacion_det_no_conciliado_Data NoConcili_D = new ba_Conciliacion_det_no_conciliado_Data();


                EntitiesBanco db = new EntitiesBanco();

                var select_ = from T in db.vwba_Conciliacion

                              where T.IdEmpresa == IdEmpresa && T.IdConciliacion == IdConciliacion
                              select T;


                foreach (var item in select_)
                {
                    datos.IdEmpresa = item.IdEmpresa;
                    datos.IdConciliacion = item.IdConciliacion;
                    datos.IdBanco = item.IdBanco;
                    datos.IdPeriodo = item.IdPeriodo;
                    datos.co_Fecha = item.co_Fecha;
                    datos.co_SaldoContable_MesAnt = item.co_SaldoContable_MesAnt;
                    datos.co_totalIng = item.co_totalIng;
                    datos.co_totalEgr = item.co_totalEgr;
                    datos.co_SaldoContable_MesAct = item.co_SaldoContable_MesAct;
                    datos.co_SaldoBanco_EstCta = item.co_SaldoBanco_EstCta;
                    datos.co_Cant_Cheque = item.co_Cant_Cheque;
                    datos.co_Cant_Deposito = item.co_Cant_Deposito;
                    datos.co_Cant_NC = item.co_Cant_NC;
                    datos.co_Cant_ND = item.co_Cant_ND;
                    datos.co_Cant_OtrosIng = item.co_Cant_OtrosIng;
                    datos.co_TotalOtrosIng = item.co_TotalOtrosIng;
                    datos.co_Cant_OtrosEgr = item.co_Cant_OtrosEgr;
                    datos.co_TotalOtrosEgr = item.co_TotalOtrosEgr;
                    datos.co_TotalCheque = item.co_TotalCheque;
                    datos.co_TotalDepositos = item.co_TotalDepositos;
                    datos.co_totalNC = item.co_totalNC;
                    datos.co_TotalND = item.co_TotalND;
                    datos.Estado = item.Estado;
                    datos.IdUsuario = item.IdUsuario;
                    datos.IdUsuario_Anu = item.IdUsuario_Anu;
                    datos.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    datos.MotivoAnulacion = item.MotivoAnulacion;
                    datos.Fecha_Transac = item.Fecha_Transac;
                    datos.Fecha_UltMod = item.Fecha_UltMod;
                    datos.FechaAnulacion = item.FechaAnulacion;
                    datos.co_Observacion = item.co_Observacion;
                    datos.ba_descripcion = item.ba_descripcion;
                    datos.IdCtaCble = item.IdCtaCble;
                    datos.Periodo = item.Periodo;
                    datos.co_SaldoBanco_anterior = item.co_SaldoBanco_anterior;
                }

                datos.LstConciliadaRPT = Concili_D.Get_List_ConciIngEgr(IdEmpresa, IdConciliacion);
               // datos.LstNoConciliadaRPT = NoConcili_D.Get_List_TransaccionesAConciliar(IdEmpresa, IdConciliacion);
                return datos;
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

        public Boolean VerificarPeriodoConciliado(int IdEmpresa , int IdPeriodo, int IdBanco) 
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {

                    if ((from q in Entity.ba_Conciliacion where q.IdEmpresa == IdEmpresa 
                             && q.IdPeriodo == IdPeriodo && q.IdBanco == IdBanco && q.Estado == "A" select q).Count() != 0)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean VerificarConciliacionPrimeraVez(int IdEmpresa, int Idbanco) 
        {
            try
            {
                using (EntitiesBanco  Entity = new EntitiesBanco())
                {
                    int Cantidad = (from q in Entity.ba_Conciliacion where q.IdEmpresa == IdEmpresa && q.IdBanco == Idbanco && q.Estado=="A" select q).Count();

                    if (Cantidad != 0) 
                    {
                        return false;
                    }
                        else
                    {
                        return true;
                    }
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean VerficiacionParaAnular(int IdEmpresa, int IdBanco, int IdPeriodo) 
        {
            try
            {
                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    int cantidad = (from q in Conexion.ba_Conciliacion 
                                    where q.IdEmpresa == IdEmpresa && q.IdBanco == IdBanco 
                                    && q.IdPeriodo == IdPeriodo && q.Estado =="A" select q).Count();

                    if (cantidad != 0)
                    {
                        //esta pregunta esta en blanco, no hace nada
                    }
                    else 
                    {
                    
                    }
                }

                return false;
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
    }
}
