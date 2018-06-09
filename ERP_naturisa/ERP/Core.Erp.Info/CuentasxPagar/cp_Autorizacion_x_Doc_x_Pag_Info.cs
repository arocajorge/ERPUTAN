using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
  public  class cp_Autorizacion_x_Doc_x_Pag_Info
    {

        public string Id_Num_Autorizacion { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public DateTime Valido_Hasta { get; set; }
        public string factura_inicial { get; set; }
        public string factura_final { get; set; }
        public string NumAutorizacionImprenta { get; set; }

       public cp_Autorizacion_x_Doc_x_Pag_Info(){}
    }
}
