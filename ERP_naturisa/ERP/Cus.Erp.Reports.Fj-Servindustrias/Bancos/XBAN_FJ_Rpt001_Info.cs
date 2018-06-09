using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Bancos
{
  public  class XBAN_FJ_Rpt001_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdCbteCble { get; set; }
      public int IdTipocbte { get; set; }
      public Nullable<System.DateTime> cb_FechaCheque { get; set; }
      public string cb_Cheque { get; set; }
      public string pe_nombreCompleto { get; set; }
      public double cb_Valor { get; set; }
      public string ca_descripcion { get; set; }
      public System.DateTime cb_Fecha { get; set; }
      public string Nombre { get; set; }
      public string cb_Observacion { get; set; }
      public string em_nombre { get; set; }
      public byte[] em_logo { get; set; }
    }
}
