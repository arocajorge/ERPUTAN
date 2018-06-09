using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_parametro_x_pago_variable_Det_Info
   {
       public int Idempresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public int Id_Tipo_Pago_Variable { get; set; }
       public string cod_Pago_Variable { get; set; }
       public double Meta { get; set; }
       public double Variable_porcentaje_prorrateado { get; set; }
       public bool icono_eliminar { get; set; }
    }
}
