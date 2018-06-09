using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_TerminoPago_Distribucion_Info
    {
        public string IdTipoFormaPago { get; set; }
        public int Secuencia { get; set; }
        public int Num_Dias_Vcto { get; set; }
        public double Por_distribucion{get; set;}

        public fa_factura_TerminoPago_Distribucion_Info() { }
       
    }
}
