using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt014_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdTipoNomina { get; set; }
      public int IdDepartamento { get; set; }
      public string de_descripcion { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public Nullable<System.DateTime> Fec_Inicio_Acumulacion { get; set; }
      public Nullable<System.DateTime> Fec_Fin_Acumulacion { get; set; }
      public string ru_descripcion { get; set; }
      public string NombreCorto { get; set; }
      public string Nombres { get; set; }
      public string em_nombre { get; set; }
      public string RazonSocial { get; set; }
      public string NombreComercial { get; set; }
      public byte[] em_logo { get; set; }
      public string Decimo_Cuarto { get; set; }
      public string Decimo_Tercero { get; set; }
      public string Fondos_Reservas { get; set; }
    }
}
