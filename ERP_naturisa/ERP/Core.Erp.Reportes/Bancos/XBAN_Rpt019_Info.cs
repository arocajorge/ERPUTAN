using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt019_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipocbte{ get; set; }
        public decimal IdCbteCble{ get; set; }
        public decimal IdCbteCble_Ogiro{ get; set; }
        public string Referencia	{ get; set; }
        public double MontoAplicado{ get; set; }
        public string co_observacion{ get; set; }
        public DateTime co_fecha { get; set; }
    }
}
