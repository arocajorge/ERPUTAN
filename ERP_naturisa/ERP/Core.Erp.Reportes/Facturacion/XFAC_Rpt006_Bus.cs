using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt006_Bus
    {
        XFAC_Rpt006_Data dataRpt = new XFAC_Rpt006_Data();

        public List<XFAC_Rpt006_Info> getDevolucionVentas(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta)
        {
            try
            {
                return dataRpt.getDevolucionVentas(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaHasta);
            }
            catch (Exception)
            {
                return new List<XFAC_Rpt006_Info>();
            }
        }

        public XFAC_Rpt006_Bus()
        {
        }
    }
}
