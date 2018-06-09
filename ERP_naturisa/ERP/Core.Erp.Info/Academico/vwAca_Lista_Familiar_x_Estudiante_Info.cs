using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_Lista_Familiar_x_Estudiante_Info
    {
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public decimal IdFamiliar { get; set; }
        public string pe_cedulaRuc { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public Nullable<System.DateTime> pe_fechaNacimiento { get; set; }
        public string IdEstadoCivil { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string IdNivelEducativo_cat { get; set; }
        public string Titulo { get; set; }
        public string OcupacionLaboral { get; set; }
        public string empresa_donde_trabaja { get; set; }
        public string empresa_direccion { get; set; }
        public string empresa_telefono { get; set; }
        public string empresa_email { get; set; }
        public bool esta_autorizado_recibir_not_mail { get; set; }
        public bool esta_autorizado_ret_alum { get; set; }
        public string Calle_Principal { get; set; }
        public string Calle_Secundaria { get; set; }
        public bool Fallecido { get; set; }
        public bool FueExAlumnoGraduado { get; set; }
        public string IdCatalogoIdiomaNativo { get; set; }
        public string IdCatalogoReligion { get; set; }
        public string IdCatalogoTipoSangre { get; set; }
        public bool PoseeDiscapacidad { get; set; }
        public string Sector_Urbanizacion { get; set; }
        public bool ViveFueraDelPais { get; set; }
        public string IdCiudad { get; set; }
        public bool Vive_con_el_estudiante { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string pe_telefonoInter { get; set; }
        public string pe_celular { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public string IdParentesco_cat { get; set; }
        public string cod_familiar { get; set; }

        public vwAca_Lista_Familiar_x_Estudiante_Info() { }
    }
}
