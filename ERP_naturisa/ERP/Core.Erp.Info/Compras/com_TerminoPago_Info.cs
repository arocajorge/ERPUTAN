using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_TerminoPago_Info
    {

        public string IdTerminoPago { get; set; }
        public int Dias { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }

        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotiAnula { get; set; }
        public DateTime FechaUltMod { get; set; }
        public DateTime Fecha_UltAnu { get; set; }


		
	public  com_TerminoPago_Info(){ }

    }
}
