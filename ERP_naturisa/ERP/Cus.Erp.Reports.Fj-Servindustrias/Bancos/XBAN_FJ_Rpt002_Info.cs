using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt002_Info
   {
       public decimal IdConciliacion { get; set; }
       public int IdBanco { get; set; }
       public int IdPeriodo { get; set; }
       public string tc_TipoCbte { get; set; }
       public double cb_Valor { get; set; }
       public string cb_Observacion { get; set; }
       public string tipo_IngEgr { get; set; }
       public int IdEmpresa { get; set; }
       public string ba_descripcion { get; set; }
       public double cb_total { get; set; }
       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
