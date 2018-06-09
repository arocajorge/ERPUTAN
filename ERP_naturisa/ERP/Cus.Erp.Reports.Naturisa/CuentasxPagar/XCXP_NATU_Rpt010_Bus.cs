using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    class XCXP_NATU_Rpt010_Bus
    {
        XCXP_NATU_Rpt010_Data NCPROVEE = new XCXP_NATU_Rpt010_Data();
        public List<XCXP_NATU_Rpt010_Info> consultar_data(int IdEmpresa, decimal IdCbteCble_Nota, ref string mensaje)
        {
            try
            {
                return NCPROVEE.consultar_data(IdEmpresa, IdCbteCble_Nota, ref mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
