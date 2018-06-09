using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt005_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string IdTipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public string Referencia { get; set; }
        public string IdComprobante { get; set; }
        public string CodComprobante { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime no_fecha { get; set; }
        public double vt_total { get; set; }
        public double Saldo { get; set; }
        public double TotalCobrado { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public DateTime no_fecha_venc { get; set; }
        public decimal IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public double sc_cantidad { get; set; }
        public double sc_precioFinal { get; set; }
        public Image Logo { get; set; }
        public int IdTipoNota { get; set; }
        public string CodTipoNota { get; set; }
        public int Plazo { get; set; }
        public string IdUsuario { get; set; }

        public XFAC_Rpt005_Info()
        {

        }

    }
}
