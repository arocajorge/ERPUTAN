using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_estudiante_x_Aca_Beca_Info
    {

       public int IdInstitucion { get; set; }
       public decimal IdEstudiante { get; set; }
       public int ? IdBeca1 { get; set; }
       public string  nom_beca1 { get; set; }
       public int ? IdBeca2 { get; set; }
       public string nom_beca2 { get; set; }
       public int ? IdBeca3 { get; set; }
       public string nom_beca3 { get; set; }
       public DateTime ? FechaEmisionBeca1 { get; set; }
       public DateTime ? FechaEmisionBeca2 { get; set; }
       public DateTime ? FechaEmisionBeca3 { get; set; }


    }
}
