using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt003_Bus
    {

        XFAC_Rpt003_Data dataRptVenta = new XFAC_Rpt003_Data();

        public List<XFAC_Rpt003_Info> getDatosRptVentasProduc(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago)
        {
            try
            {
                return dataRptVenta.getDatosRptVentasProduc(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni , IdClienteFin, FechaIni, FechaHasta, TipoPago);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt003_Info>();
            }
        }

        public XFAC_Rpt003_Bus()
        {

        }

    }
}
