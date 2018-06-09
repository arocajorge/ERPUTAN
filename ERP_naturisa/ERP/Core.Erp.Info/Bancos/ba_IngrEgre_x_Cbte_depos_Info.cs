using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_IngrEgre_x_Cbte_depos_Info
    {
        public int IdEmpresa { get; set; }
        public string TipoIngEgr { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }

        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string estado { get; set; }


        public ba_IngrEgre_x_Cbte_depos_Info(){}
    }
}
