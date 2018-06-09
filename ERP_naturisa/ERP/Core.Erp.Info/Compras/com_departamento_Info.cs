using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
   public class com_departamento_Info
    {
       public int IdEmpresa { get; set; }
       public decimal IdDepartamento { get; set; }
       public string nom_departamento { get; set; }
       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string MotiAnula { get; set; }
       public string Estado { get; set; }


    }
}
