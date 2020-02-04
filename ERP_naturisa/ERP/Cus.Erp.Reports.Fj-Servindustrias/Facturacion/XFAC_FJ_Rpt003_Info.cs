using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidaciones { get; set; }
        public int IdPeriodo { get; set; }
        public string Observacion { get; set; }
        public string Observacion_x_liqui { get; set; }
        public string detalle_x_producto { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
        public double valor_iva { get; set; }
        public double Total_liq { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
    }
}
