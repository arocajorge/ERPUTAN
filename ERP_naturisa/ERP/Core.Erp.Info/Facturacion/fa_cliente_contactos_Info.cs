using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
     public class fa_cliente_contactos_Info
    {
        public int IdEmpresa_cli { get; set; }
        public decimal IdCliente { get; set; }
        public int IdEmpresa_cont { get; set; }
        public decimal IdContacto { get; set; }
        public string observacion { get; set; }

        public tb_contacto_Info Contacto_Info { get; set; }
        public fa_Cliente_Info  Cliente_Info { get; set; }

        public fa_cliente_contactos_Info()
        {
            Contacto_Info = new tb_contacto_Info();
            Cliente_Info = new fa_Cliente_Info();
        }
    }
}
