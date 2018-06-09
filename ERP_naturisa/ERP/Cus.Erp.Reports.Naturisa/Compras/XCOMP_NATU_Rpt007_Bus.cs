using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt007_Bus
    {
        XCOMP_NATU_Rpt007_Data OCdata = new XCOMP_NATU_Rpt007_Data();

        public List<XCOMP_NATU_Rpt007_Info> consultar_data(int idempresa, int idsucursal, decimal IdOrdenCompra, ref string mensaje)
        {
            try
            {
                return OCdata.consultar_data(idempresa, idsucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_NATU_Rpt007_Info>();
            }
        }

        public XCOMP_NATU_Rpt007_Bus()
        {

        }
    }
}
