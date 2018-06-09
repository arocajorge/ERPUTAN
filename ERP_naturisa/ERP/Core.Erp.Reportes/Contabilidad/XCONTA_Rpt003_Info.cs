using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt003_Info
    {
        public double debe { get; set; }
        public double Cred { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime cb_Fecha { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Estado { get; set; }
        public int cb_Anio { get; set; }
        public int cb_mes { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public string pc_Cuenta { get; set; }
        public string tc_TipoCbte { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string pc_clave_corta { get; set; }

        public XCONTA_Rpt003_Info() { }
    }
}
