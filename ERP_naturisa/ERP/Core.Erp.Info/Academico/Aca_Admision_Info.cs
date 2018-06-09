using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Admision_Info
    {

        public int IdInstitucion { get; set; }
        public decimal IdAdmision { get; set; }
        public string CodAlterno { get; set; }
        public string CodAdmision { get; set; }
        public decimal IdAspirante { get; set; }

        ////public string  IdPeriodoLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public int IdCurso { get; set; }
        public int IdSede { get; set; }
        public int IdJornada { get; set; }
        public int IdSeccion { get; set; }
        public string IdCatalogoGrupoFamiliarConviviencia { get; set; }
        public string IdCatalogoTipoReligion { get; set; }
        public string IdCatalogoTipoSangre { get; set; }
        public string IdCatalogoIdiomaNativo { get; set; }
        public string TelefonoEmergente { get; set; }
        public bool PoseeDiscapacidad { get; set; }
        public bool HijoUnico { get; set; }
        public bool ActualAsisteEstableEducativo { get; set; }
        public string EstablecimientoEducativoDondeAsiste { get; set; }
        public bool TieneHermanosEnOtrosColegios { get; set; }
        public bool TieneHermanoEnNuestroColegio { get; set; }
        public string EnQueGradoTieneHermanos { get; set; }
        public bool HijoProfeDelColegio { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string Estado { get; set; }
        public string Base { get; set; }
        public string MotivoAnulacion { get; set; }
        
        public Aca_Aspirante_Info aspiranteInfo { get; set; }

      public Aca_Admision_Info() {          
          aspiranteInfo = new Aca_Aspirante_Info();
      }
    }
}
