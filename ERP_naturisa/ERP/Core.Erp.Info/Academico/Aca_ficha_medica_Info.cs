using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_ficha_medica_Info
    {

        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public string GrupoSanguineoCatalogo { get; set; }
        public string MedicaContraIndic { get; set; }
        public string SeguroMedico { get; set; }
        public string OtrasIndicacionesMedicas { get; set; }

        public Aca_ficha_medica_Info() { }
    }
}
