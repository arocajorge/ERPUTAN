using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt002_Bus
    {

       XPRO_CUS_CID_Rpt002_Data data = new XPRO_CUS_CID_Rpt002_Data();
       public List<XPRO_CUS_CID_Rpt002_Info> OptenerData_spPRD_Rpt_RPRD002(int IdEmpresa, int idOrdenCompra)
       {
           try
           {

               return data.OptenerData_spPRD_Rpt_RPRD002(IdEmpresa, idOrdenCompra);
           }
           catch (Exception)
           {

               return new List<XPRO_CUS_CID_Rpt002_Info>();
           }
       }
    }
}
