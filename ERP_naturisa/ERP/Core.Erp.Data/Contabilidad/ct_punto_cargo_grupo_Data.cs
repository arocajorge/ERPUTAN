using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_punto_cargo_grupo_Data
    {
        public List<ct_punto_cargo_grupo_Info> Get_List_punto_cargo_grupo(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<ct_punto_cargo_grupo_Info> Lista = new List<ct_punto_cargo_grupo_Info>();

                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    var select = from q in Context.ct_punto_cargo_grupo
                                 where q.IdEmpresa == IdEmpresa
                                 select q;
                                 

                    foreach (var item in select)
                    {
                        ct_punto_cargo_grupo_Info Info = new ct_punto_cargo_grupo_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        Info.cod_Punto_cargo_grupo = item.cod_Punto_cargo_grupo;
                        Info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        Info.nom_punto_cargo_grupo2 = "[" + item.IdPunto_cargo_grupo + "]-" + item.nom_punto_cargo_grupo;
                        Info.IdCtaCble = item.IdCtaCble;
                        Info.estado = item.estado;
                        if (Info.estado == true)
                            Info.Estado = "A";
                        else
                            Info.Estado = "I";
                            Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesDBConta Context = new EntitiesDBConta();
                int select = (from q in Context.ct_punto_cargo_grupo
                              where q.IdEmpresa == IdEmpresa
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Context.ct_punto_cargo_grupo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdPunto_cargo_grupo).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public bool GuardarDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_punto_cargo_grupo contact = new ct_punto_cargo_grupo();

                    contact.IdEmpresa = Info.IdEmpresa;
                    if (Info.IdPunto_cargo_grupo == 0)
                        contact.IdPunto_cargo_grupo = getId(Info.IdEmpresa);
                    else
                        contact.IdPunto_cargo_grupo = Info.IdPunto_cargo_grupo;
                    contact.cod_Punto_cargo_grupo = (Info.cod_Punto_cargo_grupo== "")? Info.IdPunto_cargo_grupo.ToString().Trim() : Info.cod_Punto_cargo_grupo;
                    contact.nom_punto_cargo_grupo = Info.nom_punto_cargo_grupo; 
                    contact.IdCtaCble = Info.IdCtaCble;
                    contact.estado = Info.estado;
                    
                    Context.ct_punto_cargo_grupo.Add(contact);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificiarDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_punto_cargo_grupo contact = Context.ct_punto_cargo_grupo.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdPunto_cargo_grupo == Info.IdPunto_cargo_grupo);

                    if (contact != null)
                    {
                        contact.nom_punto_cargo_grupo = Info.nom_punto_cargo_grupo;
                        contact.cod_Punto_cargo_grupo = (Info.cod_Punto_cargo_grupo == "") ? Info.IdPunto_cargo_grupo.ToString().Trim() : Info.cod_Punto_cargo_grupo;
                        contact.IdCtaCble = Info.IdCtaCble;
                        Context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(ct_punto_cargo_grupo_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    ct_punto_cargo_grupo contact = Context.ct_punto_cargo_grupo.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdPunto_cargo_grupo == Info.IdPunto_cargo_grupo);

                    if (contact != null)
                    {
                        contact.estado = false;
                        Context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
