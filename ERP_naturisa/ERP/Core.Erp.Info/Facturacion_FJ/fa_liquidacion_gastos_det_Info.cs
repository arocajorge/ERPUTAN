using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_gastos_det_Info
    {
        public int IdEmpresa { get; set; }
        public Decimal IdLiquidacion { get; set; }
        public int secuencia { get; set; }
        public int IdProducto_Liqui { get; set; }
        public string detalle_x_producto { get; set; }
        public Double cantidad { get; set; }
        public Double precio { get; set; }
        public Double subtotal { get; set; }
        public Boolean aplica_iva { get; set; }
        public Double por_iva { get; set; }
        public Double valor_iva { get; set; }
        public Double Total_liq { get; set; }
       
        public decimal IdProducto { get; set; }
        public string nom_producto_Liqui { get; set; }

    }
}
