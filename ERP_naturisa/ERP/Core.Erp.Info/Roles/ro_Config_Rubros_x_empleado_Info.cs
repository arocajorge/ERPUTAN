using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Config_Rubros_x_empleado_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        public string Estado { get; set; }
        public int OrdenPres { get; set; }
        public string ru_descripcion { get; set; }
        public Boolean Checked { get; set; }

        //04/11/2013
        public int Secuencia { get; set; }

        public ro_Config_Rubros_x_empleado_Info()
        {
            
        }

    }
}
