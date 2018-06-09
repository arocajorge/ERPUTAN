using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Importacion
{

	public class vwImp_LiquidacionImportacion_Info
	{
	

		public int IdEmpresa{ get; set; } 
		public decimal IdRegistroGasto{ get; set; } 
		public int IdSucusal{ get; set; } 
		public decimal IdOrdenCompraExt{ get; set; } 
		public string ga_decripcion{ get; set; } 
		public string pr_nombre{ get; set; } 
		public int IdTipoCbte{ get; set; } 
		public decimal IdCbteCble{ get; set; } 
		public double Valor{ get; set; } 
		public string CodCbteCble{ get; set; } 


	public vwImp_LiquidacionImportacion_Info(){ }


	}
}
