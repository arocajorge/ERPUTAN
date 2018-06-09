using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_caj_Caja_Movimiento_Info
    {
        public int cbr_IdEmpresa{ get; set; } 
	    public int cbr_IdSucursal{ get; set; } 
	    public decimal cbr_IdCobro{ get; set; } 
	    public int mcj_IdEmpresa{ get; set; } 
	    public decimal mcj_IdCbteCble{ get; set; } 
	    public int mcj_IdTipocbte{ get; set; } 

        //haac 29/01/2014

        //campos extras de la vista vwcxc_cobro_x_caj_Caja_Movimiento
        public string em_nombre{ get; set; }
        public string Su_Descripcion { get; set; }
        public string tc_descripcion{ get; set; }
        public string tc_TipoCbte { get; set; }

        //haac 07/02/2014
        //campos extras de la vista vwcxc_cobro_x_movi_caja_x_cbtecble 
     
        public string IdCobro_tipo { get; set; } 
        public double? cr_TotalCobro { get; set; }
        public DateTime cr_fecha { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento{ get; set; }
        public int IdCaja { get; set; }
        public string ca_Descripcion { get; set; }
        public decimal  Movi_Caja { get; set; }
        public string tm_descripcion{ get; set; }
        public string tc_TipoCbte2 { get; set; }
        public decimal Num_CbteCble { get; set; }
    }
}
