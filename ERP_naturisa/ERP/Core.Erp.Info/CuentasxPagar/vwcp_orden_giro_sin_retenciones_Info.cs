using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
 public class vwcp_orden_giro_sin_retenciones_Info
    {

     public int Idempresa { get; set; }
     public decimal IdCbteCble_Ogiro { get; set; }
     public int IdTipoCbte_Ogiro  { get; set; }
     public string IdOrden_giro_Tipo { get; set; }
     public decimal IdProveedor { get; set; }
     public DateTime co_fechaOg { get; set; }
     public string co_serie { get; set; }
     public string co_factura { get; set; }
     public DateTime co_FechaFactura { get; set; }
     public DateTime co_FechaFactura_vct { get; set; }
     public int co_plazo { get; set; }
     public string  co_observacion { get; set; }
     public double co_subtotal_iva { get; set; }
     public double co_subtotal_siniva { get; set; }   
     public double co_baseImponible { get; set; }
     public double co_Por_iva { get; set; }
     public double co_valoriva { get; set; }
     public int IdCod_ICE { get; set; }
     public double co_Ice_base { get; set; }
     public double co_Ice_por { get; set; }
     public double co_Ice_valor { get; set; } 
     public double co_Serv_por { get; set; }
     public double co_Serv_valor { get; set; }
     public double co_OtroValor_a_descontar { get; set; }
     public double co_OtroValor_a_Sumar { get; set; }
     public double co_BaseSeguro { get; set; }
     public double co_total { get; set; }
     public double co_valorpagar { get; set; }
     public string co_vaCoa { get; set; }
     public decimal IdAutorizacion { get; set; }
     public int IdIden_credito { get; set; }
     public int IdCod_101 { get; set; }
     public string IdTipoServicio { get; set; }
     public string IdCtaCble_Gasto { get; set; }
     public string IdCtaCble_IVA { get; set; }
     public string IdUsuario { get; set; }
     public DateTime Fecha_Transac { get; set; }
     public string Estado { get; set; }
     public string IdUsuarioUltMod { get; set; }
     public DateTime Fecha_UltMod { get; set; }
     public string IdUsuarioUltAnu { get; set; }
     public string MotivoAnu { get; set; }
     public string nom_pc { get; set; }
     public string ip { get; set; }
     public DateTime Fecha_UltAnu { get; set; }
     public string co_retencionManual { get; set; }
     public decimal IdCbteCble_Anulacion { get; set; }
     public int IdTipoCbte_Anulacion { get; set; }
     public decimal SaldoOG { get; set; }
     public string em_nombre { get; set; }
     public string IdCentroCosto { get; set; }
     public string  tc_TipoCbte { get; set; }
     public int IdSucursal { get; set; }
     public string Sucursal { get; set; }
     public decimal IdTipoFlujo { get; set; }
     public string TipoFlujo { get; set; }
     public string PagoLocExt { get; set; }
     public string PaisPago { get; set; }
     public string PagoSujetoRetencion { get; set; }
     public string ConvenioTributacion { get; set; }
     public DateTime co_FechaContabilizacion { get; set; }
     public double BseImpNoObjDeIva { get; set; }
     public string pr_nombre { get; set; }

     public string IdCtaCble_CXP { get; set; }
     public bool Checked { get; set; }
     public string Tipo_Documento { get; set; }
   
     public vwcp_orden_giro_sin_retenciones_Info(){}

    }
}
