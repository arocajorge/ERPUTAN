using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.SeguridadAcceso
{
    public class seg_Menu_x_Empresa_x_Usuario_info
    {

        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public int IdMenu { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }

        public string DescripcionMenu { get; set; }
        public int IdMenuPadre { get; set; }
        public bool SeModificoValor { get; set; }
        public bool Existe { get; set; }
        public bool Checkeado { get; set; }

        public seg_Menu_x_Empresa_x_Usuario_info() { }

    }
}
