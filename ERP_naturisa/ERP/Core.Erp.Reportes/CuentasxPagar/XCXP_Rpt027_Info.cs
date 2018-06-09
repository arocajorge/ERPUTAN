using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt027_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdConciliacion_Caja { get; set; }
      public int Secuencia { get; set; }
      public int IdEmpresa_movcaja { get; set; }
      public decimal IdCbteCble_movcaja { get; set; }
      public int IdTipocbte_movcaja { get; set; }
      public string IdCtaCble { get; set; }
      public double cm_valor { get; set; }
      public string cm_beneficiario { get; set; }
      public int IdTipoMovi { get; set; }
      public string tm_descripcion { get; set; }
      public string cm_observacion { get; set; }
      public string pc_Cuenta { get; set; }

    }
}
