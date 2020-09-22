using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Distribucion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }

        public string IdUsuario { get; set; }
    }
}
