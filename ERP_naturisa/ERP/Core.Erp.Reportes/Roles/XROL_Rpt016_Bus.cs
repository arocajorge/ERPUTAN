using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt016_Bus
    {
      XROL_Rpt016_Data data = new XROL_Rpt016_Data();
      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina, int idDepartamento,int idrubro, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_Valor_Acumulado_x_empleado(idEmpresa, idNomina, idDepartamento,idrubro, fi, ff);
          }
          catch (Exception ex)
          {
              
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Valor_Acumulado_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }


      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina, int iddepartamento, int IdEmpleado,int idRubro, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_Valor_Acumulado_x_empleado(idEmpresa, idNomina, iddepartamento, IdEmpleado,idRubro, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Valor_Acumulado_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }



      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina, int iddepartamento, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_Valor_Acumulado_x_empleado(idEmpresa, idNomina, iddepartamento, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Valor_Acumulado_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }


      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina, int IdDepartamento, decimal IdEmpleado, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_Valor_Acumulado_x_empleado(idEmpresa, idNomina, IdDepartamento, IdEmpleado, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Valor_Acumulado_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }



    }
}
