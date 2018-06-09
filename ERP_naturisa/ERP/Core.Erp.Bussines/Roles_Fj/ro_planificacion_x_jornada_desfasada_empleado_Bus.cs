using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_planificacion_x_jornada_desfasada_empleado_Bus
    {

      string mensaje = "";
      ro_planificacion_x_jornada_desfasada_empleado_Data data = new ro_planificacion_x_jornada_desfasada_empleado_Data();
        public bool Guardar_DB(ro_planificacion_x_jornada_desfasada_empleado_Info info)
        {
            try
            {
                return data.Guardar_DB(info);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool Modificar_DB(ro_planificacion_x_jornada_desfasada_empleado_Info info)
        {
            try
            {
                return data.Modificar_DB(info);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool Anular_DB(List<ro_planificacion_x_jornada_desfasada_empleado_Info> lista)
        {
            try
            {
                return data.Anular_DB(lista);

            }
            catch (Exception ex)
            {
                
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Listado_planificacion_x_periodo(int IdEmpresa, int IdNomina_Tipo, int IdPeriodo)
        {
            try
            {
                return data.Listado_planificacion_x_periodo(IdEmpresa, IdNomina_Tipo, IdPeriodo); 
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
        public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdDepartamento, int IdCargo, int IdTurno)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada(IdEmpresa, IdNomina_tipo, info_periodo, IdDepartamento, IdCargo,IdTurno);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_dep(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdDepartamento, int IdTurno)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada_dep(IdEmpresa, IdNomina_tipo, info_periodo, IdDepartamento, IdTurno);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
        public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_car(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, int IdCargo, int IdTurno)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada_car(IdEmpresa, IdNomina_tipo, info_periodo, IdCargo, IdTurno);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }


        public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada_car(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo, decimal IdDivision, int IdTurno)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada_car(IdEmpresa, IdNomina_tipo, info_periodo, IdDivision, IdTurno);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
      public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo,int IdTurno)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada(IdEmpresa, IdNomina_tipo, info_periodo, IdTurno);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
      public bool Eliminar(ro_planificacion_x_jornada_desfasada_Info info)
        {
            try
            {
                return data.Eliminar(info);
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
