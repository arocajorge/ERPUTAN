using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_codigo_SRI_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string Modificado { get; set; }
        public string observacion { get; set; }

        public cp_proveedor_codigo_SRI_Info() {
            Modificado = "G";//los registros con G son los que se van a grabar xprimera vez
        }
    }
}
