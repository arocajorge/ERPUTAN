using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_CompraChatarra_CusTalme_x__in_movi_inven_Info
	{

		public int IdEmpresa{ get; set; } 
		public decimal IdLiquidacion{ get; set; } 
		public int mv_IdEmpresa{ get; set; } 
		public int mv_IdSucursal{ get; set; } 
		public int mv_IdBodega{ get; set; } 
		public int mv_IdMovi_inven_tipo{ get; set; } 
		public decimal mv_IdNumMovi{ get; set; } 
		public string None{ get; set; } 


	public prod_CompraChatarra_CusTalme_x__in_movi_inven_Info(){ }

	

	}
}
