using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_x_in_Ing_Egr_Inven_Info
    {
        public int IdEmpresa_fa { get; set; }
        public int IdSucursal_fa { get; set; }
        public int IdBodega_fa { get; set; }
        public decimal IdCbteVta_fa { get; set; }
        public int IdEmpresa_in_eg_x_inv { get; set; }
        public int IdSucursal_in_eg_x_inv { get; set; }
        public int IdMovi_inven_tipo_in_eg_x_inv { get; set; }
        public decimal IdNumMovi_in_eg_x_inv { get; set; }
        public string observacion { get; set; }
    }
}
