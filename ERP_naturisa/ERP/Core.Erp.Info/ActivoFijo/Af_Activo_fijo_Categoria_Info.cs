using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
   public class Af_Activo_fijo_Categoria_Info
    {
       
       public int IdEmpresa { get; set; }
       public int IdCategoriaAF { get; set; }
       public int IdActivoFijoTipo { get; set; }
       public string CodCategoriaAF { get; set; }
       public string Descripcion { get; set; }
       public string Descripcion2 { get; set; }
       public string IdUsuario { get; set; }
       public string Estado { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string MotiAnula { get; set; }

       //datos de consulta 
       public string Tipo_Descripcion { get; set; }

       
    }
}
