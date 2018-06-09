using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt023_Bus
    {

       XROL_Rpt023_Data data = new XROL_Rpt023_Data();
       public List<XROL_Rpt023_Info> Get_List(int idEmpresa, int IdEmpleado, int IdNovedad)
       {
           try
           {
               return data.Get_List(idEmpresa, IdEmpleado, IdNovedad);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Prestamos_Empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

           }
       }
    }
}
