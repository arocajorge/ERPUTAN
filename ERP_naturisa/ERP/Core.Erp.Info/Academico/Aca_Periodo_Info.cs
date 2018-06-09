using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Periodo_Info
    {
        public int IdInstitucion { get; set; }
        public int IdPeriodo { get; set; }
        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public int pe_anio { get; set; }
        public int pe_mes { get; set; }
        public DateTime pe_FechaIni { get; set; }
        public DateTime pe_FechaFin { get; set; }
        public string pe_Descripcion { get; set; }
        public string pe_estado { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string est_apertura { get; set; }
        public bool check { get; set; }

        //ACA_RUBRO_x_ACA_PERIODO
        public double ValorRubro { get; set; }

        public Aca_Periodo_Info()
        {

        }
    }
}
