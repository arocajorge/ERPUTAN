using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_orden_Desp_det_x_fa_pedido_det_Info
    {
        public int od_IdEmpresa { get; set; }
        public int od_IdSucursal { get; set; }
        public int od_IdBodega { get; set; }
        public decimal od_IdOrdenDespacho { get; set; }
        public int od_Secuencia { get; set; }
        public decimal od_IdProducto { get; set; }
        public double od_cantidad { get; set; }
        public int pe_IdEmpresa { get; set; }
        public int pe_IdSucursal { get; set; }
        public int pe_IdBodega { get; set; }
        public decimal pe_IdPedido { get; set; }
        public int pe_Secuencia { get; set; }
        public decimal pe_IdProducto { get; set; }


        public fa_orden_Desp_det_x_fa_pedido_det_Info()
        {

        }
    }
}
