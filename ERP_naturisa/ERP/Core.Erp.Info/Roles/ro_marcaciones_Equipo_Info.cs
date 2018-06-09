using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//V 15.11.13 K 17:00
namespace Core.Erp.Info.Roles
{
    public class ro_marcaciones_Equipo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdEquipoMar { get; set; }
        public string Nombre_Equipo { get; set; }
        public string Modelo_Equipo { get; set; }
        public string TipoBd { get; set; }
        public string CadenaConexion { get; set; }
        public string Tabla_Vista { get; set; }
        public string FormatoFecha { get; set; }
        public string FormatoHora { get; set; }
        public System.DateTime FechaUltimaImportacionMarcaiones { get; set; }
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



        public ro_marcaciones_Equipo_Info()
        {

        }

    }
}
