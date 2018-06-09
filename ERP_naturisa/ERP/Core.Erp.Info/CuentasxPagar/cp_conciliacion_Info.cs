using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.CuentasxPagar
{
    //Derek Mejia 10/03/2014 - MOD 13/03/2014

	public class cp_conciliacion_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdConciliacion{ get; set; } 
		public DateTime Fecha{ get; set; } 
		public string Observacion{ get; set; } 
		public string Estado{ get; set; } 
		public string IdUsuarioUltMod{ get; set; } 
		public DateTime? Fecha_Transac{ get; set; } 
		public DateTime? Fecha_UltMod{ get; set; } 
		public string IdUsuarioUltAnu{ get; set; } 
		public string MotivoAnu{ get; set; } 
		public string nom_pc{ get; set; } 
		public DateTime? Fecha_UltAnu{ get; set; } 
		public string ip{ get; set; }

        public decimal IdCancelacion { get; set; } 

        //DEREK MEJIA 28/03/2014
        public string Tipo_detalle { get; set; }

        //DEREK MEJIA 29/03/2014
        public string Tipo { get; set; }


        public List<cp_orden_pago_Info> lista_Orden_Pago { get; set; }

        public List<cp_orden_pago_cancelaciones_Info> lista_Orden_Pago_Cancel {get;set;}

        public List<cp_conciliacion_det_Info> lista_Det_Concilia { get; set; }

        public int IdEmpresa_cbtecble { get; set; }
        public int IdTipoCbte_cbtecble { get; set; }
        public decimal IdCbteCble_cbtecble { get; set; }

        public string  tipo { get; set; }

	public cp_conciliacion_Info()
    {

        lista_Orden_Pago = new List<cp_orden_pago_Info>();

        lista_Orden_Pago_Cancel = new List<cp_orden_pago_cancelaciones_Info>();

        lista_Det_Concilia = new List<cp_conciliacion_det_Info>();
    }

	}
}
