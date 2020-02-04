using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt002_Bus
    {
        XINV_NAT_Rpt002_Data Data = new XINV_NAT_Rpt002_Data();
        public List<XINV_NAT_Rpt002_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi,  ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_NAT_Rpt002_Info>();
            }
        }

        public XINV_NAT_Rpt002_Bus()
        {

        }
    }
}
