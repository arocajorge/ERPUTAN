using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
  public   class XFAC_CUS_TAL_Rpt003_Bus
    {




      public XFAC_CUS_TAL_Rpt003_Bus()
      {

      }





      public List<XFAC_CUS_TAL_Rpt003_Info> obtener_list_data(int idempresa,int idsucursal,int idbodega ,decimal idGuiaRemision,ref string mensaje)
      {

          try
          {


              XFAC_CUS_TAL_Rpt003_Data Odata = new XFAC_CUS_TAL_Rpt003_Data();

              return Odata.obtener_list_data(idempresa, idsucursal, idbodega, idGuiaRemision, ref mensaje);

          }
          catch (Exception ex)
          {

              return new List<XFAC_CUS_TAL_Rpt003_Info>();
          }
      }


    }
}
