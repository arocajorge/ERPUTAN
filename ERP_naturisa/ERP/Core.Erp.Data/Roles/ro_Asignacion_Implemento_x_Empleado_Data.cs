using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_Data
    {
        string mensaje = "";
        ro_Asignacion_Implemento_x_Empleado_det_Data Data_det = new ro_Asignacion_Implemento_x_Empleado_det_Data();

     
    
        public List<ro_Asignacion_Implemento_x_Empleado_Info> Get_ListAsignacion_Implemento_x_Empleado(int idEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<ro_Asignacion_Implemento_x_Empleado_Info> Lista = new List<ro_Asignacion_Implemento_x_Empleado_Info>();
                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                 var   query = (from q in Conexion.vwro_Asignacion_Implemento_x_Empleado
                             where idEmpresa == q.IdEmpresa &&
                             FechaIni <= q.Fecha_Entrega && q.Fecha_Entrega <= FechaFin
                             select q);
                 foreach (var item in query)
                 {
                     ro_Asignacion_Implemento_x_Empleado_Info info = new ro_Asignacion_Implemento_x_Empleado_Info();
                     info.IdEmpleado = item.IdEmpresa;
                     info.IdEmpleado = item.IdEmpleado;
                     info.IdAsignacion_Impl = item.IdAsignacion_Impl;
                     info.Fecha_Entrega = item.Fecha_Entrega;
                     info.Observacion = item.Observacion;
                     info.Fecha_Transac = item.Fecha_Transac;
                     info.pe_nombreCompleto = item.pe_nombreCompleto;
                     info.Tipo_Movimiento = item.Tipo_Movimiento;

                     Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetId()
        {
            try
            {
                decimal x = 0;

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    x = (from q in Conexion.ro_Asignacion_Implemento_x_Empleado
                         select q.IdAsignacion_Impl).Max() + 1;
               }
                return x;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return 1;
            }
        }

        public Boolean GuardarDB(ro_Asignacion_Implemento_x_Empleado_Info Info , ref decimal IdAsignacion)
        {
            try
            {
                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    ro_Asignacion_Implemento_x_Empleado Entity = new ro_Asignacion_Implemento_x_Empleado();
                    Entity.IdEmpresa = Info.IdEmpresa;
                    Entity.IdNomina_Tipo = Info.IdNomina_Tipo;
                    Entity.IdAsignacion_Impl = Info.IdAsignacion_Impl = GetId();
                    Entity.Fecha_Entrega = Info.Fecha_Entrega;
                    Entity.IdEmpleado = Info.IdEmpleado;
                    Entity.Observacion = Info.Observacion;
                    Entity.Estado = Info.Estado;
                    Entity.Tipo_Movimiento = Info.Tipo_Movimiento;
                    Conexion.ro_Asignacion_Implemento_x_Empleado.Add(Entity);
                    Conexion.SaveChanges();
                    IdAsignacion = Entity.IdAsignacion_Impl;
                }

                foreach (var item in Info.Lst_ro_Asignacion_Implemento_x_Empleado_det)
                {
                    item.IdAsignacion_Impl = Info.IdAsignacion_Impl;
                    item.IdEmpresa = Info.IdEmpresa;
                }

                Data_det.GuardarDB(Info.Lst_ro_Asignacion_Implemento_x_Empleado_det);
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return false;
            }
        }

        public Boolean ModificarDB(ro_Asignacion_Implemento_x_Empleado_Info Info)
        {
            try
            {
                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    ro_Asignacion_Implemento_x_Empleado Entity = Conexion.ro_Asignacion_Implemento_x_Empleado.SingleOrDefault(q=>q.IdAsignacion_Impl==Info.IdAsignacion_Impl);
                    Entity.IdEmpresa = Info.IdEmpresa;
                    Entity.IdAsignacion_Impl = Info.IdAsignacion_Impl;
                    Entity.Fecha_Entrega = Info.Fecha_Entrega;
                    Entity.IdEmpleado = Info.IdEmpleado;
                    Entity.Observacion = Info.Observacion;
                    Entity.Estado = Info.Estado;
                    Entity.Tipo_Movimiento = Info.Tipo_Movimiento;

                    Conexion.SaveChanges();
                }

                Data_det.EliminarDB(Info);

                foreach (var item in Info.Lst_ro_Asignacion_Implemento_x_Empleado_det)
                {
                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdAsignacion_Impl = Info.IdAsignacion_Impl;
                }

                Data_det.GuardarDB(Info.Lst_ro_Asignacion_Implemento_x_Empleado_det);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return false;
            }
        }

        public Boolean AnularDB(ro_Asignacion_Implemento_x_Empleado_Info Info)
        {
            try
            {
                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    ro_Asignacion_Implemento_x_Empleado Entity = Conexion.ro_Asignacion_Implemento_x_Empleado.SingleOrDefault(q => q.IdAsignacion_Impl == Info.IdAsignacion_Impl);
                    Entity.Estado = "I";
                    Entity.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Entity.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Entity.MotivoAnulacion = Info.MotivoAnulacion;

                    Conexion.SaveChanges();
                }
                Data_det.EliminarDB(Info);
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return false;
            }
        }


        public bool Get_si_existe_Implemento_pendiente_devolver(Int32 idEmpresa, int IdNominaTipo, int IdEmpleado)
        {
            try
            {
                bool Bandera_si_existe = false;

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    var query = (from q in Conexion.vwro_ro_Asignacion_Implemento_x_Empleado_xi_existen_pemdientes_devolver
                                 where q.IdEmpresa == idEmpresa
                                 && q.IdNomina_Tipo == IdNominaTipo
                                 && q.IdEmpleado == IdEmpleado
                                 select q);


                    if (query.Count() > 0)
                        Bandera_si_existe = true;
                    else
                        Bandera_si_existe = false;

                }

                return Bandera_si_existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
