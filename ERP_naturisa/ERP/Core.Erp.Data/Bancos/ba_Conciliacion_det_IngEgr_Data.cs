using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Data.Bancos
{
    public class ba_Conciliacion_det_IngEgr_Data
    {
        string mensaje = "";

        public List<ba_Conciliacion_det_IngEgr_Info> Get_List_Conciliacion_det_IngEgr(int IdEmpresa)
        {
            try
            {
                List<ba_Conciliacion_det_IngEgr_Info> lM = new List<ba_Conciliacion_det_IngEgr_Info>();
                EntitiesBanco db = new EntitiesBanco();

                var select_ = from T in db.ba_Conciliacion_det_IngEgr
                              where T.IdEmpresa == IdEmpresa
                              select T;


                foreach (var item in select_)
                {
                    ba_Conciliacion_det_IngEgr_Info dat = new ba_Conciliacion_det_IngEgr_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdConciliacion = item.IdConciliacion;
                    dat.Secuencia = item.Secuencia;
                    dat.tipo_IngEgr = item.tipo_IngEgr;
                    dat.IdCbteCble = item.IdCbteCble;
                    dat.IdTipocbte = item.IdTipocbte;
                    dat.SecuenciaCbteCble = item.SecuenciaCbteCble;
                    dat.Estado = item.Estado;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.FechaAnulacion = item.FechaAnulacion;
                    dat.ip = item.ip;
                    dat.nom_pc = item.nom_pc;
                    dat.MotivoAnulacion = item.MotivoAnulacion;

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

        public List<ct_Cbtecble_det_Info> Get_List_Conciliacion_det_IngEgr(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                List<ct_Cbtecble_det_Info> lM = new List<ct_Cbtecble_det_Info>();
                EntitiesBanco db = new EntitiesBanco();

                var select_ = from T in db.ba_Conciliacion_det_IngEgr
                              where T.IdEmpresa == IdEmpresa
                              && T.IdTipocbte == IdTipoCbte
                              && T.IdCbteCble == IdCbteCble
                              group T by new
                              {
                                  T.IdEmpresa,
                                  T.IdTipocbte,
                                  T.IdCbteCble,
                                  T.SecuenciaCbteCble
                              } into grouping
                              select new ct_Cbtecble_det_Info
                              {
                                  IdEmpresa = grouping.Key.IdEmpresa,
                                  IdTipoCbte = grouping.Key.IdTipocbte,
                                  IdCbteCble = grouping.Key.IdCbteCble,
                                  secuencia = grouping.Key.SecuenciaCbteCble
                              };


                foreach (var item in select_)
                {
                    ct_Cbtecble_det_Info dat = new ct_Cbtecble_det_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdTipoCbte = item.IdTipoCbte;
                    dat.IdCbteCble = item.IdCbteCble;
                    dat.secuencia = item.secuencia;

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

        public int GetSecuencia(int IdEmpresa,int IdConciliacion)
        {
            try
            {
                int Id;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_Conciliacion_det_IngEgr
                        where C.IdEmpresa == IdEmpresa && C.IdConciliacion == IdConciliacion
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from T in base_.ba_Conciliacion_det_IngEgr
                                   where T.IdEmpresa == IdEmpresa && T.IdConciliacion == IdConciliacion
                                   select T.Secuencia).Max();
                    Id = select_ + 1;
                    return Id;
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

        public Boolean GrabarDB(vwba_TransaccionesAConciliar_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();

                    //var contact = ba_Conciliacion_det_IngEgr.Createba_Conciliacion_det_IngEgr(0,0,0,"",0,0,0);
                    var address = new ba_Conciliacion_det_IngEgr();

             
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdConciliacion = info.IdConciliacion;
                    address.Secuencia = info.secuencia;
                    address.tipo_IngEgr = info.Tipo;
                    address.IdCbteCble = info.IdCbteCble;
                    address.IdTipocbte = info.IdTipocbte;
                    address.SecuenciaCbteCble = info.SecuenciaCbteCble;
                    address.Estado = info.Estado;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.ip = info.ip;
                    address.nom_pc = info.nom_pc;
                    address.@checked = info.chk;
                    address.SecuenciaCbteCble = info.SecuenciaCbteCble;
                    address.SecuenciaCbteCble = info.SecuenciaCbteCble;
                    context.ba_Conciliacion_det_IngEgr.Add(address);
                    context.SaveChanges();
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

        public Boolean ModificarDB(ba_Conciliacion_det_IngEgr_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Conciliacion_det_IngEgr.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion && minfo.Secuencia==info.Secuencia );
                    if (contact != null)
                    {
                        contact.tipo_IngEgr = info.tipo_IngEgr;
                        contact.IdCbteCble = info.IdCbteCble;
                        contact.IdTipocbte = info.IdTipocbte;
                        contact.SecuenciaCbteCble = info.SecuenciaCbteCble;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
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

        public Boolean AnularDB(ba_Conciliacion_det_IngEgr_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Conciliacion_det_IngEgr.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdConciliacion == info.IdConciliacion && minfo.Secuencia == info.Secuencia);
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                context.Database.ExecuteSqlCommand("delete from ba_Conciliacion_det_IngEgr where IdEmpresa = "+IdEmpresa+"  and IdConciliacion= "+IdConciliacion);
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

        public List<vwba_TransaccionesAConciliar_Info> Get_List_ConciIngEgr(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<vwba_TransaccionesAConciliar_Info> lM = new List<vwba_TransaccionesAConciliar_Info>();
                EntitiesBanco b = new EntitiesBanco();


                var select_ = from T in b.vwba_Conciliacion_det_IngEgr
                              where T.IdEmpresa == IdEmpresa && T.IdConciliacion == IdConciliacion

                              select T;
                foreach(var item in select_)
                {
                    vwba_TransaccionesAConciliar_Info dat_ = new vwba_TransaccionesAConciliar_Info();

                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble = item.IdCbteCble;
                    dat_.IdTipocbte = item.IdTipocbte;
                    dat_.CodTipoCbte = item.CodTipoCbte;
                    dat_.tc_TipoCbte = (item.tc_TipoCbte!=null) ? item.tc_TipoCbte.Trim() : "";
                    dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                    dat_.Descripcion = item.ba_descripcion;
                    dat_.IdPeriodo = item.IdPeriodo;
                    dat_.IdBanco =(int) item.IdBanco;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.cb_Observacion = item.cb_Observacion;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.cb_FechaCheque = item.cb_FechaCheque;
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.pc_Cuenta = item.pc_Cuenta;
                    dat_.dc_Valor = item.dc_Valor;
                    dat_.Estado = item.Estado;
                    dat_.SecuenciaCbteCble = item.SecuenciaCbteCble;
                    dat_.ReferenciaCbte = item.ReferenciaCbte;
                    dat_.IdConciliacion = item.IdConciliacion;
                    dat_.SecuenciaConciliacion = item.SecuenciaConciliacion;
                    dat_.tipo_IngEgr = item.tipo_IngEgr;

                    dat_.chk = true;

                    lM.Add(dat_);
                }
                return(lM);
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

        public ba_Conciliacion_det_IngEgr_Data()
        {
           
        }

        public Boolean Cbte_existe_en_conciliacion(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                int Cont = 0;

                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    var lst = from q in Context.ba_Conciliacion_det_IngEgr
                              where q.IdEmpresa == IdEmpresa &&
                              q.IdTipocbte == IdTipoCbte && q.IdCbteCble == IdCbteCble
                              select q;

                    Cont = lst.Count();
                }

                if (Cont > 0) return true; else return false;
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

        public Boolean Cbte_existe_en_conciliacion(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, int Secuencia)
        {
            try
            {
                int Cont = 0;

                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    var lst = from q in Context.ba_Conciliacion_det_IngEgr
                              where q.IdEmpresa == IdEmpresa &&
                              q.IdTipocbte == IdTipoCbte && q.IdCbteCble == IdCbteCble
                              && q.SecuenciaCbteCble == Secuencia
                              select q;

                    Cont = lst.Count();
                }

                if (Cont > 0) return true; else return false;
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
