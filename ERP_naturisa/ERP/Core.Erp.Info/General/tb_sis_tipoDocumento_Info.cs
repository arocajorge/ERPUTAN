using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_tipoDocumento_Info
    {
        public string IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public int Posicion { get; set; }
        public string Estado { get; set; }

        public tb_sis_tipoDocumento_Info() { }
    }
}
