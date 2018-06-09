using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt030_Bus
    {
        XCXP_Rpt030_Data oData = new XCXP_Rpt030_Data();
        public List<XCXP_Rpt030_Info> Get_List_Data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,Boolean x_Fecha_Emision, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Data(IdEmpresa, FechaIni, FechaFin, x_Fecha_Emision ,ref mensaje);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
