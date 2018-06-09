using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class vwAca_Familiar_x_Estudiante_RepEco_Info
    {
        public decimal IdEstudiante { get; set; }
        public decimal IdFamiliar { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string IdParentesco_cat { get; set; }
        public decimal IdPersona { get; set; }
        public string Titulo { get; set; }
        public string empresa_telefono { get; set; }
        public string empresa_donde_trabaja { get; set; }
        public string empresa_direccion { get; set; }
        public string IdNivelEducativo_cat { get; set; }
        public bool activo { get; set; }
        public int IdInstitucion { get; set; }
        public string pe_correo { get; set; }
    }
}
