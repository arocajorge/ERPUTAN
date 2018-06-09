using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public string Su_Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int? DiasVencidos { get; set; }
        public double? Valor_Original { get; set; }
        public double? TotalCobrado { get; set; }
        public double? Saldo { get; set; }
        public decimal IdCbteVta { get; set; }
        public DateTime vt_fecha { get; set; }
        public DateTime? vt_fecha_venc { get; set; }
        public string numDocumento { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_Observacion { get; set; }
        public string Nom_Empresa { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_dia { get; set; }
        public string em_Telefono { get; set; }
        public string em_fax { get; set; }
        public Nullable<double> Valor_x_Vencer_f { get; set; }
        public Nullable<double> Vencer_30_Dias { get; set; }
        public Nullable<double> Vencer_60_Dias { get; set; }
        public Nullable<double> Vencer_90_Dias { get; set; }
        public Nullable<double> Mayor_a_90Dias { get; set; }
    }
}
