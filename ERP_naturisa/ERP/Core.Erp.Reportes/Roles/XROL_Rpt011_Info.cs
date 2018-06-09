/*CLASE: XROL_Rpt011_Info
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
    public class XROL_Rpt011_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdArchivo { get; set; }
        public double Valor { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string NoCuenta { get; set; }
        public string CodigoEmpleado { get; set; }
        public Boolean pagacheque { get; set; }
        public string TipoCuenta { get; set; }
        public string em_SeAcreditaBanco { get; set; }
        public string EstadoEmpleado { get; set; }
        public string IdBancoEmpleado { get; set; }
        public Nullable<int> IdDivisionEmpleado { get; set; }
        public Nullable<int> IdArea { get; set; }
        public string StatusEmpleado { get; set; }
        public int IdNomina { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdPeriodo { get; set; }
        public string DescripcionNominaTipo { get; set; }
        public string DescripcionNominaTipoLiqui { get; set; }
        public string IdBancoArchivo { get; set; }
        public Nullable<int> IdDivisionArchivo { get; set; }
        public string DescripcionBancoEmpleado { get; set; }
        public System.DateTime FechaInicial { get; set; }
        public System.DateTime FechaFinal { get; set; }
        public int secuencia { get; set; }
        public Image Logo { get; set; }

        public XROL_Rpt011_Info() { }

    }
}
