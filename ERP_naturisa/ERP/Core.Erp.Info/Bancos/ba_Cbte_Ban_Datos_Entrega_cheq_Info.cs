using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
   public class ba_Cbte_Ban_Datos_Entrega_cheq_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdCbteCble { get; set; }
       public int IdTipocbte { get; set; }
       public System.DateTime fecha_hora_entrega { get; set; }
       public string IdEstado_cheque_cat { get; set; }
       public decimal IdPersona_Entrega { get; set; }
       public string Nota_entrega { get; set; }
       public System.DateTime fecha_trans { get; set; }
       public string usuario { get; set; }

       
    }
}
