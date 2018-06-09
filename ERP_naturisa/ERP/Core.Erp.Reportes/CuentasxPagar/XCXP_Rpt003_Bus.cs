using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt003_Bus
    {
        XCXP_Rpt003_Data FactProveedata = new XCXP_Rpt003_Data();


        public List<XCXP_Rpt003_Info> consultar_data(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble_Ogiro, ref String mensaje)  
        {
            try 
	     {
             return FactProveedata.consultar_data(IdEmpresa, IdTipoCbte, IdCbteCble_Ogiro, ref mensaje);

	     }
	catch (Exception ex )
	     {
	    return new List<XCXP_Rpt003_Info>();
	   }
      }
        public XCXP_Rpt003_Bus()
        {
        }
    }
}