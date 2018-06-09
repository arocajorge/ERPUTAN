using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public class ro_Historico_Liquidacion_Vacaciones_Det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNominatipo { get; set; }
       public int IdSolicitud_Vacaciones { get; set; }
       public decimal IdEmpleado { get; set; }
       public int Sec { get; set; }

       public int Anio { get; set; }
       public int Mes { get; set; }
       public double Total_Remuneracion { get; set; }
       public double Total_Vacaciones { get; set; }
       public double Valor_Cancelar { get; set; }
    }
}
