﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt023_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public string serie { get; set; }
        public string NumRetencion { get; set; }
        public string NAutorizacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string observacion { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public int Idsecuencia { get; set; }
        public string re_tipoRet { get; set; }
        public double re_baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double re_valor_retencion { get; set; }
        public decimal IdProveedor { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_direccion { get; set; }
        public string CodTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public string Num_Autorizacion { get; set; }

        public string num_Comprobante { get; set; }
        public string num_Comprobante_venta { get; set; }
    }
}
