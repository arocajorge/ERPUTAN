using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_planificacion_x_jornada_desfasada_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }

       public int IdPeriodo { get; set; }
       public string Observación { get; set; }
       public string Esta_Proceso { get; set; }
       public string IdUsuario { get; set; }
       public Nullable<System.DateTime> Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string Estado { get; set; }
       public string MotiAnula { get; set; }
       public List<ro_planificacion_x_jornada_desfasada_empleado_Info> Lista { get; set; }
       public System.DateTime pe_FechaIni { get; set; }
       public System.DateTime pe_FechaFin { get; set; }
       public string pe_descripcion { get; set; }
    }
}
