using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cotizacion_info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime cc_fecha { get; set; }
        public int cc_diasPlazo { get; set; }
        public DateTime cc_fechaVencimiento { get; set; }
        public string cc_observacion { get; set; }
        public string cc_tipopago { get; set; }
        public string cc_estado { get; set; }
        public string cc_dirigidoA { get; set; }
        public string CodCotizacion { get; set; }

        public double cc_transporte { get; set; }
        public double cc_interes { get; set; }
        public double cc_otroValor1 { get; set; }
        public double cc_otroValor2 { get; set; }


        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }

        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }





        public List<fa_cotizacion_det_info> lista_detalle = new List<fa_cotizacion_det_info>();
        

        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string Vendedor { get; set; }
        public decimal subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }

        public fa_cotizacion_info()
        {
            lista_detalle = new List<fa_cotizacion_det_info>();
        }

    }

}
