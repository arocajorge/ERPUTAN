using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt022_Info
    {
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Nota { get; set; }
        public int IdTipoCbte_Nota { get; set; }
        public string DebCre { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdSucursal { get; set; }
        public System.DateTime cn_fecha { get; set; }
        public Nullable<System.DateTime> cn_FechaNota { get; set; }
        public string cn_serie1 { get; set; }
        public string cn_serie2 { get; set; }
        public string cn_Nota { get; set; }
        public string cn_observacion { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_sucCentro_costo { get; set; }
        public string IdTipoNota { get; set; }
        public string nom_cuenta { get; set; }
        public double cn_subtotal_iva { get; set; }
        public double cn_subtotal_siniva { get; set; }
        public double cn_baseImponible { get; set; }
        public decimal cn_total { get; set; }

        public double dc_Valor_Debe { get; set; }
        public double dc_Valor_Haber { get; set; }
    }
}
