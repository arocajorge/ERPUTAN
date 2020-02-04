using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public string cod_empresa { get; set; }
        public string nom_empresa { get; set; }
        public System.DateTime fecha { get; set; }
        public string cod_TipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string num_documento { get; set; }
        public decimal IdCbte { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public double total_doc { get; set; }
        public double valor_a_pagar { get; set; }
        public double? Total_Retencion { get; set; }
        public int total_pagos { get; set; }
        public int total_NC { get; set; }
        public double Total { get; set; }
    }
}
