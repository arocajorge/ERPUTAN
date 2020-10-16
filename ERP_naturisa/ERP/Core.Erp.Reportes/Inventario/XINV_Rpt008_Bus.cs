using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt008_Bus
    {
        XINV_Rpt008_Data odata = new XINV_Rpt008_Data();

        public List<XINV_Rpt008_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
