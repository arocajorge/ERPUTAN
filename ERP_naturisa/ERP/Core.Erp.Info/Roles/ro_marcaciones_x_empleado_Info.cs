using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Info.Roles
{
    public class ro_marcaciones_x_empleado_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRegistro { get; set; }
        public decimal IdEmpleado { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public string IdTipoMarcaciones { get; set; }
        public decimal secuencia { get; set; }
        public TimeSpan? es_Hora { get; set; }
        public DateTime? es_fechaRegistro { get; set; }
        public Nullable<int> es_anio { get; set; }
        public Nullable<int> es_mes { get; set; }
        public Nullable<int> es_semana { get; set; }
        public Nullable<int> es_dia { get; set; }
        public string es_sdia { get; set; }
        public Nullable<int> es_idDia { get; set; }
        public string es_EsActualizacion { get; set; }
        public string NomCompleto { get; set; }
        public string em_codigo { get; set; }
        public string Codigo_Biometrico { get; set; }
        public string existeerror { get; set; }
        public bool check { get; set; }
        public string IdTipoMarcaciones_Biometrico { get; set; }
        // datos marcaciones externa
        public string cedula { get; set; }
        public TimeSpan? HMarcacion { get; set; }
        public bool Si_empleadoExisteBaseVZEN { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string  Error { get; set; }
        public DateTime FechaUltimoCorte { get; set; }
        public int IdEquipo { get; set; }

        public Nullable<System.DateTime> FechaCreaccion { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string Ip { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string Motivo_Anu { get; set; }
        public string  Jornada { get; set; }
        public TimeSpan? es_Hora_Salida { get; set; }
        public ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info info_novedad_x_ingreso { get; set; }
        public bool es_jornada_desfasada { get; set; }
        public int IdTurno { get; set; }
        public int IdNomina_Tipo { get; set; }

        public ro_marcaciones_x_empleado_Info()
        {
            info_novedad_x_ingreso = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info();
        }

    }
     
 }

