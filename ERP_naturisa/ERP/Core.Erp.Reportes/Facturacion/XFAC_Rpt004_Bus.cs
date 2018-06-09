using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt004_Bus
    {
        XFAC_Rpt004_Data dataRpt = new XFAC_Rpt004_Data();

        public List<XFAC_Rpt004_Info> getDatosRpt_NDC_NDB(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago, string IdTipoDoc, List<int> IdTipoNota, string TipoNota)
        {
            try
            {
                return dataRpt.getDatosRpt_NDC_NDB(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaHasta, TipoPago, IdTipoDoc, IdTipoNota, TipoNota);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt004_Info>();
            }
        }

    }
}
