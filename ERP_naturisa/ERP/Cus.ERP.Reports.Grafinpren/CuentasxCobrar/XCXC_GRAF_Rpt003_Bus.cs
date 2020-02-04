using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt003_Bus
    {
        XCXC_GRAF_Rpt003_Data oData = new XCXC_GRAF_Rpt003_Data();

        public List<XCXC_GRAF_Rpt003_Info> Get_list_reporte(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdCliente);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
