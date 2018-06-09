using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt010_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public double Valor_a_pagar { get; set; }
        public int Valor_debe { get; set; }
        public Nullable<double> Valor_Haber { get; set; }
        public string Observacion { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string representante_legal { get; set; }
        public Nullable<System.DateTime> co_FechaFactura_vct { get; set; }


    }
}
