using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt022_Bus
    {
      XROL_Rpt022_Data data = new XROL_Rpt022_Data();
      public List<XROL_Rpt022_Info> Get_List_Prestamos_Empleado(int idEmpresa, int idNomina, int idDepartamento, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_List_Prestamos_Empleado(idEmpresa, idNomina, idDepartamento, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Prestamos_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }


      public List<XROL_Rpt022_Info> Get_List_Prestamos_Empleado(int idEmpresa, int idNomina, int IdDepartamento, int IdEmpleado, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_List_Prestamos_Empleado(idEmpresa, idNomina, IdDepartamento, IdEmpleado, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Prestamos_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }



      public List<XROL_Rpt022_Info> Get_List_Prestamos_Empleado(int idEmpresa, int idNomina, DateTime fi, DateTime ff)
      {
          try
          {
              return data.Get_List_Prestamos_Empleado(idEmpresa, idNomina, fi, ff);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Prestamos_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }


    }
}
