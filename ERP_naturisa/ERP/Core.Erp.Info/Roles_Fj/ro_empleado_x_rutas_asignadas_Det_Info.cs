using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_empleado_x_rutas_asignadas_Det_Info
  {
      public int IdEmpresa { get; set; }
      public int IdNomina_Tipo { get; set; }
      public decimal IdEmpleado { get; set; }
      public int id_ruta { get; set; }
      public int secuencia { get; set; }
      public bool icono_eliminar { get; set; }
      public bool check { get; set; }
      public string ru_descripcion { get; set; }

    }
}
