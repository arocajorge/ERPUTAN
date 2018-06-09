using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_x_fa_guia_remision_info
    {
        public int fa_IdEmpresa { get; set; }
        public int fa_IdSucursal { get; set; }
        public int fa_IdBodega { get; set; }
        public decimal fa_IdCbteVta { get; set; }
        public int gi_IdEmpresa { get; set; }
        public int gi_IdSucursal { get; set; }
        public int gi_IdBodega { get; set; }
        public decimal gi_IdGuiaRemision { get; set; }
        public string Observacion { get; set; }

        

        public fa_factura_x_fa_guia_remision_info() { }
    }
}
