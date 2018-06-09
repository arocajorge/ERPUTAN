using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar_Grafinpren
{
    public class cxc_Comisiones_x_vendedor_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public int Secuencia { get; set; }
        public double Porc_pactado { get; set; }
        public double Porc_pagado { get; set; }
        public double Valor_pagado { get; set; }

        //Campos para vista
        public string IdCobro_tipo { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public double Pago { get; set; }
        public Nullable<int> IdEmpresa_fact { get; set; }
        public Nullable<int> IdSucursal_fact { get; set; }
        public Nullable<int> IdBodega_fact { get; set; }
        public Nullable<decimal> IdCbteVta_fact { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
        public Nullable<System.DateTime> fecha_fact { get; set; }
        public Nullable<System.DateTime> fecha_vcto_fact { get; set; }
        public string nom_Cliente { get; set; }
        public double Fa_total { get; set; }
        public int Dias_atraso { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<double> Base_com { get; set; }
        public string vt_NumFactura { get; set; }
        public int Dias_Vct { get; set; }
        public Nullable<double> com_negociada { get; set; }
        public string num_op { get; set; }
        public string num_cotizacion { get; set; }
        public string vt_tipoDoc { get; set; }

        //Validador para guardar o modificar
        public bool Esta_en_base { get; set; }
    }
}
