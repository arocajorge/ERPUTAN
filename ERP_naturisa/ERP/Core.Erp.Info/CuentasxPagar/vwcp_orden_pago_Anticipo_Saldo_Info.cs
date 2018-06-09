using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
   public class vwcp_orden_pago_Anticipo_Saldo_Info
    {

       public int? IdEmpresa_cxp { get; set; }
       public decimal? IdCbteCble_cxp { get; set; }
       public int? IdTipoCbte_cxp { get; set; }
       public DateTime Fecha { get; set; }
       public string Observacion { get; set; }
       public string referencia { get; set; }
       public string tc_TipoCbte { get; set; }
       public double Valor_cbte { get; set; }
       public double valor_cancelado { get; set; }
       public double valor_saldo_cbte { get; set; }
       public string ANTPROV { get; set; }
       public int IdEmpresaOP { get; set; }
       public decimal IdOrdenPagoOP { get; set; }
       public int SecuenciaOP { get; set; }
       public string IdCtaCble { get; set; }
       public string IdCtaCble_Anticipo { get; set; }
       public string Beneficiario { get; set; }
       public decimal? IdEntidad { get; set; }


       public vwcp_orden_pago_Anticipo_Saldo_Info() 
       { 
       
       
       }
    }
}
