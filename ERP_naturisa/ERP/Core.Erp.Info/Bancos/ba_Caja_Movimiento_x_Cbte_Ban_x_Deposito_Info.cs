using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Bancos
{

	public class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info
	{

		public int mcj_IdEmpresa{ get; set; } 
		public decimal mcj_IdCbteCble{ get; set; } 
		public int mcj_IdTipocbte{ get; set; } 
		public int mba_IdEmpresa{ get; set; } 
		public decimal mba_IdCbteCble{ get; set; } 
		public int mba_IdTipocbte{ get; set; }
        public int mcj_Secuencia { get; set; }
        public string Observacion { get; set; }




	public ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info(){ }

	

	}
}
