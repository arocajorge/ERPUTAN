using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt008_Bus
    {
        XFAC_Rpt008_Data dataRpt = new XFAC_Rpt008_Data();

        public List<XFAC_Rpt008_Info> get_ImpresionFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return dataRpt.get_ImpresionFactura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt008_Info>();
            }
        }

        public XFAC_Rpt008_Bus()
        {

        }

    }
}
