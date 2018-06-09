using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt024_Bus
    {
        XCXP_Rpt024_Data oData = new XCXP_Rpt024_Data();

        public List<XCXP_Rpt024_Info> Get_Lista_Sub_Reporte(int idEmpresa,int IdTipoCbte, decimal idOrdenGiro)
        {
            try
            {
                return oData.Get_Lista_Sub_Reporte(idEmpresa,IdTipoCbte, idOrdenGiro);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
