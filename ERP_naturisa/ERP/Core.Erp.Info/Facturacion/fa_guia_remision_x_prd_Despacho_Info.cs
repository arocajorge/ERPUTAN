using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_guia_remision_x_prd_Despacho_Info
    {
        public int IdEmpresa_guia { get; set; }
        public int IdSucursal_guia { get; set; }
        public int IdBodega_guia { get; set; }
        public decimal IdGuiaRemision_guia { get; set; }
        public int IdEmpresa_des { get; set; }
        public int IdSucursal_des { get; set; }
        public string IdCentroCosto_des { get; set; }
        public decimal IdDespacho_des { get; set; }


    }
}
