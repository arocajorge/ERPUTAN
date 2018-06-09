using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public decimal IdEmpleado { get; set; }
       public string IdRegistro { get; set; }
       public System.DateTime es_fecha_registro { get; set; }
       public string Id_catalogo_Cat { get; set; }
       public string Observacion { get; set; }
       public int IdTurno { get; set; }
       public bool es_jornada_desfasada { get; set; }
       public Nullable<int> IdDisco { get; set; }
       public Nullable<int> IdRuta { get; set; }
       public Nullable<int> IdSala { get; set; }
       // vista

       public string IdTipoMarcaciones { get; set; }
       public Nullable<System.TimeSpan> es_Hora { get; set; }
       public Nullable<int> es_anio { get; set; }
       public Nullable<int> es_mes { get; set; }
       public Nullable<int> es_semana { get; set; }
       public Nullable<int> es_dia { get; set; }
       public string es_sdia { get; set; }
       public Nullable<int> es_idDia { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string ca_descripcion { get; set; }
       public string de_descripcion { get; set; }
       public int imagen { get; set; }
       public bool es_feriado { get; set; }
    }
}
