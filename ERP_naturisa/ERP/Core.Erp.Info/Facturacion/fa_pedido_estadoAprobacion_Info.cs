using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_pedido_estadoAprobacion_Info
    {
        public string IdEstadoAprobacion { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public int posicion { get; set; }

        public fa_pedido_estadoAprobacion_Info() { }
    }
}
