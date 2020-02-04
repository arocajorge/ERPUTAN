using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt001_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdNominaTipo { get; set; }
      public int IdNominaTipoLiqui { get; set; }
      public int IdPeriodo { get; set; }
      public int IdCalendario { get; set; }
      public decimal IdTurno { get; set; }
      public decimal IdHorario { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_nombreCompleto { get; set; }
      public string ca_descripcion { get; set; }
      public string de_descripcion { get; set; }
      public System.DateTime FechaRegistro { get; set; }
      public double Tot_horas_1ra_jornada { get; set; }
      public double Tot_horas_2da_jornada { get; set; }
      public int dia { get; set; }
      public string primer_turno { get; set; }
      public string segundo_turno { get; set; }
      public Nullable<System.TimeSpan> time_entrada1 { get; set; }
      public Nullable<System.TimeSpan> time_salida1 { get; set; }
      public Nullable<System.TimeSpan> time_entrada2 { get; set; }
      public Nullable<System.TimeSpan> time_salida2 { get; set; }
      public int almuerzo { get; set; }
      public double hora_trabajada { get; set; }
      public double hora_extra25 { get; set; }
      public double hora_extra50 { get; set; }
      public double hora_extra100 { get; set; }
    }
}
