using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produccion_Talme
{
    public class prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info
    {
        public int gp_IdEmpresa { get; set; }
        public int gp_IdSucursal { get; set; }
        public decimal gp_IdGestionAceria { get; set; }
        public int mv_IdEmpresa { get; set; }
        public int mv_IdSucursal { get; set; }
        public int mv_IdBodega { get; set; }
        public int mv_IdMovi_inven_tipo { get; set; }
        public decimal mv_IdNumMovi { get; set; }

        public prod_GestionProductivaAcero_CusTalme_x_in_movi_inven_Info()
        {

        }
    }
}
