using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Talme.Roles
{
    class XROL_TALME_Rpt001_Info
    {
        public string NombreCompleto { get; set; }
        public string Ruc { get; set; }
        public Nullable<int> IdCargo { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string Empresa { get; set; }
        public string RucEmpresa { get; set; }
        public string RubroDescripcion { get; set; }
        public string RazonSocial { get; set; }
        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public double Ingreso { get; set; }
        public double Egreso { get; set; }
        public int Orden { get; set; }
        public string Cargo { get; set; }
        public string Division { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Centro_costo { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Departamento { get; set; }
        public Image Logo { get; set; }
        public string FechaPago { get; set; }
        
        public int DiasTrabajos{ get; set; }
        public string NombreComercial { get; set; }
        public string Estado { get; set; }

        public double Horas_al_25 { get; set; }
        public double Horas_al_50 { get; set; }
        public double Horas_al_100 { get; set; }




        public XROL_TALME_Rpt001_Info() { }
    }
}
