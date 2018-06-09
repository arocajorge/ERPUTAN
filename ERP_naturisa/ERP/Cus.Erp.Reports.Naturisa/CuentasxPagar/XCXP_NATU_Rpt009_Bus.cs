using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt009_Bus
    {
        XCXP_NATU_Rpt009_Data oData = new XCXP_NATU_Rpt009_Data();
        public List<XCXP_NATU_Rpt009_Info> Get_Lista_Orden_Giro(int idEmpresa, decimal idOrdenGiro, int idProveedor)
        {
            try
            {
                return oData.Get_Lista_Orden_Giro(idEmpresa, idOrdenGiro, idProveedor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
