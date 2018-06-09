using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt008_Bus
    {
        XCXC_Rpt008_Data datRpt = new XCXC_Rpt008_Data();

        public List<XCXC_Rpt008_Info> get_ReporteCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte)
        {
            try
            {
               return  datRpt.get_ReporteCarteraVencida(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt008_Info>();
            }
        }



        public XCXC_Rpt008_Bus()
        {

        }
    }
}
