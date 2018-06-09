using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int IdCaja { get; set; }
        public Nullable<System.DateTime> Fecha_ini { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
        public string IdEstadoCierre { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_clave_corta { get; set; }
        public string pc_Cuenta { get; set; }
        public double Debe { get; set; }
        public Nullable<double> Haber { get; set; }
        public string dc_Observacion { get; set; }
        public Nullable<int> IdEmpresa_cbte { get; set; }
        public string nom_tipo_cbte { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public string nom_caja { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
    }
}
