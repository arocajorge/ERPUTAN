using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_giro_x_com_ordencompra_local_Data
    {
        string mensaje = "";
        public List<cp_orden_giro_x_com_ordencompra_local_Info> Get_List_orden_giro_x_com_ordencompra_local(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                List<cp_orden_giro_x_com_ordencompra_local_Info> lM = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_orden_giro_x_com_ordencompra_local
                              where T.og_IdEmpresa == IdEmpresa_Ogiro && T.og_IdCbteCble == IdCbteCble_Ogiro && T.og_IdTipoCbte == IdTipoCbte_Ogiro
                              select T;

                foreach(var item in select_)
                {
                    cp_orden_giro_x_com_ordencompra_local_Info dat = new cp_orden_giro_x_com_ordencompra_local_Info();
                    dat.com_IdEmpresa = item.com_IdEmpresa;
                    dat.com_IdOrdenCompraLocal = item.com_IdOrdenCompraLocal;
                    dat.com_IdSucursal = item.com_IdSucursal;
                    dat.og_IdCbteCble = item.og_IdCbteCble;
                    dat.og_IdEmpresa = item.og_IdEmpresa;
                    dat.og_IdTipoCbte = item.og_IdTipoCbte;

                    lM.Add(dat);
                }
                return(lM);
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_orden_giro_x_com_ordencompra_local_Info> Get_List_orden_giro_x_com_ordencompra_local(int IdEmpresa_Ogiro)
        {
            try
            {
                List<cp_orden_giro_x_com_ordencompra_local_Info> lM = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_orden_giro_x_com_ordencompra_local
                              where T.og_IdEmpresa == IdEmpresa_Ogiro 
                              select T;

                foreach(var item in select_)
                {
                    cp_orden_giro_x_com_ordencompra_local_Info dat = new cp_orden_giro_x_com_ordencompra_local_Info();
                    dat.com_IdEmpresa = item.com_IdEmpresa;
                    dat.com_IdOrdenCompraLocal = item.com_IdOrdenCompraLocal;
                    dat.com_IdSucursal = item.com_IdSucursal;
                    dat.og_IdCbteCble = item.og_IdCbteCble;
                    dat.og_IdEmpresa = item.og_IdEmpresa;
                    dat.og_IdTipoCbte = item.og_IdTipoCbte;

                    lM.Add(dat);
                }
                return(lM);
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

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa)
        {
            try
            {
                com_ordencompra_local_Data Com_D = new com_ordencompra_local_Data();
                List<com_ordencompra_local_Info> LstCom = new List<com_ordencompra_local_Info>();
                List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
                List<cp_orden_giro_x_com_ordencompra_local_Info> LstComOG = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
                string msg="";

                LstCom = Com_D.Get_List_ordencompra_local(IdEmpresa, ref msg).FindAll(c => c.IdEstadoAprobacion_cat == "APRO" && c.Estado == "A");
                LstComOG = Get_List_orden_giro_x_com_ordencompra_local(IdEmpresa);
                

                foreach(var item in LstCom)
                {
                    int re = 0;
                    foreach(var item2 in LstComOG)
                    {
                        if(item.IdEmpresa==item2.com_IdEmpresa  && item.IdSucursal==item2.com_IdSucursal && item.IdOrdenCompra ==item2.com_IdOrdenCompraLocal)
                        {
                            re++;
                        }
                    }
                    if(re == 0)
                    {
                        Lst.Add(item);
                    }
                }
                return Lst;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int og_IdEmpresa, decimal og_IdCbteCble, int og_IdTipoCbte)
        {
            try
            {
                com_ordencompra_local_Data Com_D = new com_ordencompra_local_Data();
                List<com_ordencompra_local_Info> LstCom = new List<com_ordencompra_local_Info>();
                List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
                List<cp_orden_giro_x_com_ordencompra_local_Info> LstComOG = new List<cp_orden_giro_x_com_ordencompra_local_Info>();

                string msg = "";



                LstComOG = Get_List_orden_giro_x_com_ordencompra_local(og_IdEmpresa, og_IdCbteCble, og_IdTipoCbte);
                LstCom = Com_D.Get_List_ordencompra_local(og_IdEmpresa, ref msg).FindAll(c => c.IdEstadoAprobacion_cat == "APRO");
                foreach (var item in LstCom)
                {
                    foreach (var item2 in LstComOG)
                    {
                        if (item.IdEmpresa == item2.com_IdEmpresa && item.IdSucursal == item2.com_IdSucursal && item.IdOrdenCompra == item2.com_IdOrdenCompraLocal)
                        {
                            Lst.Add(item);
                        }
                    }
                }

                return Lst;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(cp_orden_giro_x_com_ordencompra_local_Info info)
        {
            try
            {
                using(EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    //var contact = cp_orden_giro_x_com_ordencompra_local.Createcp_orden_giro_x_com_ordencompra_local(0, 0, 0, 0, 0, 0);
                    var address = new cp_orden_giro_x_com_ordencompra_local();

                    address.com_IdEmpresa = info.com_IdEmpresa;
                    address.com_IdOrdenCompraLocal = info.com_IdOrdenCompraLocal;
                    address.com_IdSucursal = info.com_IdSucursal;
                    address.og_IdCbteCble = info.og_IdCbteCble;
                    address.og_IdEmpresa = info.og_IdEmpresa;
                    address.og_IdTipoCbte = info.og_IdTipoCbte;
                    address.og_Observacion = info.og_Observacion;

                    //contact = address;

                    context.cp_orden_giro_x_com_ordencompra_local.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> lista)
        {
            try
            {
                foreach(var item in lista)
                {
                    GrabarDB(item);
                }
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> listaNueva, List<cp_orden_giro_x_com_ordencompra_local_Info> listaAntigua)
        {
            try
            {
                EliminarDB(listaAntigua);
                GrabarDB(listaNueva);
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> lista)
        {
            try
            {
                foreach (var item in lista)
                {
                    EliminarDB(item);
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

        public Boolean EliminarDB(cp_orden_giro_x_com_ordencompra_local_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro_x_com_ordencompra_local.FirstOrDefault(minfo => minfo.com_IdEmpresa == info.com_IdEmpresa && minfo.com_IdOrdenCompraLocal == info.com_IdOrdenCompraLocal && minfo.com_IdSucursal == info.com_IdSucursal && minfo.og_IdCbteCble == info.og_IdCbteCble && minfo.og_IdEmpresa == info.og_IdEmpresa && minfo.og_IdTipoCbte == info.og_IdTipoCbte);
                    if (contact != null)
                    {
                        context.cp_orden_giro_x_com_ordencompra_local.Remove(contact);
                        context.SaveChanges();
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

        public Boolean EliminarDB(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var q = from C in context.cp_orden_giro_x_com_ordencompra_local
                            where C.og_IdEmpresa == IdEmpresa && C.og_IdCbteCble == IdCbteCble_Ogiro && C.og_IdTipoCbte == IdTipoCbte_Ogiro
                            select C;
                    if(q.ToList().Count > 0)
                    {
                        var contact = context.cp_orden_giro_x_com_ordencompra_local.FirstOrDefault(minfo => minfo.og_IdEmpresa == IdEmpresa && minfo.og_IdCbteCble == IdCbteCble_Ogiro && minfo.og_IdTipoCbte == IdTipoCbte_Ogiro);
                        if (contact != null)
                        {
                            context.cp_orden_giro_x_com_ordencompra_local.Remove(contact);
                            context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<cp_orden_giro_x_com_ordencompra_local_Info> Lst, int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    context.Database.ExecuteSqlCommand("delete from cp_orden_giro_x_com_ordencompra_local where og_IdTipoCbte =" + IdTipoCbte + " and og_IdEmpresa =" + IdEmpresa + " and og_IdCbteCble = " + IdCbteCble);
                    context.SaveChanges();
                    GrabarDB(Lst);
                }
                return true;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public cp_orden_giro_x_com_ordencompra_local_Data(){}
    }
}
