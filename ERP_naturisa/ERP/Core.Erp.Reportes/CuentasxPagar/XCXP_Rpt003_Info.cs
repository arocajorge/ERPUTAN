using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string num_comprobante { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public DateTime co_FechaContabilizacion { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public string Detalle { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public string nom_cuenta { get; set; }
        public string clave_cuenta { get; set; }
        public string nom_proveedor { get; set; }  
        public string Codigo { get; set; }
        public string nom_comprobante { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }

        public double valor_debe { get; set; }
        public double valor_haber { get; set; }

        public string debe { get; set; }
        public string haber { get; set; }

        public string em_nombre { get; set; }
        
        public XCXP_Rpt003_Info()
        {
        }
    }
}
