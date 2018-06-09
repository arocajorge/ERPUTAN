using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Catalogo_Data
    {
        string mensaje = "";

        public List<Af_Catalogo_Info> Get_List_Catalogo()
        {
                List<Af_Catalogo_Info> lst = new List<Af_Catalogo_Info>();
                Af_Catalogo_Info Info;
            try
            {
                EntitiesActivoFijo context = new EntitiesActivoFijo();

                var lista = from q in context.Af_Catalogo
                            select q;

                foreach (var item in lista)
                {
                    Info = new Af_Catalogo_Info();
                    Info.IdCatalogo = item.IdCatalogo;
                    Info.IdTipoCatalogo = item.IdTipoCatalogo;
                    Info.Descripcion = item.Descripcion;
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
        
        public List<Af_Catalogo_Info> Get_List_Catalogo(string cod_Catalogo)
        {
            List<Af_Catalogo_Info> lista = new List<Af_Catalogo_Info>();
            EntitiesActivoFijo context = new EntitiesActivoFijo();
            try
            {
                var Existe = from q in context.Af_Catalogo
                             where q.IdTipoCatalogo == cod_Catalogo
                             select q;

                foreach (var item in Existe)
                {
                    Af_Catalogo_Info info = new Af_Catalogo_Info();

                    info.IdCatalogo = item.IdCatalogo;
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
                    info.Descripcion = item.Descripcion;
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
        
        public Af_Catalogo_Info Get_Info_Catalogo(string IdCatalogo)
        {
            EntitiesActivoFijo context = new EntitiesActivoFijo();
            Af_Catalogo_Info Info = new Af_Catalogo_Info();
            try
            {
                var contenido = context.Af_Catalogo.First(var => var.IdCatalogo == IdCatalogo);

                Info.IdCatalogo = contenido.IdCatalogo;
                Info.IdTipoCatalogo = contenido.IdTipoCatalogo;
                Info.Descripcion = contenido.Descripcion;
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
        
        public string GetIdCatalogo(string IdTipoCatalogo)
        {
            try
            {
                String Codigo = "";
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Catalogo
                             where q.IdTipoCatalogo == IdTipoCatalogo
                             select q;

                if (select.ToList().Count == 0)
                {
                    Codigo = "000001";
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Catalogo
                                     where q.IdTipoCatalogo == IdTipoCatalogo
                                     select q.IdCatalogo.Substring(q.IdCatalogo.Length - 6, 6)).Count()+1;

                    Codigo ="000001" +select_pv.ToString();
                    
                }
                return IdTipoCatalogo + "_" + Codigo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesActivoFijo context = new EntitiesActivoFijo();

                var Existe = from q in context.Af_Catalogo
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

        public Boolean GuardarDB(Af_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_Catalogo();
                    Address.IdCatalogo = Info.IdCatalogo;
                    Address.IdTipoCatalogo = Info.IdTipoCatalogo;
                    Address.Descripcion = Info.Descripcion;
                    Address.Estado = "A";
                    Address.Orden = Info.Orden;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    Context.Af_Catalogo.Add(Address);
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
       
        public bool Modificar(Af_Catalogo_Info info)
        {
            try
            {
                EntitiesActivoFijo context = new EntitiesActivoFijo();
                var contenido = context.Af_Catalogo.FirstOrDefault(var => var.IdCatalogo == info.IdCatalogo);
                if (contenido != null)
                {
                    contenido.Descripcion = info.Descripcion;
                    contenido.Orden = info.Orden;
                    contenido.Estado = info.Estado;
                    contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contenido.FechaUltMod = info.FechaUltMod;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
       
        public Boolean Anular(Af_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {

                    var contact = context.Af_Catalogo.FirstOrDefault(var => var.IdCatalogo == Info.IdCatalogo && var.IdTipoCatalogo == Info.IdTipoCatalogo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotiAnula = Info.MotiAnula;
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
       
        public Boolean ValidarIdTipoCatalogo_Descripcion(string IdTipoCatalogo, string Descripcion)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {

                    var Existe = from q in context.Af_Catalogo
                                 where q.Descripcion == Descripcion && q.IdTipoCatalogo == IdTipoCatalogo
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
