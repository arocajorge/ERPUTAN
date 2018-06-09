using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
    public class XFAC_CUS_TAL_Rpt004_bus
    {
        XFAC_CUS_TAL_Rpt004_Data Odata = new XFAC_CUS_TAL_Rpt004_Data();

        public List<XFAC_CUS_TAL_Rpt004_info> Obtener_data(int idempresa, int idsucursal, int idbodega, decimal IdCbte_vta,
            ref string mensaje)
        {
            try
            {
                return Odata.Obtener_data(idempresa, idsucursal, idbodega, IdCbte_vta, ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XFAC_CUS_TAL_Rpt004_info>();
            }
        }
       
       public XFAC_CUS_TAL_Rpt004_bus()
    {

       }
    }
}
     