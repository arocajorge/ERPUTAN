using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_AnioPeriodo_Activo_Info
    {
        public int IdInstitucion { get; set; }
        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public string AnioLectivo { get; set; }


        public int IdPeriodo { get; set; }
        public int pe_anio { get; set; }
        public int pe_mes { get; set; }
        public string EstadoAnioLectivo { get; set; }
        public string EstadoAperturaPeriodo { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string pe_estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

    }
}
