using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt023_Bus
    {
        XCXP_Rpt023_Data oData = new XCXP_Rpt023_Data();

        public List<XCXP_Rpt023_Info> Get_Lista_Comprobante_Retencion(int idEmpresa, decimal IdCbteCble_Ogiro)
        {
            try
            {
                return oData.Get_Lista_Comprobante_Retencion(idEmpresa, IdCbteCble_Ogiro);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
