using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
  public  class XCAJ_Rpt005_Info
  {
      public int IdEmpresa { get; set; }
      public string em_nombre { get; set; }
      public int IdSucursal { get; set; }
      public string Su_Descripcion { get; set; }
      public int IdCaja { get; set; }
      public string ca_Descripcion { get; set; }
      public int IdTipoMovi { get; set; }
      public string tm_descripcion { get; set; }
      public System.DateTime cm_fecha { get; set; }
      public string IdUsuario { get; set; }
      public string IdCobro_tipo { get; set; }
      public string tc_descripcion { get; set; }
      public decimal IdCbteCble { get; set; }
      public int IdTipocbte { get; set; }
      public string cr_Banco { get; set; }
      public string cr_cuenta { get; set; }
      public string cr_NumDocumento { get; set; }
      public double cr_Valor { get; set; }
      public string cm_Signo { get; set; }
      public string Ingreso_Egreso { get; set; }
    }
}
