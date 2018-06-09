using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_GestionProductivaLaminado_x_paradas_CusTalme_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdGestionProductiva{ get; set; } 
		public string IdTipoParada{ get; set; } 
		public int Secuencia{ get; set; } 
		public TimeSpan HoraIni{ get; set; }
        public TimeSpan HoraFin { get; set; } 
		public string Descripcion{ get; set; } 
		public string causa{ get; set; } 


	public prod_GestionProductivaLaminado_x_paradas_CusTalme_Info(){ }

	}
}
