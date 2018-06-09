using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt004_Info
    { 
        
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo{ get; set; }
        public decimal IdProveedor { get; set; }
        public string Detalle{ get; set; }
        public string num_comprobante { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public decimal IdRetencion { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public double dc_Valor { get; set; }
        public double valor_debe { get; set; }
        public double valor_haber { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string dc_Observacion { get; set; }
        public string nom_cuenta { get; set; }
        public string clave_cuenta { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string Codigo { get; set; }
        public string nom_comprobante { get; set; }
        public string nom_proveedor { get; set; }

        public string em_empresa { get; set; }

        public string Serie_Ret { get; set; }
        public string NumRetencion { get; set; }
        public string Num_Auto_Reten { get; set; }
        public DateTime Fecha_Reten { get; set; }
        public string Observacion_Reten { get; set; }
        public string Tiene_RTIva { get; set; }
        public string Tiene_RTFte { get; set; }

        public int ? IdTipoCbte_Ret { get; set; }
        public decimal? IdCbteCble_Ret { get; set; }
        public int ? IdEmpresa_Ret { get; set; }
        public string nom_TipoCbte_Ret { get; set; }







        public string debe { get; set; }
        public string haber { get; set; }
        public Image Logo { get; set; }

        public XCXP_Rpt004_Info()
        {
        }

    }
}
