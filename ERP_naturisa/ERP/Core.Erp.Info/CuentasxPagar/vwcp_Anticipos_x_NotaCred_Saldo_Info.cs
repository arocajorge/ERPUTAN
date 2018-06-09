using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
   public class vwcp_Anticipos_x_NotaCred_Saldo_Info
    {

       public int? IdEmpresa { get; set; }
       public decimal? IdCbteCble { get; set; }
       public int? IdTipoCbte{ get; set; }
       public DateTime Fecha { get; set; }
       public string Observacion { get; set; }
       public string Referencia { get; set; }
       public string tc_TipoCbte { get; set; }
       public double? Valor_cbte { get; set; }
       public double valor_cancelado { get; set; }
       public double? valor_saldo_cbte { get; set; }
       public string Tipo{ get; set; }
       public int? IdEmpresaOP { get; set; }
       public decimal? IdOrdenPagoOP { get; set; }
       public int? SecuenciaOP { get; set; }
       public string IdCtaCble { get; set; }
       public string IdCtaCble_Anticipo { get; set; }
       public string Beneficiario { get; set; }
       public decimal? IdEntidad { get; set; }


       public vwcp_Anticipos_x_NotaCred_Saldo_Info() 
       { 
       
       
       }
    }
}
