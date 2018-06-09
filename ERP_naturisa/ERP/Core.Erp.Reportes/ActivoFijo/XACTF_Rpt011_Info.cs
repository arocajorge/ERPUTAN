using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.ActivoFijo
{
  public  class XACTF_Rpt011_Info
    {
      //declaro las respectivas variables de la clase info
      public int IdEmpresa { get; set; }
      public decimal IdDepreciacion { get; set; }
      public int IdPeriodo { get; set; }
      public string nom_activo { get; set; }
      public string nom_tipo_depreciacion { get; set; }
      public double Af_costo_compra { get; set; }
      public double Valor_Depre_Acum { get; set; }
      public double Dep_Actual { get; set; }
      public double Porc_Depreciacion { get; set; }
      public double? Valor_dep_Ant { get; set; }
      public string Estado { get; set; }
      public int IdActijoFijoTipo { get; set; }
      public string nom_ActijoFijoTipo { get; set; }
      public int IdCategoriaAF { get; set; }
      public string nom_CategoriaAF { get; set; }

      public  XACTF_Rpt011_Info(){}

    }
}
