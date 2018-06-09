using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt029_Bus
    {
        XCXP_Rpt029_Data oData = new XCXP_Rpt029_Data();

        public List<XCXP_Rpt029_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Data(IdEmpresa, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
