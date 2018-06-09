using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cliente_pto_emision_cliente_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public int IdPuntoEmision { get; set; }
        public string cod_ptoemision { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail1 { get; set; }
        public string mail2 { get; set; }
        public string Estado { get; set; }
    }
}
