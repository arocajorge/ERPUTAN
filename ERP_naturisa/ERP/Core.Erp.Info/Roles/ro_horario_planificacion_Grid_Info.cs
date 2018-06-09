using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_horario_planificacion_Grid_Info
    {


        public class turnos
        {
            public int[] turno { get; set; }
            public int count { get; set; }
            public DateTime fecha { get; set; }
            public turnos()
            {
                turno = new int[20];

            }

        }
        public List<turnos> Listado { get; set; }
        public string Observacion { get; set; }

        public int IdEmpresa { get; set; }
        public int IdCalendario { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdRegistro { get; set; }
        public decimal IdHorario { get; set; }
        public string Estado { get; set; }
        public int secuencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdDepartamento { get; set; }
        public string de_Descripcion { get; set; }
        // campos para presentar el grid

        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string NomCompleto { get; set; }
        public string DescripcionTurno { get; set; }

        public decimal[] IdHorarioDia {get;set;}
        public decimal IdHorarioDia0 { get; set; }
        public decimal IdHorarioDia1 { get; set; }
        public decimal IdHorarioDia2 { get; set; }
        public decimal IdHorarioDia3 { get; set; }
        public decimal IdHorarioDia4 { get; set; }
        public decimal IdHorarioDia5 { get; set; }
        public decimal IdHorarioDia6 { get; set; }
        public decimal IdHorarioDia7 { get; set; }
        public decimal IdHorarioDia8 { get; set; }
        public decimal IdHorarioDia9 { get; set; }
        public decimal IdHorarioDia10 { get; set; }
        public decimal IdHorarioDia11 { get; set; }
        public decimal IdHorarioDia12 { get; set; }
        public decimal IdHorarioDia13 { get; set; }
        public decimal IdHorarioDia14 { get; set; }
        public decimal IdHorarioDia15 { get; set; }
        public decimal IdHorarioDia16 { get; set; }
        public decimal IdHorarioDia17 { get; set; }
        public decimal IdHorarioDia18 { get; set; }
        public decimal IdHorarioDia19 { get; set; }
        public decimal IdHorarioDia20 { get; set; }
        public decimal IdHorarioDia21 { get; set; }
        public decimal IdHorarioDia22 { get; set; }
        public decimal IdHorarioDia23 { get; set; }
        public decimal IdHorarioDia24 { get; set; }
        public decimal IdHorarioDia25 { get; set; }
        public decimal IdHorarioDia26 { get; set; }
        public decimal IdHorarioDia27 { get; set; }
        public decimal IdHorarioDia28 { get; set; }
        public decimal IdHorarioDia29 { get; set; }
        public decimal IdHorarioDia30 { get; set; }
        public decimal IdHorarioDia31 { get; set; }
        public Boolean checkcambiaturno { get; set; }
        public string Departamento { get; set; }
        public string ca_descripcion { get; set; }


        public ro_horario_planificacion_Grid_Info()
        {
            IdHorarioDia = new decimal[32];
            Listado = new List<turnos>();
            //IdHorarioDia1 = Convert.ToInt32(IdHorarioDia[0]);
            //IdHorarioDia2 = Convert.ToInt32(IdHorarioDia[1]);

        }
    }
}
