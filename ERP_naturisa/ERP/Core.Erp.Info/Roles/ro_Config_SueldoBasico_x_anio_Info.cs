using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Config_SueldoBasico_x_anio_Info
    {
        public string sb_IdRubro { get; set; }
        public int sb_anio { get; set; }
        public double sb_valor { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public ro_Config_SueldoBasico_x_anio_Info()
        {

        }
    }
}
