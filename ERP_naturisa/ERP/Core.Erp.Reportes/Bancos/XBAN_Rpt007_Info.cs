using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt007_Info
    {
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public string Tipo_cbte_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public string Tipo_cbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public string co_observacion { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public decimal IdTipoFlujo { get; set; }
        public string nom_tipo_flujo { get; set; }
        public string cod_flujo { get; set; }
        public string Tipo { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public int IdBanco { get; set; }
        public string nom_banco { get; set; }
        public string Tipo_movi { get; set; }
        public int orden { get; set; }

    }
}
