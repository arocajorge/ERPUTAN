using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cartera_x_cobrar_Info
    {

        public int IdEmpresa{ get; set; }
		public int IdSucursal{ get; set; }
		public int IdBodega{ get; set; }
        public decimal IdCbteVta { get; set; }
		public string vt_tipoDoc{ get; set; }
		public string vt_NunDocumento{ get; set; }
		public string Referencia{ get; set; }
		public decimal IdComprobante{ get; set; }
		public string CodComprobante{ get; set; } 
		public string Su_Descripcion{ get; set; } 
		public decimal IdCliente{ get; set; } 
		public DateTime? vt_fecha{ get; set; } 
		public double? vt_total{ get; set; } 
		public double? Saldo{ get; set; } 
		public double TotalxCobrado{ get; set; }
        public string Bodega { get; set; }


        public string Observacion { get; set; }
        public string Sucursal { get; set; }
        public string TipoDoc { get; set; }
        public double Total { get; set; }
        public bool Check { get; set; }
        public DateTime Fecha { get; set; }
        public double dc_ValorRetFu { get; set; }
        public double dc_ValorRetIva { get; set; }
        public string NombCli { get; set; }
        public string NombEmp { get; set; }
        public Bitmap Ico { get; set; }
        public string Estado { get; set; }

                
        // haac 23/01/2014
        public double? vt_Subtotal { get; set; }
        public double? vt_iva { get; set; }

        public string pe_nombreCompleto { get; set; }

        // haac 01/03/2014
        //campos de la vista vwcxc_cartera_x_cobrar
        public Boolean check_cartera { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public string plazo { get; set; }
        public string  observacion { get; set; }
        public double valor_aplicar { get; set; }
        public double SaldoAUX { get; set; }

        // haac 06/03/2014
        public string NomCliente { get; set; }

        public vwcxc_cartera_x_cobrar_Info(){}
    }
}

