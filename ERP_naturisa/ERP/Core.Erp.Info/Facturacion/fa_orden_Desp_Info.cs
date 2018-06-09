using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_orden_Desp_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdOrdenDespacho { get; set; }
        public string CodOrden { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdTransportista { get; set; }
        public DateTime od_fecha { get; set; }
        public int od_plazo { get; set; }
        public DateTime od_fech_venc { get; set; }
        public string od_Observacion { get; set; }
        public float od_TotalKilos { get; set; }
        public float od_TotalQuintales { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }

        public Boolean Chek { get; set; }
        public List<fa_orden_Desp_det_Info> listaDetalle = new List<fa_orden_Desp_det_Info>();
        public List<fa_orden_Desp_valor_Info> listaValores = new List<fa_orden_Desp_valor_Info>();

        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string Vendedor { get; set; }
        public decimal Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public double Precio { get; set; }
        public double Precio_Final { get; set; }
        public string MotivoAnu { get; set; }
        public string od_DespAbierto { get; set; }


        public decimal IdPedido { get; set; }
        public decimal IdProducto { get; set; }

        public List<fa_orden_Desp_det_Info> ListaDetalle { get; set; }
        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> DespachoxPedido{ get; set; }
        public List<fa_orden_Desp_det_x_fa_pedido_det_Info> ListaAuxiliar { get; set; }

        public List<fa_guia_remision_det_x_fa_orden_Desp_det_Info> ListaGuiaRemision { get; set; }


        public fa_orden_Desp_Info() 
        {
            ListaDetalle = new List<fa_orden_Desp_det_Info>();
            DespachoxPedido = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
            ListaAuxiliar = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();

            ListaGuiaRemision = new List<fa_guia_remision_det_x_fa_orden_Desp_det_Info>();
        }
    }
}
