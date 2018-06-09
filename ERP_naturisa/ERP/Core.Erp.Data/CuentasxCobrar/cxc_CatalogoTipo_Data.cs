using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{
    public class cxc_CatalogoTipo_Data
    {
        string mensaje = "";

        public List<cxc_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
            try
            {
                List<cxc_CatalogoTipo_Info> lista = new List<cxc_CatalogoTipo_Info>();

                EntitiesCuentas_x_Cobrar oEnt = new EntitiesCuentas_x_Cobrar();

                var select = from q in oEnt.cxc_CatalogoTipo
                             select q;

                foreach (var item in select)
                {
                    cxc_CatalogoTipo_Info info = new cxc_CatalogoTipo_Info();
                    info.IdCatalogo_tipo = item.IdCatalogo_tipo;
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cxc_CatalogoTipo_Info Get_Info_CatalogoTipo(string id)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();
                cxc_CatalogoTipo_Info Info = new cxc_CatalogoTipo_Info();

                var contenido = context.cxc_CatalogoTipo.FirstOrDefault(var => var.IdCatalogo_tipo == id);
                if (contenido != null)
                {
                    Info.IdCatalogo_tipo = contenido.IdCatalogo_tipo;
                    Info.Descripcion = contenido.Descripcion;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar();

                var Existe = from q in context.cxc_CatalogoTipo
                             where q.IdCatalogo_tipo == Cod
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

        public Boolean GuardarDB(cxc_CatalogoTipo_Info Info)
        {
            try
            {
                using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
                {
                    var Address = new cxc_CatalogoTipo ();

                    Address.IdCatalogo_tipo = Info.IdCatalogo_tipo;
                    Address.Descripcion = Info.Descripcion;
                    Context.cxc_CatalogoTipo.Add(Address);
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

        public bool ModificarDB(cxc_CatalogoTipo_Info info)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
                {
                    var contenido = context.cxc_CatalogoTipo.FirstOrDefault(var => var.IdCatalogo_tipo == info.IdCatalogo_tipo);
                    if (contenido != null)
                    {
                        contenido.Descripcion = info.Descripcion;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
