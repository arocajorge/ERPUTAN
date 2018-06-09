using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt030_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public Decimal IdCbteCble_Ogiro { get; set; }
        public string pr_nombre { get; set; }
        public string NumDocumento { get; set; }
        public string co_observacion { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Double co_Por_iva { get; set; }
        public Double co_valoriva { get; set; }
        public Double co_subtotal_iva { get; set; }
        public Double co_subtotal_siniva { get; set; }
        public Double co_baseImponible { get; set; }
        public Double co_total { get; set; }
        public string co_vaCoa { get; set; }
        public int? IdIden_credito { get; set; }
        public string Codigo { get; set; }
        public string codigoSRI { get; set; }
        public string co_descripcion { get; set; }
        public string TipoServicio { get; set; }
        public Nullable<System.DateTime> co_FechaContabilizacion { get; set; }
        //campos adicionales
        public string em_Nombre { get; set; }
    }
}
