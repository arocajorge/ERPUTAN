using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_Autorizacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdAutorizacion { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string nAutorizacion { get; set; }
        public DateTime Valido_Hasta { get; set; }

        public string factura_inicial { get; set; }
        public string factura_final { get; set; }        
        public string Modificado { get; set; }
        public bool Estado { get; set; }
        public cp_proveedor_Autorizacion_Info() { Modificado = "G"; }//los registros con G son los que se van a grabar xprimera vez

        public string NumAutorizacionImprenta { get; set; }
    }
}
