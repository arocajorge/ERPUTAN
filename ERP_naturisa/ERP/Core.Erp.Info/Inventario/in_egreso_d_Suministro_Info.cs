using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Inventario
{

	public class in_egreso_d_Suministro_Info
	{


		public int IdEmpresa{ get; set; } 
		public int IdSucursa{ get; set; } 
		public int IdBodega{ get; set; } 
		public decimal IdEgresoSumin{ get; set; }
        public decimal IdGasto { get; set; } 
		public decimal IdCentroDeCosto{ get; set; } 
		public Nullable< decimal> IdProducto{ get; set; } 
		public Nullable<double >Cantidad{ get; set; } 
		public Nullable<double> Precio{ get; set; } 
		public Nullable<double> Subtotal{ get; set; } 
		public string observacion{ get; set; } 
		public string IdUsuario{ get; set; } 
		public Nullable<DateTime> Fecha_Transa{ get; set; } 
		public string IdUsuarioUltModi{ get; set; } 
		public Nullable<DateTime> FechaUltModi{ get; set; } 
		public string IdUsuarioAnula{ get; set; } 
		public Nullable<DateTime> FechaAnula{ get; set; } 
		public string Estado{ get; set; }
        public string  IdUnico { get; set; }


	public in_egreso_d_Suministro_Info(){ }

	
	}
}
