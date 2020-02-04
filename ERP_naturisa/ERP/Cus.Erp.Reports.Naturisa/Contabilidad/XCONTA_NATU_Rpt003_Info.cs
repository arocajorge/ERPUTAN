using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Contabilidad
{
    class XCONTA_NATU_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Estado { get; set; }
        public int cb_Anio { get; set; }
        public int cb_mes { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public string pc_Cuenta { get; set; }
        public string tc_TipoCbte { get; set; }
        public string pc_clave_corta { get; set; }
        public Nullable<double> debe { get; set; }
        public Nullable<double> Cred { get; set; }

        public XCONTA_NATU_Rpt003_Info()
        {

        }
    }
}
