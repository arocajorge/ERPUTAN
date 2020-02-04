using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt001_Info
    {
        public long fila { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string Tipo_persona { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public decimal IdPersona { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<double> Valor_a_pagar { get; set; }
        public Nullable<double> Valor_debe { get; set; }
        public double Valor_Haber { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdClaseProveedor { get; set; }
        public string nom_clase_proveedor { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string nom_sucursal { get; set; }
        public string cod_sucursal { get; set; }
        public string nom_TipoPersona { get; set; }  

        public XCXP_NATU_Rpt001_Info()
        {

        }

    }
}
