using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_rpt_cobro_Info
    {
        public tb_Empresa_Info infoEmp { get; set; }

        public List<cxc_cobro_Det_Info> listaP { get; set; }
        public cxc_cobro_Info cobro { get; set; }

        public string Sucursal { get; set; }
        public string idUsuario { get; set; }
        public string TipoCobro { get; set; }
        public decimal Total { get; set; }

        public cxc_rpt_cobro_Info()
        { 
            infoEmp = new tb_Empresa_Info();
            listaP = new List<cxc_cobro_Det_Info>();
            cobro = new cxc_cobro_Info();
        }
    }
}
