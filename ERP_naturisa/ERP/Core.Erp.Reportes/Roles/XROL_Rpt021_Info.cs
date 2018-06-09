using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt021_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoNomina { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdDepartamento { get; set; }
        public int IdFalta { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public Nullable<int> DiasDescuento { get; set; }
        public Nullable<System.DateTime> FechaDescuentaRol { get; set; }
        public string Descripcion { get; set; }
        public string de_descripcion { get; set; }
        public byte[] em_logo { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string NombreCompleto { get; set; }
        public int secuencia { get; set; }
        
    }
}
