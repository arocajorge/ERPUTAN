using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_Vendedor_Tabla_Info
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public int IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; } 
        public double Ve_Comision { get; set; }
        public bool Ve_Estado { get; set; }

        public fa_Vendedor_Tabla_Info() { }
    }
}
