/*CLASE: XROL_Rpt007_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 24-06-2015
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
    public class XROL_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdActaFiniquito { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdCausaTerminacion { get; set; }
        public Nullable<decimal> IdContrato { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public double UltimaRemuneracion { get; set; }
        public string Observacion { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public Nullable<bool> EsMujerEmbarazada { get; set; }
        public Nullable<bool> EsDirigenteSindical { get; set; }
        public Nullable<bool> EsPorDiscapacidad { get; set; }
        public Nullable<bool> EsPorEnfermedadNoProfesional { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string NomCompleto { get; set; }
        public int IdSecuencia { get; set; }
        public string DescripcionDetalle { get; set; }
        public string Signo { get; set; }
        public double Valor { get; set; }
        public Nullable<int> IdCargo { get; set; }
        public string DescripcionCargo { get; set; }
        public string NumDocumento { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string CodigoEmpleado { get; set; }

        public Image em_logo_Image { get; set; }

        public XROL_Rpt007_Info() { }

    }
}
