using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Contrato_x_Estudiante_det_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdContrato { get; set; }
        public decimal IdRubro { get; set; }
        public decimal IdMatricula { get; set; }
        public decimal IdEstudiante { get; set; }
        public int IdParalelo { get; set; }
        public System.DateTime Fecha_matricula { get; set; }
       
        public string Descripcion_rubro { get; set; }
        public Nullable<double> Valor { get; set; }

        public int IdInstitucion_Per { get; set; }

        //public string IdAnioLectivo_Per { get; set; }
        public int IdAnioLectivo_Per { get; set; }

        public int IdPeriodo_Per { get; set; }
        public string est_apertura_periodo { get; set; }

        public Nullable<int> IdGrupoFE { get; set; }
        public string deb_cred { get; set; }
        public bool estado_rubro { get; set; }

        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public string Observacion { get; set; }
        public Nullable<bool> estado_rubro_contrato { get; set; }
        public Aca_Contrato_x_Estudiante_det_Info() { }
    }
}
