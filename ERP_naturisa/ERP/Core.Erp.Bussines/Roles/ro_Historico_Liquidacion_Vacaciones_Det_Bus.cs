using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles;

namespace Core.Erp.Business.Roles
{
  public  class ro_Historico_Liquidacion_Vacaciones_Det_Bus

  {
      ro_Historico_Liquidacion_Vacaciones_Det_Data data = new Data.Roles.ro_Historico_Liquidacion_Vacaciones_Det_Data();
      public bool Guardar_DB(ro_Historico_Liquidacion_Vacaciones_Det_Info info)
      {
          try
          {
              return data.Guardar_DB(info);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
     
          }
      }

      public bool Eliminar(ro_Historico_Liquidacion_Vacaciones_Det_Info info)
      {
          string mensaje = "";
          try
          {
              return data.Eliminar(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };
     
          }
      }
      public List<ro_Historico_Liquidacion_Vacaciones_Det_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
      {
          try
          {
              return data.Get_Lis(IdEmpresa,idempleado,idsolicitud);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };

          }
      }
    }
}
