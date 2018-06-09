using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.SeguridadAcceso
{
   public class seg_Menu_info
    {

        public int IdMenu { get; set; }
        public Nullable<int> IdMenuPadre { get; set; }
        public string DescripcionMenu { get; set; }
        public int PosicionMenu { get; set; }
        public bool Habilitado { get; set; }
        public bool Tiene_FormularioAsociado { get; set; }
        public string nom_Formulario { get; set; }
        public string nom_Asembly { get; set; }
        public byte[] imagen_grande { get; set; }
        public byte[] imagen_peque { get; set; }
        public byte[] icono { get; set; }
        public Nullable<int> nivel { get; set; }


        public seg_Menu_info() { }
    }
}
