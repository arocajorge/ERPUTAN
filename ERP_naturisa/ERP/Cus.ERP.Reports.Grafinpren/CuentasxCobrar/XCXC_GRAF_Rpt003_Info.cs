using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt003_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string vt_NumFactura { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<double> dc_ValorPago { get; set; }
        public Nullable<double> Saldo { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public Nullable<int> Dias_en_credito { get; set; }
        public Nullable<int> Dias_vencido { get; set; }
    }
}
