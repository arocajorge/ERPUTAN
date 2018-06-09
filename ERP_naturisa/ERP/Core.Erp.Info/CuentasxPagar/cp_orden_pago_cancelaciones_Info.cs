using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_pago_cancelaciones_Info
    {

        public int IdEmpresa { get; set; }
        public decimal Idcancelacion { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_op { get; set; }
        public decimal ? IdOrdenPago_op { get; set; }
        public int ? Secuencia_op { get; set; }
        public int? IdEmpresa_op_padre { get; set; }
        public decimal? IdOrdenPago_op_padre { get; set; }
        public int? Secuencia_op_padre { get; set; }
        public int? IdEmpresa_cxp { get; set; }
        public int? IdTipoCbte_cxp { get; set; }
        public decimal? IdCbteCble_cxp { get; set; }
        public int? IdEmpresa_pago { get; set; }
        public int? IdTipoCbte_pago { get; set; }
        public decimal? IdCbteCble_pago { get; set; }
        public double MontoAplicado { get; set; }
        public double SaldoAnterior { get; set; }
        public double SaldoActual { get; set; }
        public string Observacion { get; set; }
        public DateTime fechaTransaccion { get; set; }

        //  campos vista vwcp_orden_pago_cancelacion_Saldos
        public string IdTipo_op { get; set; }
        public string Referencia { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IdEntidad { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public bool Check { get; set; }



        public cp_orden_pago_cancelaciones_Info()
        {

        }

    }
}
