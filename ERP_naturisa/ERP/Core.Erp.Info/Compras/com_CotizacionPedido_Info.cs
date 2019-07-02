using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_CotizacionPedido_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProveedor { get; set; }
        public string IdTerminoPago { get; set; }
        public System.DateTime cp_Fecha { get; set; }
        public int cp_Plazo { get; set; }
        public string cp_Observacion { get; set; }
        public decimal IdComprador { get; set; }
        public decimal IdDepartamento { get; set; }        
        public decimal IdSolicitante { get; set; }
        public string EstadoJC { get; set; }
        public string EstadoGA { get; set; }
        public decimal oc_IdOrdenCompra { get; set; }
        public string ObservacionAprobador { get; set; }

        public List<com_CotizacionPedidoDet_Info> ListaDetalle { get; set; }

        public string Su_Descripcion { get; set; }

        public string pe_nombreCompleto { get; set; }

        public string Comprador { get; set; }

        public string TerminoPago { get; set; }

        public string nom_solicitante { get; set; }

        public string nom_departamento { get; set; }

        public int cp_PlazoEntrega { get; set; }

        public bool? Pasado { get; set; }
        public string pe_correo { get; set; }

        public decimal IdPersona { get; set; }

        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }

        public decimal? opd_IdOrdenPedido { get; set; }

        public string IdUsuario { get; set; }
    }
}
