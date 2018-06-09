using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCargo { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public Nullable<double> hora_extra25 { get; set; }
        public Nullable<double> hora_extra50 { get; set; }
        public Nullable<double> hora_extra100 { get; set; }
        public Nullable<double> TotalHorasExtras { get; set; }
        public Nullable<double> hora_trabajada { get; set; }
        public Nullable<int> Dias_Efectivos { get; set; }
        public Nullable<double> Sueldo { get; set; }
        public Nullable<double> Valor_Hora_25 { get; set; }
        public Nullable<double> Valor_Hora_250 { get; set; }
        public Nullable<double> Valor_Hora_100 { get; set; }
    }
}
