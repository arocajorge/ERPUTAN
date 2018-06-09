using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_det_Data
    {
        string mensaje = "";

        public List<ro_Asignacion_Implemento_x_Empleado_det_Info> Get_Lista_Implemento_x_empleador_det(int idEmpresa, decimal IdAsignacion_Impl)
        {
            try
            {
                List<ro_Asignacion_Implemento_x_Empleado_det_Info> Lista = new List<ro_Asignacion_Implemento_x_Empleado_det_Info>();

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    var query = (from q in Conexion.ro_Asignacion_Implemento_x_Empleado_det
                                 where q.IdEmpresa == idEmpresa
                                 && q.IdAsignacion_Impl == IdAsignacion_Impl
                                 select q);


                    foreach (var item in query)
                    {
                        ro_Asignacion_Implemento_x_Empleado_det_Info info = new ro_Asignacion_Implemento_x_Empleado_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdAsignacion_Impl = item.IdAsignacion_Impl;
                        info.IdProducto = item.IdProducto;
                        info.Fecha_Caducidad = item.Fecha_Caducidad;
                        info.Vida_Util = item.Vida_Util;
                        info.Detalle = item.Detalle;
                        info.Estado_implemnto = item.Estado_implemnto;
                        info.Cantidad = item.Cantidad;
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

        public Boolean GuardarDB(List<ro_Asignacion_Implemento_x_Empleado_det_Info> Lst_Info)
        {
            try
            {
                int sec = 1;
                foreach (var item in Lst_Info)
                {
                    using (EntitiesRoles Conexion = new EntitiesRoles())
                    {
                        ro_Asignacion_Implemento_x_Empleado_det Entity = new ro_Asignacion_Implemento_x_Empleado_det();
                        Entity.IdAsignacion_Impl = item.IdAsignacion_Impl;
                        Entity.IdEmpresa = item.IdEmpresa;

                        Entity.secuencia = sec;
                        Entity.IdProducto = item.IdProducto;
                        Entity.Vida_Util = item.Vida_Util;
                        Entity.Cantidad = item.Cantidad;
                        Entity.Detalle = item.Detalle;
                        Entity.Fecha_Caducidad = item.Fecha_Caducidad;
                        Entity.Estado_implemnto =item.Estado_implemnto.ToString();
                        sec = sec + 1;
                        Conexion.ro_Asignacion_Implemento_x_Empleado_det.Add(Entity);
                        Conexion.SaveChanges();
                    }
                    sec++;
                }
                
                return true;
                
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

        public Boolean EliminarDB(ro_Asignacion_Implemento_x_Empleado_Info info)
        {
            try
            {
                EntitiesRoles Conexion = new EntitiesRoles();

                var Comando = Conexion.Database.ExecuteSqlCommand("delete from ro_Asignacion_Implemento_x_Empleado_det where IdEmpresa = " + info.IdEmpresa + "  and IdAsignacion_Impl = " + info.IdAsignacion_Impl + "");

                return true;
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
