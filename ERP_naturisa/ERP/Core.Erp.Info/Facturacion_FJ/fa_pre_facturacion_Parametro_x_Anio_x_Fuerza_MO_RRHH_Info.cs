using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info
   {
       public int IdEmpresa { get; set; }
       public int Anio { get; set; }
       public int Mes { get; set; }
       public int IdFuerza { get; set; }
       public decimal Porcentaje_Calculo_BS { get; set; }
       public decimal Porcentaje_Calculo_MO { get; set; }
       public System.DateTime Fecha_Inicio { get; set; }
       public System.DateTime Fecha_Fin { get; set; }
       public string periodo { get; set; }
    }
}
