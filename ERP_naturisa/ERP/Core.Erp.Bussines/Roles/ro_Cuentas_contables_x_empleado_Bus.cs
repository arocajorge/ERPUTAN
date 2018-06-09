using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles
{
  public  class ro_Cuentas_contables_x_empleado_Bus
  {
      ro_Cuentas_contables_x_empleado_Data data = new ro_Cuentas_contables_x_empleado_Data();
      public List<ro_Cuentas_contables_x_empleado_Info> Get_List_Cuentas_contables_x_empleados(int IdEmpresa,decimal IdEmpleado)
      {
          try
          {
              return data.Get_List_Cuentas_contables_x_empleados(IdEmpresa, IdEmpleado);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cuentas_contables_x_empleados", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

          }
      }
      public List<ro_Cuentas_contables_x_empleado_Info> Get_List_Cuentas_contables_x_empleados(int IdEmpresa)
      {
          try
          {
              return data.Get_List_Cuentas_contables_x_empleados(IdEmpresa);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cuentas_contables_x_empleados", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

          }
      }

      public bool GuardarDB(List<ro_Cuentas_contables_x_empleado_Info> lista)
      {
          try
          {
              return data.GuardarDB(lista);
             
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

          }
      }



      public bool EliminarDB(int IdEmpresa, decimal IdEmpleado)
      {
          try
          {
              return data.EliminarDB(IdEmpresa, IdEmpleado);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

          }
      }

    }
}
