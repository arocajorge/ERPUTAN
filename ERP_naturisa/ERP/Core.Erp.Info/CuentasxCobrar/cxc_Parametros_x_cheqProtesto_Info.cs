using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_Parametros_x_cheqProtesto_Info
    {
        public int IdEmpresa { get; set; }
        public int secuencia { get; set; }
        public int? pa_IdSucursal_x_default_x_cheqProtes { get; set; }
        public int? pa_IdBodega_x_default_x_cheqProtes { get; set; }
        public decimal? pa_IdProducto_x_ND_x_CheqProtes { get; set; }
        public decimal? pa_IdProducto_x_NC_x_Cobro { get; set; }

        public string Bodega { get; set; }
        public string ProductoND { get; set; }
        public string ProductoNC { get; set; }

        public cxc_Parametros_x_cheqProtesto_Info() { }
    }
}
