
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
namespace Core.Erp.Info.Roles
{
    public class ro_permiso_x_empleado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPermiso { get; set; }
        public string IdEstadoAprob { get; set; }
        public Nullable<decimal> IdEmpleado_Apro { get; set; }
        public Nullable<decimal> IdEmpleado_Soli { get; set; }
        public string IdTipoLicencia { get; set; }
        public string Id_Forma_descuento_permiso_Cat { get; set; }
        public Nullable<int> Dias_tomados { get; set; }
        public System.DateTime Fecha { get; set; }
        public string MotivoAusencia { get; set; }
        public System.TimeSpan TiempoAusencia { get; set; }
        public string FormaRecuperacion { get; set; }
        public string MotivoAproba { get; set; }
        public string Observacion { get; set; }
        public Nullable<bool> EsLicencia { get; set; }
        public Nullable<bool> EsPermiso { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<bool> LLegoAtrasado { get; set; }
        public Nullable<System.TimeSpan> HorasAtraso { get; set; }
        public Nullable<System.TimeSpan> HoraSalida { get; set; }
        public Nullable<System.TimeSpan> HoraRegreso { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string MotivoAnulacion { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string NomEmpleado { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string em_codigo { get; set; }
	    public ro_permiso_x_empleado_Info(){ }
    }
}
