/*CLASE: ro_Nomina_X_Horas_Extras_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 10-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Nomina_X_Horas_Extras_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public int IdCalendario { get; set; }
        public decimal IdTurno { get; set; }
        public decimal IdHorario { get; set; }

        public DateTime FechaRegistro { get; set; }


        public TimeSpan? time_entrada1 { get; set; }
        public TimeSpan? time_entrada2 { get; set; }
        public TimeSpan? time_salida1 { get; set; }
        public TimeSpan? time_salida2 { get; set; }

        public double hora_extra25 { get; set; }
        public double hora_extra50 { get; set; }
        public double hora_extra100 { get; set; }
        public double hora_atraso { get; set; }
        public double hora_temprano { get; set; }
        public double hora_trabajada { get; set; }

        public Boolean ? es_HorasExtrasAutorizadas { get; set; }


        //SEGURIDAD
        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }

        //VISTA
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string DescripcionHorario { get; set; }
        public string DiaSemana { get; set; }



        public ro_Nomina_X_Horas_Extras_Info() { }

    }
}
