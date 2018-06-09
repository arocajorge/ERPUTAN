using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt017_Bus
    {

       XROL_Rpt017_Data data = new XROL_Rpt017_Data();



       public List<XROL_Rpt017_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina,string CodCtbteCble, DateTime fi, DateTime ff)
       {
          try
          {
              return data.Get_Valor_Acumulado_x_empleado(idEmpresa, idNomina,CodCtbteCble, fi, ff);
          }
          catch (Exception ex)
          {
              
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Valor_Acumulado_x_empleado", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }

    }
}
