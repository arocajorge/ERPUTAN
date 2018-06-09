using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt013_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public Nullable<System.DateTime> co_fechaOg { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<double> Valor_a_pagar { get; set; }
        public double MontoAplicado { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string Observacion { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string representante_legal { get; set; }
        public string Tipo_cbte { get; set; }
        public Nullable<int> Plazo { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public Nullable<double> Ven_1_30 { get; set; }
        public Nullable<double> Ven_31_60 { get; set; }
        public Nullable<double> Ven_61_180 { get; set; }
        public Nullable<double> Ven_180_9999 { get; set; }
    }
}
