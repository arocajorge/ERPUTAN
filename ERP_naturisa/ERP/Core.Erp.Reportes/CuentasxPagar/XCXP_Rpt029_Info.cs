using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt029_Info
    {
        public int IdEmpresa { get; set; }
        public string em_nombre { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string Factura { get; set; }
        public string NumRetencion { get; set; }
        public Double? co_Por_iva { get; set; }
        public Double? co_valoriva { get; set; }
        public Double? co_subtotal_iva { get; set; }
        public Double? co_subtotal_siniva { get; set; }
        public DateTime? fecha { get; set; }
        public Double? Base_Fuente { get; set; }
        public Double? Diferencia { get; set; }
        public string Tiene_retencion { get; set; }
        public string re_tipoRet { get; set; }
    }
}
