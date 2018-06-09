using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxCobrar
{
    public class XCXC_NATU_Rpt001_Bus
    {
        XCXC_NATU_Rpt001_Data oData = new XCXC_NATU_Rpt001_Data();

        public List<XCXC_NATU_Rpt001_Info> Get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list(IdEmpresa, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
