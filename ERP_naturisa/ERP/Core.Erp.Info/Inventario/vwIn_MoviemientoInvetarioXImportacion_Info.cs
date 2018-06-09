using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Inventario
{

	public class vwIn_MoviemientoInvetarioXImportacion_Info
	{
		public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public int in_IdBodega{ get; set; } 
		public decimal IdOrdenCompraExt{ get; set; } 
		public decimal? IdProducto{ get; set; } 
		public double? dm_cantidad_Ingresa{ get; set; } 
		public double? di_cantidad_Solicitada{ get; set; } 
		public double? SaldoxIngresar{ get; set; } 


	public vwIn_MoviemientoInvetarioXImportacion_Info(){ }

	}
}
