using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.SeguridadAcceso
{
    public class seg_usuario_info
    {

        public string IdUsuario { get; set; }
        public string Contrasena { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string Nombre { get; set; }
        public bool? CambiarContraseniaSgtSesion { get; set; }
        public bool? ExigirDirectivaContrasenia { get; set; }

        public seg_usuario_info() { }

    }
}
