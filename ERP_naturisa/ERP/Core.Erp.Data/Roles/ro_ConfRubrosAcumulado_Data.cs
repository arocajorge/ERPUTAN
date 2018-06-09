using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_ConfRubrosAcumulado_Data
    {
        string mensaje = "";
        List<ro_ConfRubrosAcumulado_Info> lista = new List<ro_ConfRubrosAcumulado_Info>();

        public Boolean GrabarDB(ro_ConfRubrosAcumulado_Info ro_info, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    EntitiesRoles EDB = new EntitiesRoles();

                    var address = new ro_Config_Rubros_Acumulado();

                    address.IdEmpresa = ro_info.IdEmpresa;
                    address.IdRubro = ro_info.IdRubro;
                    address.FechaInicio =Convert.ToDateTime( ro_info.FechaInicio);
                    address.FechaFin = Convert.ToDateTime(ro_info.FechaFin);
                    address.Configurable = ro_info.Configurable;

                    context.ro_Config_Rubros_Acumulado.Add(address);
                    context.SaveChanges();

                    mensaje = "Se ha procedido a grabar exitosamente los datos..";
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

       

        public List<ro_ConfRubrosAcumulado_Info> ConsultaGeneral(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                lista = new List<ro_ConfRubrosAcumulado_Info>();

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwRo_Conf_Rubros_Acumulados
                              where A.IdEmpresa == IdEmpresa && A.IdEmpleado==IdEmpleado
                              select A;

                foreach (var item in sresult)
                {
                    ro_ConfRubrosAcumulado_Info Reg = new ro_ConfRubrosAcumulado_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdRubro = item.IdRubro;
                    Reg.FechaInicio = item.Fec_Inicio_Acumulacion;
                    Reg.FechaFin = item.Fec_Fin_Acumulacion;
                    Reg.Descripcion = item.Descripcion;
                    Reg.Configurable = item.Configurable;

                    lista.Add(Reg);
                }
                return lista;
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

        public List<ro_ConfRubrosAcumulado_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                lista = new List<ro_ConfRubrosAcumulado_Info>();

                EntitiesRoles ORol = new EntitiesRoles();

                var sresult = from A in ORol.vwRo_Conf_Rubros_Acumulados_x_Empresa
                              where A.IdEmpresa == IdEmpresa
                              select A;

                foreach (var item in sresult)
                {
                    ro_ConfRubrosAcumulado_Info Reg = new ro_ConfRubrosAcumulado_Info();

                    Reg.IdEmpresa = item.IdEmpresa;
                    Reg.IdRubro = item.IdRubro;
                    Reg.Descripcion = item.ru_descripcion;
                    Reg.Configurable = item.Configurable;

                    lista.Add(Reg);
                }
                return lista;
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

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var S = context.Database.ExecuteSqlCommand("Delete from dbo.ro_Config_Rubros_Acumulado where IdEmpresa =" + IdEmpresa);

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

        public Boolean ExisteRubro(int IdEmpresa, string Idrubro)
        {
            try
            {
                Boolean Existe;

                Existe = false;

                EntitiesRoles OERol_Empleado = new EntitiesRoles();

                var select = from A in OERol_Empleado.ro_Config_Rubros_Acumulado
                             where A.IdEmpresa == IdEmpresa && A.IdRubro == Idrubro
                             select A;

                foreach (var item in select)
                {
                    Existe = true;
                }

                return Existe;

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



        public ro_ConfRubrosAcumulado_Info GetConsultaPorId(int IdEmpresa, string idRubro)
        {
            try
            {
                ro_ConfRubrosAcumulado_Info info = new ro_ConfRubrosAcumulado_Info();
                EntitiesRoles db = new EntitiesRoles();

                var datos = (from a in db.ro_Config_Rubros_Acumulado
                              where a.IdEmpresa == IdEmpresa
                              && a.IdRubro==idRubro
                              select a);

                foreach (var item in datos)
                {

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdRubro = item.IdRubro;
                    info.FechaInicio = item.FechaInicio;
                    info.FechaFin = item.FechaFin;
                    info.Configurable = item.Configurable;
             
                }

                return info;
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
