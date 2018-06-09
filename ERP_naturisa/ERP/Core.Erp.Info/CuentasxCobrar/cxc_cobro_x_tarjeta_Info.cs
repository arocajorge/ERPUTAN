using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_tarjeta_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCobro_Aplicado { get; set; }
        public decimal IdCbte_vta_aplicado { get; set; }
        public string IdCobro_tipo_Aplicado { get; set; }
        public string pa_IdCobro_tipo_Comision_TC { get; set; }

        public cxc_cobro_x_tarjeta_Info()
        {

        }
    }
}
