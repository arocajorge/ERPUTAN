using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_Fact_x_Gastos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public string secuencia { get; set; }
        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public int IdEmpresa_og { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
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

        public decimal IdProveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_punto_cargo { get; set; }
        public Nullable<int> IdEmpresa_cli { get; set; }
        public Nullable<decimal> IdCliente_cli { get; set; }
        public string nom_Cliente { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public string Descripcion { get; set; }
        public string IdTipoGasto { get; set; }
        public string nom_Gasto { get; set; }
    }
}
