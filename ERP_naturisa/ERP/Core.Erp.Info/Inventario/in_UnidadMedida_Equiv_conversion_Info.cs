using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public  class in_UnidadMedida_Equiv_conversion_Info
    {


        public string IdUnidadMedida { get; set; }
        public string IdUnidadMedida_equiva { get; set; }
        public double valor_equiv { get; set; }
        public string interpretacion { get; set; }

       //Propiedad para el ingreso o egreso de un producto en su unidad de consumo
        public string IdUnidadMedida_Consumo { get; set; }

       public in_UnidadMedida_Equiv_conversion_Info()
       {

       }
    }
}
