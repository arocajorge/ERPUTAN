using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo_FJ
{
    public class Af_Poliza_x_AF_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPoliza { get; set; }
        public int IdActivoFijo { get; set; }
        public int secuencia { get; set; }
        public string IdEstadoFacturacion_cat { get; set; }
        public Nullable<double> Subtotal_0 { get; set; }
        public Nullable<double> Subtotal_12 { get; set; }
        public Nullable<double> Iva { get; set; }
        public Nullable<double> Prima { get; set; }
        public string observacion_det { get; set; }
        public bool check { get; set; }
        public string Af_Nombre { get; set; }
    }
}
