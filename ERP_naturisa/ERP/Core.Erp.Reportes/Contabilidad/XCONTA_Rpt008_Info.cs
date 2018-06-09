using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public int Secuencia_op { get; set; }
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public int secuencia_cxp { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public string pc_clave_corta { get; set; }
        public string dc_Observacion { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public double dc_Valor { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
    }
}
