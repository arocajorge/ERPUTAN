using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cobros_x_vta_nota_x_Ret_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public Nullable<int> IdBodega_Cbte { get; set; }
        public decimal IdCbte_vta_nota { get; set; }
        public Nullable<double> dc_ValorPago { get; set; }
        public string ESRetenFTE { get; set; }
        public string IdCobro_tipo { get; set; }
        public string tc_descripcion { get; set; }
        public Nullable<double> PorcentajeRet { get; set; }
        public string ESRetenIVA { get; set; }
        public Nullable<double> Base{ get; set; }
        public string cr_NumDocumento { get; set; }
        public DateTime cr_fecha { get; set; }
        public DateTime cr_fechaDocu { get; set; }
        public Boolean Modificable { get; set; }

        public vwcxc_cobros_x_vta_nota_x_Ret_Info()
        {
            cr_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            cr_fechaDocu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            Modificable = true;

        }
    }
}
