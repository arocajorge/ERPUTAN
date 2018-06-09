using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_Parametro_calculo_Horas_Extras_Info
  {
      public int IdEmpresa { get; set; }
      public bool Se_calcula_horas_Extras_al100 { get; set; }
      public bool Se_calcula_horas_Extras_al50 { get; set; }
      public bool Se_calcula_horas_Extras_al25 { get; set; }
      public int Corte_Horas_extras { get; set; }
      public bool Se_Crea_reverso_h_extras_si_Emp_tiene_remplazo { get; set; }
      public string IdRubro_rev_Horas { get; set; }
      public string IdRubro_Rebaja_Desahucio { get; set; }
      public Nullable<int> MinutosLunch { get; set; }

    }
}
