using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_orden_Desp_det_Info : fa_orden_Desp_Info
    {
        public int IdEmpresa { get; set; }
        public string producto { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdOrdenDespacho { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double od_cantidad { get; set; }
        public double od_Precio { get; set; }
        public double od_PorDescUnitario { get; set; }
        public double od_DescUnitario { get; set; }
        public double od_PrecioFinal { get; set; }
        public double od_Subtotal { get; set; }
        public double od_iva { get; set; }
        public double od_total { get; set; }
        public double od_costo { get; set; }
        public string od_tieneIVA { get; set; }
        public string od_detallexItems { get; set; }
        public string pr_descripcion { get; set; }
        public int SecuenciaPedido { get; set; }
        public decimal Saldo { get; set; }
        public decimal cantidaajus { get; set; }

        public decimal  IdPedido { get; set; }
        public decimal  od_pedido { get; set; }
        public float Peso { get; set; }

        // campo de la vista vwfa_orden_Desp_det_x_Pedido_det
        public string Tiene_guia { get; set; }

        public fa_orden_Desp_det_Info() { }
    }
}
