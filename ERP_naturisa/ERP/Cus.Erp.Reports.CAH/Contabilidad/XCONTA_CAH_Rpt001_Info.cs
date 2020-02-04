using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Contabilidad
{
    public class XCONTA_CAH_Rpt001_Info
    {
        public Nullable<double> debe { get; set; }
        public Nullable<double> Cred { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public Nullable<double> cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Estado { get; set; }
        public Nullable<int> cb_Anio { get; set; }
        public Nullable<int> cb_mes { get; set; }
        public Nullable<int> secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public string pc_Cuenta { get; set; }
        public string tc_TipoCbte { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string pc_clave_corta { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
    }
}
