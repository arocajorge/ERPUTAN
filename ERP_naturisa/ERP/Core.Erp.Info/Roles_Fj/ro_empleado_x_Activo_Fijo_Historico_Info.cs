using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_empleado_x_Activo_Fijo_Historico_Info
   {
       public int IdEmpresa { get; set; }
       public int IdActivo_fijo { get; set; }
       public int Id_Historico { get; set; }
       public int IdNomina_tipo { get; set; }
       public int IdPeriodo { get; set; }
       public decimal IdEmpleado { get; set; }
       public DateTime Fecha_Asignacion { get; set; }
       public DateTime Fecha_Hasta { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_nombreCompleto { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string de_descripcion { get; set; }
       public string Descripcion { get; set; }
    }
}
