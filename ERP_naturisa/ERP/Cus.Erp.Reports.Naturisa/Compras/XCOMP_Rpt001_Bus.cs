using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt001_Bus
    {
        XCOMP_Rpt001_Data OCdata = new XCOMP_Rpt001_Data();

        

        public List<XCOMP_Rpt001_Info> consultar_data(int idempresa, int idsucursal, decimal IdOrdenCompra,
          ref string mensaje)
        {
            try
            {
                return OCdata.consultar_data(idempresa, idsucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_Rpt001_Info>();
            }
        }

             public XCOMP_Rpt001_Bus()

        {

        }
    }
}
