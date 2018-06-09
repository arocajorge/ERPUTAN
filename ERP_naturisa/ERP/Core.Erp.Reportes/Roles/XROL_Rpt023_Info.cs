using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt023_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public decimal IdPersona { get; set; }
      public decimal IdNovedad { get; set; }
      public System.DateTime FechaPago { get; set; }
      public double Valor { get; set; }
      public System.DateTime Fecha_Transac { get; set; }
      public string ca_descripcion { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string DescripcionProcesoNomina { get; set; }
      public string Descripcion { get; set; }
      public string Observacion { get; set; }
      public string rub_Acuerdo_Descuento { get; set; }
      public int Anio { get; set; }
      public string mes { get; set; }
      public byte[] em_logo { get; set; }
      public string RazonSocial { get; set; }
      public string NombreComercial { get; set; }
      public string ru_descripcion { get; set; }

    }
}
