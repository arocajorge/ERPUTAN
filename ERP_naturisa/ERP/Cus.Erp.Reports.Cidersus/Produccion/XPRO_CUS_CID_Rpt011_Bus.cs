using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class XPRO_CUS_CID_Rpt011_Bus
    {
        XPRO_CUS_CID_Rpt001_Data data = new XPRO_CUS_CID_Rpt001_Data();
        public List<XPRO_CUS_CID_Rpt001_Info> Get_Codigo_Barra(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, int IdNumMovi)
        {
            try
            {

                return data.Get_Codigo_Barra(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception)
            {

                return new List<XPRO_CUS_CID_Rpt001_Info>();
            }
        }
    }
}
