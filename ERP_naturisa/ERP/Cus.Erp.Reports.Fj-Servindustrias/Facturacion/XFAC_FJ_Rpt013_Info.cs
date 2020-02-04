using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
  public  class XFAC_FJ_Rpt013_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdPreFacturacion { get; set; }
      public int secuencia { get; set; }
      public string IdCentro_Costo { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }
      public Nullable<int> IdPunto_cargo { get; set; }
      public string Tipo_Cobro_Poliza_X { get; set; }
      public Nullable<int> IdEmpresa_pol_det { get; set; }
      public Nullable<decimal> IdPoliza_pol_det { get; set; }
      public Nullable<int> IdActivoFijo_pol_det { get; set; }
      public Nullable<int> secuencia_pol_det { get; set; }
      public Nullable<int> IdEmpresa_pol_cuota { get; set; }
      public Nullable<decimal> IdPoliza_pol_cuota { get; set; }
      public string cod_cuota_pol_cuota { get; set; }
      public Nullable<double> Cantidad { get; set; }
      public Nullable<double> Costo_Uni { get; set; }
      public Nullable<double> Subtotal { get; set; }
      public Nullable<bool> Aplica_Iva { get; set; }
      public Nullable<double> Por_Iva { get; set; }
      public Nullable<double> Valor_Iva { get; set; }
      public Nullable<double> Total { get; set; }
      public bool Facturar { get; set; }
      public Nullable<double> Subtotal_iva { get; set; }
      public Nullable<double> Subtotal_0 { get; set; }
      public Nullable<decimal> IdTarifario { get; set; }
      public double Porc_ganancia { get; set; }
      public int num_cuotas { get; set; }
      public int IdPeriodo { get; set; }
      public double iva { get; set; }
      public Nullable<double> pago_contado { get; set; }
      public Nullable<double> subtotal_noIva { get; set; }
      public double porc_iva { get; set; }
      public Nullable<double> MontoAsegurado { get; set; }
      public string Cuota { get; set; }
      public double valor_prima { get; set; }


      public string em_nombre { get; set; }
      public byte[] em_logo { get; set; }

    }
}
