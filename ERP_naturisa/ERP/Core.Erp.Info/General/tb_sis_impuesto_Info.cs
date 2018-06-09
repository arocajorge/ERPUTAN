using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
   public class tb_sis_impuesto_Info
    {
       public string IdCod_Impuesto { get; set; }
       public string nom_impuesto { get; set; }
       public bool Usado_en_Ventas { get; set; }
       public bool Usado_en_Compras { get; set; }
       public double porcentaje { get; set; }
       public int ? IdCodigo_SRI { get; set; }
       public string IdTipoImpuesto { get; set; }
       public bool estado { get; set; }

       public tb_sis_Impuesto_x_ctacble_Info Info_sis_Impuesto_x_ctacble { get; set; }

       public tb_sis_impuesto_Info()
       {
           Info_sis_Impuesto_x_ctacble = new tb_sis_Impuesto_x_ctacble_Info();

       }



    }
}
