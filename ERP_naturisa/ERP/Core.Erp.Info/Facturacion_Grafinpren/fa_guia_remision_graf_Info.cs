using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_Grafinpren
{
   public class fa_guia_remision_graf_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public decimal IdGuiaRemision { get; set; }

       public string Num_OP { get; set; }
       public decimal? Num_Cotizacion { get; set; }
       public DateTime? fecha_Cotizacion { get; set; }
       public int IdEquipo { get; set; }
       public string nom_equipo { get; set; }
    }
}
