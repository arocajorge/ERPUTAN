using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    /// <summary>
    /// 26122013 
    /// </summary>
    /// 

    public class ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public string CodTipoCbteBan { get; set; }
        public int IdTipoCbteCble { get; set; }
        public int IdTipoCbteCble_Anu { get; set; }
        public string IdCtaCble { get; set; }
        public string Tipo_DebCred { get; set; }

        public string nom_TipoCbteBan { get; set; }



        public ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info()
        {

        }
    }
}
