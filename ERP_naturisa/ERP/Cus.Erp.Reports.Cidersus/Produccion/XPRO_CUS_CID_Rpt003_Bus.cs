using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt003_Bus
    {
       XPRO_CUS_CID_Rpt003_Data data = new XPRO_CUS_CID_Rpt003_Data();
       public List<XPRO_CUS_CID_Rpt003_Info> Get_cotizacion(int IdEmpresa, int IdCotizacion, int IdSucursal)
       {
           return data.Get_cotizacion(IdEmpresa, IdCotizacion, IdSucursal);
       }
    }
}
