using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Beca_Info
    {

        public int IdInstitucion { get; set; }
        public int IdBeca { get; set; }
        public Nullable<int> IdRubro { get; set; }
        public string nom_beca { get; set; }
        public double porcentaje { get; set; }
        public string estado { get; set; }

        public DateTime FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }


    }
}
