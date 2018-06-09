using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_planificacion_x_ruta_x_empleado_det_Bus
  {
      string mensaje="";
      ro_planificacion_x_ruta_x_empleado_det_Data data = new ro_planificacion_x_ruta_x_empleado_det_Data();
      public bool Guardar_DB(List<ro_planificacion_x_ruta_x_empleado_det_Info> lista)
      {
          try
          {
              return data.Guardar_DB(lista);
             
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

      public bool Modificar_DB(List<ro_planificacion_x_ruta_x_empleado_det_Info> lista)
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
      public List<ro_planificacion_x_ruta_x_empleado_det_Info> get_lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
      {
          try
          {
              return data.get_lista_planificacion(IdEmpresa, idnomina_tipo, IdPeriodo);

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

      public List<ro_planificacion_x_ruta_x_empleado_det_Info> lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
      {
          try
          {
              return data.lista_planificacion(IdEmpresa, idnomina_tipo, IdPeriodo);

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
