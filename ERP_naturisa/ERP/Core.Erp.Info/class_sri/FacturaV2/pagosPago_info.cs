using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;


namespace Core.Erp.Info.class_sri.FacturaV2
{
   public class pagosPago_info
    {
       public pagosPago formaPago { get; set; }
       public fa_formaPago_Info Tipo_Forma_Pago { get; set; }

       public pagosPago_info()
       {
           formaPago = new pagosPago();
           Tipo_Forma_Pago = new fa_formaPago_Info();
       }
    }
}
