/*CLASE: ro_Empleado_X_Horario_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 12-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Data.Roles
{
    public class ro_Empleado_X_Horario_Data
    {
        string mensaje = "";


        public List<ro_Empleado_X_Horario_Info> Get_List_Empleado_X_Horario(int IdEmpresa, decimal IdEmpleado)
        {
            List<ro_Empleado_X_Horario_Info> listado = new List<ro_Empleado_X_Horario_Info>();

            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_empleado_x_horario
                                where a.IdEmpresa == IdEmpresa && a.IdEmpleado==IdEmpleado
                                select a;

                foreach (var item in datos)
                {
                    ro_Empleado_X_Horario_Info info = new ro_Empleado_X_Horario_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdHorario = item.IdHorario;
                    info.EsPredeterminado = item.EsPredeterminado;
                    info.FechaIngresa = item.FechaIngresa;
                    info.UsuarioIngresa = item.UsuarioIngresa;                 

                    listado.Add(info);
                }
                return (listado);
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


        public ro_Empleado_X_Horario_Info Get_Info_Empleado_X_Horario_Preterminado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                ro_Empleado_X_Horario_Info info = new ro_Empleado_X_Horario_Info();

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_empleado_x_horario
                            where a.IdEmpresa == IdEmpresa 
                            && a.IdEmpleado == IdEmpleado 
                            && a.EsPredeterminado==true
                            select a;

                foreach (var item in datos)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdHorario = item.IdHorario;
                    info.EsPredeterminado = item.EsPredeterminado;
                    info.FechaIngresa = item.FechaIngresa;
                    info.UsuarioIngresa = item.UsuarioIngresa;
                }
                return (info);
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


        public Boolean GrabarBD(ro_Empleado_X_Horario_Info info, ref string msg)
        {
            try {

                using(EntitiesRoles db =new EntitiesRoles()){
                    ro_empleado_x_horario item = new ro_empleado_x_horario();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdHorario = info.IdHorario;
                    item.EsPredeterminado = info.EsPredeterminado;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;

                    db.ro_empleado_x_horario.Add(item);
                    db.SaveChanges();
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


        public Boolean ModificarBD(ro_Empleado_X_Horario_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_empleado_x_horario item = (from a in db.ro_empleado_x_horario
                                                  where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado && a.IdHorario == info.IdHorario
                                                  select a).FirstOrDefault();

                    
                    item.EsPredeterminado = info.EsPredeterminado;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;

                    db.SaveChanges();
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


        public Boolean GetExiste(ro_Empleado_X_Horario_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_empleado_x_horario
                                where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado && a.IdHorario==info.IdHorario
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
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

        public Boolean EliminarBD(int IdEmpresa, decimal IdEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_horario where IdEmpresa =" + IdEmpresa.ToString()
                                           + " AND IdEmpleado=" + IdEmpleado.ToString()
                       );
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
    }
}
