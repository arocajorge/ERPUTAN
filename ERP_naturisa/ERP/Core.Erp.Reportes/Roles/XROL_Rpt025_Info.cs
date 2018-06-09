
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt025_Info
    {
        public int secuencia { get; set; }
        public string CedulaRuc { get; set; }
        public string NombreCompleto { get; set; }
        public string IdRubro { get; set; }
        public System.DateTime FechaPago { get; set; }
        public double Valor { get; set; }
        public string EstadoCobro { get; set; }
        public string RubroDescripcion { get; set; }
        public string Division { get; set; }
        public string CentroCosto { get; set; }
        public string Departamento { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string IdCentroCosto { get; set; }
        public string CodigoEmpleado { get; set; }
        public int IdDepartamento { get; set; }
        public Image Logo { get; set; }
        public Nullable<double> Num_Horas { get; set; }
        public string em_nombre { get; set; }


        public XROL_Rpt025_Info() { }

    }
}
