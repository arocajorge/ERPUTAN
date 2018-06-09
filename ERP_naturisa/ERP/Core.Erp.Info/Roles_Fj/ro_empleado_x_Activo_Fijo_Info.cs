using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
namespace Core.Erp.Info.Roles_Fj
{
   public class ro_empleado_x_Activo_Fijo_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_tipo { get; set; }
       public int IdPeriodo { get; set; }
       public int IdActivo_fijo { get; set; }
       public decimal IdEmpleado { get; set; }
       public DateTime Fecha_Asignacion { get; set; }
       public DateTime Fecha_Hasta { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_nombreCompleto { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string de_descripcion { get; set; }
       public string Descripcion { get; set; }
       public bool check { get; set; }
       public string Af_Nombre { get; set; }
       public string Af_DescripcionCorta { get; set; }

       public ro_empleado_x_centro_costo_Info Info_Centro_costo_x_empleado { get; set; }
    }
}
