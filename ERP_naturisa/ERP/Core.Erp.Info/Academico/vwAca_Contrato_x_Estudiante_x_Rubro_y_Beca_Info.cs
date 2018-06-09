using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_Contrato_x_Estudiante_x_Rubro_y_Beca_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdContrato { get; set; }
        public decimal IdEstudiante { get; set; }
        public int IdInstitucion_Per { get; set; }
        //public string IdAnioLectivo_Per { get; set; }
        public int IdAnioLectivo_Per { get; set; }

        public int IdPeriodo_Per { get; set; }
        public decimal IdRubro { get; set; }
        public string Descripcion_rubro { get; set; }
        public Nullable<double> Valor { get; set; }

    }
}
