
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using DevExpress.Utils;
using IExcel = Microsoft.Office.Interop.Excel;
using System.Data.Entity.Validation;
namespace Core.Erp.Data.Roles
{
    public class ro_permiso_x_empleado_Data
    {
        string mensaje = "";

        public List<ro_permiso_x_empleado_Info> ConsultaGeneral(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
        {   
            List<ro_permiso_x_empleado_Info> lst = new List<ro_permiso_x_empleado_Info>();
            try
            {

                using (EntitiesRoles Gene = new EntitiesRoles())
                {                    
                    var cons = from q in Gene.vwRo_Permiso_x_Empleado
                               where q.IdEmpresa == IdEmpresa  
                               &&q.Fecha>=Fecha_inicio
                               &&q.Fecha<=Fecha_Fin
                               orderby q.IdPermiso descending
                               select q;
                    foreach (var item in cons)
                    {
                        ro_permiso_x_empleado_Info info = new ro_permiso_x_empleado_Info();
                        ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPermiso = item.IdPermiso;
                        info.Fecha = item.Fecha;
                        info.IdEmpleado = item.IdEmpleado;
                        info.MotivoAusencia = item.MotivoAusencia;
                        info.TiempoAusencia = item.TiempoAusencia;
                        info.FormaRecuperacion = item.FormaRecuperacion;
                        info.IdEmpleado_Soli = item.IdEmpleado_Soli;
                        info.IdEstadoAprob = item.IdEstadoAprob;
                        info.IdEmpleado_Apro = item.IdEmpleado_Apro;
                        info.MotivoAproba = item.MotivoAproba;
                        info.Observacion = item.Observacion;
                        info.Estado = item.Estado;
                        info.pe_nombre = item.pe_apellido + " " + item.pe_nombre;
                        info.em_codigo = item.em_codigo;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.IdTipoLicencia = item.IdTipoLicencia;
                        info.EsLicencia = item.EsLicencia;
                        info.EsPermiso = item.EsPermiso;
                        info.FechaEntrada = item.FechaEntrada;
                        info.FechaSalida = item.FechaSalida;
                        info.HoraRegreso = item.HoraRegreso;
                        info.HoraSalida = item.HoraSalida;
                        info.HorasAtraso = item.HorasAtraso;
                        info.LLegoAtrasado =Convert.ToBoolean( item.LLegoAtrasado);
                        info.ca_descripcion = item.ca_descripcion;
                        info.de_descripcion = item.de_descripcion;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NomEmpleado = item.NomEmpleado;
                        
                        info.Id_Forma_descuento_permiso_Cat = item.Id_Forma_descuento_permiso_Cat;
                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_permiso_x_empleado_Info> GetListLicenciaPorEmpleado(int IdEmpresa, int idEmpleado, DateTime fecha_I,DateTime fecha_F)
        {
            List<ro_permiso_x_empleado_Info> lst = new List<ro_permiso_x_empleado_Info>();
            try
            {
                // ARREGLAR CARLOS

                using (EntitiesRoles Gene = new EntitiesRoles())
                {
                    var cons = from q in Gene.ro_permiso_x_empleado
                               where q.IdEmpresa==IdEmpresa
                               && q.IdEmpleado==idEmpleado
                               && q.IdTipoLicencia == "143"
                               && q.Estado=="A"
                               select q;
                    foreach (var item in cons)
                    {
                        ro_permiso_x_empleado_Info info = new ro_permiso_x_empleado_Info();
                        info.FechaEntrada = item.FechaEntrada;
                        info.FechaSalida = item.FechaSalida;
                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public decimal GetId(int idEmpresa) {
            try
            {
                decimal Id;
                EntitiesRoles db = new EntitiesRoles();

                var datos = (from a in db.ro_permiso_x_empleado
                             where a.IdEmpresa == idEmpresa
                             select a);
                if (datos.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from a in db.ro_permiso_x_empleado
                                   where a.IdEmpresa == idEmpresa
                                   select a.IdPermiso).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }        
        }




        public Boolean GuardarDB(ro_permiso_x_empleado_Info info, ref decimal id, ref string msg)
        {
            try
            {
                    using (EntitiesRoles db = new EntitiesRoles())
                    {
   
                        ro_permiso_x_empleado data = new ro_permiso_x_empleado();
                        
                        data.IdPermiso = id =GetId(info.IdEmpresa);
                        data.IdEmpresa = info.IdEmpresa;
                        data.Fecha = Convert.ToDateTime(info.Fecha);
                        data.IdEmpleado = info.IdEmpleado;
                        data.MotivoAusencia = info.MotivoAusencia;
                       
                        data.TiempoAusencia = info.TiempoAusencia;
                        if (info.FormaRecuperacion == null || info.FormaRecuperacion=="")
                        {
                            data.FormaRecuperacion = ".";
                        }
                        else
                        {
                            data.FormaRecuperacion = info.FormaRecuperacion;

                        }
                        data.IdEmpleado_Soli = info.IdEmpleado_Soli;
                        data.IdEstadoAprob = info.IdEstadoAprob;
                        data.IdEmpleado_Apro = info.IdEmpleado_Apro;
                        data.MotivoAproba = info.MotivoAproba;
                        data.Observacion = info.Observacion;
                        

                        data.IdTipoLicencia = info.IdTipoLicencia;
                        data.EsLicencia = info.EsLicencia;
                        data.EsPermiso = info.EsPermiso;

                        data.FechaEntrada =Convert.ToDateTime( Convert.ToDateTime( info.FechaEntrada).ToShortDateString());
                        data.FechaSalida = Convert.ToDateTime(Convert.ToDateTime(info.FechaSalida).ToShortDateString());
                        data.LLegoAtrasado = info.LLegoAtrasado;
                        data.HoraSalida = info.HoraSalida;
                        data.HoraRegreso = info.HoraRegreso;
                        data.HorasAtraso = info.HorasAtraso;



                        data.Estado = info.Estado;
                        data.IdUsuario = info.IdUsuario;
                        data.Fecha_Transac = info.Fecha_Transac;
                        data.ip = info.ip;
                       // data.nom_pc = info.nom_pc;
                        data.Id_Forma_descuento_permiso_Cat = info.Id_Forma_descuento_permiso_Cat;
                        db.ro_permiso_x_empleado.Add(data);
                        db.SaveChanges();
                    }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    
                }

                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public Boolean ModificarDB(ro_permiso_x_empleado_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles()){

                    ro_permiso_x_empleado data = (from a in db.ro_permiso_x_empleado
                                   where a.IdEmpresa==info.IdEmpresa && a.IdPermiso==info.IdPermiso
                                    select a).FirstOrDefault();

                    data.Fecha = Convert.ToDateTime(info.Fecha);
                    data.MotivoAusencia = info.MotivoAusencia;
                    data.TiempoAusencia = info.TiempoAusencia;
                    data.FormaRecuperacion = info.FormaRecuperacion;
                    data.IdEmpleado_Soli = info.IdEmpleado_Soli;
                    data.IdEstadoAprob = info.IdEstadoAprob;
                    data.IdEmpleado_Apro = info.IdEmpleado_Apro;
                    data.MotivoAproba = info.MotivoAproba;
                    data.Observacion = info.Observacion;
                    data.Fecha_UltMod = info.Fecha_Transac;
                    data.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    data.IdTipoLicencia = info.IdTipoLicencia;
                    data.EsLicencia = info.EsLicencia;
                    data.EsPermiso = info.EsPermiso;
                    data.FechaEntrada = Convert.ToDateTime(Convert.ToDateTime(info.FechaEntrada).ToShortDateString());
                    data.FechaSalida = Convert.ToDateTime(Convert.ToDateTime(info.FechaSalida).ToShortDateString());
                    data.LLegoAtrasado = info.LLegoAtrasado;
                    data.HoraSalida = info.HoraSalida;
                    data.HoraRegreso = info.HoraRegreso;
                    data.HorasAtraso = info.HorasAtraso;
                    data.Id_Forma_descuento_permiso_Cat = info.Id_Forma_descuento_permiso_Cat;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean EliminarPermiso(ro_permiso_x_empleado_Info info)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    ro_permiso_x_empleado data = rol.ro_permiso_x_empleado.First(v => v.IdPermiso == info.IdPermiso);
                    rol.ro_permiso_x_empleado.Remove(data);
                    rol.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int MaxPermiso(int IdEmpresa)
        {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var numero =Convert.ToInt32(( from q in rol.ro_permiso_x_empleado
                                  where q.IdEmpresa == IdEmpresa
                                                     select q.IdPermiso).Max());
                    return numero;     
                }
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GetExiste(ro_permiso_x_empleado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_permiso_x_empleado
                                where a.IdEmpresa == info.IdEmpresa && a.IdPermiso == info.IdPermiso
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ro_permiso_x_empleado_Info Get_Dias_Permiso(int idempresa, int IdNomina_Tipo, int idempleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                ro_permiso_x_empleado_Info info = new ro_permiso_x_empleado_Info();

                using (EntitiesRoles Gene = new EntitiesRoles())
                {
                    var cons = from q in Gene.ro_permiso_x_empleado
                               where q.IdEmpresa == idempresa
                               && q.IdEmpleado == idempleado
                               && q.IdTipoLicencia == "143"
                               && q.Estado == "A"

                                   && (
                                       (q.FechaSalida >= fechaIni && q.FechaEntrada <= fechaFin)
                                       || (q.FechaEntrada >= fechaIni && q.FechaEntrada <= fechaFin)
                                       || (q.FechaSalida <= fechaFin && q.FechaEntrada >= fechaFin
                                       )
                                     )
                               select q;
                    foreach (var item in cons)
                    {
                        info.FechaEntrada = item.FechaEntrada;
                        info.FechaSalida = item.FechaSalida;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

      
    }
}
