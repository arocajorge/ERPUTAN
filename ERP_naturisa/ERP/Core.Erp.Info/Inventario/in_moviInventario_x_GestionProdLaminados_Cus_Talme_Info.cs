using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Inventario
{

	public class in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info
	{
	

		public int mov_IdEmpresa{ get; set; } 
		public int mov_IdSucursal{ get; set; } 
		public int mov_IdBodega{ get; set; } 
		public int mov_IdMovi_inven_tipo{ get; set; } 
		public decimal mov_IdNumMovi{ get; set; } 
		public int prod_IdEmpresa{ get; set; } 
		public decimal prod_IdGestionProductiva{ get; set; } 


	public in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info(){ }

	
	}
}
