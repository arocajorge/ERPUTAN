using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_Grupo_empleado_det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdGrupo { get; set; }
       public string cod_Pago_Variable { get; set; }
       public double Porcentaje_calculo { get; set; }
       public bool icono_eliminar { get; set; }
       public string IdRubro { get; set; }
       public ero_parametro_x_pago_variable_tipo cod_Pago_Variable_enum { get; set; }
       public double Valor_bono { get; set; }


    }
}
