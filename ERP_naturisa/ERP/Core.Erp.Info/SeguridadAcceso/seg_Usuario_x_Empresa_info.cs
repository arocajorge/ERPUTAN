using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.SeguridadAcceso
{
    public class seg_Usuario_x_Empresa_info
    {

        public string IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string Observacion { get; set; }


        public string em_nombre { get; set; }
        public string em_ruc { get; set; }


        public seg_Usuario_x_Empresa_info() { }

    }
}
