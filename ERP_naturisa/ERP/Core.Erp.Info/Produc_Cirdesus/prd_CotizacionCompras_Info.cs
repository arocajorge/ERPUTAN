using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
   public class prd_CotizacionCompras_Info
    {
         public int IdCotizacion { get; set; }
         public int IdEmpresa { get; set; }
         public int IdSucursal { get; set; }
         public string Observacion { get; set; }
         public string Estado { get; set; }

         public DateTime FechaReg { get; set; }
    }
}
