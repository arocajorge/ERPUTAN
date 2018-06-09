using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_poliza_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_pol { get; set; }
        public decimal IdPoliza_pol { get; set; }
        public string cod_couta_pol { get; set; }
    }
}
