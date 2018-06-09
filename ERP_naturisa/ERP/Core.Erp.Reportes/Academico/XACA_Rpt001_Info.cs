using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.Academico
{
    public class XACA_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEstudiante { get; set; }
        public decimal IdPersonaEstudiante { get; set; }
        public string cod_estudiante { get; set; }
        public string IdTipoDocumento { get; set; }
        public string DescTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string IdPais_Nacionalidad { get; set; }
        public string Nacionalidad { get; set; }
        public string lugar { get; set; }
        public string barrio { get; set; }
        public string pe_direccion { get; set; }
        public string pe_celular { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_correo { get; set; }
        public DateTime pe_fechaNacimiento { get; set; }
        public string pe_sexo { get; set; }
        public string descripcion_sexo { get; set; }
        public string IDGrupoSanguineo { get; set; }
        public string DescGrupoSanguineo { get; set; }
        public string Medica_contraIndic { get; set; }
        public string Otras_Indicaciones_medicas { get; set; }
        public string Seguro_medico { get; set; }
        public decimal IdFamiliarMadre { get; set; }
        public string CedulaMadre { get; set; }
        public string ApellidoMadre { get; set; }
        public string NombreMadre { get; set; }
        public decimal IdPersonaMadre { get; set; }
        public string IDParentescoMadre { get; set; }
        public string DescParentescoMadre { get; set; }
        public string empresa_direccionMadre { get; set; }
        public string empresa_donde_trabajaMadre { get; set; }
        public string empresa_telefonoMadre { get; set; }
        public string idNivelEducativoMadre { get; set; }
        public string DescNivelEducativoMadre { get; set; }
        public string TituloMadre { get; set; }
        public decimal IdFamiliarPadre { get; set; }
        public string CedulaPadre { get; set; }
        public string ApellidoPadre { get; set; }
        public string NombrePadre { get; set; }
        public decimal IdPersonaPadre { get; set; }
        public string IDParentescoPadre { get; set; }
        public string DescParentescoPadre { get; set; }
        public string empresa_direccionPadre { get; set; }
        public string empresa_donde_trabajaPadre { get; set; }
        public string empresa_telefonoPadre { get; set; }
        public string idNivelEducativoPadre { get; set; }
        public string DescNivelEducativoPadre { get; set; }
        public string TituloPadre { get; set; }
        public decimal IdFamiliarRepEco { get; set; }
        public string CedulaRepEco { get; set; }
        public string ApellidoRepEco { get; set; }
        public string NombreRepEco { get; set; }
        public decimal IdPersonaRepEco { get; set; }
        public string IDParentescoRepEco { get; set; }
        public string DescParentescoRepEco { get; set; }
        public string empresa_direccionRepEco { get; set; }
        public string empresa_donde_trabajaRepEco { get; set; }
        public string empresa_telefonoRepEco { get; set; }
        public string idNivelEducativoRepEco { get; set; }
        public string DescNivelEducativoRepEco { get; set; }
        public string TituloRepEco { get; set; }
        public string Nom_Empresa { get; set; }
        public Image Logo { get; set; }

        public XACA_Rpt001_Info() 
        { 
        }
    }
}
