using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_contrato_x_estudiante_det_beca_Info
   {
       public int IdInstitucion { get; set; }
       public decimal IdContrato { get; set; }
       public decimal IdRubro { get; set; }
       public int IdInstitucion_Per { get; set; }

       //public string IdAnioLectivo_Per { get; set; }
       public int IdAnioLectivo_Per { get; set; }

       public int IdPeriodo_Per { get; set; }
       public int IdBeca { get; set; }
       public double valor_beca { get; set; }
       public double porc_beca { get; set; }
       public bool check { get; set; }

       public string Descripcion_rubro { get; set; }
       public double Valor { get; set; }
       public string Descripcion { get; set; }
       public System.DateTime pe_FechaIni { get; set; }
       public System.DateTime pe_FechaFin { get; set; }
       public int TieneBeca { get; set; }
       public string nom_beca { get; set; }

    }
}
