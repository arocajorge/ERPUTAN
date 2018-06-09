using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{
    public class fa_pedido_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string CodPedido { get; set; }
        public decimal IdPedido { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime cp_fecha { get; set; }
        public int cp_diasPlazo { get; set; }
        public DateTime cp_fechaVencimiento { get; set; }
        public string cp_observacion { get; set; }
        public string cp_tipopago { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string EstadoAprobacion { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        
        public List<fa_pedido_det_Info> lista_detalle = new List<fa_pedido_det_Info>();
        public List<fa_pedido_valor_Info> lista_valores = new List<fa_pedido_valor_Info>();
        //public tb_Bodega_Info bodega_info { get; set; }
        public string  Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string Vendedor { get; set; }
        public double Subtotal { get; set; }
        public double TOTAL { get; set; }

        public double Interes { get; set; }
        public double Trasnporte { get; set; }
        public double Otro1 { get; set; }
        public double Otro2 { get; set; }
        public string MotivoAnulacion { get; set; }

        public string Referencia { get; set; }

        public double saldo { get; set; }

        public Boolean Chek { get; set; }

        public List<fa_pedido_det_Info> ListaDetalle { get; set; }


        public List<fa_pedido_x_formaPago_Info> DetformaPago_list { get; set; }


        // campo de la vista vwFa_Total_pedidos_x_cliente_No_despachados
        public double dp_total { get; set; }


        public fa_pedido_Info() 
        {
            ListaDetalle = new List<fa_pedido_det_Info>();
            DetformaPago_list = new List<fa_pedido_x_formaPago_Info>();
        }

        public string Entregado { get; set; }

        public string IdEstadoProduccion { get; set; }
    }
}
