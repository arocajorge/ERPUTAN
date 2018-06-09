using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt021_Bus
    {
        XCXP_Rpt021_Data oData = new XCXP_Rpt021_Data();

        public List<XCXP_Rpt021_Info> Get_Lista_Orden_Giro(int idEmpresa, decimal idOrdenGiro, int idProveedor)
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
