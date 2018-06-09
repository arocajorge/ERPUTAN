using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt005_Bus
    {
        XFAC_Rpt005_Data dataRpt = new XFAC_Rpt005_Data();

        public List<XFAC_Rpt005_Info> getDatosRpt_NDC_NDB_Producto(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, string TipoPago, string IdTipoDoc, int IdTipoNotaIni, int IdTipoNotaFin)
        {
            try
            {
                return dataRpt.getDatosRpt_NDC_NDB_Producto(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaHasta, TipoPago, IdTipoDoc,  IdTipoNotaIni,  IdTipoNotaFin);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt005_Info>();
            }
        }

    }
}
