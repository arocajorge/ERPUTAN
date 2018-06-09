using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public class ro_Capacitaciones_x_Empleado_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdEmpleado { get; set; }
       public int Secuencia { get; set; }
       public string Institucion { get; set; }
       public string NombreCurso { get; set; }
       public int Horas { get; set; }
       public string Observacion { get; set; }
    }
}
