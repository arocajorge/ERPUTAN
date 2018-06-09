
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
   public  class ro_archivos_bancos_generacion_x_empleado_Data
    {
        string mensaje = "";

        public List<ro_archivos_bancos_generacion_x_empleado_Info> GetListConsultaPorIdArchivo(int idEmpresa, decimal idArchivo)
        {
            List<ro_archivos_bancos_generacion_x_empleado_Info> listado = new List<ro_archivos_bancos_generacion_x_empleado_Info>();
            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.ro_archivos_bancos_generacion_x_empleado
                                where a.IdEmpresa == idEmpresa && a.IdArchivo==idArchivo
                                select a;

                foreach (var item in datos)
                {
                    ro_archivos_bancos_generacion_x_empleado_Info info = new ro_archivos_bancos_generacion_x_empleado_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdArchivo = item.IdArchivo;
                    info.Valor = item.Valor;
                  
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


        public Boolean GuardarBD(ro_archivos_bancos_generacion_x_empleado_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_archivos_bancos_generacion_x_empleado item = new ro_archivos_bancos_generacion_x_empleado();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdArchivo = info.IdArchivo;
                    item.Valor = info.Valor;
                    item.pagacheque = info.pagacheque;
                    db.ro_archivos_bancos_generacion_x_empleado.Add(item);
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


        public Boolean EliminarBD(int idEmpresa, decimal idArchivo, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_archivos_bancos_generacion_x_empleado where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdArchivo=" + idArchivo.ToString()                    
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


        public Boolean ActulizarDB(int idEmpresa, int IdNomina, int IdNomiaTipoLiq, int IdPeriodo, decimal IdEmpleado, double valor)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("update dbo.ro_archivos_bancos_generacion_x_empleado set Valor='" + valor + "' from vwro_archivos_bancos_generacion_x_empleado where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNomina=" + IdNomina
                       + " and IdNominaTipo="+IdNomiaTipoLiq
                        + " and IdPeriodo=" + IdPeriodo
                       + " and IdEmpleado=" + IdEmpleado
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



        public bool SiExiste(int idEmpresa, int IdNomina, int IdNomiaTipoLiq, int IdPeriodo, decimal IdEmpleado)
        {
            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = from a in db.vwro_archivos_bancos_generacion_x_empleado
                            where a.IdEmpresa == idEmpresa
                             && a.IdNomina == IdNomina
                             && a.IdNominaTipo == IdNomiaTipoLiq
                             && a.IdPeriodo == IdPeriodo
                             && a.IdEmpleado == IdEmpleado
                            select a;

                if (datos.Count() > 0)
                    return true;
                else
                    return false;
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
