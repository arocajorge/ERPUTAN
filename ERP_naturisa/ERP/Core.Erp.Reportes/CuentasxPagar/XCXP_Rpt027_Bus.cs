using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    
   public class XCXP_Rpt027_Bus
   {
       XCXP_Rpt027_Data data = new XCXP_Rpt027_Data();


       public List<XCXP_Rpt027_Info> Get_Lista_Sub_Reporte(int idEmpresa, decimal idOrdenGiro,ref string mensaje)
       {
           try
           {
               return data.consultar_data(idEmpresa, idOrdenGiro,ref mensaje);
           }
           catch (Exception)
           {

               return new List<XCXP_Rpt027_Info>();
           }
       }
    }
}
