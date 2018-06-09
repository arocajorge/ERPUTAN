using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt007_Bus
    {
        XFAC_Rpt007_Data dataRpt = new XFAC_Rpt007_Data();

        public List<XFAC_Rpt007_Info> get_SoporteFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return dataRpt.get_SoporteFactura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt007_Info>();
            }
        }

        public XFAC_Rpt007_Bus()
        {

        }
    }
}
