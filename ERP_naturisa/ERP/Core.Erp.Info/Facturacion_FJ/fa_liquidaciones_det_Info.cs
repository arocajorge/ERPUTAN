using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_liquidaciones_det_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdLiquidaciones { get; set; }
      public int IdLiquidacion_liqui_gastos { get; set; }
      public int secuencia_pre_fac { get; set; }
      public int IdPeriodo { get; set; }
      public int IdEmpresa_liqui_gastos { get; set; }
      public System.DateTime fecha { get; set; }
      public string Observacion { get; set; }
      public string Estado_Proceso { get; set; }
      public bool Estado { get; set; }
      public string IdUsuario { get; set; }
      public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
      public string IdUsuarioUltModi { get; set; }
      public Nullable<System.DateTime> Fecha_UltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
      public string MotivoAnulacion { get; set; }
      public string nom_pc { get; set; }
      public string ip { get; set; }
    }
}
