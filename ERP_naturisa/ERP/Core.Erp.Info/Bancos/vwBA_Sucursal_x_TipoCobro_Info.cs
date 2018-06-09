using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class vwBA_Sucursal_x_TipoCobro_Info
    {
        public int? IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string IdCobro_tipo { get; set; }
        public string tc_descripcion { get; set; }
        public string IdCtaCble_Deudora { get; set; }
        public string IdCtaCble_Credito { get; set; }

        public vwBA_Sucursal_x_TipoCobro_Info()
        {

        }
    }
}
