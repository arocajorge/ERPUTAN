using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_GestionProductivaTechos_CusTalme_Detalle_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdGestionProductiva{ get; set; } 
		public int Secuencia{ get; set; } 
		public decimal Prod_IdProducto{ get; set; } 
		public double Prod_Largo{ get; set; } 
		public double Prod_Ancho{ get; set; } 
		public double Prod_PsoEsp{ get; set; } 
		public double Prod_Espesor{ get; set; } 
		public double Prod_PsoUnd{ get; set; } 
		public double Prducc_Unidades{ get; set; } 
		public double Prducc_Kg{ get; set; } 
		public decimal Segunda_IdProducto{ get; set; } 
		public double Segunda_Unidades{ get; set; } 
		public double Segunda_Kg{ get; set; } 
		public double Chatarra_Kg{ get; set; } 
		public double Peso{ get; set; } 
		public double Kg_Desp{ get; set; } 
		public double Rend_Metalico{ get; set; } 
		public double KW{ get; set; } 
		public TimeSpan? Tiempo_Preparacion{ get; set; }
        public TimeSpan? Tiempo_Produccion { get; set; }
        public TimeSpan? Tiempo_Total { get; set; }
        public TimeSpan? Parada_Mecanica { get; set; }
        public TimeSpan? Parada_Electrico { get; set; }
        public TimeSpan? Parada_Logistica { get; set; }
        public TimeSpan? Parada_Otros { get; set; }
        public TimeSpan? TotalParos { get; set; } 
		public double Indicadores_TnHrs{ get; set; } 
		public double Indicadores_TimeParda{ get; set; } 
		public double Indicadores_UndsHrs{ get; set; } 
		public double Indicadores_Calidad{ get; set; } 


	public prod_GestionProductivaTechos_CusTalme_Detalle_Info(){ }

	}
}
