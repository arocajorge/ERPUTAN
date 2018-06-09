
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Core.Erp.Info.Roles
{
    public class ro_Empleado_Novedad_Det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdNovedad { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Secuencia { get; set; }
        public DateTime FechaPago { get; set; }
        public double NumHoras { get; set; }
        public double Valor { get; set; }
        public string EstadoCobro { get; set; }
        public string Estado { get; set; }
        public string EstadoCab { get; set; }
        public string Observacion { get; set; }
        public string IdRol { get; set; }
        public string IdRubro { get; set; }
        public string ru_descripcion { get; set; }
        public string em_nombre { get; set; }
        public string em_cedula { get; set; }
        public string em_codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Boolean check { get; set; }
        public string ru_tipo { get; set; }
        public string IdCalendario { get; set; }
        //DATOS PARA COMPLEMENTAR LA VISTA
        public int IdNomina { get; set; }
        public int IdNominaLiqui { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fecha_Excel { get; set; }
        public string Nomina { get; set; }
        public Nullable<TimeSpan> es_Hora_ingreso_jornada1 { get; set; }
        public Nullable<TimeSpan> es_Hora_salida_jornada1 { get; set; }
        public Nullable<TimeSpan> es_Hora_ingreso_jornada2 { get; set; }
        public Nullable<TimeSpan> es_Hora_salida_jornada2 { get; set; }
        public double es_tot_horasTrabajadas { get; set; }
        public string existeerror { get; set; }
        public DateTime es_Fech_remplazo { get; set; }
        public ro_Empleado_Novedad_Det_Info()
        {
            FechaPago = DateTime.Now;
        }
    }
}
