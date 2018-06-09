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
  public  class ro_empleado_x_turno_Bus
    {

      string mensaje = "";
      ro_empleado_x_turno_Data data = new ro_empleado_x_turno_Data();
        public bool Guardar_DB(ro_empleado_x_turno_Info info)
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

        public bool Modificar_DB(List<ro_empleado_x_turno_Info> lista)
        {
            try
            {
                return data.Modificar_DB(lista);
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

        public bool Anular_DB(List<ro_empleado_x_turno_Info> lista)
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

        public List<ro_empleado_x_turno_Info> listado_Grupos(int IdEmpresa, int IdNomina_Tipo, int IdPeriodo)
        {
            try
            {
                return data.listado_Grupos(IdEmpresa, IdNomina_Tipo, IdPeriodo); 
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

        public List<ro_empleado_x_turno_Info> Get_list_empleado_con_jornada_desfasada(int IdEmpresa, int IdNomina_tipo, ro_periodo_Info info_periodo)
        {
            string mensaje = "";
            try
            {
                return data.Get_list_empleado_con_jornada_desfasada(IdEmpresa, IdNomina_tipo, info_periodo);
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
