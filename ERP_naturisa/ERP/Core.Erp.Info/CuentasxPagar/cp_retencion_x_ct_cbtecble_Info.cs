using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_retencion_x_ct_cbtecble_Info
    {
        public int rt_IdEmpresa { get; set; }
      //  public decimal rt_IdCbteCble_Ogiro { get; set; }
      //  public int rt_IdTipoCbte_Ogiro { get; set; }
        public decimal rt_IdRetencion { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }
        public string Observacion { get; set; }
        
        public cp_retencion_x_ct_cbtecble_Info()
        {

        }
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 14/02/2014 10:45
/// </summary>
