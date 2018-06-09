using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Config_Rubros_x_Empresa_AportaIess_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string ru_descripcion { get; set; }
        public string NombreCorto { get; set; }
        public string rub_codigo { get; set; }

        public ro_Config_Rubros_x_Empresa_AportaIess_Info()
        {

        }
    }
}
