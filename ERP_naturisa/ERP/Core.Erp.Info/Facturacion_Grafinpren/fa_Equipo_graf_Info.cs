using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_Grafinpren
{
    public class fa_Equipo_graf_Info
    {
        public int IdEmpresa { get; set; }
        public int IdEquipo { get; set; }
        public string nom_Equipo { get; set; }
        public Boolean estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    }
}
