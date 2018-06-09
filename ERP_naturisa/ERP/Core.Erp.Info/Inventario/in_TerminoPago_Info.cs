using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_TerminoPago_Info
    {
        public int IdTerminoPago { get; set; }
        public string Descripcion { get; set; }
        public int Dias { get; set; }
        public string Estado { get; set; }

        public in_TerminoPago_Info() { }
    }
}
