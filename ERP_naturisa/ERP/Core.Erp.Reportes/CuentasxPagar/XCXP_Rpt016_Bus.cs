using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt016_Bus
    {
       XCXP_Rpt016_Data odata = new XCXP_Rpt016_Data();


       public List<XCXP_Rpt016_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
        {

            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt016_Info>();              
            }
            
        }
    }
}
