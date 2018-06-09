/*CLASE: XROL_Rpt008_Info
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
    public class XROL_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public double UtilidadDerechoIndividual { get; set; }
        public double UtilidadCargaFamiliar { get; set; }
        public double LimiteDistribucionUtilidad { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public double DiasTrabajados { get; set; }
        public double CargasFamiliares { get; set; }
        public double ValorIndividual { get; set; }
        public double ValorCargaFamiliar { get; set; }
        public double ValorExedenteIESS { get; set; }
        public double ValorTotal { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string StatusEmpleado { get; set; }
        public string EstadoEmpleado { get; set; }
        public decimal IdEmpleado { get; set; }
        public string CodigoEmpleado { get; set; }      

        public Image Logo { get; set; }

        public XROL_Rpt008_Info() { }
    }
}
