using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt007_Bus
    {
        XCXP_Rpt007_Data NBPROVEE = new XCXP_Rpt007_Data();
        public List<XCXP_Rpt007_Info> consultar_data(int IdEmpresa,int IdTipoCbte , decimal IdCbteCble_Nota,  ref string mensaje)
         {
             try 
	{
        return NBPROVEE.consultar_data(IdEmpresa, IdTipoCbte,IdCbteCble_Nota, ref mensaje);
	}
	catch (Exception ex)
	{
        
		
		 return new List<XCXP_Rpt007_Info>();
         }
        }
        public XCXP_Rpt007_Bus()
        {
	    }

    }
}
