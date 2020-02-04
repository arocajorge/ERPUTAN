using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
   public class XFAC_GRAF_Rpt002_Bus
    {
       XFAC_GRAF_Rpt002_Data Odata = new XFAC_GRAF_Rpt002_Data();


       public List<XFAC_GRAF_Rpt002_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
       {
           try
           {
               return Odata.Get_List_Data(IdEmpresa, FechaIni, FechaFin, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Lista_Guias", ex.Message), ex) { EntityType = typeof(XFAC_GRAF_Rpt002_Bus) };
           }
       }

    }
}
