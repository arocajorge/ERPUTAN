using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_guia_remision_det_x_fa_orden_Desp_det_Info
    {
        public int gi_IdEmpresa { get; set; }
        public int gi_IdSucursal { get; set; }
        public int gi_IdBodega { get; set; }
        public decimal gi_IdGuiaRemision { get; set; }
        public int gi_Secuencia { get; set; }
        public decimal gi_IdProducto { get; set; }

        public double gi_cantidad { get; set; }
        public int od_IdEmpresa { get; set; }
        public int od_IdSucursal { get; set; }
        public int od_IdBodega { get; set; }
        public decimal od_IdOrdenDespacho { get; set; }
        public int od_Secuencia { get; set; }
        public decimal od_IdProducto { get; set; }
        
        public fa_guia_remision_det_x_fa_orden_Desp_det_Info() { }
    }
}
