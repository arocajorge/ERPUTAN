using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_pago_cancelacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal Idcancelacion { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_op { get; set; }
        public decimal IdOrdenPago_op { get; set; }
        public int Secuencia_op { get; set; }
        public int IdEmpresa_cbtecble { get; set; }
        public int IdTipoCbte_cbtecble { get; set; }
        public decimal IdCbteCble_cbtecble { get; set; }
        public double MontoAplicado { get; set; }
        public double SaldoAnterior { get; set; }
        public double SaldoActual { get; set; }
        public string Observacion { get; set; }
        public string NumCheque { get; set; }
        public string Banco { get; set; }
        public DateTime fechaTransaccion { get; set; }


        public cp_orden_pago_cancelacion_Info() { }
    }
}
