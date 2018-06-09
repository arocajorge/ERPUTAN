using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt032_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_OGiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public Nullable<int> IdTipoMovi { get; set; }
        public decimal Valor_a_aplicar { get; set; }
        public string Tipo_documento { get; set; }
        public Nullable<int> IdEmpresa_OP { get; set; }
        public Nullable<decimal> IdOrdenPago_OP { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public System.DateTime co_FechaFactura_vct { get; set; }
        public int co_plazo { get; set; }
        public string co_observacion { get; set; }
        public double co_baseImponible { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public string Codigo { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_centro_costo { get; set; }

        //campos adicionales
        public string em_Nombre { get; set; }
    }
}
