using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_grupo_x_Tipo_Gasto_Data
    {
        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto(int IdEmpresa)
        {
            try
            {
                List<ct_grupo_x_Tipo_Gasto_Info> Lista = new List<ct_grupo_x_Tipo_Gasto_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.vwct_grupo_x_Tipo_Gasto
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        ct_grupo_x_Tipo_Gasto_Info info = new ct_grupo_x_Tipo_Gasto_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        info.IdTipo_Gasto_Padre = item.IdTipo_Gasto_Padre;
                        info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                        info.estado = item.estado;
                        info.nivel = item.nivel;
                        info.orden = item.orden;
                        info.nom_tipo_Gasto2 = "["+item.IdTipo_Gasto.ToString()+"] " + item.nom_tipo_Gasto;
                        info.nom_tipo_Gasto_Padre = item.nom_tipo_Gasto_Padre;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto_nivel_3(int IdEmpresa)
        {
            try
            {
                List<ct_grupo_x_Tipo_Gasto_Info> Lista = new List<ct_grupo_x_Tipo_Gasto_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.vwct_grupo_x_Tipo_Gasto
                              where q.IdEmpresa == IdEmpresa
                              && q.nivel == 3 && q.estado == true
                              select q;

                    foreach (var item in lst)
                    {
                        ct_grupo_x_Tipo_Gasto_Info info = new ct_grupo_x_Tipo_Gasto_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        info.IdTipo_Gasto_Padre = item.IdTipo_Gasto_Padre;
                        info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                        info.estado = item.estado;
                        info.nivel = item.nivel;
                        info.orden = item.orden;
                        info.nom_tipo_Gasto2 = "[" + item.IdTipo_Gasto.ToString() + "] " + item.nom_tipo_Gasto;
                        info.nom_tipo_Gasto_Padre = item.nom_tipo_Gasto_Padre;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto_nivel_menor_3(int IdEmpresa)
        {
            try
            {
                List<ct_grupo_x_Tipo_Gasto_Info> Lista = new List<ct_grupo_x_Tipo_Gasto_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.vwct_grupo_x_Tipo_Gasto
                              where q.IdEmpresa == IdEmpresa
                              && q.nivel < 3 && q.estado == true
                              select q;

                    foreach (var item in lst)
                    {
                        ct_grupo_x_Tipo_Gasto_Info info = new ct_grupo_x_Tipo_Gasto_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo_Gasto = item.IdTipo_Gasto;
                        info.IdTipo_Gasto_Padre = item.IdTipo_Gasto_Padre;
                        info.nom_tipo_Gasto = item.nom_tipo_Gasto;
                        info.estado = item.estado;
                        info.nivel = item.nivel;
                        info.orden = item.orden;
                        info.nom_tipo_Gasto2 = "[" + item.IdTipo_Gasto.ToString() + "] " + item.nom_tipo_Gasto;
                        info.nom_tipo_Gasto_Padre = item.nom_tipo_Gasto_Padre;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    ct_grupo_x_Tipo_Gasto Entity = new ct_grupo_x_Tipo_Gasto();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdTipo_Gasto = info.IdTipo_Gasto = Get_id(info.IdEmpresa);
                    Entity.IdTipo_Gasto_Padre = info.IdTipo_Gasto_Padre;
                    Entity.nom_tipo_Gasto = info.nom_tipo_Gasto;
                    Entity.estado = true;
                    Entity.nivel = info.nivel;
                    Entity.orden = info.orden;
                    context.ct_grupo_x_Tipo_Gasto.Add(Entity);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    ct_grupo_x_Tipo_Gasto Entity = context.ct_grupo_x_Tipo_Gasto.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTipo_Gasto == info.IdTipo_Gasto);
                    if (Entity!=null)
                    {
                        Entity.IdTipo_Gasto_Padre = info.IdTipo_Gasto_Padre;
                        Entity.nom_tipo_Gasto = info.nom_tipo_Gasto;
                        Entity.nivel = info.nivel;
                        Entity.orden = info.orden;
                        context.SaveChanges();    
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    ct_grupo_x_Tipo_Gasto Entity = context.ct_grupo_x_Tipo_Gasto.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTipo_Gasto == info.IdTipo_Gasto);
                    if (Entity != null)
                    {
                        Entity.estado = false;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int Get_id(int IdEmpresa)
        {
            try
            {
                int ID = 0;

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.ct_grupo_x_Tipo_Gasto
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0)
                    {
                        ID = lst.Max(q => q.IdTipo_Gasto) + 1;
                    }
                    else
                        ID = 1;
                }
                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int Get_orden(int IdEmpresa, Nullable<int> IdTipo_gasto_padre)
        {
            try
            {
                int Orden = 0;

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var lst = from q in Context.ct_grupo_x_Tipo_Gasto
                              where IdEmpresa == q.IdEmpresa
                              && IdTipo_gasto_padre == q.IdTipo_Gasto_Padre
                              select q;

                    if (lst.Count() == 0)
                        Orden = 1;
                    else
                        Orden = lst.Max(q => q.orden) == null ? 1 : Convert.ToInt32(lst.Max(q => q.orden))+ 1;
                }

                return Orden;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
