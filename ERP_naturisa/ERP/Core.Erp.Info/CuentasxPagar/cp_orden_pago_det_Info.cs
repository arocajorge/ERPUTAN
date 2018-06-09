using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_orden_pago_det_Info
    {
       public int IdEmpresa	{set;get;}
       public decimal IdOrdenPago {set;get;}	
       public int Secuencia	{set;get;}	
       public int ? IdEmpresa_cxp	{set;get;}	
       public decimal? IdCbteCble_cxp	{set;get;}
       public int? IdTipoCbte_cxp	{set;get;}
       public double Valor_a_pagar { set; get; }
       public string Referencia { set; get; }


       public string IdFormaPago { set; get; }
       public DateTime Fecha_Pago { set; get; }
       public string IdEstadoAprobacion { set; get; }
       public int? Idbanco { set; get; }
       public string IdUsuario_Aproba { set; get; }
       public DateTime fecha_hora_Aproba { set; get; }
       public string Motivo_aproba { set; get; }


       public string IdTipo_Persona { get; set; }
       public decimal IdPersona { get; set; }
       public decimal IdEntidad { get; set; }
       public string pr_nombre { get; set; }
       public string IdTipo_op { get; set; }
       public string IdCtaCble_Acreedora { get; set; }
       public string Observacion { get; set; }

       public cp_orden_pago_det_Info(){}
    }
}
