using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Derek Mejia
///V 22 02 2014 12.18

//ULT. MOD = DEREK MEJIA 12/02/2014
namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cancelacion_Intercompany_Info
	{
		public int IdEmpresa{ get; set; } 
		public decimal IdCancelacion{ get; set; } 
		public decimal IdCliente{ get; set; } 
		public string IdCobro_tipo{ get; set; } 
		public int? IdBanco_Deposito{ get; set; } 
		public string Observacion{ get; set; } 
		public string PapeletaDeposito{ get; set; } 
		public int? cbteban_IdEmpresa{ get; set; } 
		public decimal? cbteban_IdCbteCble{ get; set; } 
		public int? cbteban_IdTipocbte{ get; set; } 
		public double? cr_TotalCobro{ get; set; } 
		public DateTime? cr_fecha{ get; set; } 
		public DateTime? cr_fechaDocu{ get; set; }
        public DateTime? cr_fechaCobro { get; set; } 
		public string cr_observacion{ get; set; } 
		public string cr_Banco{ get; set; } 
		public string cr_cuenta{ get; set; } 
		public string cr_NumDocumento{ get; set; } 
		public string cr_Tarjeta{ get; set; } 
		public string cr_propietarioCta{ get; set; } 
		public string cr_estado{ get; set; } 
		public DateTime? Fecha_Transac{ get; set; } 
		public string IdUsuario{ get; set; } 
		public string IdUsuarioUltMod{ get; set; } 
		public DateTime? Fecha_UltMod{ get; set; } 
		public string IdUsuarioUltAnu{ get; set; } 
		public DateTime? Fecha_UltAnu{ get; set; } 
		public string nom_pc{ get; set; } 
		public string ip{ get; set; } 
		public int IdSucursal{ get; set; } 
		public string GeneraDeps{ get; set; }

        public string NombreCliente{ get; set; }
        public string NombreSucursal { get; set; }
        public String NombreTipoCobro { get; set; }

        //Derek Mejia 14/02/2014
        public int IdCaja { get; set; }
        public string IdTipoNotaCredito { get; set; }    
    
        //DErek Mejia 21/02/2014
        public string NomEmp { get; set; }

	    public cxc_cancelacion_Intercompany_Info(){ }
    }
}
