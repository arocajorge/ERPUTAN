using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_TipoTransac_x_Cta_CbteCble_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTipTransActivoFijo { get; set; }
        public string IdCatalogo { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }


        public Af_TipoTransac_x_Cta_CbteCble_Info()
        {

        }
    }
}
