using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt004_Bus
    {
        XINV_NAT_Rpt004_Data Ocdata = new XINV_NAT_Rpt004_Data();

        public List<XINV_NAT_Rpt004_Info> consultar_data(int idempresa, int idsucursal, int IdMovi_inven_tipo, decimal IdNumMovi, int IdBodega, ref String mensaje)
        {
            try
            {
                return Ocdata.consultar_data(idempresa, idsucursal, IdMovi_inven_tipo, IdNumMovi, IdBodega, ref mensaje);

            }
            catch (Exception)
            {
                return new List<XINV_NAT_Rpt004_Info>();
            }
        }
    }
}
