using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class Cl_TipoCliente_Info
    {
        public int id { get; set; }
        public string CodCatalogo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

        public Cl_TipoCliente_Info() { }
    }
}
