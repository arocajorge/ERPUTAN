using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.General
{

	public class tb_Calendario_Info
	{

		public int IdCalendario{ get; set; } 
		public DateTime fecha{ get; set; } 
		public string NombreFecha{ get; set; } 
		public string NombreCortoFecha{ get; set; } 
		public Nullable<int>dia_x_semana{ get; set; } 
		public Nullable<int> dia_x_mes{ get; set; } 
		public string Inicial_del_Dia{ get; set; } 
		public string NombreDia{ get; set; } 
		public Nullable<int> Mes_x_anio{ get; set; } 
		public string NombreMes{ get; set; } 
		public Nullable<int> IdMes{ get; set; } 
		public string NombreCortoMes{ get; set; } 
		public Nullable<int> AnioFiscal{ get; set; } 
		public Nullable<int> Semana_x_anio{ get; set; } 
		public string NombreSemana{ get; set; } 
		public Nullable<int> IdSemana{ get; set; } 
		public Nullable<int> Trimestre_x_Anio{ get; set; } 
		public string NombreTrimestre{ get; set; } 
		public Nullable<int> IdTrimestre{ get; set; } 
		public string IdPeriodo{ get; set; } 
		public string EsFeriado{ get; set; }
        public string Descripcion { get; set; }

        public int Max{ get; set; }
        public int Min{ get; set; }


	public tb_Calendario_Info(){ }




    
    }
}
