using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{//08052013 10:04
    public class cxc_cobro_tipo_Param_conta_x_sucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCobro_tipo { get; set; }
        public string IdCtaCble { get; set; }     
        public string Sucursal { get; set; }
        public string IdCtaCble_Anticipo { get; set; }
        public cxc_cobro_tipo_Param_conta_x_sucursal_Info()
        {

        }
    }
}
