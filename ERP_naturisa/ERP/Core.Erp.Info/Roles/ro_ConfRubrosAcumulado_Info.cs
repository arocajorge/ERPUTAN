using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_ConfRubrosAcumulado_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Descripcion { get; set; }

        //VISTA
        public Boolean Ckeck { get; set; }
        public Boolean? Configurable { get; set; }

        public ro_ConfRubrosAcumulado_Info()
        {

        }
    }
}
