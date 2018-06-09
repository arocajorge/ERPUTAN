using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Nomina_Tipo_Info
    {

        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public string Descripcion { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }
        public string Estado { get; set; }
        
        public Boolean check { get; set; }

        public ro_Nomina_Tipo_Info() { }
    }
}
