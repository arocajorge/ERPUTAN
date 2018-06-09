using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt012_Bus
    {
        XCXC_Rpt012_Data oData = new XCXC_Rpt012_Data();

        public List<XCXC_Rpt012_Info> get_DetalleDiasxVencer(int IdEmpresa, decimal IdCliente, DateTime FechaCorte)
        {
            try
            {
                return oData.get_DetalleDiasxVencer(IdEmpresa, IdCliente, FechaCorte);
            }
            catch (Exception ex)
            {
                return new List<XCXC_Rpt012_Info>();
            }
        }
    }
}
