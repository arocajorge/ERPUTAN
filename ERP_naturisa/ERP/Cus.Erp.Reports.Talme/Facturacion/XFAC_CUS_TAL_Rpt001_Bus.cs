using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cus.Erp.Reports.Talme.Facturacion;


namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class XFAC_CUS_TAL_Rpt001_Bus
    {

       XFAC_CUS_TAL_Rpt001_Data Odata = new XFAC_CUS_TAL_Rpt001_Data();


       public List<XFAC_CUS_TAL_Rpt001_Info> Obtener_data(int idempresa, int idsucursal, int idbodega, decimal idpedido,
          ref string mensaje)
       {
           try
           {
              return  Odata.Obtener_data(idempresa, idsucursal, idbodega, idpedido,ref mensaje);

           }
           catch (Exception ex)
           {
               return new List<XFAC_CUS_TAL_Rpt001_Info>();
              
           }

       }


       public XFAC_CUS_TAL_Rpt001_Bus()
       {

       }
    }
}
