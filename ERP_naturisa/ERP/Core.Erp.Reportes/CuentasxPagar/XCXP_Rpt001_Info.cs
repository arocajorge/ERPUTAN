using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal? IdCbteCble_Ogiro { get; set; }
        public int? IdTipoCbte_Ogiro{ get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string Documento { get; set; }
        public string nom_tipo_doc { get; set; }
        public string cod_tipo_doc { get; set; }
        public DateTime? co_fechaOg { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public double Valor_a_pagar { get; set; }
        public double? Valor_debe { get; set; }
        public double Valor_Haber { get; set; }
        public string Observacion { get; set; }
        public Image Logo { get; set; }
        public string Ruc_Proveedor { get; set; }
        public string representante_Legal { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }


        public string Tipo_cbte { get; set; }
        public int? IdEmpresa_pago { get; set; }
        public int? IdTipoCbte_pago { get; set; }
        public decimal? IdCbteCble_pago { get; set; }
        public string cb_Observacion_pago { get; set; }
        public string tc_TipoCbte_pago { get; set; }
        public string cb_Cheque_pago { get; set; }
        public double? Saldo { get; set; }


        public XCXP_Rpt001_Info()
        {
        }


       
    }


    public enum eFiltro_Mostrar_Pagos
    {
        SI ,
        NO 
    }

    
    
    public enum eFiltro_Estado_Pago
    {
        TODOS = 1,
        PAGADOS = 2,
        PENDIENTES = 3
    }

}
