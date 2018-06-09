using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Caja
{
    public class caj_parametro_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbteCble_MoviCaja_Ing { get; set; }
        public int IdTipoCbteCble_MoviCaja_Egr { get; set; }
        public int IdTipoCbteCble_MoviCaja_Ing_Anu { get; set; }
        public int IdTipoCbteCble_MoviCaja_Egr_Anu { get; set; }
        public Nullable<int> IdTipo_movi_ing_x_reposicion { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime FechaUltMod { get; set; }

        public caj_parametro_Info()
        {

        }
    }
}
