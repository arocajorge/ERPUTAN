using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt004_Bus
    {
        XCXP_Rpt004_Data FactProvRet = new XCXP_Rpt004_Data();

        public List<XCXP_Rpt004_Info> consultar_data(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble_Ogiro, ref String mensaje)
        {
            try 
	{
        return FactProvRet.consultar_data(IdEmpresa, IdTipoCbte_OG, IdCbteCble_Ogiro, ref mensaje);
	}
	catch (Exception ex)
	{
		return new List<XCXP_Rpt004_Info>();
           }
        }
        public XCXP_Rpt004_Bus() 
        {
        }
	}
  }

