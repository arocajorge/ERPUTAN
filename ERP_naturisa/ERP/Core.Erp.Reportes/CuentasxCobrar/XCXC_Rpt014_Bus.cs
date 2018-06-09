using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt014_Bus
    {
        XCXC_Rpt014_Data Odata = new XCXC_Rpt014_Data();

        public List<XCXC_Rpt014_Info> Get_Data_Reporte(int IdEmpresa, int IdVendedor, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Odata.Get_Data_Reporte(IdEmpresa, IdVendedor, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                return new List<XCXC_Rpt014_Info>();
            }
        }
    }
}
