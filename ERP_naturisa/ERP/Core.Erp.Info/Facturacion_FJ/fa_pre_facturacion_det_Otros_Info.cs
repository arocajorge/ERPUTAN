using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_pre_facturacion_det_Otros_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdPreFacturacion { get; set; }
       public int secuencia { get; set; }
       public double Valor { get; set; }
       public string Nombre_Cobro { get; set; }
       public string Observacion { get; set; }

    }
}
