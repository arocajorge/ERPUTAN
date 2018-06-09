using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Nomina_Tipoliqui_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public string Nomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }
        public string Estado { get; set; }

        public List<ro_nomina_tipo_liqui_orden_Info> oLstNominaRubroOrden = new List<ro_nomina_tipo_liqui_orden_Info>();
        
        public ro_Nomina_Tipoliqui_Info() { }

    }
}
