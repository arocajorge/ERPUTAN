using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt005_Bus
    {
        XCXP_NATU_Rpt005_Data retdata = new XCXP_NATU_Rpt005_Data();
        public List<XCXP_NATU_Rpt005_Info> consultar_data(int IdEmpresa_Ogiro, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, ref string mensaje)
        {
            try
            {
                return retdata.consultar_data(IdEmpresa_Ogiro, IdTipoCbte_Ogiro, IdCbteCble_Ogiro, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_NATU_Rpt005_Info>();
            }
        }
        public XCXP_NATU_Rpt005_Bus()
        {
        }
    }
}
