using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo_FJ
{
    public class Af_Poliza_x_AF_det_cuota_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPoliza { get; set; }
        public string cod_couta { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public double valor_prima { get; set; }
        public string IdEstadoCancelacion_cat { get; set; }
        public string IdEstadoFacturacion_cat { get; set; }
        public double Sub_total_12 { get; set; }
        public Nullable<double> Sub_total_0 { get; set; }
        public double Iva { get; set; }
        public string Observacion_detalle { get; set; }
    }
}
