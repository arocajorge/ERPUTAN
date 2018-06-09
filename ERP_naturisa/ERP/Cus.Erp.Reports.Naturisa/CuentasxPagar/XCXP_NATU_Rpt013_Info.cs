using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt013_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public string co_observacion { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string IdCtaCble_CXP_clase { get; set; }
        public string IdCtaCble_CXP_provee { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public Nullable<double> Saldo_inicial { get; set; }
        public Nullable<double> Debe { get; set; }
        public Nullable<double> Haber { get; set; }
        public double dc_Valor { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string referencia { get; set; }
        public int Secuencia_rpt { get; set; }
    }
}
