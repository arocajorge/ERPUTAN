using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_rpt_SaldoxCta_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public double sa_SaldoInicial { get; set; }
        public double sa_Debitos { get; set; }
        public double sa_Creditos { get; set; }
        public double sa_SaldoFinal { get; set; }

        public ct_rpt_SaldoxCta_Info() { }
    }
}
