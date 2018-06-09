using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlATS
{
   public class detalleVentas
    {

       public string tpIdCliente { get; set; }
       public string idCliente { get; set; }
       public string tipoComprobante { get; set; }
       public Int32 numeroComprobantes { get; set; }
       public string baseNoGraIva { get; set; }
       public string baseImponible { get; set; }
       public string baseImpGrav { get; set; }
       public string montoIva { get; set; }
       public string valorRetIva { get; set; }
       public string valorRetRenta { get; set; }
    
       public detalleVentas(){}
    }
}
