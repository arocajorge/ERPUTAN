using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.Roles
{
 public   class XROL_Rpt020_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina { get; set; }
        public int IdDepartamento { get; set; }
        public int IdEmpleado { get; set; }
        public Nullable<double> Num_horas25 { get; set; }
        public Nullable<double> Valor_hora_25 { get; set; }
        public Nullable<double> Num_horas50 { get; set; }
        public Nullable<double> Valor_hora_50 { get; set; }
        public Nullable<double> Num_horas100 { get; set; }
        public Nullable<double> Valor_hora_100 { get; set; }
        public string Nomina { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Departamento { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public Image Logo { get; set; }

    }
}
