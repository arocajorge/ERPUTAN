using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_giro_pagos_Info
    {
        public decimal IdCancelacion { get; set; }
        public int IdEmpresa_Og { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public int IdEmpresa_cbte { get; set; }
        public decimal IdCbteCble_cbte { get; set; }
        public int IdTipocbte_cbte { get; set; }
        public int pg_secuencia { get; set; }
        public double? pg_MontoAplicado { get; set; }
        public double? pg_saldoAnterior { get; set; }
        public double? pg_saldoActual { get; set; }
        public string pg_numCheque { get; set; }
        public int? IdBanco { get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string estado { get; set; }


       public cp_orden_giro_pagos_Info() { }
    }
}
