using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cus.Erp.Reports.Talme.Facturacion;


namespace Cus.Erp.Reports.Talme.Facturacion
{
    public class XFAC_CUS_TAL_Rpt002_bus
    {
    XFAC_CUS_TAL_Rpt002_Data Odata = new XFAC_CUS_TAL_Rpt002_Data();


       public List<XFAC_CUS_TAL_Rpt002_Info> Obtener_data(int idempresa, int idsucursal, int idbodega, decimal idordendespacho,
          ref string mensaje)
       {
           try
           {
              return  Odata.Obtener_data(idempresa, idsucursal, idbodega, idordendespacho,ref mensaje);

           }
           catch (Exception ex)
           {
               return new List<XFAC_CUS_TAL_Rpt002_Info>();
           } 
       }
         
       public XFAC_CUS_TAL_Rpt002_bus()

       {

       }
    }
}