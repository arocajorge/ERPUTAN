using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Inventario
{

	public class in_movi_inven_X_imp_OrdCompraExterna_Info
	{


		public int imp_IdEmpresa{ get; set; } 
		public int imp_IdSucursal{ get; set; } 
		public decimal imp_IdOrdenCompraExt{ get; set; } 
		public int in_IdEmpresa{ get; set; } 
		public int in_IdSucursal{ get; set; } 
		public int in_IdBodega{ get; set; } 
		public int in_IdMovi_inven_tipo{ get; set; } 
		public decimal in_IdNumMovi{ get; set; } 


	    public in_movi_inven_X_imp_OrdCompraExterna_Info(){ }

	


	}
}
