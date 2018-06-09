using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_giro_x_imp_ordencompra_ext_Data
    {
        string mensaje = "";
        public List<cp_orden_giro_x_imp_ordencompra_ext_Info> Get_List_orden_giro_x_imp_ordencompra_ext(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                List<cp_orden_giro_x_imp_ordencompra_ext_Info> lM = new List<cp_orden_giro_x_imp_ordencompra_ext_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_orden_giro_x_imp_ordencompra_ext
                              where T.og_IdEmpresa == IdEmpresa_Ogiro && T.og_IdCbteCble == IdCbteCble_Ogiro && T.og_IdTipoCbte == IdTipoCbte_Ogiro
                              select T;

                foreach (var item in select_)
                {
                    cp_orden_giro_x_imp_ordencompra_ext_Info dat = new cp_orden_giro_x_imp_ordencompra_ext_Info();
                    dat.imp_IdEmpresa = item.imp_IdEmpresa;
                    dat.imp_IdOrdenCompraExt = item.imp_IdOrdenCompraExt;
                    dat.imp_IdSucursal = item.imp_IdSucursal;
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

        public Boolean GrabarDB(cp_orden_giro_x_imp_ordencompra_ext_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    //var contact = cp_orden_giro_x_imp_ordencompra_ext.Createcp_orden_giro_x_imp_ordencompra_ext(0, 0, 0, 0, 0, 0);
                    var address = new cp_orden_giro_x_imp_ordencompra_ext();

                    address.imp_IdEmpresa = info.imp_IdEmpresa;
                    address.imp_IdOrdenCompraExt = info.imp_IdOrdenCompraExt;
                    address.imp_IdSucursal = info.imp_IdSucursal;
                    address.og_IdCbteCble = info.og_IdCbteCble;
                    address.og_IdEmpresa = info.og_IdEmpresa;
                    address.og_IdTipoCbte = info.og_IdTipoCbte;
                    
                    //contact = address;

                    context.cp_orden_giro_x_imp_ordencompra_ext.Add(address);
                    context.SaveChanges();
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

        public Boolean GrabarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> lista, ref string mensaje)
        {
            try
            {
                foreach (var item in lista)
                {
                    GrabarDB(item, ref mensaje );
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

        public Boolean ActualizarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> listaNueva, List<cp_orden_giro_x_imp_ordencompra_ext_Info> listaAntigua)
        {
            try
            {
                EliminarDB(listaAntigua);
                GrabarDB(listaNueva, ref mensaje);

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

        public Boolean EliminarDB(List<cp_orden_giro_x_imp_ordencompra_ext_Info> lista)
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

        public Boolean EliminarDB(cp_orden_giro_x_imp_ordencompra_ext_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_orden_giro_x_imp_ordencompra_ext.FirstOrDefault(minfo => minfo.imp_IdEmpresa == info.imp_IdEmpresa && minfo.imp_IdOrdenCompraExt == info.imp_IdOrdenCompraExt && minfo.imp_IdSucursal == info.imp_IdSucursal && minfo.og_IdCbteCble== info.og_IdCbteCble && minfo.og_IdEmpresa== info.og_IdEmpresa && minfo.og_IdTipoCbte==info.og_IdTipoCbte);
                    if (contact != null)
                    {
                        context.cp_orden_giro_x_imp_ordencompra_ext.Remove(contact);
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
                    var contact = context.cp_orden_giro_x_imp_ordencompra_ext.FirstOrDefault(minfo => minfo.og_IdEmpresa == IdEmpresa && minfo.og_IdCbteCble == IdCbteCble_Ogiro && minfo.og_IdTipoCbte == IdTipoCbte_Ogiro);
                    if (contact != null)
                    {
                        context.cp_orden_giro_x_imp_ordencompra_ext.Remove(contact);
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

        public Boolean ModificarDB(cp_orden_giro_x_imp_ordencompra_ext_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar Contex = new EntitiesCuentasxPagar())
                {
                    var contact = Contex.cp_orden_giro_x_imp_ordencompra_ext.FirstOrDefault(var => var.og_IdEmpresa == info.og_IdEmpresa && var.og_IdCbteCble == info.og_IdCbteCble && var.og_IdTipoCbte == info.og_IdTipoCbte);
                    if(contact!=null)
                    {
                         contact.imp_IdEmpresa = info.imp_IdEmpresa;
                         contact.imp_IdSucursal = info.imp_IdSucursal;
                         contact.imp_IdOrdenCompraExt = info.imp_IdOrdenCompraExt;
                         Contex.SaveChanges();
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

        public cp_orden_giro_x_imp_ordencompra_ext_Data(){}

    }
}
