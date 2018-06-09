using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt018_Bus
    {
       XROL_Rpt018_Data data = new XROL_Rpt018_Data();
       public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int idDepartamento, int idrubro, DateTime fi, DateTime ff)
       {
           try
           {
               return data.Get_Ingreso_Egreso_Empleado(idEmpresa, idNomina, idDepartamento, idrubro, fi, ff);
           }
           catch (Exception ex)
           {
               
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Ingreso_Egreso_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

           }

       }


       public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdDepartamento, int IdEmpleado, int idRubro, DateTime fi, DateTime ff)
       {
           try
           {
               return data.Get_Ingreso_Egreso_Empleado(idEmpresa, idNomina, IdDepartamento,IdEmpleado, idRubro, fi, ff);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Ingreso_Egreso_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

           }

       }



       public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdDepartamento, decimal IdEmpleado, DateTime fi, DateTime ff)
       {
           try
           {
               return data.Get_Ingreso_Egreso_Empleado(idEmpresa, idNomina, IdDepartamento, IdEmpleado, fi, ff);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Ingreso_Egreso_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

           }
       }

       public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdRubro, DateTime fi, DateTime ff)
       {
           try
           {
               return data.Get_Ingreso_Egreso_Empleado(idEmpresa, idNomina, IdRubro, fi, ff);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Ingreso_Egreso_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

           }
       }


    }
}
