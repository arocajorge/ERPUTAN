using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt019_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCaja { get; set; }
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }

        public int? IdEmpresa_op { get; set; }
        public decimal? IdOrdenPago_op { get; set; }
        public string ca_Descripcion { get; set; }
        public int IdEmpresa_OGiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }

        public int IdTipoCbte_Ogiro { get; set; }

        public DateTime? co_fechaOg { get; set; }
        public DateTime? co_FechaFactura { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public double? co_valorpagar { get; set; }
        public string co_observacion { get; set; }
        public string Nombre { get; set; }

        public string Beneficiario { get; set; }
        public string nomEmpresa { get; set; }



    }
}
	
	
