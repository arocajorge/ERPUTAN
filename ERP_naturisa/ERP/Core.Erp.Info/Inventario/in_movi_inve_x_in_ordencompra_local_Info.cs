using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_movi_inve_x_in_ordencompra_local_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }      
        public int IdEmpresaOC { get; set; }
        public int IdSucursalOC { get; set; }
        public decimal IdOrdenCompra { get; set; }

        public in_movi_inve_x_in_ordencompra_local_Info(){}
    }
}
