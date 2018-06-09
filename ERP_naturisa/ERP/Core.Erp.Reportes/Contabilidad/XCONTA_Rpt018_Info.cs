using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt018_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> Valor { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string Comprobante { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
    }
}
