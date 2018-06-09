using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_CatalogoTipo_Data
    {
        string mensaje = "";
        public List<Af_CatalogoTipo_Info> Get_List_CatalogoTipo()
        {
                List<Af_CatalogoTipo_Info> lista = new List<Af_CatalogoTipo_Info>();
                EntitiesActivoFijo oEnt = new EntitiesActivoFijo();
            try
            {
                var select = from q in oEnt.Af_CatalogoTipo
                             select q;

                foreach (var item in select)
                {
                    Af_CatalogoTipo_Info info = new Af_CatalogoTipo_Info();
                    info.IdTipoCatalogo = item.IdTipoCatalogo;
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

        public Af_CatalogoTipo_Info Get_Info_CatalogoTipo(string id)
        {
                EntitiesActivoFijo context = new EntitiesActivoFijo();
                Af_CatalogoTipo_Info Info = new Af_CatalogoTipo_Info();
            try
            {
                var contenido = context.Af_CatalogoTipo.First(var => var.IdTipoCatalogo == id);
                Info.IdTipoCatalogo = contenido.IdTipoCatalogo;
                Info.Descripcion = contenido.Descripcion;
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
                EntitiesActivoFijo context = new EntitiesActivoFijo();

                var Existe = from q in context.Af_CatalogoTipo
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

        public Boolean GuardarDB(Af_CatalogoTipo_Info Info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var Address = new Af_CatalogoTipo();

                    Address.IdTipoCatalogo = Info.IdTipoCatalogo;
                    Address.Descripcion = Info.Descripcion;
                    Context.Af_CatalogoTipo.Add(Address);
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

        public bool Modificar(Af_CatalogoTipo_Info info)
        {
            try
            {
                EntitiesActivoFijo context = new EntitiesActivoFijo();

                var contenido = context.Af_CatalogoTipo.FirstOrDefault(var => var.IdTipoCatalogo == info.IdTipoCatalogo);
                contenido.Descripcion = info.Descripcion;
                if (contenido != null)
                {
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
