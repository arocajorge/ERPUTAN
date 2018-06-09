using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string CodigoSectorialIESS { get; set; }
        public string StatusEmpleado { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public string CentroCosto { get; set; }
        public string Division { get; set; }
        public string EstadoEmpleado { get; set; }
        public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
        public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
        public byte[] em_foto { get; set; }
        public Nullable<bool> es_AcreditaHorasExtras { get; set; }
        public double por_discapacidad { get; set; }
        public string carnet_conadis { get; set; }
        public string pe_sexo { get; set; }
        public string em_empEspecial { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_celular { get; set; }
        public string IdEstadoCivil { get; set; }
        public string CodigoEmpleado { get; set; }
        public decimal Sueldo_Actual { get; set; }
        public Image Logo { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }

        public XROL_Rpt001_Info() { }
    }
}
