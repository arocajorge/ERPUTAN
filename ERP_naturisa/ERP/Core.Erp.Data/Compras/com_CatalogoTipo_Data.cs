using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras
{
    public class com_CatalogoTipo_Data
    {

        string mensaje = "";

        public List<com_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
            try
            {
                List<com_CatalogoTipo_Info> lista = new List<com_CatalogoTipo_Info>();

                EntitiesCompras oEnt = new EntitiesCompras();

                var select = from q in oEnt.com_catalogo_tipo
                             select q;

                foreach (var item in select)
                {
                    com_CatalogoTipo_Info info = new com_CatalogoTipo_Info();
                    info.IdCatalogocompra_tipo = item.IdCatalogocompra_tipo;
                    info.Descripcion = item.Descripcion;
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
                throw new Exception(ex.ToString());
            }
        }

        public com_CatalogoTipo_Info Get_Info_CatalogoTipo(string id)
        {
            try
            {
                EntitiesCompras context = new EntitiesCompras();
                com_CatalogoTipo_Info Info = new com_CatalogoTipo_Info();

                var contenido = context.com_catalogo_tipo.FirstOrDefault(var => var.IdCatalogocompra_tipo == id);
                if (contenido != null)
                {
                    Info.IdCatalogocompra_tipo = contenido.IdCatalogocompra_tipo;
                    Info.Descripcion = contenido.Descripcion;
                    Info.Estado = contenido.Estado;
                }

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
                EntitiesCompras context = new EntitiesCompras();

                var Existe = from q in context.com_catalogo_tipo
                             where q.IdCatalogocompra_tipo == Cod
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
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GuardarDB(com_CatalogoTipo_Info Info)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var Address = new com_catalogo_tipo();

                    Address.IdCatalogocompra_tipo = Info.IdCatalogocompra_tipo;
                    Address.Descripcion = Info.Descripcion;
                    Address.Estado = Info.Estado;
                    Context.com_catalogo_tipo.Add(Address);
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
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(com_CatalogoTipo_Info info)
        {
            try
            {
                EntitiesCompras context = new EntitiesCompras();

                var contenido = context.com_catalogo_tipo.FirstOrDefault(var => var.IdCatalogocompra_tipo == info.IdCatalogocompra_tipo);
                if (contenido != null)
                {
                    contenido.Descripcion = info.Descripcion;
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
