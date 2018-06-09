using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt014_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<double> Valor_a_pagar { get; set; }
        public Nullable<double> MontoAplicado { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string Tipo_cbte { get; set; }
        public Nullable<double> Ven_1_30 { get; set; }
        public Nullable<double> Ven_31_60 { get; set; }
        public Nullable<double> Ven_61_180 { get; set; }
        public Nullable<double> Ven_180_9999 { get; set; }
        public Nullable<double> x_Ven_1_30 { get; set; }
        public Nullable<double> x_Ven_31_60 { get; set; }
        public Nullable<double> x_Ven_61_180 { get; set; }
        public Nullable<double> x_Ven_180_9999 { get; set; }
    }
}
