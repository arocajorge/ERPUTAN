using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Roles
{

	public class ro_division_Info
	{


		public int IdEmpresa{ get; set; } 
		public decimal IdDivision{ get; set; } 
		public string Descripcion{ get; set; }
        public string IdUsuario { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string estado { get; set; }
        public string MotivoAnulacion { get; set; }


	public ro_division_Info(){ }


	}
}
