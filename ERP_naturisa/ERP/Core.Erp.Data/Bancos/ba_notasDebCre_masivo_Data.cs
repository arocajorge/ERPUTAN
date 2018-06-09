using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_notasDebCre_masivo_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ba_notasDebCre_masivo_Info Info, ref decimal IdTransaccion )
        {
            try
            { 
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    IdTransaccion = Id(Info.IdEmpresa);

                    ba_notasDebCre_masivo Address = new ba_notasDebCre_masivo();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdTransaccion =IdTransaccion;
                    Address.IdEmpresa_cb = Info.IdEmpresa_cb;
                    Address.IdCbteCble_cb = Info.IdCbteCble_cb;
                    Address.IdTipocbte_cb = Info.IdTipocbte_cb;
                    Address.Observacion = Info.Observacion;
                    Address.Deb_Cred = Info.Deb_Cred;
                    Address.fecha = Info.fecha;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Context.ba_notasDebCre_masivo.Add(Address);
                    Context.SaveChanges();
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

        public Boolean GuardarDB(List<ba_notasDebCre_masivo_Info> Lis, ref decimal IdTran,int IdEmpresa)
        {
            try
            {
                IdTran = Id(IdEmpresa);

                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    foreach (var item in Lis)
                    {

                        ba_notasDebCre_masivo_Info Info = new ba_notasDebCre_masivo_Info();
                        Info = item;

                        ba_notasDebCre_masivo Address = new ba_notasDebCre_masivo();

                        Address.IdEmpresa = Info.IdEmpresa;
                        Address.IdTransaccion = IdTran;
                        Address.IdEmpresa_cb = Info.IdEmpresa_cb;
                        Address.IdCbteCble_cb = Info.IdCbteCble_cb;
                        Address.IdTipocbte_cb = Info.IdTipocbte_cb;
                        Address.Observacion = Info.Observacion;
                        Address.Deb_Cred = Info.Deb_Cred;
                        Address.fecha = Info.fecha;
                        Address.IdUsuario = Info.IdUsuario;
                        Address.Fecha_Transac = Info.Fecha_Transac;
                        Address.nom_pc = Info.nom_pc;
                        Address.ip = Info.ip;

                        Context.ba_notasDebCre_masivo.Add(Address);
                        Context.SaveChanges();
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

        public List<vwba_notasDebCre_masivo_Info> Get_List_vwba_notasDebCre_masivo(int IdEmpresa, decimal IdTransaccion)
        {
            try
            {
                List<vwba_notasDebCre_masivo_Info> Lst = new List<vwba_notasDebCre_masivo_Info>();
                EntitiesBanco oEnti = new EntitiesBanco();
                var Query = from q in oEnti.vwba_notasDebCre_masivo
                            where q.IdEmpresa == IdEmpresa && q.IdTransaccion == IdTransaccion
                            select q;
                foreach (var item in Query)
                {
                    vwba_notasDebCre_masivo_Info Obj = new vwba_notasDebCre_masivo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTransaccion = item.IdTransaccion;
                    Obj.tm_tipo = item.tm_tipo;
                    Obj.tm_IdBanco = item.tm_IdBanco;
                    Obj.tm_fecha = item.tm_fecha;
                    Obj.tm_observacion = item.tm_observacion;
                    Obj.cb_Valor = item.cb_Valor;
                    Obj.cb_Observacion = item.cb_Observacion;
                    Obj.cb_Fecha = item.cb_Fecha;
                    Obj.cb_IdCbteCble = item.cb_IdCbteCble;
                    Obj.cb_IdTipoCte = item.cb_IdTipoCte;
                    Obj.IdTipoNota = item.IdTipoNota;
                    Obj.tn_descripcion = item.tn_descripcion;
                    Obj.tn_tipo = item.tn_tipo;
                    Obj.tn_IdCtaCble = item.tn_IdCtaCble;
                    Obj.tn_IdCentroCosto = item.tn_IdCentroCosto;

                    Lst.Add(Obj);
                }
                return Lst;
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

        public List<ba_notasDebCre_masivo_Info> Get_List_ba_notasDebCre_masivo(int IdEmpresa, decimal IdTransaccion)
        {
            try
            { 
                List<ba_notasDebCre_masivo_Info> Lst = new List<ba_notasDebCre_masivo_Info>();
                EntitiesBanco oEnti = new EntitiesBanco();
                var Query = from q in oEnti.ba_notasDebCre_masivo
                            where q.IdEmpresa == IdEmpresa && q.IdTransaccion == IdTransaccion
                            select q;
                foreach (var item in Query)
                {
                    ba_notasDebCre_masivo_Info Obj = new ba_notasDebCre_masivo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdTransaccion = item.IdTransaccion;
                    Obj.IdEmpresa_cb = item.IdEmpresa_cb;
                    Obj.IdCbteCble_cb = item.IdCbteCble_cb;
                    Obj.IdTipocbte_cb = item.IdTipocbte_cb;
                    Obj.Observacion = item.Observacion;
                    Obj.Deb_Cred = item.Deb_Cred;
                    Obj.fecha = item.fecha;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Lst.Add(Obj);
                }
                return Lst;
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

        public List<ba_notasDebCre_masivo_Info> Get_List_notasDebCre_masivo(int IdEmpresa)
        {
            try
            {
                List<ba_notasDebCre_masivo_Info> Lst=new List<ba_notasDebCre_masivo_Info>();
                using (EntitiesBanco ent=new EntitiesBanco())
                {
                    var select_ = from t in ent.vwba_notasDebCre_masivo_consul
                                  where t.IdEmpresa == IdEmpresa
                                  select t;
                              

                      foreach(var item in select_)
                      {
                          ba_notasDebCre_masivo_Info Obj = new ba_notasDebCre_masivo_Info();
                          Obj.IdEmpresa = item.IdEmpresa;
                          Obj.IdTransaccion = item.IdTransaccion;
                          Obj.fecha = item.tm_fecha;
                          Obj.Deb_Cred = item.tm_tipo;
                          Obj.Observacion = item.tm_observacion;
                          Obj.IdUsuario = item.tm_IdUsuario;
                          Obj.TotalTransacciones = Convert.ToInt32(item.TotalTransacciones); 
                          Lst.Add(Obj);
                      }
                      return Lst;
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

        public decimal Id(int IdEmpresa)
        {
            try
            {
                using (EntitiesBanco oEnti = new EntitiesBanco())
                {
                    var Query = from q in oEnti.ba_notasDebCre_masivo
                                where q.IdEmpresa == IdEmpresa
                                select q;
                    if (Query.Count() < 1)
                        return 1;
                    else
                    { 
                   var c= (from q in oEnti.ba_notasDebCre_masivo
                                where q.IdEmpresa == IdEmpresa
                                select q.IdTransaccion).Max();
                   return Convert.ToDecimal(c) + 1;
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

        public ba_notasDebCre_masivo_Data()
        {
            
        }
    }
}
