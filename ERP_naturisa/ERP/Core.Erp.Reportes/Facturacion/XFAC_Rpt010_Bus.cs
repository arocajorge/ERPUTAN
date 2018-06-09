using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt010_Bus
    {
        XFAC_Rpt010_Data dataRpt = new XFAC_Rpt010_Data();

        public List<XFAC_Rpt010_Info> get_Impresion_NC_ND(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return dataRpt.get_Impresion_NC_ND(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception)
            {
                return new List<XFAC_Rpt010_Info>();
            }
        }

        public XFAC_Rpt010_Bus()
        {

        }
    }
}
