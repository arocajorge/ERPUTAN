using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//DEREK MEJIA 27/02/2014
namespace Core.Erp.Info.Contabilidad
{
    public class vwct_cbtecble_con_saldo_cxp_Info
    {
        public int? IdEmpresa { get; set; }
        public decimal? IdCbteCble { get; set; }
        public int? IdTipocbte { get; set; }
        public DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string referencia { get; set; }
        public string tc_TipoCbte { get; set; }
        public double? Valor_cbte { get; set; }
        public double Valor_cancelado_cbte { get; set; }
        public double? valor_Saldo_cbte { get; set; }
        public Boolean Check { get; set; }
        //DEREK MEJIA 21/03/2014
        public string tipo { get; set; }
        //DEREK MEJIA 28/03/2014
        public int? IdEmpresaOP { get; set; }
        public decimal? IdOrdenPagoOP { get; set; }
        public int? SecuenciaOP { get; set; }

        public string IdCtaCble { get; set; }
        public string IdCtaCble_Anticipo { get; set; }
        public string Beneficiario { get; set; }

        public decimal? IdBeneficiario { get; set; }
        public decimal IdPersona { get; set; }



        public vwct_cbtecble_con_saldo_cxp_Info() { }
    }
}
