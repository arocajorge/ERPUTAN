using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//V211013
namespace Core.Erp.Info.Roles
{
   public class vwRo_Prestamo_Info
    {
       public int IdEmpresa{ get; set; } 
		public decimal IdPrestamo{ get; set; } 
		public int IdNomina_Tipo{ get; set; } 
		public string nomi_descripcion{ get; set; } 
		public decimal IdEmpleado{ get; set; } 
		public string pe_nombre{ get; set; } 
		public string pe_apellido{ get; set; } 
		public string IdRubro{ get; set; } 
		public string ru_descripcion{ get; set; } 
		public decimal IdEmpleado_Aprueba{ get; set; } 
		public string pe_nombre_apru{ get; set; } 
		public string pe_apellido_apru{ get; set; } 
		public string Codigo{ get; set; } 
		public string ca_descripcion{ get; set; } 
		public string Estado{ get; set; } 
		public DateTime Fecha{ get; set; } 
		public double MontoSol{ get; set; } 
		public double TasaInteres{ get; set; } 
		public int NumCuotas{ get; set; } 
		public string cod_pago{ get; set; } 
		public string peri_pago{ get; set; } 
		public DateTime Fecha_PriPago{ get; set; } 
		public string Observacion{ get; set; } 
		public Nullable<Double> TotalPrestamo{ get; set; }
        public string Tipo_Calculo { get; set; }
       public Nullable<Double> TotalCobrado {get; set;}
       public Nullable<Double> SaldoPrestamo { get; set; }

       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string MotiAnula { get; set; }

        public vwRo_Prestamo_Info() 
        {
        
        }


    }
}
