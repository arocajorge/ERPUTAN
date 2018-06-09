using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
  public  class Af_Activo_fijo_x_Af_Activo_fijo_Info
  {
      public int IdEmpresa { get; set; }
      public int IdActivoFijo_padre { get; set; }
      public int IdActivoFijo_hijo { get; set; }
    }
}
