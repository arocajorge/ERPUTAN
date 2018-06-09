using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_NumFactura { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Double vt_cantidad { get; set; }
        public double vt_total { get; set; }
        public DateTime vt_fecha { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public int IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
    }
}
