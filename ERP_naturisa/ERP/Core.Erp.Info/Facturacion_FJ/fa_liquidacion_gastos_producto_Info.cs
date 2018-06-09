using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_gastos_producto_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProducto_Liqui { get; set; }
        public string nom_producto_Liqui { get; set; }
        public string estado { get; set; }
        public Decimal IdProducto { get; set; }
    }
}
