using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Academico
{
 public class Aca_Familiar_Info
    {

        public int IdInstitucion { get; set; }
        public decimal IdEstudiante  { get; set; }
        public decimal IdFamiliar { get; set; }
        public string CodFamiliar { get; set; }
        public decimal IdPersona { get; set; }
        public string IdNivelEducativo { get; set; }
        public string IdParentescoCat { get; set; }
        public string Titulo { get; set; }
        public string OcupacionLaboral { get; set; }
        public string EmpresaDondeTrabaja { get; set; }
        public string EmpresaDireccion { get; set; }
        public string EmpresaTelefono { get; set; }
        public string EmpresaEmail { get; set; }
        public bool EstaAutorizadoRetAlum { get; set; }
        public bool EstaAutorizadoRecAlumn { get; set; }
        public bool ViveConEl { get; set; }
        public string Calle_Principal { get; set; }
        public string Calle_Secundaria { get; set; }
        public string Sector_Urbanizacion { get; set; }
        public string IdCiudad { get; set; }
        public string IdProvincia { get; set; }
        public string IdPais { get; set; }
        public bool PoseeDiscapacidad { get; set; }
        public bool  ViveFueraDelPais { get; set; }
        public bool Fallecido { get; set; }
        public string IdCatalogoIdiomaNativo { get; set; }
        public string IdCatalogoTipoSangre { get; set; }
        public string IdCatalogoReligion { get; set; }
        public bool FueExAlumnoGraduado { get; set; }
        public bool Si_estoy_deacuerdo_foto { get; set; }
        public bool No_estoy_deacuerdo_foto { get; set; }
        public bool Cod_convivencia_doy_fe { get; set; }
        public string IdParentesco_cat { get; set; }
        public bool activo { get; set; }
        public Nullable<int> porcentaje_dual { get; set; }
       
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public tb_persona_Info  Persona_Info { get; set; }
        public string Nombres { get; set; }
        public bool check { get; set; }

        public Aca_Familiar_Info() {
            Persona_Info = new tb_persona_Info();
            
        }

    }
}
