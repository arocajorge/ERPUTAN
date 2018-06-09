using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public class ro_ConexionBiometrico_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBiometrico { get; set; }
        public string Modelo { get; set; }
        public string CadenaConexion { get; set; }
        public string NombreTabla { get; set; }
        public string FormatoFecha { get; set; }
        public string FormatoHora { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string TipoBD { get; set; }



    }
}
