using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
   public  class ct_rpt_SaldosxCuentas_Info
    {

        public int IdEmpresa { get; set; }
        public int IdAnioFiscal { get; set; }
        public int IdPeriodo { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCblePadre { get; set; }
        public string NomCtaCble { get; set; }
        public string Naturaleza { get; set; }
        public int Nivel { get; set; }
        public double Saldo_anterior { get; set; }
        public double debito_mes { get; set; }
        public double credito_mes { get; set; }
        public double saldo_periodo { get; set; }
        public double debito_acumulado { get; set; }
        public double credito_acumulado { get; set; }
        public double saldo_acumulado { get; set; }
        public string IdGrupoCble { get; set; }
        public string GrupoCble { get; set; }
        public int Orden { get; set; }
        public string EstadoFinanciero { get; set; }
        public string SIdPeriodo { get; set; }
        public string NomPeriodo { get; set; }

       
       public byte[] em_logo { get; set; }


       public ct_rpt_SaldosxCuentas_Info() { }



    }
}
