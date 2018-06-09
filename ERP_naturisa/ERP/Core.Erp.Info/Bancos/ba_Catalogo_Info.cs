using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_Catalogo_Info
    {

        public string  IdCatalogo { get; set; }
        public string IdTipoCatalogo { get; set; }
        public string ca_descripcion{ get; set; }
        public string ca_estado { get; set; }
        public int ca_orden { get; set; }

        // vista periodo de pago
        public string IdPeriPago { get; set; }

        // vista vwba_MotivoPrestamo
        public string IdMotivoPrestamo { get; set; }

        //vista vwba_MetodoCalculo
        public string IdMetCalc { get; set; }

        //vista vwba_EstadoPago
        public string IdEstadoPago { get; set; }

        public string IdUsuario { get; set; }

        public DateTime Fecha_Transac { get; set; }
	
        public string IdUsuarioUltMod { get; set; }
	
        public DateTime Fecha_UltMod { get; set; }

        public string nom_pc { get; set; }
	
        public string ip { get; set; }
	
        public string IdUsuarioUltAnu { get; set; }

        public DateTime Fecha_UltAnu { get; set; }

        public string MotiAnula { get; set; }
	



        public ba_Catalogo_Info()
        {

        }

    }
}
