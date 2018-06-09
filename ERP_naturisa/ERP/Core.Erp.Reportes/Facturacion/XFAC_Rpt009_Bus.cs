using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt009_Bus
    {
        XFAC_Rpt009_Data dataRpt = new XFAC_Rpt009_Data();

        public List<XFAC_Rpt009_Info> get_Soporte_NC_ND(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return dataRpt.get_Soporte_NC_ND(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception)
            {
                return new List<XFAC_Rpt009_Info>();
            }
        }


        public XFAC_Rpt009_Bus()
        {

        }
    }
}
