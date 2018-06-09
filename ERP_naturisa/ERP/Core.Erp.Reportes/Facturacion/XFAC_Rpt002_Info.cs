using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt002_Info
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
        public string pe_cedulaRuc { get; set; }
        public DateTime vt_fecha { get; set; }
        public double vt_total { get; set; }
        public double Saldo { get; set; }
        public double TotalCobrado { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public double dc_ValorRetFu { get; set; }
        public double dc_ValorRetIva { get; set; }
        public decimal vt_plazo { get; set; }
        public string IdUsuario { get; set; }
        public Image Logo { get; set; }
        public double? SubTotal_0 { get; set; }
        public double? SubTotal_Iva { get; set; }
        public string IdFormaPago { get; set; }
        public string nom_FormaPago { get; set; }

        public XFAC_Rpt002_Info()
        {

        }

    }
}
