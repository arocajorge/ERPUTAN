using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class vwba_Cbte_Ban_detallePagos_Info
    {

      public int IdEmpresa { get; set; }
      public decimal IdCbteCble_Ogiro  { get; set; }
      public DateTime co_fechaOg  { get; set; }
      public string co_observacion  { get; set; }
      public double co_valorpagar  { get; set; }
      public double? pg_MontoAplicado  { get; set; }
      public decimal IdProveedor  { get; set; }
      public decimal IdCbteCble_cbte  { get; set; }
      public int IdTipocbte_cbte  { get; set; }
      public double? pg_saldoAnterior { get; set; }
      public int IdTipoCbte_Ogiro { get; set; }
      public decimal IdCancelacion { get; set; }
      public int? IdEmpresa_cbte { get; set; }
      public string NFactura { get; set; }

      public vwba_Cbte_Ban_detallePagos_Info() { }
    }
}
