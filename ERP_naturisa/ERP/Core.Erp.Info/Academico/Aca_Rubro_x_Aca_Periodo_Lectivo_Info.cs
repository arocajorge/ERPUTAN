using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_Rubro_x_Aca_Periodo_Lectivo_Info
    {


        public int IdInstitucion_rub { get; set; }
        public int IdRubro { get; set; }
        public int IdInstitucion_per { get; set; }

        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public int IdPeriodo { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }



       //public int IdInstitucion { get; set; }
       //public string IdPeriodoLectivo { get; set; }
       //public int IdRubro { get; set; }
       //public string IdAnioLectivo { get; set; }
       //public decimal Valor { get; set; }
       //public string Estado { get; set; }
       public string Existe_en_Base { get; set; }
       public DateTime FechaInicio { get; set; }
       public DateTime FechaFin { get; set; }

       public string UsuarioCreacion { get; set; }
       public Nullable<System.DateTime> FechaCreacion { get; set; }
       public string UsuarioModificacion { get; set; }
       public Nullable<System.DateTime> FechaModificacion { get; set; }
       public string UsuarioAnulacion { get; set; }
       public Nullable<System.DateTime> FechaAnulacion { get; set; }
       public string MotivoAnulacion { get; set; }


       public bool chequeo { get; set; }

    }
}
