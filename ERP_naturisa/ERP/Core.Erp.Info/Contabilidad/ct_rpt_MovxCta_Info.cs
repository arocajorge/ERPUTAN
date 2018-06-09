using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_rpt_MovxCta_Info
    {
        public int Idempresa { get; set; }
        public int IdPeriodo { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable < DateTime> FechaCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdTipoCbte { get; set; }
        public string sTipoCbte { get; set; }
        public string Observacion { get; set; }
        public double Debito { get; set; }
        public double Credito { get; set; }
        public double Saldo { get; set; }

        public string IdUsuario { get; set; }

        public string Nom_Pc { get; set; }
    }
}
