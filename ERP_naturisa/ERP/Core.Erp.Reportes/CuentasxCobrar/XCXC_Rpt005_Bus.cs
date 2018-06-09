using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt005_Bus
    {
        XCXC_Rpt005_Data dataRpt = new XCXC_Rpt005_Data();

        public List<XCXC_Rpt005_Info> get_ImpresionCobro_x_Venta(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string IdTipoDoc)
        {
            try
            {
                return dataRpt.get_ImpresionCobro_x_Venta(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, IdTipoDoc);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt005_Info>();
            }
        }

        public XCXC_Rpt005_Bus()
        {

        }
    }
}
