using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_SaldoxCuentas_Info
    {

        public int IdEmpresa { get; set; }
        public int IdAnioF { get; set; }
        public int IdPeriodo { get; set; }
        public string IdCtaCble { get; set; }
        public int IdNivel { get; set; }
        public double sc_saldo_anterior { get; set; }
        public double sc_debito_mes { get; set; }
        public double sc_credito_mes { get; set; }
        public double sc_saldo_mes { get; set; }
        public double sc_credito_acum { get; set; }
        public double sc_debito_acum { get; set; }
        public double sc_saldo_acum { get; set; }



        public ct_SaldoxCuentas_Info() { }

    }
}
