/*CLASE: tbROL_Rpt002_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 17-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class tbROL_Rpt002_Info
    {
        public int IdEmpresa{ get; set; } 
		public decimal IdEmpleado{ get; set; } 
		public int IdPeriodo{ get; set; } 
		public string IdRubro{ get; set; } 
		public int IdNomina_Tipo{ get; set; } 
		public int IdNomina_TipoLiqui{ get; set; } 
		public int IdDepartamento{ get; set; } 
		public double Valor{ get; set; } 
		public string IdUsuario{ get; set; } 
		public string pe_nombreCompleto{ get; set; } 
		public string Departamento{ get; set; } 
		public DateTime pe_FechaFin{ get; set; } 
		public DateTime Fecha_Transac{ get; set; } 
		public string em_nombre{ get; set; } 
		public string nom_pc{ get; set; } 
		public string ru_descripcion{ get; set; } 
		public string ru_tipo{ get; set; } 
		public int dias_trabajo{ get; set; } 
		public int dias_vacaciones{ get; set; } 
		public int dias_maternidad{ get; set; }


        public int secuencia { get; set; }
        public string OrgCopy { get; set; }

        //nuevos campos en la tabla 15/11/2013
        public double totIng { get; set; }
        public double totEgr{ get; set; }
        public double totalNeto { get; set; }
        //variable para reporte
        public double Descuento { get; set; }
        public double Ingreso { get; set; }

        

	public tbROL_Rpt002_Info(){ }

    }
}
