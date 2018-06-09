using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

	public class prod_CompraChatarra_CusTalme_Info
	{


		public int IdEmpresa{ get; set; } 
		public decimal IdLiquidacion{ get; set; } 
		public decimal IdProveedor_Presu{ get; set; } 
		public decimal IdProveedor{ get; set; } 
		public DateTime Fecha{ get; set; } 
		public string Beneficiario{ get; set; } 
		public string Placa{ get; set; } 
		public int IdTipoChatarra{ get; set; } 
		public double PrecioChatarra{ get; set; } 
		public double TLlenoKg{ get; set; } 
		public double TVacionKg{ get; set; } 
		public double TMermaKg{ get; set; } 
		public double Subtotal{ get; set; } 
		public double Descuento{ get; set; } 
		public double Total{ get; set; }
        public double? TNetokg { get; set; }
        public string TipoChatarra { get; set; }
        public string Proveedor { get; set; }
        public string Presupuesto { get; set; }


	public prod_CompraChatarra_CusTalme_Info(){ }






    public string IdUsuario { get; set; }

    public string IdUsuarioUltModi { get; set; }

    public DateTime? Fecha_Transaccion { get; set; }

    public DateTime? Fecha_UltMod { get; set; }

    public string ip { get; set; }

    public string nom_pc { get; set; }

    public DateTime? Fecha_UltAnu { get; set; }

    public string Estado { get; set; }
    }
}
