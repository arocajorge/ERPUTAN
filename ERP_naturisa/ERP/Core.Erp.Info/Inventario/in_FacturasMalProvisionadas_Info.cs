using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_FacturasMalProvisionadas_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public DateTime cm_fecha { get; set; }
        public string Observacion { get; set; }
        public string num_documento { get; set; }
        public string pr_descripcion { get; set; }
        public double Cantidad { get; set; }
        public double Costo_uni { get; set; }
        public double SubTotal { get; set; }
        public double valor_Iva { get; set; }
        public double Total { get; set; }
        public string pe_nombreCompleto { get; set; }
        public double? dc_Valor { get; set; }
        public DateTime? cb_Fecha { get; set; }

        public string Agrupar { get; set; }
    }
}
