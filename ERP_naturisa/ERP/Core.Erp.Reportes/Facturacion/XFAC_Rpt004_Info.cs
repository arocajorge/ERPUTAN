using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt004_Info
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
        public string pe_cedulaRuc { get; set; }
        public System.DateTime no_fecha { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<double> Saldo { get; set; }
        public Nullable<double> TotalCobrado { get; set; }
        public double SubTotal { get; set; }

        public Nullable<double> SubTotal_0 { get; set; }
        public Nullable<double> SubTotal_Iva { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<System.DateTime> no_fecha_venc { get; set; }
        public int IdTipoNota { get; set; }
        public string CodTipoNota { get; set; }
        public string No_Descripcion { get; set; }
        public Nullable<int> Plazo { get; set; }
        public string IdUsuario { get; set; }
        public string em_nombre { get; set; }
        public string NaturalezaNota { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }


        public List<XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info> list_resumen_x_Subtotal { get; set; }


        public XFAC_Rpt004_Info()
        {
            list_resumen_x_Subtotal = new List<XFAC_Rpt004_Resumen_x_Subtotal_x_Iva_Info>();
        }

    }
}
