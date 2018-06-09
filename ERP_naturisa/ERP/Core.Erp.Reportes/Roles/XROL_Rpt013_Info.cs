using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt013_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string pe_cedulaRuc { get; set; }
      public Nullable<double> Ingreso { get; set; }
      public Nullable<int> pe_mes { get; set; }
      public Nullable<int> pe_anio { get; set; }
      public System.DateTime pe_FechaIni { get; set; }
      public System.DateTime pe_FechaFin { get; set; }
      public string Periodo { get; set; }
      public double tot_Ingreso { get; set; }
    }
}
