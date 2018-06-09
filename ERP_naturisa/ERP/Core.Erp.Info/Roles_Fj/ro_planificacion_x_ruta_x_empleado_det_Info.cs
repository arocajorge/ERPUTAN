using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_planificacion_x_ruta_x_empleado_det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public int IdNomina_Tipo_Liq { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdPeriodo { get; set; }
       public int IdPlaca { get; set; }
       public int IdRuta { get; set; }
       public int IdFuerza { get; set; }
       public int IdZona { get; set; }
       public int IdDisco { get; set; }
       public string Observacion { get; set; }

       // vista
       public string pe_nombreCompleto { get; set; }
       public string de_descripcion { get; set; }
       public string ca_descripcion { get; set; }

       public bool icono_eliminar { get; set; }
    }
}
