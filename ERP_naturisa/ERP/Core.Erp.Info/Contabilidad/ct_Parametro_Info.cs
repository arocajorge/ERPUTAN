using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Parametro_Info
    {
        //CJimenez
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_SaldoInicial { get; set; }
        public int IdTipoCbte_AsientoCierre_Anual { get; set; }
        public Boolean ? P_Se_Muestra_Todas_las_ctas_en_combos { get; set; }



        public ct_Parametro_Info() { }

    }
}
