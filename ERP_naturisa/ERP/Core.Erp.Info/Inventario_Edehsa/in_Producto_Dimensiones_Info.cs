using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_Edehsa
{
    public class in_Producto_Dimensiones_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public double longitud { get; set; }
        public double espesor { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public double ceja { get; set; }
        public double diametro { get; set; }
        public bool estado { get; set; }

        public in_Producto_Dimensiones_Info() { }
    }
}
