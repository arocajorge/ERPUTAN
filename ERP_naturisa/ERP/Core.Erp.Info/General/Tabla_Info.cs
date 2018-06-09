using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.General
{
    public class Tabla_Info
    {
        public int IdTabla { get; set; }
        public string Nombre { get; set; }
        public int IdModulo { get; set; }
        public string TablaDB { get; set; }
        public string NameControl { get; set; }

        public Tabla_Info() { }

    }
}
