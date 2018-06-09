using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt005_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public double Valor { get; set; }
        public string Centro_costo { get; set; }
        public string TipoCbte { get; set; }
        public string nom_Cuenta { get; set; }
        public string Naturaleza_cta { get; set; }
        public string IdCtaCblePadre { get; set; }
        public Nullable<int> AnioFiscal { get; set; }
        public Nullable<int> IdMes { get; set; }
        public string Mes { get; set; }
    }
}
