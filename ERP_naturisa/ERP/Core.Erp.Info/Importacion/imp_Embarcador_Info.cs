using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_Embarcador_Info
    {
        public int IdEmpresa { get; set; }
        public int IdEmbarcador { get; set; }
        public string em_descripcion { get; set; }
        public string em_direccion { get; set; }
        public string em_telefono{ get; set; }
        public string em_contacto { get; set; }
        public string em_email { get; set; }
        public string Estado { get; set; }

        public imp_Embarcador_Info() { }
    }
}
