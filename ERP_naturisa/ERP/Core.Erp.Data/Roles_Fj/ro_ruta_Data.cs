using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles_Fj
{
    public class ro_ruta_Data
    {
        string mensaje = "";

        public List<ro_ruta_Info> Get_List_Ruta(int IdEmpresa)
        {
            List<ro_ruta_Info> list_Ruta = new List<ro_ruta_Info>();
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    var contact = from q in Context.ro_ruta
                                  where q.IdEmpresa == IdEmpresa
                                  select q;

                    foreach (var item in contact)
                    {
                        ro_ruta_Info Info = new ro_ruta_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdRuta = item.IdRuta;
                        Info.ru_descripcion = item.ru_descripcion;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = item.Fecha_Transaccion;
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        list_Ruta.Add(Info);
                    }
                }
                return list_Ruta;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ro_ruta_Info> Get_List_Ruta(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<ro_ruta_Info> list_Ruta = new List<ro_ruta_Info>();

                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    var lst = from q in Context.ro_ruta
                              where q.IdEmpresa == IdEmpresa
                              && q.Fecha_Transaccion >= Fecha_Ini
                              && q.Fecha_Transaccion <= Fecha_Fin
                              select q;

                    foreach (var item in lst)
                    {
                        ro_ruta_Info Info = new ro_ruta_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdRuta = item.IdRuta;
                        Info.ru_descripcion = item.ru_descripcion;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = item.Fecha_Transaccion;
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                        list_Ruta.Add(Info);
                    }
                }
                return list_Ruta;
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

        public ro_ruta_Info Get_Info_Ruta(int IdEmpresa, int IdRuta)
        {
            try
            {
                ro_ruta_Info Info = new ro_ruta_Info();
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    var contact = from q in Context.ro_ruta
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdRuta == IdRuta
                                  select q;

                    foreach (var item in contact)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdRuta = item.IdRuta;
                        Info.ru_descripcion = item.ru_descripcion;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = item.Fecha_Transaccion;
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = item.Fecha_UltMod;
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = item.Fecha_UltAnu;
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
                    }
                }
                return Info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int Get_Id(int IdEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                EntityRoles_FJ db = new EntityRoles_FJ();
                var selecte = db.ro_ruta.Count(q => q.IdEmpresa == IdEmpresa);
                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_ruta
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdRuta).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
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

        public bool GuardarDB(ro_ruta_Info Info, ref int IdRuta, ref string mensaje)
        {
            try
            {
                IdRuta = Get_Id(Info.IdEmpresa, ref mensaje);

                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_ruta contact = new ro_ruta();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdRuta = Info.IdRuta = IdRuta;
                    contact.ru_descripcion = Info.ru_descripcion;
                    contact.Estado = Info.Estado;
                    contact.IdUsuario = Info.IdUsuario;
                    contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                    contact.nom_pc = Info.nom_pc;
                    contact.ip = Info.ip;

                    Context.ro_ruta.Add(contact);
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

        public bool ModificarDB(ro_ruta_Info Info, ref string mensaje)
        {
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_ruta contact = Context.ro_ruta.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdRuta == Info.IdRuta);
                    if (contact != null)
                    {
                        contact.ru_descripcion = Info.ru_descripcion;
                        contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
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

        public bool AnularDB(ro_ruta_Info Info, ref string mensaje)
        {
            try
            {
                using (EntityRoles_FJ Context = new EntityRoles_FJ())
                {
                    ro_ruta contact = Context.ro_ruta.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdRuta == Info.IdRuta);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.Estado = false;
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
