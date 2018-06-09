using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt002_Bus
    {
        XFAC_Rpt002_Data dataRptVentas = new XFAC_Rpt002_Data();

        public List<XFAC_Rpt002_Info> getDatosReporteVentas(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni , decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago)
        { 
            try
            {
                return dataRptVentas.getDatosReporteVentas(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni , IdClienteFin, FechaIni, FechaHasta, TipoPago);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt002_Info>();
            }
        }

        public XFAC_Rpt002_Bus()
        {

        }

    }
}
