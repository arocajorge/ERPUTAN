using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxCobrar
{
   public class cxc_catalogo_Data
    {
       string mensaje = "";
       public List<cxc_catalogo_Info> Get_List_Catalogo(string IdCatalogo_tipo)
       {
           try
           {
               EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

               var lista = from q in context.cxc_Catalogo
                           where q.IdCatalogo_tipo == IdCatalogo_tipo
                           select q;

               List<cxc_catalogo_Info> lst = new List<cxc_catalogo_Info>();
               cxc_catalogo_Info Info;

               foreach (var item in lista)
               {
                   Info = new cxc_catalogo_Info();
                   Info.IdCatalogo= item.IdCatalogo;
                   Info.IdCatalogo_tipo = item.IdCatalogo_tipo;
                   Info.Nombre = item.Nombre;
                   Info.Estado = item.Estado;
                   Info.Orden = Convert.ToInt32(item.Orden);
                   Info.IdUsuario = item.IdUsuario;
                   Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                   Info.FechaUltMod = Convert.ToDateTime(item.FechaUltMod);
                   Info.nom_pc = item.nom_pc;
                   Info.ip = item.ip;              
                   lst.Add(Info);                 
              }

               return lst;
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
        
       public string GetId()
        {
            try
            {
                string Id = "";
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var select = from q in context.vwCxc_Catalogo_IdAuto_numeric
                             select q;
                foreach (var item in select)
                {
                    Id = (string)item.IdCatalogo;
                }

                return Id;
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

       public List<cxc_catalogo_Info> Get_List_catalogo()
        {
            try
            {
                List<cxc_catalogo_Info> lista = new List<cxc_catalogo_Info>();
                EntitiesCuentas_x_Cobrar oEnt = new EntitiesCuentas_x_Cobrar();

                var select = from q in oEnt.cxc_Catalogo
                             select q;

                foreach (var item in select)
                {
                    cxc_catalogo_Info info = new cxc_catalogo_Info();
                    info.IdCatalogo = item.IdCatalogo;
                    info.Nombre = item.Nombre;
                    lista.Add(info);
                }
                return lista;
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

       public cxc_catalogo_Info Get_Info_catalogo(string id)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                cxc_catalogo_Info Info = new cxc_catalogo_Info();
                var contenido = context.cxc_Catalogo.First(var => var.IdCatalogo == id);

                Info.IdCatalogo = contenido.IdCatalogo;
                Info.IdCatalogo_tipo = contenido.IdCatalogo_tipo;
                Info.Nombre = contenido.Nombre;
                Info.Estado = contenido.Estado;
                Info.Orden = (int)contenido.Orden;
                return Info;

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
       
       public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var Existe = from q in context.cxc_Catalogo
                             where q.IdCatalogo == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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

       public Boolean GuardarDB(cxc_catalogo_Info Info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var Address = new cxc_Catalogo();
                    Address.IdCatalogo = Info.IdCatalogo;
                    Address.IdCatalogo_tipo = Info.IdCatalogo_tipo;
                    Address.Nombre = Info.Nombre;
                    Address.Estado = "A";
                    Address.Orden = Info.Orden;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Context.cxc_Catalogo.Add(Address);
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

       public List<cxc_catalogo_Info> Get_List_IdTipoLista(string cod)
        {
            try
            {
                List<cxc_catalogo_Info> lista = new List<cxc_catalogo_Info>();

                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                var Existe = from q in context.cxc_Catalogo
                             where q.IdCatalogo_tipo == cod
                             select q;

                foreach (var item in Existe)
                {
                    cxc_catalogo_Info info = new cxc_catalogo_Info();

                    info.IdCatalogo = item.IdCatalogo;
                    info.IdCatalogo_tipo = item.IdCatalogo_tipo;
                    info.Nombre = item.Nombre;
                    info.Orden = (int)item.Orden;
                    info.Estado = item.Estado;
                    lista.Add(info);
                }
                return lista;
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
        
       public bool ModificarDB(cxc_catalogo_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var contenido = context.cxc_Catalogo.FirstOrDefault(var => var.IdCatalogo == info.IdCatalogo);
                    if (contenido != null)
                    {
                        contenido.Nombre = info.Nombre;
                        contenido.Orden = info.Orden;
                        contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contenido.FechaUltMod = info.FechaUltMod;
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

       public Boolean AnularDB(cxc_catalogo_Info Info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var contact = context.cxc_Catalogo.FirstOrDefault(var => var.IdCatalogo == Info.IdCatalogo && var.IdCatalogo_tipo == Info.IdCatalogo_tipo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.FechaUltMod = Info.FechaUltMod;
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

       public Boolean ValidarIdTipoCatalogo_Descripcion(string IdCatalogo_tipo, string Descripcion)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {

                    var Existe = from q in context.cxc_Catalogo
                                 where q.Nombre == Descripcion && q.IdCatalogo_tipo == IdCatalogo_tipo
                                 select q;
                    if (Existe.ToList().Count() > 0)
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
    }
}
