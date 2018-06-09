/*CLASE: XROL_Rpt010_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt010_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRegistro { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdTipoMarcaciones { get; set; }
        public decimal secuencia { get; set; }
        public Nullable<System.TimeSpan> es_Hora { get; set; }
        public Nullable<System.DateTime> es_fechaRegistro { get; set; }
        public Nullable<int> es_anio { get; set; }
        public Nullable<int> es_mes { get; set; }
        public Nullable<int> es_semana { get; set; }
        public Nullable<int> es_dia { get; set; }
        public string es_sdia { get; set; }
        public Nullable<int> es_idDia { get; set; }
        public string es_EsActualizacion { get; set; }
        public string IdTipoMarcaciones_Biometrico { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string EstadoEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string StatusEmpleado { get; set; }
        public string DescripcionDivision { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Centro_costo { get; set; }
        public string IdCentroCosto { get; set; }
        public string CodigoEmpleado { get; set; }      

        public Image Logo { get; set; }

        public XROL_Rpt010_Info() { }
    }
}
