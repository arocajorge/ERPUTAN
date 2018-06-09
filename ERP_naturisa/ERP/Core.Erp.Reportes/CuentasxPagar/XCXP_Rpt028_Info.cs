using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt028_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdCaja { get; set; }
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }
        public decimal IdOrdenPago { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public string IdTipo_op { get; set; }
        public System.DateTime Fecha_OP { get; set; }
        public double Valor_a_pagar { get; set; }
        public string Referencia { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public double debe { get; set; }
        public double haber { get; set; }

        public string SubCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Observacion_OP { get; set; }
        public string Estado_Conciliacion { get; set; }

    }
}
