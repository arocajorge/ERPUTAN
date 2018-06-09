using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_pre_facturacion_det_gasto_mano_obra_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdPreFacturacion { get; set; }
      public int IdPeriodo { get; set; }
      public int IdNomina_Tipo { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdCargo { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string ca_descripcion { get; set; }
      public Nullable<double> SALARIO { get; set; }
      public Nullable<double> H_EXTRAS { get; set; }
      public Nullable<double> ALIMENTACION { get; set; }
      public Nullable<double> T_BENEFICIOS { get; set; }
      public Nullable<double> TOTAL_INGRESOS { get; set; }
      public Nullable<double> TOTAL_M_O { get; set; }
    }
}
