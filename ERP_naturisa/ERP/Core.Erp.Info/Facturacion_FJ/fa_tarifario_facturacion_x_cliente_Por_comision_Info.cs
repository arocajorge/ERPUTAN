using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_Por_comision_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdTarifario { get; set; }
       public int IdAnio { get; set; }
       public double porcentaje { get; set; }
       public System.DateTime Fecha_inicio { get; set; }
       public System.DateTime Fecha_Fin { get; set; }
    }
}
