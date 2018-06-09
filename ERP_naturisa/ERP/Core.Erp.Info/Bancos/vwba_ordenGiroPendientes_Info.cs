using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Derek Mejia
///V 22 02 2014 12.18

namespace Core.Erp.Info.Bancos
{
    public class vwba_ordenGiroPendientes_Info
    {
        public decimal IdProveedor { get; set; }
        public DateTime  co_fechaOg { get; set; }
        public string co_observacion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public double?  valorAPagar { get; set; }
        public double TotalPagado { get; set; }
        public double? saldo { get; set; }
        public double? saldo2 { get; set; }
        public decimal? valorAplicado { get; set; }

        public string Proveedor { get; set; }
        public string NFactura { get; set; }
        public string CtaProveedor { get; set; }
        public string GiraCheque { get; set; }

        public Boolean   chek { get; set; }

        /// <summary>
        /// Prog: Katiuska Franco
        /// frmCP_OrdenGiro_CanceXOtrosMoti 
        /// </summary>
        /// 

        public decimal IdCancelacion { get; set; }

     
        public vwba_ordenGiroPendientes_Info(){
            co_fechaOg = DateTime.Now.Date;
        }
    }
}
