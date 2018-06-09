using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt022_Bus
    {
        XCXP_Rpt022_Data oData = new XCXP_Rpt022_Data();

        public List<XCXP_Rpt022_Info> Get_Lista_Nota_Credito(int idEmpresa,int IdTipoCbte_cxp, decimal idCbteCble_cxp)
        {
            try
            {
                return oData.Get_Lista_Nota_Credito(idEmpresa, IdTipoCbte_cxp, idCbteCble_cxp);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
