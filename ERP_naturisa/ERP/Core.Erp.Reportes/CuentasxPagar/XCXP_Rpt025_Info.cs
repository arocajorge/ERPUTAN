using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt025_Info
    {
        public string nom_Centro_costo { get; set; }
        public string nom_subCentro_costo { get; set; }
        public int IdEmpresa { get; set; }
        public string IdTipo_op { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<int> Secuencia_OP { get; set; }
        public string IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public string Nom_Beneficiario { get; set; }
        public System.DateTime Fecha_Fa_Prov { get; set; }
        public string Observacion { get; set; }
        public double Valor_a_pagar { get; set; }
        public double Saldo_x_Pagar_OP { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSubCentro_Costo { get; set; }
        public string IdFormaPago { get; set; }
    }
}
