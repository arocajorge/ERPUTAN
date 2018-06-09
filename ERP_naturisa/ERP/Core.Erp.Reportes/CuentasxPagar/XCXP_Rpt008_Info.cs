using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public string co_factura { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public int IdClaseProveedor { get; set; }
        public string cod_clase_proveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public double valor_fa { get; set; }
        public double valor_nc { get; set; }
        public double valor_ba { get; set; }
        public Nullable<double> valor_ret { get; set; }
        public Nullable<double> Total { get; set; }
        public string Estado { get; set; }
        public string Documento { get; set; }
    }
}
