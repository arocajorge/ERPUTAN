using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<double> vt_por_iva { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<double> dc_ValorPago { get; set; }
        public Nullable<double> Saldo { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public string Ve_Vendedor { get; set; }
        public int IdVendedor { get; set; }
        public string CodCbteVta { get; set; }
        public Nullable<int> Dias_vcdos { get; set; }
        public string pe_telefonoOfic { get; set; }
    }
}
