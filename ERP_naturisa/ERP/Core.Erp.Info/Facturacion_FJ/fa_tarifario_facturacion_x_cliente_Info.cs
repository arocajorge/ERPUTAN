using Core.Erp.Info.ActivoFijo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_tarifario_facturacion_x_cliente_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdTarifario { get; set; }
      public string codTarifario { get; set; }
      public string nom_tarifario { get; set; }
      public string observacion { get; set; }
      public System.DateTime fecha { get; set; }
      public System.DateTime fecha_inicio { get; set; }
      public System.DateTime fecha_fin { get; set; }
      public decimal IdCliente { get; set; }
      public bool se_fact_depreciacion { get; set; }
      public bool se_fact_seguro { get; set; }
      public bool se_fact_movilizacion { get; set; }
      public bool se_fact_gatos { get; set; }
      public bool se_fact_egreso_bodega { get; set; }
      public bool se_factura_gastos_roles { get; set; }
      public bool se_fact_margen_ganacia { get; set; }
      public bool se_fact_horometro { get; set; }
      public bool se_fact_horas_minimas { get; set; }
      public bool se_fact_otros { get; set; }
      public Nullable<bool> se_fact_recargo_interes { get; set; }
      public Nullable<double> Porcentaje_recargo_iteres_poliza { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string Estado { get; set; }
      public string IdUsuario { get; set; }
      public string nom_pc { get; set; }
      public string ip { get; set; }
      public string IdUsuarioUltMod { get; set; }
      public Nullable<System.DateTime> FechaUltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
      public string MotiAnula { get; set; }

      public string IdEstadoVigencia_cat { get; set; }
      public string nom_EstadoVigencia_cat { get; set; }
      public Double Movilizacion { get; set; }

      public List<fa_tarifario_facturacion_x_cliente_det_Info> lst_det { get; set; }
      public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> lst_Act_x_tarifario { get; set; }


     

    }
}
