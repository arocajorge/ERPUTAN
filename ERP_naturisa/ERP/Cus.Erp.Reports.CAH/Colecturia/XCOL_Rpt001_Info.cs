using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public class XCOL_Rpt001_Info
    {
        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public int IdCurso { get; set; }
        public int IdParalelo { get; set; }
        public decimal IdEstudiante { get; set; }
        public decimal IdMatricula { get; set; }
        public string CodMatricula { get; set; }
        public decimal IdContrato { get; set; }
        public string IdAnioLectivo { get; set; }
        public string Tipo_documento_cat { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public double vt_total { get; set; }

        public string Sede { get; set; }
        public string Jornada { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Paralelo { get; set; }


        public Nullable<bool> tiene_seguro { get; set; }
        public bool Cod_convivencia_doy_fe { get; set; }
    }
}
