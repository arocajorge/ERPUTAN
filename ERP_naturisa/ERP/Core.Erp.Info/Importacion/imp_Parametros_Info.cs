using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_Parametros_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_DiarioFob { get; set; }
        public int IdTipoCbte_DiarioLiquidacion { get; set; }
        public int IdTipoCbte_DiarioFob_Anul { get; set; }
        public int IdTipoCbte_DiarioLiquidacion_Anul { get; set; }
        public string IdCtaCble_para_Importaciones { get; set; }
        public imp_Parametros_Info()
        {

        }

    }
}
