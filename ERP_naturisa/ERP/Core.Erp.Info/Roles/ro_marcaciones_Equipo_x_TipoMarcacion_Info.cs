using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_marcaciones_Equipo_x_TipoMarcacion_Info
    {
        public int IdEquipoMar { get; set; }
        public string IdTipoMarcaciones_sys { get; set; }
        public string IdTipoMarcaciones_Biometrico { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        public ro_marcaciones_Equipo_x_TipoMarcacion_Info() { }
        
    }
}
