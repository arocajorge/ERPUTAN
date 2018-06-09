using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_proveedor_Autorizacion_Data
    {
        string mensaje = "";
        public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_proveedor_Autorizacion_Info> lM = new List<cp_proveedor_Autorizacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_proveedor_Autorizacion 
                              where T.IdEmpresa==IdEmpresa && T.IdProveedor==IdProveedor 
                              orderby  T.Valido_Hasta descending 
                              select T;

                foreach (var item in select_)
                {
                    cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion  = item.IdAutorizacion ;
                    dat.Serie1  = item.Serie1 ;
                    dat.Serie2  = item.Serie2 ;
                    dat.nAutorizacion  = item.nAutorizacion ;
                    dat.Valido_Hasta  = item.Valido_Hasta ;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;
                    dat.Estado = (item.Estado == null) ? false : Convert.ToBoolean(item.Estado);
                    lM.Add(dat);
                }
                return (lM);
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

        public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa, decimal Iproveedor, DateTime fecha)
        {
            try
            {
                List<cp_proveedor_Autorizacion_Info> lM = new List<cp_proveedor_Autorizacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                fecha = Convert.ToDateTime(fecha.ToShortDateString()); 
                var select_ = from T in db.cp_proveedor_Autorizacion
                              where T.IdEmpresa == IdEmpresa && T.IdProveedor == Iproveedor && T.Valido_Hasta >= fecha
                              orderby T.Valido_Hasta descending
                              select T;

                foreach (var item in select_)
                {
                    cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.Serie1 = item.Serie1;
                    dat.Serie2 = item.Serie2;
                    dat.nAutorizacion = item.nAutorizacion;
                    dat.Valido_Hasta = item.Valido_Hasta;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;
                    lM.Add(dat);
                }
                return (lM);
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

        public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa, decimal Iproveedor, string NumAutoriza, string Establecimiento
            , string Pto_Emision, decimal NumDoc_A_Buscar)
        {
            try
            {
                List<cp_proveedor_Autorizacion_Info> listado = new List<cp_proveedor_Autorizacion_Info>();

                string SSQL = "";
                SSQL = "SELECT        IdEmpresa, IdProveedor, IdAutorizacion, Serie1, Serie2, nAutorizacion, Valido_Hasta, factura_inicial, factura_final, NumAutorizacionImprenta";
                SSQL = SSQL + " FROM            cp_proveedor_Autorizacion ";
                SSQL = SSQL + " where IdEmpresa=" + IdEmpresa;
                SSQL = SSQL + " and IdProveedor=" + Iproveedor;
                SSQL = SSQL + " and Serie1='" + Establecimiento + "'";
                SSQL = SSQL + " and Serie2='" + Pto_Emision + "'";
                SSQL = SSQL + " and nAutorizacion='" + NumAutoriza + "'";
                SSQL = SSQL + " and " + NumDoc_A_Buscar + " between CAST( factura_inicial  as numeric) and cast( factura_final  as numeric)";


             
               
                
               using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
               {
                   
                   listado = Entity.Database.SqlQuery<cp_proveedor_Autorizacion_Info>(SSQL).ToList();
               }


               return (listado);
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

        public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa)
        {
            try
            {
                List<cp_proveedor_Autorizacion_Info> lM = new List<cp_proveedor_Autorizacion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var select_ = from T in db.cp_proveedor_Autorizacion
                              where T.IdEmpresa == IdEmpresa
                              orderby T.Valido_Hasta descending
                              select T;

                foreach (var item in select_)
                {
                    cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.Serie1 = item.Serie1;
                    dat.Serie2 = item.Serie2;
                    dat.nAutorizacion = item.nAutorizacion;
                    dat.Valido_Hasta = item.Valido_Hasta;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;
                    lM.Add(dat);
                }
                return (lM);
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

        public cp_proveedor_Autorizacion_Info ExisteNAutorizacion(int IdEmpresa, decimal IdProveedor, string NAutorizacion)
        {
            try
            {
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                var select_ = from T in db.cp_proveedor_Autorizacion
                              where T.IdEmpresa == IdEmpresa && T.IdProveedor == IdProveedor && T.nAutorizacion == NAutorizacion
                              select T;

                foreach (var item in select_)
                {
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.Serie1 = item.Serie1;
                    dat.Serie2 = item.Serie2;
                    dat.nAutorizacion = item.nAutorizacion;
                    dat.Valido_Hasta = item.Valido_Hasta;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;
                }
                return (dat);
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

        public cp_proveedor_Autorizacion_Info Get_Info_proveedor_Autorizacion(int Iempresa, decimal Iproveedor, decimal iAutorizacion)
        {
            try
            {
               EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
               cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                var select_ = from T in db.cp_proveedor_Autorizacion
                              where T.IdEmpresa == Iempresa && T.IdProveedor == Iproveedor && T.IdAutorizacion == iAutorizacion 
                             
                              select T;

                foreach (var item in select_)
                {
                   
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.Serie1 = item.Serie1;
                    dat.Serie2 = item.Serie2;
                    dat.nAutorizacion = item.nAutorizacion;
                    dat.Valido_Hasta = item.Valido_Hasta;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;

                }
                return (dat);
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

        public decimal GetId(int IdEmpresa,decimal IdProveedor)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar();

                var q = from C in base_.cp_proveedor_Autorizacion
                        where C.IdEmpresa == IdEmpresa && C.IdProveedor == IdProveedor
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from CbtCble in base_.cp_proveedor_Autorizacion
                                   where CbtCble.IdEmpresa == IdEmpresa && CbtCble.IdProveedor == IdProveedor
                                   select CbtCble.IdAutorizacion).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
                    return Id;
                }
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

        public Boolean GrabarDB(cp_proveedor_Autorizacion_Info info,ref decimal idAuto)
        {
            try
            {
                decimal id_ = 0;
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();

                    if(info.IdAutorizacion < 1)
                        id_ = GetId(info.IdEmpresa, info.IdProveedor);
                    else
                        id_ = info.IdAutorizacion;

                        //var contact = cp_proveedor_Autorizacion.Createcp_proveedor_Autorizacion(0, 0, 0, "", "", "", DateTime.Now,"","");
                        var address = new cp_proveedor_Autorizacion();
                        address.IdEmpresa  = info.IdEmpresa ;
                        address.IdProveedor = info.IdProveedor;
                        idAuto = id_;
                        address.IdAutorizacion  = id_ ;
                        address.Serie1 = info.Serie1.Trim();
                        address.Serie2 = info.Serie2.Trim();
                        address.nAutorizacion = info.nAutorizacion;
                        address.Valido_Hasta = Convert.ToDateTime(info.Valido_Hasta.ToShortDateString());
                        address.factura_inicial = info.factura_inicial;
                        address.factura_final = info.factura_final;
                        address.NumAutorizacionImprenta = info.NumAutorizacionImprenta;
                        address.Estado = info.Estado;
                        //contact = address;

                        context.cp_proveedor_Autorizacion.Add(address);
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

        public Boolean ModificarDB(cp_proveedor_Autorizacion_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    decimal id=0;
                    if (info.IdAutorizacion < 1)
                    {
                        GrabarDB(info,ref id);
                    }
                    else
                    {
                        var contact = context.cp_proveedor_Autorizacion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProveedor == info.IdProveedor && minfo.IdAutorizacion==info.IdAutorizacion);
                        if (contact != null)
                        {
                            contact.Serie1 = info.Serie1;
                            contact.Serie2 = info.Serie2;
                            contact.nAutorizacion = info.nAutorizacion;
                            contact.Valido_Hasta = Convert.ToDateTime(info.Valido_Hasta.ToShortDateString()); ;
                            contact.factura_inicial = info.factura_inicial;
                            contact.factura_final = info.factura_final;
                            contact.NumAutorizacionImprenta = info.NumAutorizacionImprenta;
                            contact.Estado = info.Estado;
                            context.SaveChanges();
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
        
        public Boolean ModificarDB(List<cp_proveedor_Autorizacion_Info> lista,int idEmpresa,decimal IdProveedor)
        {
            try
            {
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    foreach (var item in lista)
                    {
                        cp_proveedor_Autorizacion contact = db.cp_proveedor_Autorizacion.FirstOrDefault
                                   (var => var.IdEmpresa == idEmpresa && var.IdProveedor == IdProveedor
                                   && var.IdAutorizacion  == item.IdAutorizacion );
                        if (contact != null)
                        {
                            contact.Serie1 = item.Serie1;
                            contact.Serie2 = item.Serie2;
                            contact.nAutorizacion = item.nAutorizacion;
                            contact.NumAutorizacionImprenta = item.NumAutorizacionImprenta;
                            contact.Valido_Hasta = item.Valido_Hasta;
                            contact.factura_final = item.factura_final;
                            contact.factura_inicial = item.factura_inicial;
                            contact.Estado = item.Estado;
                            db.SaveChanges();
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
                
        public Boolean GrabarDB(List<cp_proveedor_Autorizacion_Info> lista)
        {
            try
            {
                decimal id = 0;
                foreach (var item in lista)
                {
                    GrabarDB(item,ref id);
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
                return false;
            }
        }

        public Boolean EliminarDB(cp_proveedor_Autorizacion_Info Info)
        {
            try
            {
                using(EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_proveedor_Autorizacion.FirstOrDefault(min => min.IdEmpresa == Info.IdEmpresa && min.IdProveedor == Info.IdProveedor && min.IdAutorizacion ==Info.IdAutorizacion);
                    if (contact != null)
                    {
                        context.cp_proveedor_Autorizacion.Remove(contact);
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(List<cp_proveedor_Autorizacion_Info> lm)
        {
            try
            {

                foreach (var item in lm)
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

        public cp_proveedor_Autorizacion_Info Get_Info_proveedor_Autorizacion(int Iempresa, decimal Iproveedor, string Ser1, string ser2, string numeroFact)
        {
            try
            {
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_proveedor_Autorizacion_Info dat = new cp_proveedor_Autorizacion_Info();
                var select_ = from T in db.cp_proveedor_Autorizacion
                              where T.IdEmpresa == Iempresa 
                              && T.IdProveedor == Iproveedor 
                              && T.Serie1==Ser1
                              && T.Serie2==ser2
                              
                              select T;

                foreach (var item in select_)
                {

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdProveedor = item.IdProveedor;
                    dat.IdAutorizacion = item.IdAutorizacion;
                    dat.Serie1 = item.Serie1;
                    dat.Serie2 = item.Serie2;
                    dat.nAutorizacion = item.nAutorizacion;
                    dat.Valido_Hasta = item.Valido_Hasta;
                    dat.factura_inicial = item.factura_inicial;
                    dat.factura_final = item.factura_final;
                    dat.NumAutorizacionImprenta = item.NumAutorizacionImprenta;

                }
                return (dat);
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

    }
}
