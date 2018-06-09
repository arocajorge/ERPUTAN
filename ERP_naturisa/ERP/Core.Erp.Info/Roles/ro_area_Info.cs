using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Roles
{

	public class ro_area_Info
	{

		public int IdEmpresa{ get; set; } 
		public int IdDivision{ get; set; } 
		public int IdArea{ get; set; } 
		public string Estado{ get; set; } 
		public string Descripcion{ get; set; }

        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaTransac { get; set; }
        public DateTime ? FechaUltModi { get; set; }
   

        //


	public ro_area_Info(){ }



    public string Descripcion_Division { get; set; }
    }
}
