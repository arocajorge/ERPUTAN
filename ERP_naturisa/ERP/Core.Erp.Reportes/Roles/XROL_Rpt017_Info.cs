using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt017_Info
  {
      public int IdEmpresa { get; set; }
      public int IdTipoCbte { get; set; }
      public decimal IdCbteCble { get; set; }
      public string CodCtbteCble { get; set; }
      public int IdPeriodo { get; set; }
      public int IdNomina_Tipo { get; set; }
      public int secuencia { get; set; }
      public string IdCtaCble { get; set; }
      public double dc_Valor { get; set; }
      public string pc_Cuenta { get; set; }
      public string dc_Observacion { get; set; }
      public byte[] em_logo { get; set; }
      public string RazonSocial { get; set; }
      public string NombreComercial { get; set; }
      public System.DateTime pe_FechaIni { get; set; }
      public System.DateTime pe_FechaFin { get; set; }
      public decimal debito { get; set; }
      public decimal credito { get; set; }

    }
}
