using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_GestionProductivaAcero_CusTalme_Info
	{


		public int IdEmpresa{ get; set; } 
		public int IdSucursal{ get; set; } 
		public decimal IdGestionAceria{ get; set; } 
		public DateTime Fecha{ get; set; } 
		public int IdHorno{ get; set; } 
		public decimal IdColada{ get; set; } 
		public double chat_En_Horno{ get; set; } 
		public double chat_Cargada{ get; set; } 
		public double Vaci_TempC{ get; set; } 
		public double Vaci_acero{ get; set; } 
		public double EnHor_Acero{ get; set; } 
		public double EnHor_Perdida{ get; set; } 
		public double Comps_C{ get; set; } 
		public double Comps_Si{ get; set; } 
		public double Comps_Mn{ get; set; } 
		public double Comps_P{ get; set; } 
		public double Comps_S{ get; set; } 
		public double Comps_SAE{ get; set; } 
		public double AdiMet_Carburante{ get; set; } 
		public double AdiMet_Cal{ get; set; } 
		public double AdiMet_Desercoriante{ get; set; } 
		public TimeSpan Tiem_Encendido{ get; set; } 
		public TimeSpan Tiem_Apagado{ get; set; } 
		public TimeSpan Tiem_Fundicion{ get; set; } 
		public TimeSpan Tiem_Vaciado{ get; set; } 
		public TimeSpan Tiem_Total{ get; set; } 
		public double Ener_Ea{ get; set; } 
		public double Ener_Er{ get; set; } 
		public double Ener_Total{ get; set; } 
		public double Ferroa_FeSi{ get; set; } 
		public double Ferroa_FeMn{ get; set; } 
		public double IndiHor_Rendimiento{ get; set; } 
		public double IndiHor_Productividad{ get; set; } 
		public decimal Tundish{ get; set; } 
		public TimeSpan InicioCC{ get; set; } 
		public TimeSpan FinCC{ get; set; }
        public TimeSpan Tiempo { get; set; } 
		public double AceroCldo{ get; set; } 
		public double Palanquilla{ get; set; } 
		public double Marrano{ get; set; } 
		public double Escoria{ get; set; } 
		public double PerdidaCC{ get; set; } 
		public double RendtCC{ get; set; } 
		public double ProductivCC{ get; set; } 
		public double IdProducto_TipoPalanquilla{ get; set; } 
		public double Unidades{ get; set; } 
		public double Longitud{ get; set; } 
		public double PesoUnitario{ get; set; } 
		public double PesoMetro{ get; set; } 
		public double Perdida{ get; set; } 
		public double ProdRend{ get; set; } 
		public double ProdProduct{ get; set; } 
		public string Observacion{ get; set; } 
		public string IdUsuario{ get; set; } 
		public DateTime Fecha_Transaccion{ get; set; } 
		public string IdUsuarioUltModi{ get; set; } 
		public DateTime Fecha_UltMod{ get; set; } 
		public DateTime? Fecha_UltAnu{ get; set; } 
		public string MotivoAnulacion{ get; set; } 
		public string nom_pc{ get; set; } 
		public string ip{ get; set; } 
		public string Estado{ get; set; }

        public string Horno { get; set; }
        public string Su_Descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<double> FeSiMn { get; set; }
        public Nullable<double> Termopares { get; set; }

	public prod_GestionProductivaAcero_CusTalme_Info(){ }

	}
}
