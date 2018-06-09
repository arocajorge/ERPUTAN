using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_conciliacion_Det_Cobro_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdConciliacion { get; set; }
        public decimal IdCobro { get; set; }
        public int IdBodega { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_NunDocumento { get; set; }
        public string Referencia { get; set; }
        public decimal IdComprobante { get; set; }
        public string CodComprobante { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime vt_fecha { get; set; }
        public double vt_total { get; set; }
        public double Saldo { get; set; }
        public double TotalxCobrado { get; set; }
        public string Bodega { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public double dc_ValorRetFu { get; set; }
        public double dc_ValorRetIva { get; set; }
        public string CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string em_nombre { get; set; }

    }
}
