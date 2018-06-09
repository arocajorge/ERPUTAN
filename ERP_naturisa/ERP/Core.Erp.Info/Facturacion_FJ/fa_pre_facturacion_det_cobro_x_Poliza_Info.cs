using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_cobro_x_Poliza_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int secuencia { get; set; }
        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string Tipo_Cobro_Poliza_X { get; set; }
        public Nullable<int> IdEmpresa_pol_det { get; set; }
        public Nullable<decimal> IdPoliza_pol_det { get; set; }
        public Nullable<int> IdActivoFijo_pol_det { get; set; }
        public Nullable<int> secuencia_pol_det { get; set; }
        public Nullable<int> IdEmpresa_pol_cuota { get; set; }
        public Nullable<decimal> IdPoliza_pol_cuota { get; set; }
        public string cod_cuota_pol_cuota { get; set; }
        public Nullable<double> Cantidad { get; set; }
        public Nullable<double> Costo_Uni { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<bool> Aplica_Iva { get; set; }
        public Nullable<double> Por_Iva { get; set; }
        public Nullable<double> Valor_Iva { get; set; }
        public Nullable<double> Total { get; set; }
        public Boolean Facturar { get; set; }
        public double Porc_ganancia { get; set; }
        public Nullable<decimal> IdTarifario { get; set; }

        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string Af_Nombre { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string nom_Cliente { get; set; }
        public string nom_EstadoFacturacion_cat { get; set; }
    }
}
