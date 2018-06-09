using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt003_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdNominaTipo { get; set; }
      public int IdNominaTipoLiqui { get; set; }
      public int IdPeriodo { get; set; }
      public Nullable<double> hora_extra25 { get; set; }
      public Nullable<double> hora_extra50 { get; set; }
      public Nullable<double> hora_extra100 { get; set; }
      public Nullable<double> TotalHorasExtras { get; set; }
      public Nullable<double> hora_trabajada { get; set; }
      public Nullable<int> Dias_Efectivos { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_nombre { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombreCompleto { get; set; }
    }
}
