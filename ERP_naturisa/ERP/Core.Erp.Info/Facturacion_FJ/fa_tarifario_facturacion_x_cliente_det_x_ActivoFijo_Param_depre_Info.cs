using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdTarifario { get; set; }
      public int IdActivoFijo { get; set; }
      public Nullable<double> Af_porcentaje_deprec { get; set; }
      public Nullable<int> Af_anios_vida_util { get; set; }
      public Nullable<double> Af_costo_historico { get; set; }
      public Nullable<double> Af_costo_compra { get; set; }
      public Nullable<int> Af_Meses_depreciar { get; set; }
      public Nullable<System.DateTime> Af_fecha_ini_depre { get; set; }
      public Nullable<System.DateTime> Af_fecha_fin_depre { get; set; }
      public Nullable<double> Af_ValorSalvamento { get; set; }
      public Nullable<double> Af_ValorResidual { get; set; }
      public Nullable<bool> se_factura_valorSalvamento { get; set; }
      public string Af_Nombre { get; set; }
      public int Periodo { get; set; }
      public Nullable<bool> se_factura_Iva { get; set; }

      public List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> list_depreciacion_x_mes { get; set; }
   


    }
}
