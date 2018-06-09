using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_cbte_ban_verificado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int Secuencia { get; set; }
        public string tipo_IngEgr { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public int SecuenciaCbteCble { get; set; }
        public string observacion { get; set; }
        public ba_cbte_ban_verificado_Info()
        {

        }
    }
}
