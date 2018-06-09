/*CLASE: XROL_Rpt006_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 18-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt006_Info
    {
        public int iddepartamento { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public double hora_extra25 { get; set; }
        public double hora_extra50 { get; set; }
        public double hora_extra100 { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string EstadoEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Apellido { get; set; }
        public string CedulaRuc { get; set; }
        public string StatusEmpleado { get; set; }
        public int IdCalendario { get; set; }
        public double hora_atraso { get; set; }
        public double hora_temprano { get; set; }
        public Nullable<System.TimeSpan> time_entrada1 { get; set; }
        public Nullable<System.TimeSpan> time_entrada2 { get; set; }
        public Nullable<System.TimeSpan> time_salida1 { get; set; }
        public Nullable<System.TimeSpan> time_salida2 { get; set; }
        public double hora_trabajada { get; set; }
        public int IdTurno { get; set; }
        public decimal IdHorario { get; set; }
        public string DescripcionHorario { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string DescripcionDivision { get; set; }
        public string DescripcionCentroCosto { get; set; }
        public string IdCentroCosto { get; set; }
        public string DescripcionNominaTipoLiqui { get; set; }
        public string DescripcionNominaTipo { get; set; }
        public System.DateTime FechaInicial { get; set; }
        public System.DateTime FechaFinal { get; set; }
        public string CodigoEmpleado { get; set; }      

        public Image Logo { get; set; }

        public XROL_Rpt006_Info() { }
    }
}
