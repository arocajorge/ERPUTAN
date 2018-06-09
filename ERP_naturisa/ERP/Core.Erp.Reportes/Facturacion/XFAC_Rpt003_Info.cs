using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_NunDocumento { get; set; }
        public string Referencia { get; set; }
        public decimal IdComprobante { get; set; }
        public string CodComprobante { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime vt_fecha { get; set; }
        public double vt_total { get; set; }
        public double Saldo { get; set; }
        public double TotalCobrado { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public decimal vt_plazo { get; set; }
        public decimal IdProducto { get; set; }
        public string  nombreProducto { get; set; }

        public Image  Logo { get; set; }
        public double sc_cantidad { get; set; }
        public double sc_precioFinal { get; set; }
        public string IdUsuario { get; set; }


        public XFAC_Rpt003_Info()
        {

        }
    }
}
