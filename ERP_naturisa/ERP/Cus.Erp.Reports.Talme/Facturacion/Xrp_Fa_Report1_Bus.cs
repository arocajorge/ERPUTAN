using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Talme.Facturacion
{
  public   class Xrp_Fa_Report1_Bus
    {
      Xrp_Fa_Report1_Data DataReport = new Xrp_Fa_Report1_Data();

      public List<Xrp_Fa_Report1_Info> Obtener_data(ref string mensaje)
      {
          try
          {
              return DataReport.Obtener_data(ref mensaje);

          }
          catch (Exception ex)
          {
              return new List<Xrp_Fa_Report1_Info>();
              
          }

      }
    }
}
