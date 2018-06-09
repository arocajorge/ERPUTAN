using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_producto_x_cp_proveedor_Info
    {
        public int IdEmpresa_prod { get; set; }
        public decimal IdProducto { get; set; }
        public int IdEmpresa_prov { get; set; }
        public decimal IdProveedor { get; set; }
        public string NomProducto_en_Proveedor { get; set; }

        public in_producto_x_cp_proveedor_Info() { }
    }
}
