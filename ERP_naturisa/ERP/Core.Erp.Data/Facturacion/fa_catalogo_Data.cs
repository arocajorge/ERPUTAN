using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
   public  class fa_catalogo_Data
   {
       string mensaje = "";

       public List<fa_catalogo_Info> Get_List_catalogo(int IdCatalogoTipo)
        {
            try
            {
                List<fa_catalogo_Info> Lst = new List<fa_catalogo_Info>();
                EntitiesFacturacion oEnti = new EntitiesFacturacion();
                var Query = from q in oEnti.fa_catalogo
                            where q.IdCatalogo_tipo == IdCatalogoTipo
                            select q;

                fa_catalogo_Info Obj = new fa_catalogo_Info();
                Obj.IdCatalogo = "0";
                Obj.IdCatalogo_tipo = IdCatalogoTipo;
                Obj.Nombre = "Todos";                
                Lst.Add(Obj);

                foreach (var item in Query)
                {
                    Obj = new fa_catalogo_Info();
                    Obj.IdCatalogo = item.IdCatalogo;
                    Obj.IdCatalogo_tipo = item.IdCatalogo_tipo;
                    Obj.Nombre = item.Nombre;
                    Obj.Estado = item.Estado;
                    Obj.Abrebiatura = item.Abrebiatura;
                    Obj.NombreIngles = item.NombreIngles;
                    Obj.Orden = item.Orden;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.FechaUltMod = item.FechaUltMod;
                    Obj.nom_pc = item.nom_pc;
                    Obj.ip = item.ip;
                    Obj.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Obj.Fecha_UltAnu = item.Fecha_UltAnu;
                    Obj.MotiAnula = item.MotiAnula;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

       public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesFacturacion Ent = new EntitiesFacturacion();

                var Existe = from q in Ent.fa_catalogo
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

       public string GetId()
        {
            try
            {
                string Id = "";
                EntitiesFacturacion context = new EntitiesFacturacion();
                var select = from q in context.vwfa_Catalogo_IdAuto_numeric
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

       public Boolean ValidarIdTipoCatalogo_Descripcion(int IdCatalogo_tipo, string nombre)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {

                    var Existe = from q in context.fa_catalogo
                                 where q.Nombre == nombre && q.IdCatalogo_tipo == IdCatalogo_tipo
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

       public Boolean GuardarDB(fa_catalogo_Info Info, ref string IdCatalogo, ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var Address = new fa_catalogo();
                    Address.IdCatalogo = IdCatalogo = GetId();
                    Address.IdCatalogo_tipo = Info.IdCatalogo_tipo;
                    Address.Nombre = Info.Nombre;
                    Address.Estado = Info.Estado;
                    Address.Orden = Info.Orden;

                    Address.IdUsuario = Info.IdUsuario;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;

                    Context.fa_catalogo.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

       public bool ModificarDB(fa_catalogo_Info info, ref string msjError)
        {
            try
            {
                EntitiesFacturacion context = new EntitiesFacturacion();
                var contenido = context.fa_catalogo.FirstOrDefault(var => var.IdCatalogo == info.IdCatalogo);
                if (contenido != null)
                {
                    contenido.Nombre = info.Nombre;
                    contenido.Orden = info.Orden;
                    contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contenido.FechaUltMod = info.FechaUltMod;
                    contenido.MotiAnula = info.MotiAnula;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }

       public Boolean AnularDB(fa_catalogo_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_catalogo.FirstOrDefault(var => var.IdCatalogo == Info.IdCatalogo && var.IdCatalogo_tipo == Info.IdCatalogo_tipo);

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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msjError = mensaje;
                throw new Exception(ex.ToString());
            }
        }


    }
}
