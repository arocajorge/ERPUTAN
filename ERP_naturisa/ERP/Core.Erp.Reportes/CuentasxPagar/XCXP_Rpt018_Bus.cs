using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt018_Bus
    {
        XCXP_Rpt018_Data NBPROVEE = new XCXP_Rpt018_Data();
        public List<XCXP_Rpt018_Info> consultar_data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return NBPROVEE.consultar_data(IdEmpresa, ProveedorIni, ProveedorFin, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {


                return new List<XCXP_Rpt018_Info>();
            }
        }
    }
}
