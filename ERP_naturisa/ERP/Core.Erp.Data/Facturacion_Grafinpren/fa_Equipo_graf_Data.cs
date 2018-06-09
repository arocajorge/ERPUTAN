using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_Grafinpren;

namespace Core.Erp.Data.Facturacion_Grafinpren
{
    public class fa_Equipo_graf_Data
    {
        public int Get_Id(int IdEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                EntitiesFacturacion_Grafinpren db = new EntitiesFacturacion_Grafinpren();
                var selecte = db.fa_Equipo_graf.Count(q => q.IdEmpresa == IdEmpresa);
                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.fa_Equipo_graf
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdEquipo).Max();
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

        public List<fa_Equipo_graf_Info> Get_List_Equipo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<fa_Equipo_graf_Info> Lista = new List<fa_Equipo_graf_Info>();

                using (EntitiesFacturacion_Grafinpren Context = new EntitiesFacturacion_Grafinpren())
                {
                    var lst = from q in Context.fa_Equipo_graf
                              where q.IdEmpresa == IdEmpresa
                              && q.Fecha_Transaccion >= Fecha_Ini
                              && q.Fecha_Transaccion <= Fecha_Fin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_Equipo_graf_Info Info = new fa_Equipo_graf_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdEquipo = item.IdEquipo;
                        Info.nom_Equipo = item.nom_Equipo;
                        Info.estado = item.estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = Convert.ToDateTime(item.Fecha_Transaccion);
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
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

        public List<fa_Equipo_graf_Info> Get_List_Equipo(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<fa_Equipo_graf_Info> Lista = new List<fa_Equipo_graf_Info>();

                using (EntitiesFacturacion_Grafinpren Context = new EntitiesFacturacion_Grafinpren())
                {
                    var lst = from q in Context.fa_Equipo_graf
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        fa_Equipo_graf_Info Info = new fa_Equipo_graf_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdEquipo = item.IdEquipo;
                        Info.nom_Equipo = item.nom_Equipo;
                        Info.estado = item.estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = Convert.ToDateTime(item.Fecha_Transaccion);
                        Info.IdUsuarioUltModi = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_pc = item.nom_pc;
                        Info.ip = item.ip;
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

        public bool GuardarDB(fa_Equipo_graf_Info Info, ref int IdEquipo, ref string mensaje)
        {
            try
            {
                IdEquipo = Get_Id(Info.IdEmpresa, ref mensaje);

                using (EntitiesFacturacion_Grafinpren Context = new EntitiesFacturacion_Grafinpren())
                {
                    fa_Equipo_graf contact = new fa_Equipo_graf();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdEquipo = Info.IdEquipo = IdEquipo;
                    contact.nom_Equipo = Info.nom_Equipo;
                    contact.estado = Info.estado;
                    contact.IdUsuario = Info.IdUsuario;
                    contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                    contact.nom_pc = Info.nom_pc;
                    contact.ip = Info.ip;

                    Context.fa_Equipo_graf.Add(contact);
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

        public bool ModificarDB(fa_Equipo_graf_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion_Grafinpren Context = new EntitiesFacturacion_Grafinpren())
                {
                    fa_Equipo_graf contact = Context.fa_Equipo_graf.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdEquipo == Info.IdEquipo);
                    if (contact != null)
                    {
                        contact.nom_Equipo = Info.nom_Equipo;
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

        public bool AnularDB(fa_Equipo_graf_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesFacturacion_Grafinpren Context = new EntitiesFacturacion_Grafinpren())
                {
                    fa_Equipo_graf contact = Context.fa_Equipo_graf.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdEquipo == Info.IdEquipo);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
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
