using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt012_Bus
    {
        XCXP_Rpt012_Data NBPROVEE = new XCXP_Rpt012_Data();
        public List<XCXP_Rpt012_Info> consultar_data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return NBPROVEE.consultar_data(IdEmpresa, ProveedorIni, ProveedorFin, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {


                return new List<XCXP_Rpt012_Info>();
            }
        }
    }
}
