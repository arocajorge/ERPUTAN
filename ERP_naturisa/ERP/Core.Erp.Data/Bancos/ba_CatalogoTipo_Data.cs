using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_CatalogoTipo_Data
    {
        string mensaje = "";
        
        public List<ba_CatalogoTipo_info> Get_List_CatalogoTipo()
        {
                List<ba_CatalogoTipo_info> lista = new List<ba_CatalogoTipo_info>();
            try
            {
                EntitiesBanco oEnt = new EntitiesBanco();
                var select = from q in oEnt.ba_CatalogoTipo
                             select q;
                foreach (var item in select)
                {
                    ba_CatalogoTipo_info info = new ba_CatalogoTipo_info();
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
                    info.tc_descripcion = item.tc_Descripcion;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public ba_CatalogoTipo_info Get_Info_Catalogo(string id)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                ba_CatalogoTipo_info ba_cata_Info = new ba_CatalogoTipo_info();

                var contenido = context.ba_CatalogoTipo.FirstOrDefault(var => var.IdTipoCatalogo == id);
                if (contenido != null)
                {
                    ba_cata_Info.IdTipoCatalogo = contenido.IdTipoCatalogo;
                    ba_cata_Info.tc_descripcion = contenido.tc_Descripcion;
                }
                return ba_cata_Info;
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
                EntitiesBanco context = new EntitiesBanco();

                var Existe = from q in context.ba_CatalogoTipo
                             where q.IdTipoCatalogo == Cod
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

        public Boolean GuardarDB(ba_CatalogoTipo_info Info)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    var Address = new ba_CatalogoTipo();
                   
                    Address.IdTipoCatalogo = Info.IdTipoCatalogo;
                    Address.tc_Descripcion = Info.tc_descripcion;
                    Context.ba_CatalogoTipo.Add(Address);
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

        public bool ModificarDB(ba_CatalogoTipo_info info)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                var contenido = context.ba_CatalogoTipo.FirstOrDefault(var => var.IdTipoCatalogo == info.IdTipoCatalogo);
                if (contenido != null)
                {
                    contenido.tc_Descripcion = info.tc_descripcion;
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
    }
}
