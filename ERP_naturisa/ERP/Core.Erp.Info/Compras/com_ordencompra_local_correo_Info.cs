using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_ordencompra_local_correo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public string Mensaje { get; set; }
        public string correo { get; set; }

        public string CorreoComprador { get; set; }

        public string CorreoProveedor { get; set; }

        public string pe_nombreCompleto { get; set; }

        public string pe_cedulaRuc { get; set; }
    }
}
