using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_cobro_x_Movilizacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrefacturacion { get; set; }
        public int secuencia { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<double> Movilizacion { get; set; }
        public bool Facturar { get; set; }
        public Nullable<decimal> IdTarifario { get; set; }
        public double Porc_ganancia { get; set; }
        public string nom_Centro_costo { get; set; }
        public string Af_Nombre { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_Cliente { get; set; }
        public int IdEmpresa_cli { get; set; }
        public decimal IdCliente_cli { get; set; }
    }
}
