using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Derek Mejia
///V 22 02 2014 12.18

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCancelacion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdCobro { get; set; }
        public DateTime cr_fecha { get; set; }
        public DateTime cr_fechaDocu { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public decimal IdCliente { get; set; }
        public string NomCliente { get; set; }
        public double Valor_Aplicado { get; set; }
        public string Referencia { get; set; }


        public vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info() { }

    }
}
