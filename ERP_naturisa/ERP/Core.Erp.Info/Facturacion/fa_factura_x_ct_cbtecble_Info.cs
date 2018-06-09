using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_x_ct_cbtecble_Info
    {

        public int vt_IdEmpresa{ get; set; }
        public int vt_IdSucursal { get; set; }
        public int vt_IdBodega { get; set; }
        public decimal vt_IdCbteVta { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }
        public string Motivo { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public fa_factura_x_ct_cbtecble_Info()
        {

        }
    }
}
