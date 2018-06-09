/*CLASE: XROL_Rpt009_Info
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
    public class XROL_Rpt009_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdPeriodo { get; set; }
        public double SueldoDigno { get; set; }
        public string Observacion { get; set; }
        public double UtilidadRepartir { get; set; }
        public decimal IdEmpleado { get; set; }
        public double Valor { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string StatusEmpleado { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string EstadoEmpleado { get; set; }
        public string CodigoEmpleado { get; set; }      

        public Image Logo { get; set; }

        public XROL_Rpt009_Info() { }

    }
}
