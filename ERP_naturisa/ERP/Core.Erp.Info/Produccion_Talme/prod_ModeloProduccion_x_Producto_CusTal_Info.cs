using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_ModeloProduccion_x_Producto_CusTal_Info
	{
		public int IdEmpresa{ get; set; } 
		public int IdModeloProd{ get; set; } 
		public decimal IdProducto{ get; set; } 
		public string Tipo{ get; set; } 


	public prod_ModeloProduccion_x_Producto_CusTal_Info(){ }

	}
}
