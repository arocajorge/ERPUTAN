using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public class XCXC_GRAF_Rpt001_Info
    {
        public int IdEmpresa_cbr { get; set; }
        public int IdSucursal_cbr { get; set; }
        public decimal IdCobro_cbr { get; set; }
        public int Secuencial_cbr { get; set; }
        public string IdCobro_tipo { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public double Pago { get; set; }
        public Nullable<int> IdEmpresa_fact { get; set; }
        public Nullable<int> IdSucursal_fact { get; set; }
        public Nullable<int> IdBodega_fact { get; set; }
        public Nullable<decimal> IdCbteVta_fact { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
        public double porc_comision { get; set; }
        public Nullable<System.DateTime> fecha_fact { get; set; }
        public Nullable<System.DateTime> fecha_vcto_fact { get; set; }
        public string nom_Cliente { get; set; }
        public double Fa_total { get; set; }
        public int Dias_atraso { get; set; }
        public Nullable<double> Porc_pagado { get; set; }
        public Nullable<double> Valor_pagado { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<double> Base_com { get; set; }
        public Nullable<bool> Esta_en_base { get; set; }
        public string vt_NumFactura { get; set; }
        public int Dias_Vct { get; set; }
        public Nullable<Double> com_negociada { get; set; }
        public string num_op { get; set; }
        public string num_cotizacion { get; set; }
        public string vt_tipoDoc { get; set; }
    }
}
