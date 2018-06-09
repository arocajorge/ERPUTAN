

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Acta_Finiquito_Info
    {

        public List<ro_Acta_Finiquito_Detalle_Info> oListRo_Acta_Finiquito_Detalle_Info = new List<ro_Acta_Finiquito_Detalle_Info>();

        public int IdEmpresa { get; set; }
        public decimal IdActaFiniquito { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdCausaTerminacion { get; set; }
        public decimal? IdContrato { get; set; }
        public int? IdCargo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public double UltimaRemuneracion { get; set; }
        public string Observacion { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado{ get; set; }
        public string MotiAnula { get; set; }
        public int? IdCodSectorial { get; set; }
        public Boolean? EsMujerEmbarazada { get; set; }
        public Boolean? EsDirigenteSindical { get; set; }
        public Boolean? EsPorDiscapacidad { get; set; }
        public Boolean? EsPorEnfermedadNoProfesional { get; set; }

        //DATOS DE LA VISTA
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime? FechaNcto { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string IdContrato_Tipo { get; set; }
        public string NumDocumento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string EstadoContrato { get; set; }
        public string ObservacionContrato { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Codigo { get; set; }
        public int IdNomina_Tipo { get; set; }
        public ro_Acta_Finiquito_Info() { }
    }
}
