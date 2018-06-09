using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_modulo_Info
    {

        public string CodModulo { get; set; }
        public string Descripcion { get; set; }
        public string Nom_Carpeta { get; set; }
        public Nullable<bool> Se_Cierra { get; set; }
        public tb_modulo_Info() { }
    }
}
