using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_GestionProductivaTechos_CusTalme_Cab_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdGestionProductiva{ get; set; } 
		public decimal IdProducto_MateriaPrima{ get; set; } 
		public DateTime? Fecha{ get; set; }
        public int IdModeloProd { get; set; } 
		public TimeSpan HrsTurno{ get; set; }
        public TimeSpan Tprep { get; set; }
        public TimeSpan Despacho { get; set; }
        public double Factor { get; set; } 
		public int Num_Personas{ get; set; } 
		public double Consumo{ get; set; } 
		public double Chatarra{ get; set; } 
		public int IdTurno{ get; set; }
        public string IdUsuario	{ get; set; }
        public DateTime? Fecha_Transac	{ get; set; }
        public string IdUsuarioUltModi	{ get; set; }
        public DateTime? Fecha_UltMod	{ get; set; }
        public string IdusuarioUltAnu	{ get; set; }
        public DateTime? Fecha_UltAnu	{ get; set; }
        public string nom_pc	{ get; set; }
        public string ip	{ get; set; }
        public string Estado	{ get; set; }
        public string pr_descripcion { get; set; }
        public string Descripcion { get; set; }
        public List<prod_GestionProductivaTechos_CusTalme_Detalle_Info> ListaDetalle { get; set; }


	public prod_GestionProductivaTechos_CusTalme_Cab_Info()
    {
        ListaDetalle = new List<prod_GestionProductivaTechos_CusTalme_Detalle_Info>();
    }

	}
}
