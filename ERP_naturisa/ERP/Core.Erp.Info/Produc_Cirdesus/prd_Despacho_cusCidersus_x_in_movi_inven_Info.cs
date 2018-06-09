using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_Despacho_cusCidersus_x_in_movi_inven_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int dp_IdEmpresa { get; set; }
        public int dp_IdSucursal { get; set; }
        public decimal dp_IdDespacho { get; set; }

        public prd_Despacho_cusCidersus_x_in_movi_inven_Info(){}
    }
}
