using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_ubicacion_Info
    {
        public string IdUbicacion { get; set; }
        public string IdUbicacion_Padre { get; set; }
        public string ub_descripcion { get; set; }
        public string Estado { get; set; }
        public int ub_posicion { get; set; }
        public int ub_nivel { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        

        public tb_ubicacion_Info() { }
    }
}
