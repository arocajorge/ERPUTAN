using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
   public class in_movi_inve_detalle_x_ct_cbtecble_det_Info
    {

       public int IdEmpresa_inv { get; set; }
       public int IdSucursal_inv { get; set; }
       public int IdBodega_inv { get; set; }
       public int IdMovi_inven_tipo_inv { get; set; }
       public decimal IdNumMovi_inv { get; set; }
       public int Secuencia_inv { get; set; }
       public int IdEmpresa_ct { get; set; }
       public int IdTipoCbte_ct { get; set; }
       public decimal IdCbteCble_ct { get; set; }
       public int secuencia_ct { get; set; }
       public decimal Secuencial_reg { get; set; }
       public string observacion { get; set; }



    }
}
