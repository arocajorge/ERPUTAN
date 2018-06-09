using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_TipoDocumento_Data
    {
        string mensaje = "";

        public Boolean GuardarDB( cp_TipoDocumento_Info Info)
        {
            try
            {
                List<cp_TipoDocumento_Info> Lst = new List<cp_TipoDocumento_Info>();
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                   // var contact = cp_TipoDocumento.Createcp_TipoDocumento("","",0,"","","",DateTime.Now);
                    var Address = new cp_TipoDocumento();

                    //Address.IdTipoDocumento = getId(Info.IdTipoDocumento);
                    Address.CodTipoDocumento = Info.CodTipoDocumento;
                    Address.Codigo = Info.CodTipoDocumento;
                    Address.Descripcion = Info.Descripcion;
                    Address.Orden = Info.Orden;
                    Address.DeclaraSRI = Info.DeclaraSRI;
                    Address.GeneraRetencion = Info.GeneraRetencion;
                    Address.CodSRI = Info.CodSRI;
                    Address.Estado = "A";
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = Info.Fecha_Transac;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Address.Codigo_Secuenciales_Transaccion = Info.Codigo_Secuenciales_Transaccion;
                    Address.Sustento_Tributario = Info.Sustento_Tributario;

                    //contact = Address;
                    Context.cp_TipoDocumento.Add(Address);
                    Context.SaveChanges();
                
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_TipoDocumento_Info> Get_List_TipoDocumento()
        {
            try
            {
                List<cp_TipoDocumento_Info> Lst = new List<cp_TipoDocumento_Info>();
                EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();
                var Query = from q in oEnti.cp_TipoDocumento
                            orderby q.Orden ascending  
                            select q ;

                foreach (var item in Query)
                {
                    cp_TipoDocumento_Info Obj = new cp_TipoDocumento_Info();

                    Obj.CodTipoDocumento = item.CodTipoDocumento;
                    Obj.Codigo = item.Codigo;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Orden = item.Orden;
                    Obj.DeclaraSRI = item.DeclaraSRI;
                    Obj.CodSRI = item.CodSRI;
                    Obj.Estado = item.Estado;
                    Obj.GeneraRetencion = item.GeneraRetencion;
                    Obj.Codigo_Secuenciales_Transaccion = item.Codigo_Secuenciales_Transaccion;
                    Obj.Sustento_Tributario = item.Sustento_Tributario;
                    Obj.GeneraRetencion = item.GeneraRetencion;
                   
                    Lst.Add(Obj);

                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_TipoDocumento_Info> Get_List_TipoDocumento(string CodDocumento)
        {
            try
            {
                List<cp_TipoDocumento_Info> Lst = new List<cp_TipoDocumento_Info>();
                EntitiesCuentasxPagar oEnti = new EntitiesCuentasxPagar();

                var Query = from q in oEnti.cp_TipoDocumento
                            where q.CodTipoDocumento == CodDocumento
                            select q;

                foreach (var item in Query)
                {
                    cp_TipoDocumento_Info Obj = new cp_TipoDocumento_Info();
                    Obj.CodTipoDocumento = item.CodTipoDocumento;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Orden = item.Orden;
                    Obj.DeclaraSRI = item.DeclaraSRI;
                    Obj.CodSRI = item.CodSRI;
                    Obj.Estado = item.Estado;
                    Obj.GeneraRetencion = item.GeneraRetencion;
                    Obj.Codigo_Secuenciales_Transaccion = item.Codigo_Secuenciales_Transaccion;
                    Obj.Sustento_Tributario = item.Sustento_Tributario;
                    Obj.GeneraRetencion = item.GeneraRetencion;
                    Lst.Add(Obj);

                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(cp_TipoDocumento_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_TipoDocumento.FirstOrDefault(minfo => minfo.CodTipoDocumento == info.CodTipoDocumento);
                    if (contact != null)
                    {
                        contact.CodTipoDocumento = info.CodTipoDocumento;
                        contact.Descripcion = info.Descripcion;
                        contact.Orden = info.Orden;
                        contact.DeclaraSRI = info.DeclaraSRI;
                        contact.Estado = info.Estado;
                        contact.CodSRI = info.CodSRI;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.GeneraRetencion = info.GeneraRetencion;
                        contact.Codigo_Secuenciales_Transaccion = info.Codigo_Secuenciales_Transaccion;
                        contact.Sustento_Tributario = info.Sustento_Tributario;
                        contact.GeneraRetencion = info.GeneraRetencion;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
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

        public Boolean AnularDB(cp_TipoDocumento_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_TipoDocumento.FirstOrDefault(minfo => minfo.CodTipoDocumento == info.CodTipoDocumento);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
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

        public Boolean HabilitarDB(cp_TipoDocumento_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_TipoDocumento.FirstOrDefault(minfo => minfo.CodTipoDocumento == info.CodTipoDocumento);
                    if (contact != null)
                    {
                        contact.Estado = "A";
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean VericarCodigoExiste(string codigo, ref string mensaje)
        {
            try
            {
                    Boolean Existe;

                    string scodigo;

                    scodigo = codigo.Trim();
                    mensaje = "";
                    Existe = false;

                    EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

                    var select_ = from t in B.cp_TipoDocumento
                                  where t.CodTipoDocumento == scodigo 
                                  select t;

                    foreach (var item in select_)
                    {

                        mensaje = mensaje + " " + item.Descripcion;
                        Existe = true;
                    }

                    return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
