using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_descuento_no_planificados_Det_Info
  {
      public int IdEmpresa { get; set; }
      public int IdNomina_Tipo { get; set; }
      public int IdNomina_Tipo_Liq { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdDescuento { get; set; }
      public string IdRubro { get; set; }
      public int Secuencia { get; set; }
      public string Observacion { get; set; }
      public double Valor { get; set; }
      public System.DateTime Fecha_Descuento { get; set; }


      public bool eliminar { get; set; }

    }
}
