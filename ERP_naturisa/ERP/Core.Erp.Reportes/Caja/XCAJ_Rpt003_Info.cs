using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
  public class XCAJ_Rpt003_Info
  {
      public int IdEmpresa { get; set; }
      public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
      public Nullable<int> IdTipoCbte_Ogiro { get; set; }
      public System.DateTime co_fechaOg { get; set; }
      public Nullable<decimal> IdPersona { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string IdTipoDocumento { get; set; }
      public string IdOrden_giro_Tipo { get; set; }
      public string Descripcion { get; set; }
      public Nullable<decimal> IdProveedor { get; set; }
      public string Num_Autorizacion { get; set; }
      public string co_serie { get; set; }
      public string co_factura { get; set; }
      public System.DateTime co_FechaFactura { get; set; }
      public decimal IdConciliacion_Caja { get; set; }
      public int IdCaja { get; set; }
      public string ca_Descripcion { get; set; }
      public string IdCtaCble { get; set; }
      public string co_observacion { get; set; }
      public int IdTipoMovi { get; set; }
      public string tm_descripcion { get; set; }
      public double co_baseImponible { get; set; }
      public double co_subtotal_iva { get; set; }
      public double co_subtotal_siniva { get; set; }
      public double co_valoriva { get; set; }
      public double co_Serv_valor { get; set; }
      public double co_total { get; set; }
      public double co_valorpagar { get; set; }
      public Nullable<decimal> IdRetencion { get; set; }
      public string serie { get; set; }
      public string NumRetencion { get; set; }
      public string NAutorizacion { get; set; }
      public string re_tipoRet_RF { get; set; }
      public Nullable<double> re_baseRetencion_RF { get; set; }
      public Nullable<double> re_Porcen_retencion_RF { get; set; }
      public Nullable<double> re_valor_retencion_RF { get; set; }
      public string re_tipoRet_RIVA { get; set; }
      public Nullable<double> re_baseRetencion_RIVA { get; set; }
      public Nullable<double> re_Porcen_retencion_RIVA { get; set; }
      public Nullable<double> re_valor_retencion_RIVA { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string pe_razonSocial { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public int IdPeriodo { get; set; }
      public int IdanioFiscal { get; set; }
      public int pe_mes { get; set; }
      public string smes { get; set; }
      public System.DateTime pe_FechaIni { get; set; }
      public System.DateTime pe_FechaFin { get; set; }
      public System.DateTime Fecha { get; set; }
      public string IdEstadoCierre { get; set; }
      public string Observacion { get; set; }
      public double Saldo_cont_al_periodo { get; set; }
      public double Ingresos { get; set; }
      public double Total_Ing { get; set; }
      public double Total_fact_vale { get; set; }
      public double Total_fondo { get; set; }
      public double Dif_x_pagar_o_cobrar { get; set; }
      public Nullable<double> co_OtroValor_a_descontar { get; set; }
    }
}
