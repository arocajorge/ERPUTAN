using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_cbtes_cxp_para_conciliar_Info
    {
        public int IdEmpresa { get; set; }
        public string Su_Descripcion { get; set; }
        public string Tipo { get; set; }
        public decimal IdCbte_cxp { get; set; }        
        public string pr_nombre { get; set; }
        public DateTime co_fechaOg { get; set; }
        public string Referencia { get; set; }
        public DateTime co_FechaFactura { get; set; }
        public DateTime co_FechaFactura_vct { get; set; }
        public string co_observacion { get; set; }
        public int IdEmpresa_cxp { get; set; }
        public int IdTipoCbte_cxp { get; set; }
        public decimal IdCbteCble_cxp { get; set; }
        public double Total_Cancelado { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public double Saldo { get; set; }
        public decimal IdProveedor { get; set; }
        public Boolean check { get; set; }

        //DEREK 24/03/2014
        public double Saldo_x_Pagar2 { get; set; }

        //DEREK 28/03/2014
        public decimal IdPersona { get; set; }
        public string IdTipoPersona { get; set; }


        public string IdCtaCble_CXP { get; set; }
        public string IdCtaCble_Anticipo { get; set; }

        public vwcp_cbtes_cxp_para_conciliar_Info() { }
    }
}