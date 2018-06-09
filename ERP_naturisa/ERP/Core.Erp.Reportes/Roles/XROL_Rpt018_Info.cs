using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt018_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNominaTipo { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdNominaTipoLiqui { get; set; }
       public int IdPeriodo { get; set; }
       public string IdRubro { get; set; }
       public int IdDepartamento { get; set; }
       public Nullable<int> pe_anio { get; set; }
       public System.DateTime pe_FechaIni { get; set; }
       public System.DateTime pe_FechaFin { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string ru_descripcion { get; set; }
       public double Valor { get; set; }
       public byte[] em_logo { get; set; }
       public string RazonSocial { get; set; }
       public string NombreComercial { get; set; }
       public string NombreCompleto { get; set; }
       public int secuencia { get; set; }
       public string de_descripcion { get; set; }
       public string Descripcion { get; set; }
    }
}
