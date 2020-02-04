using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt008_Bus
    {
        XCOMP_NATU_Rpt008_Data odata = new XCOMP_NATU_Rpt008_Data();
        public List<XCOMP_NATU_Rpt008_Info> GetList(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdOrdenPedido);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
