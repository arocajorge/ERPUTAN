using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_estado_cierre_Info
    {
        
        public string IdEstado_cierre { get; set; }
        public string Descripcion { get; set; }
        public string estado { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        /// <summary>
        /// Prog: Eliana Veliz
        /// Ult Mod: 06/10/2014  10:00
        /// </summary>
    }
}
