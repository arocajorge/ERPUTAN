using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.CuentasxPagar
{

	public class cp_conciliacion_det_Info
	{
        public int? IdEmpresa { get; set; }
        public decimal IdConciliacion { get; set; }
        public int Secuencia { get; set; }
        public int? IdEmpresa_op { get; set; }
        public decimal? IdOrdenPago_op { get; set; }
        public int? Secuencia_op { get; set; }
        public int? IdEmpresa_cxp { get; set; }
        public int? IdTipoCbte_cxp { get; set; }
        public decimal? IdCbteCble_cxp { get; set; }
        public int IdEmpresa_pago { get; set; }
        public int? IdTipoCbte_pago { get; set; }
        public decimal? IdCbteCble_pago { get; set; }
        public double MontoAplicado { get; set; }
        public double SaldoAnterior { get; set; }
        public double SaldoActual { get; set; }
        public string Observacion { get; set; }     
        public DateTime fechaTransaccion { get; set; }
        
        //vwct_cbtecble_con_saldo_cxp_Info
        
        public decimal? IdCbteCble { get; set; }
        public int? IdTipocbte { get; set; }
        public DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string referencia { get; set; }
        public string tc_TipoCbte { get; set; }
        public double? Valor_cbte { get; set; }
        public double Valor_cancelado_cbte { get; set; }
        public double? valor_Saldo_cbte { get; set; }
        public Boolean Check { get; set; }
        public string Tipo { get; set; }


        //campos por borrar
        public string Beneficiario { get; set; }
        public int indice { get; set; }


        public cp_orden_giro_Info Info_Orden_Giro { get; set; }


        //public double Saldo_cont_al_periodo { get; set; }
        //public double Ingresos { get; set; }
        //public double Total_Ing { get; set; }
        //public double Total_fact_vale { get; set; }
        //public double Total_fondo { get; set; }
        //public double Dif_x_pagar_o_cobrar { get; set; }
        //public int IdPeriodo { get; set; }



	public cp_conciliacion_det_Info()
    {
        Info_Orden_Giro = new cp_orden_giro_Info();
    }

	}
}
