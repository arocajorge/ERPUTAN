
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Core.Erp.Info.Roles
{
  public class ro_Archivos_Bancos_Generacion_Info
    {

      public List<ro_Rol_Detalle_Info> ro_rol_detalle = new List<ro_Rol_Detalle_Info>();
      public List<ro_archivos_bancos_generacion_x_empleado_Info> oListRo_archivos_bancos_generacion_x_empleado_Info = new List<ro_archivos_bancos_generacion_x_empleado_Info>();

        public decimal IdArchivo{ get; set; } 
		public int IdEmpresa{ get; set; } 
		public int IdNomina{ get; set; } 
		public int IdNominaTipo{ get; set; } 
		public int IdPeriodo{ get; set; } 
		public string IdBanco{ get; set; }
        public int IdDivision { get; set; } 
		public string Cod_Empresa{ get; set; } 
		public string Nom_Archivo{ get; set; } 
	    public byte[] Archivo{ get; set; } 
		public Nullable<DateTime> Fecha_Genera{ get; set; }
        public string cod_archivo { get; set; }

        public string fecha_Descripcion { get; set; }

        public Bitmap Ico { get; set; }

     // campos vista vwRo_Archivos_Bancos_Generacion

        public string Descripcion { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public Nullable<DateTime> pe_FechaIni { get; set; }
        public Nullable<DateTime> pe_FechaFin { get; set; }
        public string ca_descripcion { get; set; }
        public string Descripcion_Division { get; set; }
        public Nullable<int> IdBanco_Acredita { get; set; }
        public string IdProceso_Bancario { get; set; }
        public string ba_descripcion { get; set; }
        public string Periodo { get; set; }
        public string rutaArchivo { get; set; }

      //SEGURIDAD
        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<double> Valor { get; set; }

	  public ro_Archivos_Bancos_Generacion_Info(){ }
    }
}
