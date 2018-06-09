using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Inventario
{

	public class in_transferencia_x_fa_guia_remision_Info
	{
	

		public int IdEmpresa{ get; set; } 
		public int IdSucursalOrigen{ get; set; } 
		public int IdBodegaOrigen{ get; set; } 
		public decimal IdTransferencia{ get; set; } 
		public int IdEmpresa_Guia{ get; set; } 
		public int IdSucursal_Guia{ get; set; } 
		public int IdBodega_Guia{ get; set; } 
		public decimal IdGuiaRemision{ get; set; } 
		public string Obser{ get; set; } 


	public in_transferencia_x_fa_guia_remision_Info(){ }

	

	}
}
