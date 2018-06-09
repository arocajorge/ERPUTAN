using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_empleado_x_turno_Info
  {
      public int IdEmpresa { get; set; }
      public int IdNomina_Tipo { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdPeriodo { get; set; }
      public int IdTurno { get; set; }
      public int IdSemana { get; set; }
      public int IdMes { get; set; }
      public int IdAnio { get; set; }
      public string Observacion { get; set; }
      public string Estado { get; set; }
      public string IdUsuario { get; set; }
      public Nullable<System.DateTime> Fecha_Transac { get; set; }
      public string IdUsuarioModif { get; set; }
      public Nullable<System.DateTime> Fecha_UltMod { get; set; }
      public Nullable<System.DateTime> FechaHoraAnul { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public string MotivoAnulacion { get; set; }



      // vista

      public decimal IdPersona { get; set; }
      public int IdCargo { get; set; }
      public int IdDepartamento { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string de_descripcion { get; set; }
      public string ca_descripcion { get; set; }
      public Nullable<int> Num_jornada_desfasada { get; set; }
    }
}
