using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
   public  class XFAC_Rpt013_Bus
    {
       XFAC_Rpt013_Data Odata = new XFAC_Rpt013_Data();


       public List<XFAC_Rpt013_Info> Get_List_Data_Reporte(int IdEmpresa, decimal IdCliente, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
       {
           try
           {

               return Odata.Get_List_Data_Reporte(IdEmpresa, IdCliente, FechaIni, FechaFin, ref MensajeError);
           }
           catch (Exception ex)
           {

               return new List<XFAC_Rpt013_Info>();
           }
       }
    }
}
