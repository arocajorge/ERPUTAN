using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public Decimal IdLiquidacion { get; set; }
        public int IdPeriodo { get; set; }
        public string cod_liquidacion { get; set; }
        public Decimal IdCliente { get; set; }
        public DateTime fecha_liqui { get; set; }
        public string Observacion { get; set; }
        public string estado { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
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
        public string nom_producto_Liqui { get; set; }
    }
}
