using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Departamento_Info
    {
       
		public int IdEmpresa{ get; set; } 
		public int IdDepartamento{ get; set; }
        public int? IdDepartamentoPadre { get; set; }
		public  string de_descripcion{ get; set; }
        public string de_descripcion2 { get; set; }

        public string MotiAnula { get; set; }
		public string IdUsuario{ get; set; } 
		public DateTime? Fecha_Transac{ get; set; } 
		public string IdUsuarioUltMod{ get; set; } 
		public DateTime? Fecha_UltMod{ get; set; } 
		public string IdUsuarioUltAnu{ get; set; } 
		public DateTime? Fecha_UltAnu{ get; set; }
        

		public string nom_pc{ get; set; } 
		public string ip{ get; set; } 
		public string Estado{ get; set; }
        public string SEstado { get; set; } 
        //public int IdEmpresa { get; set; }
        
        public ro_Departamento_Info() { }
    }
}
