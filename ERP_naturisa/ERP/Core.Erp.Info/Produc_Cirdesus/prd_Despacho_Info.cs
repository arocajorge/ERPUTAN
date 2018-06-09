using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_Despacho_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDespacho { get; set; }
        public string CodObra { get; set; }
        public decimal IdCliente { get; set; }
        public string NumDespacho { get; set; }
        public string NumFactura { get; set; }
        public string NumGuiaRemision { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaIniTras { get; set; }
        public DateTime FechaFinTras { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoLLegada { get; set; }

        public string ruta { get; set; }

        public string Chofer { get; set; }
        public string Placa { get; set; }
        public string TipoTransporte { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime FechaUltModi { get; set; }

        
        
        public string Su_Descripcion { get; set; }


        public string Referencia { get; set; }
        public string NomCliente { get; set; }

        public int idMotivo_traslado { get; set; }

        public prd_Despacho_Info() { }
    }
}
