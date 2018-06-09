using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Roles_Fj;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_empleado_x_Activo_Fijo_Historico_Bus
  {
      string mensaje = "";
      ro_empleado_x_Activo_Fijo_Historico_Data data = new ro_empleado_x_Activo_Fijo_Historico_Data();
      public bool Guardar_DB(ro_empleado_x_Activo_Fijo_Historico_Info info)
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

      public List<ro_empleado_x_Activo_Fijo_Historico_Info> listado_Grupos(int IdEmpresa, int IdActivo_fijo)
      {
          try
          {
              return data.listado_Grupos(IdEmpresa, IdActivo_fijo);
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
