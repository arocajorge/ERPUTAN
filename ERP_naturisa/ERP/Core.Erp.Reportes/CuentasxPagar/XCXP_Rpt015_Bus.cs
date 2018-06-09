using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt015_Bus
    {

      XCXP_Rpt015_Data odata = new XCXP_Rpt015_Data();
      
      public List<XCXP_Rpt015_Info> consultar_data(int IdEmpresa_Ogiro, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, ref string mensaje)
      {
          try
          {
              return odata.consultar_data(IdEmpresa_Ogiro,  IdTipoCbte_Ogiro,  IdCbteCble_Ogiro, ref  mensaje);
          }
          catch (Exception ex)
          {
              return new List<XCXP_Rpt015_Info>();
              
          }
      
      
      }
      
  
    }
}
