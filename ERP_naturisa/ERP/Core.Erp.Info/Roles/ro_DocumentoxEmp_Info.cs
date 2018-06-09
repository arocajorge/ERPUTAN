using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace Core.Erp.Info.Roles
{
    public class ro_DocumentoxEmp_Info
    {
        public bool check { get; set; }
        public int IdEmpresa{ get; set; } 
		public decimal IdEmpleado{ get; set; } 
		public decimal IdDocumento{ get; set; } 
		public string Dc_Nombre{ get; set; } 
		public string Dc_Descripcion{ get; set; } 
		public byte[] Documento{ get; set; }
        public string tipo { get; set; }
        public string Descargar { get; set; }
        public string URL { get; set; }
        public Bitmap Ico { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaElimin { get; set; }
        public String UsuarioElimin { get; set; }
        public String MotivoElimin { get; set; }
        public String Estado { get; set; }
        
	    public ro_DocumentoxEmp_Info(){ }

    }
}
