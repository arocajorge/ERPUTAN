using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_Retenciones_x_tipo_impresion_Info
    {
        public int IdEmpresa{ get; set; } 
		public string Sucursal{ get; set; } 
		public decimal IdProveedor{ get; set; } 
		public string Proveedor{ get; set; } 
		public decimal NumCbteCXP{ get; set; } 
		public string NumDocumento{ get; set; } 
		public DateTime co_FechaFactura{ get; set; } 
		public DateTime co_FechaFactura_vct{ get; set; } 
		public string Referencia{ get; set; } 
		public double co_total{ get; set; } 
		public double co_valorpagar{ get; set; } 
		public decimal IdRetencion{ get; set; } 
		public string NAutorizacion{ get; set; } 
		public string NumRetencion{ get; set; } 
		public DateTime FechaRT{ get; set; } 
		public string sImpresion{ get; set; } 
		public string TipoImpresion{ get; set; }
        public Boolean chek { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }

        public string serie { get; set; } 
   


        //DEREK 08022014
        public Bitmap Ico { get; set; }


	    public vwcp_Retenciones_x_tipo_impresion_Info(){
            Ico = null;
        }
    }
}
