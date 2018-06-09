using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Business.Roles;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_empleado_x_Activo_Fijo_Bus
  {
      string mensaje="";
      ro_empleado_x_Activo_Fijo_Data data=new ro_empleado_x_Activo_Fijo_Data();
      ro_empleado_x_centro_costo_Bus bus_centro_costo_empleado = new ro_empleado_x_centro_costo_Bus();
      public bool Guardar_DB(ro_empleado_x_Activo_Fijo_Info info)
      {
          try
          {
              bool bandera = true;

              bandera=  data.Guardar_DB(info);
              if (bandera)
              {
                 bandera= bus_centro_costo_empleado.GrabarBD(info.Info_Centro_costo_x_empleado);
              }

              return bandera;
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

      public List<ro_empleado_x_Activo_Fijo_Info> listado_Grupos(int IdEmpresa, int IdEmpleado)
      {
          try
          {
              return data.listado_Grupos(IdEmpresa, IdEmpleado);
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

      public bool Eliminar(int IdEmpresa, int IdActivo_fijo)
      {
          try
          {
              return data.Eliminar(IdEmpresa, IdActivo_fijo);
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
      public ro_empleado_x_Activo_Fijo_Info Get_Info(int IdEmpresa, int IdActivo_fijo)
      {
          try
          {
              return data.Get_Info(IdEmpresa, IdActivo_fijo);
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
