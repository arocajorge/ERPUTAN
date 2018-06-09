using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt007_Info
    {
        public string zo_descripcion { get; set; }
        public string fu_descripcion { get; set; }
        public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
        public Nullable<System.DateTime> pe_FechaIni { get; set; }
        public string ca_descripcion { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string Cargo { get; set; }
        public double SUELDOACTUAL { get; set; }
        public Nullable<double> DIAS { get; set; }
        public Nullable<int> Falta { get; set; }
        public Nullable<int> VACACIONES { get; set; }
        public Nullable<int> PERMISO_IESS { get; set; }
        public Nullable<double> DIAS_EFECTIVOS { get; set; }
        public Nullable<double> SUELDO_X_DIAS_TRABAJADOS { get; set; }
        public Nullable<double> HORAS_25 { get; set; }
        public Nullable<double> HORAS_50 { get; set; }
        public Nullable<double> HORAS_100 { get; set; }
        public Nullable<double> TRANSPORTE { get; set; }
        public Nullable<double> ALIMENTACION { get; set; }
        public Nullable<double> BONIFICACIÓN { get; set; }
        public double T_MAS_BENEFICIOS { get; set; }
        public double TOTAL_MO { get; set; }
        public double TOTAL_SOBRETIEMPO { get; set; }
        public double tot_ingreso { get; set; }
        public int DIA_TRABAJADO { get; set; }

    }
}
