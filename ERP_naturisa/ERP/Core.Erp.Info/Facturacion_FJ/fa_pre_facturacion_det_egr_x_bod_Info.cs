using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_egr_x_bod_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int secuencia { get; set; }
        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public int IdEmpresa_mov_inv { get; set; }
        public int IdSucursal_mov_inv { get; set; }
        public int IdBodega_mov_inv { get; set; }
        public int IdMovi_inven_tipo_mov_inv { get; set; }
        public decimal IdNumMovi_mov_inv { get; set; }
        public int Secuencia_det { get; set; }
        public string observacion_det { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<double> Costo_Uni { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<bool> Aplica_Iva { get; set; }
        public Nullable<double> Por_Iva { get; set; }
        public Nullable<double> Valor_Iva { get; set; }
        public Nullable<double> Total { get; set; }
        public Boolean Facturar { get; set; }
        public Nullable<decimal> IdTarifario { get; set; }
        public double Porc_ganancia { get; set; }

        public decimal IdProducto { get; set; }
        public string nom_Producto { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public string num_Factura { get; set; }
        public Nullable<double> Precio_compra_oc { get; set; }
        public Nullable<double> cantidad_egr { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_punto_cargo { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string nom_Cliente { get; set; }
        public Nullable<System.DateTime> cm_fecha { get; set; }
    }
}
