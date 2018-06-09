using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt011_Bus
    {
        XFAC_Rpt011_Data dataRpt = new XFAC_Rpt011_Data();

        public List<XFAC_Rpt011_Info> get_ImpresionDevolucion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdDevolucion)
        {
            try
            {
                return dataRpt.get_ImpresionDevolucion(IdEmpresa, IdSucursal, IdBodega, IdDevolucion);
            }
            catch (Exception)
            {
                return new List<XFAC_Rpt011_Info>();
            }
        }


        public XFAC_Rpt011_Bus()
        {

        }
    }
}
