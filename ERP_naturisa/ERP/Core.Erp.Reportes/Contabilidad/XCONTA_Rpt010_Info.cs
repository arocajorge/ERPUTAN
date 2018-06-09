using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
   public class XCONTA_Rpt010_Info
    {
       public int IdEmpresa { get; set; }
       public int ? IdPunto_cargo_grupo { get; set; }
       public int ? IdPunto_cargo { get; set; }
       public string IdCtaCble { get; set; }
       public string nom_Punto_cargo { get; set; }
       public double Saldo_Anterior { get; set; }
       public double Debito { get; set; }
       public double Credito { get; set; }
       public double Saldo_Total { get; set; }
       public string nom_empresa { get; set; }
       public string nom_periodo { get; set; }
       public int Anio { get; set; }
       public string nom_punto_cargo_grupo { get; set; }

    }
}
