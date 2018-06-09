using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt009_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public string tc_TipoCbte { get; set; }
        public int IdEmpresa_cbte { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_Cuenta { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_Centro_costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
        public string dc_Observacion { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string nom_punto_cargo { get; set; }
    }
}
