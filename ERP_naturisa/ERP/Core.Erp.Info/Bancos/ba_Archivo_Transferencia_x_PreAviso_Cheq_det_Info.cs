using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
   public class ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info
    {
       public int IdEmpresa { get; set; }
       public decimal IdArchivo_preaviso_cheq { get; set; }
       public int secuencia { get; set; }
       public string observacion_det { get; set; }

       public int IdEmpresa_mvba { get; set; }
       public decimal IdCbteCble_mvba { get; set; }
       public int IdTipocbte_mvba { get; set; }

       public DateTime cb_Fecha { get; set; }
       public string cb_Observacion { get; set; }
       public string cb_Cheque { get; set; }
       public double cb_Valor { get; set; }
       public string CodTipoCbte { get; set; }
       public string cb_giradoA { get; set; }


    }
}
