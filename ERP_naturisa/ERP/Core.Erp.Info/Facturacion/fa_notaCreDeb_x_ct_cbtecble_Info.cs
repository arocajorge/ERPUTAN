using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_x_ct_cbtecble_Info
    {
        public int no_IdEmpresa { get; set; }
        public int no_IdSucursal { get; set; }
        public int no_IdBodega { get; set; }
        public decimal no_IdNota { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }
        public fa_notaCreDeb_x_ct_cbtecble_Info()
        {

        }
    }
}
