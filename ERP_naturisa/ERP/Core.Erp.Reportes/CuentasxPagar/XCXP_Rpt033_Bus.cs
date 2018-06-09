using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt033_Bus
    {
        XCXP_Rpt033_Data oData = new XCXP_Rpt033_Data();
        public List<XCXP_Rpt033_Info> Get_List_Data(int IdEmpresa, decimal IdConciliacion_Caja, ref string mensaje)
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
