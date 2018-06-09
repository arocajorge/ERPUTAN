using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_grupo_x_sub_centro_costo_Data
    {
        fa_grupo_x_sub_centro_costo_det_Data oData_Det = new fa_grupo_x_sub_centro_costo_det_Data();

        public decimal Get_Id(int idEmpresa, ref string mensaje)
        {
            try
            {
                int Id;
                Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

                var selecte = db.fa_grupo_x_sub_centro_costo.Count(q => q.IdEmpresa == idEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.fa_grupo_x_sub_centro_costo
                                     where q.IdEmpresa == idEmpresa
                                     select q.IdGrupo).Max();
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

        public List<fa_grupo_x_sub_centro_costo_Info> Get_List_Grup_Sub(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<fa_grupo_x_sub_centro_costo_Info> Lista = new List<fa_grupo_x_sub_centro_costo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_grupo_x_sub_centro_costo
                              where q.IdEmpresa == IdEmpresa
                              && q.Fecha >= Fecha_Ini
                              && q.Fecha <= Fecha_Fin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_grupo_x_sub_centro_costo_Info Info = new fa_grupo_x_sub_centro_costo_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdGrupo = item.IdGrupo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.nom_Grupo = item.nom_Grupo;
                        Info.Fecha = item.Fecha;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = Convert.ToDateTime(item.Fecha_Transaccion);
                        Info.IdUsuarioUltMod = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                        Info.MotivoAnulacion = item.MotivoAnulacion;
                        Info.nom_Centro_costo = item.nom_Centro_costo;
                        Info.nom_Cliente = item.nom_Cliente;
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

        public List<fa_grupo_x_sub_centro_costo_Info> Get_List_Grup_Sub(int IdEmpresa, decimal IdGrupo, ref string mensaje)
        {
            try
            {
                List<fa_grupo_x_sub_centro_costo_Info> Lista = new List<fa_grupo_x_sub_centro_costo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_grupo_x_sub_centro_costo
                              where q.IdEmpresa == IdEmpresa
                              && q.IdGrupo == IdGrupo
                              select q;

                    foreach (var item in lst)
                    {
                        fa_grupo_x_sub_centro_costo_Info Info = new fa_grupo_x_sub_centro_costo_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdGrupo = item.IdGrupo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.nom_Grupo = item.nom_Grupo;
                        Info.Fecha = item.Fecha;
                        Info.Estado = item.Estado;
                        Info.IdUsuario = item.IdUsuario;
                        Info.Fecha_Transaccion = Convert.ToDateTime(item.Fecha_Transaccion);
                        Info.IdUsuarioUltMod = item.IdUsuarioUltModi;
                        Info.Fecha_UltMod = Convert.ToDateTime(item.Fecha_UltMod);
                        Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        Info.Fecha_UltAnu = Convert.ToDateTime(item.Fecha_UltAnu);
                        Info.MotivoAnulacion = item.MotivoAnulacion;
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

        public bool GuardarDB(fa_grupo_x_sub_centro_costo_Info Info, ref decimal IdGrupo, ref string mensaje)
        {
            try
            {
                IdGrupo = Get_Id(Info.IdEmpresa, ref mensaje);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_grupo_x_sub_centro_costo contact = new fa_grupo_x_sub_centro_costo();

                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdGrupo = Info.IdGrupo = IdGrupo;
                    contact.IdCentroCosto = Info.IdCentroCosto;
                    contact.nom_Grupo = Info.nom_Grupo;
                    contact.Fecha = Info.Fecha;
                    contact.Estado = Info.Estado;
                    contact.IdUsuario = Info.IdUsuario;
                    contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                    contact.nom_pc = Info.nom_pc;
                    contact.ip = Info.ip;

                    Context.fa_grupo_x_sub_centro_costo.Add(contact);
                    Context.SaveChanges();
                }

                foreach (var item in Info.List_Detalle)
                {
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdGrupo = Info.IdGrupo;
                    item.IdCentroCosto = Info.IdCentroCosto;
                }

                oData_Det.GuardarDB(Info.List_Detalle, ref mensaje);

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

        public bool ModificarDB(fa_grupo_x_sub_centro_costo_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_grupo_x_sub_centro_costo contact = Context.fa_grupo_x_sub_centro_costo.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdGrupo == Info.IdGrupo);
                    if (contact != null)
                    {
                        contact.IdEmpresa = Info.IdEmpresa;
                        contact.IdGrupo = Info.IdGrupo;
                        contact.IdCentroCosto = Info.IdCentroCosto;
                        contact.nom_Grupo = Info.nom_Grupo;
                        contact.Fecha = Info.Fecha;
                        contact.Estado = Info.Estado;
                        contact.IdUsuarioUltModi = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        Context.SaveChanges();
                    }
                }

                oData_Det.EliminarDB(Info, ref mensaje);

                foreach (var item in Info.List_Detalle)
                {
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdGrupo = Info.IdGrupo;
                    item.IdCentroCosto = Info.IdCentroCosto;
                }
                oData_Det.GuardarDB(Info.List_Detalle, ref mensaje);

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

        public bool AnularDB(fa_grupo_x_sub_centro_costo_Info Info, ref string mensaje)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_grupo_x_sub_centro_costo contact = Context.fa_grupo_x_sub_centro_costo.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdGrupo == Info.IdGrupo);
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
