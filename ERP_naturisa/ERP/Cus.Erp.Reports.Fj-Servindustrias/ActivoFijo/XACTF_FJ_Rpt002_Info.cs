using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public string Marca { get; set; }
        public string Af_Capacidad { get; set; }
        public string Modelo { get; set; }
        public string Num_Serie_Motor { get; set; }
        public Nullable<int> Anio_Fabricacion { get; set; }
        public string Factura_Serie { get; set; }
        public string Num_Factura { get; set; }
        public Nullable<System.DateTime> Fecha_compra { get; set; }
        public double Costo_Compra { get; set; }
        public Nullable<double> Garantia_Bancaria { get; set; }
        public Nullable<double> Monto_Canc { get; set; }
        public Nullable<double> MontoSol { get; set; }
        public Nullable<int> NumCuotas { get; set; }
        public Nullable<double> Pago_contado { get; set; }
        public string Institucion_prendada { get; set; }
        public Nullable<System.DateTime> Fecha_Avaluo { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public string Categoria { get; set; }
        public Nullable<System.DateTime> Af_Fecha_Venta { get; set; }
        public string Operacion { get; set; }
        public string Af_NumSerie_Chasis { get; set; }
        public double porcentaje_prendado { get; set; }
    }
}
