using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class vwcp_Cbte_x_pagar_OG_Info
    {
       public int IdEmpresa { set; get; }
       public string em_nombre { set; get; }
       public decimal IdCbteCble_Ogiro { set; get; }
       public int IdTipoCbte_Ogiro { set; get; }
       public decimal IdProveedor { set; get; }
       public string NomProveedor { set; get; }
       public DateTime co_fechaOg { set; get; }
       public string co_factura { set; get; }
       public string co_observacion { set; get; }
       public string co_serie { set; get; }
       public double co_total { set; get; }
       public double co_Valorpagar { set; get; }
       public double Valor_Respaldado { set; get; }
       public double SaldoPendiente { set; get; }
       public string TipoReg { set; get; }
       public string Descripcion { set; get; }
       public string CodTipoDocumento { set; get; }
       public string Referencia { set; get; }

       public double SaldoAUX { get; set; }

       public bool check { get; set; }
       public double Valor_a_pagar_User { set; get; }

       //campos de la vista vwcp_orden_pago_det
       public decimal IdOrdenPago { set; get; }
       public string  Observacion { set; get; }
       public string  IdTipo_op { set; get; }
       public string IdTipo_Persona { set; get; }
       public decimal IdPersona { set; get; }
       public DateTime Fecha { set; get; }
       public char Estado { set; get; }
       public string  IdEstadoAprobacion { set; get; }
       public int Secuencia { set; get; }
    //   public string referencia { set; get; }          
       public double Total_a_Pagar { set; get; }
       public double Total_a_pagar_OP { set; get; }

       public double Total_Retencion { set; get; }



       public vwcp_Cbte_x_pagar_OG_Info() { }
   
    }
}
