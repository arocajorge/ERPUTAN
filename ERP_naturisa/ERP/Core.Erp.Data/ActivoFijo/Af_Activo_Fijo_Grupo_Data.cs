using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Activo_Fijo_Grupo_Data
    {
        string mensaje = "";

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id = 0;
                //EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                //var select = from q in OEPActivoFijo.Af_Activo_fijo_Grupo
                //             where q.IdEmpresa == IdEmpresa
                //             select q;

                //if (select.ToList().Count == 0)
                //{
                //    Id = 1;
                //}
                //else
                //{
                //    var select_pv = (from q in OEPActivoFijo.Af_Activo_fijo_Grupo
                //                     where q.IdEmpresa == IdEmpresa
                //                     select q.IdGrupoActivoFijo).Max();
                //    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                //}
                return Id;
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

        public List<Af_Activo_Fijo_Grupo_Info> Get_List_ActivoFijo_Grupo(int IdEmpresa)
        {
            try
            {
                
                List<Af_Activo_Fijo_Grupo_Info> lista = new List<Af_Activo_Fijo_Grupo_Info>();
                //using (EntitiesActivoFijo context= new EntitiesActivoFijo())
                //{
                //    var contact= from q in context.Af_Activo_fijo_Grupo
                //                 where q.IdEmpresa==IdEmpresa
                //                 select q;

                //    foreach (var item in contact)
                //    {
                //        Af_Activo_Fijo_Grupo_Info Info= new Af_Activo_Fijo_Grupo_Info();
                //        Info.IdEmpresa = item.IdEmpresa;
                //        Info.IdGrupoActivoFijo = item.IdGrupoActivoFijo;
                //        Info.codGrupoActivoFijo = item.codGrupoActivoFijo;
                //        Info.nom_GrupoActivoFijo = item.nom_GrupoActivoFijo;
                //        Info.Af_Grupo_Nombre = "[" + item.IdGrupoActivoFijo.ToString() + "] - " + item.nom_GrupoActivoFijo;
                //        Info.estado = item.estado;
                //        Info.UsuarioCreacion = item.UsuarioCreacion;
                //        Info.FechaCreacion = item.FechaCreacion;
                //        Info.UsuarioModificacion = item.UsuarioModificacion;
                //        Info.FechaModificacion = item.FechaModificacion;
                //        Info.UsuarioAnulacion = item.UsuarioAnulacion;
                //        Info.FechaAnulacion = item.FechaAnulacion;
                //        Info.MotivoAnulacion = item.MotivoAnulacion;
                //        lista.Add(Info);
                //    }
                //}
                return lista;
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

        public Boolean GrabarDB(Af_Activo_Fijo_Grupo_Info info, ref string msg)
        {
            try
            {
                //using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                //{
                //    Af_Activo_fijo_Grupo address = new Af_Activo_fijo_Grupo();

                //    int id = GetId(info.IdEmpresa);
                //    address.IdEmpresa = info.IdEmpresa;
                //    address.IdGrupoActivoFijo = info.IdGrupoActivoFijo = id;
                //    address.codGrupoActivoFijo = (info.codGrupoActivoFijo == "") ? info.IdGrupoActivoFijo.ToString() : info.codGrupoActivoFijo;
                //    address.nom_GrupoActivoFijo = info.nom_GrupoActivoFijo;
                //    address.estado = info.estado;
                    
                //    context.Af_Activo_fijo_Grupo.Add(address);
                //    context.SaveChanges();
                //    msg = "Se ha procedido a grabar el registro del Activo Fijo #: " + id.ToString() + " Exitosamente.";
                //}
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(Af_Activo_Fijo_Grupo_Info info, ref string msg)
        {
            try
            {
                //using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                //{
                //    var contact = context.Af_Activo_fijo_Grupo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdGrupoActivoFijo==info.IdGrupoActivoFijo);

                //    if (contact != null)
                //    {
                //        contact.codGrupoActivoFijo = info.codGrupoActivoFijo;
                //        contact.nom_GrupoActivoFijo = info.nom_GrupoActivoFijo;
                //        contact.estado = info.estado;
                //        contact.UsuarioModificacion = info.UsuarioModificacion;
                //        contact.FechaModificacion = info.FechaModificacion;
                //        context.SaveChanges();
                //        msg = "Se ha procedido actualizar el registro del Activo Fijo #: " + info.IdGrupoActivoFijo.ToString() + " exitosamente";
                //    }
                //}
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(Af_Activo_Fijo_Grupo_Info info, ref  string msg)
        {
            try
            {
                //using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                //{
                //    var contact = context.Af_Activo_fijo_Grupo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdGrupoActivoFijo == info.IdGrupoActivoFijo);
                //    if (contact != null)
                //    {
                //        contact.UsuarioAnulacion = info.UsuarioAnulacion;
                //        contact.MotivoAnulacion = info.MotivoAnulacion;
                //        contact.FechaAnulacion = DateTime.Now;
                //        contact.estado = "I";
                //        context.SaveChanges();
                //        msg = "Se ha procedido anular el registro del Activo Fijo #: " + info.IdGrupoActivoFijo.ToString() + " exitosamente";
                //    }
                //}
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
