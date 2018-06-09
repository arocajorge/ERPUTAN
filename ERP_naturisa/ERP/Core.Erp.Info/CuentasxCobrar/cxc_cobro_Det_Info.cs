using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    //version 07/jun/2013 09:59

    public class cxc_cobro_Det_Info
    {
        public int IdEmpresa{ get; set; } 
	    public int IdSucursal{ get; set; } 
	    public decimal IdCobro{ get; set; } 
	    public int secuencial{ get; set; } 
	    public string dc_TipoDocumento{ get; set; } 
	    public int IdBodega_Cbte{ get; set; } 
	    public decimal IdCbte_vta_nota{ get; set; } 
	    public double dc_ValorPago{ get; set; } 
	    public string IdUsuario{ get; set; } 
	    public DateTime Fecha_Transac{ get; set; } 
	    public string IdUsuarioUltMod{ get; set; } 
	    public DateTime Fecha_UltMod{ get; set; } 
	    public string IdUsuarioUltAnu{ get; set; } 
	    public DateTime Fecha_UltAnu{ get; set; } 
	    public string nom_pc{ get; set; } 
	    public string ip{ get; set; } 
	    public string estado{ get; set; }
        public string Documento_Cobrado { get; set; }
        public string IdCobro_tipo { get; set; }

        


        public cxc_cobro_Det_Info()
        {

        }
    }
}
