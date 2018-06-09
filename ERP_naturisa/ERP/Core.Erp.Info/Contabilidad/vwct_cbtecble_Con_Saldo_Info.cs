using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class vwct_cbtecble_Con_Saldo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
        public double? ValorDiario { get; set; }
        public double? MontoOG { get; set; }
        public double? SaldoDiario { get; set; }
        public string Detalle { get; set; }
        public string Observacion { get; set; }
        public string TipoCbte { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean chek { get; set; }
        public Nullable<DateTime> FechaCanc { get; set; }
        public string Empresa_Cbte { get; set; }
        public decimal IdCancelacion { get; set; }
       

        public vwct_cbtecble_Con_Saldo_Info(){}
    }
}
