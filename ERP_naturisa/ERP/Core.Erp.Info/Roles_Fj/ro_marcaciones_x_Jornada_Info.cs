using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_marcaciones_x_Jornada_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRegistro { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Id_nomina_Tipo { get; set; }
        public double Sueldo_Actual { get; set; }
        public string IdTipoMarcaciones { get; set; }
        public int IdJornada { get; set; }
        public Nullable<TimeSpan> es_Hora_ingreso_jornada1 { get; set; }
        public Nullable<TimeSpan> es_Hora_salida_jornada1 { get; set; }
        public Nullable<TimeSpan> es_Hora_ingreso_jornada2 { get; set; }
        public Nullable<TimeSpan> es_Hora_salida_jornada2 { get; set; }
        public double es_tot_horasTrabajadas { get; set; }
        public DateTime? es_fechaRegistro { get; set; }
        public DateTime? Total_Horas { get; set; }
        public Nullable<int> es_anio { get; set; }
        public Nullable<int> es_mes { get; set; }
        public Nullable<int> es_semana { get; set; }
        public Nullable<int> es_dia { get; set; }
        public string es_sdia { get; set; }
        public Nullable<int> es_idDia { get; set; }
        public string pe_cedula { get; set; }
        public string nomina { get; set; }
        public string pe_NombreCompleto { get; set; }
        public int secuencia { get; set; }
        public string em_codigo { get; set; }
        public string error { get; set; }
        public bool check { get; set; }
        public string dia { get; set; }
        public double Horas_25 { get; set; }
        public double Horas_50 { get; set; }
        public double Horas_100 { get; set; }
        public double Valor { get; set; }
        public string EsFeriado { get; set; }
        // campos para el rango de fecha de remplazo
        public DateTime? es_Fech_remplazo { get; set; }
        public ro_Grupo_empleado_Info grupo { get; set; }
        public ro_marcaciones_x_Jornada_Info()
        {
            grupo = new ro_Grupo_empleado_Info();
        }
    }
}
