using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
   public class vwcp_Anticipos_para_Conciliar_Info
    {
        public int? IdEmpresa_cxp { get; set; }
        public decimal? IdCbteCble_cxp { get; set; }
        public int? IdTipocbte_cxp { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string referencia { get; set; }
        public string tc_TipoCbte { get; set; }
        public double Valor_cbte { get; set; }
        public double Valor_cancelado { get; set; }
        public double valor_Saldo_cbte { get; set; }
        public Boolean Check { get; set; }
       
        public string tipo { get; set; }
       
        public int IdEmpresaOP { get; set; }
        public decimal IdOrdenPagoOP { get; set; }
        public int SecuenciaOP { get; set; }

        public string IdCtaCble { get; set; }
        public string IdCtaCble_Anticipo { get; set; }
        public string Beneficiario { get; set; }

        public decimal IdProveedor { get; set; }
        public decimal IdPersona { get; set; }

        public vwcp_Anticipos_para_Conciliar_Info() { }

    }
}
