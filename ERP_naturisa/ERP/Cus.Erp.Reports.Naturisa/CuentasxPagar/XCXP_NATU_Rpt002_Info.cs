using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public decimal? IdCbteCble_Ogiro { get; set; }
        public int? IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string cod_tipo_doc { get; set; }
        public string tipo_doc { get; set; }
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public string Observacion { get; set; }
        public decimal? IdProveedor { get; set; }
        public string Nom_Proveedor { get; set; }
        public double? SubTotal { get; set; }
        public double Iva	{ get; set; }
        public double? Total { get; set; }
        public double Total_a_Pagar { get; set; }
        public double? Saldo_x_pagar { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }

        public decimal IdOrdenPago { get; set; }
        public decimal IdPersona { get; set; }


        public XCXP_NATU_Rpt002_Info()
        {
        }
    }
}
