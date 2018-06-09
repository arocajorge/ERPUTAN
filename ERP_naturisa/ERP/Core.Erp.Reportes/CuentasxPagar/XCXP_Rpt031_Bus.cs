using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt031_Bus
    {
        XCXP_Rpt031_Data oData = new XCXP_Rpt031_Data();
        public List<XCXP_Rpt031_Info> Get_List_Data(int IdEmpresa, decimal IdConciliacion_Caja, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Data(IdEmpresa, IdConciliacion_Caja, ref mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
