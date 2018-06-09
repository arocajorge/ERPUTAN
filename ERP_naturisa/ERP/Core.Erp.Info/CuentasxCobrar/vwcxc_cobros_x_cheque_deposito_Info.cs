using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cobros_x_cheque_deposito_Info
    {
        //YYANTEN 19/03/2014

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public decimal IdCobro { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCobro_tipo { get; set; }
        public string TipoCobro { get; set; }
        public string IdEstadoCobro { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCobro { get; set; }
        public string Banco_del_cheq { get; set; }
        public string Cuenta { get; set; }
        public string Num_Cheq { get; set; }
        public double TotalCobro { get; set; }
        public decimal? mcj_IdCbteCble { get; set; }
        public int? mcj_IdTipocbte { get; set; }
        public int? IdCaja { get; set; }
        public string CodCaja { get; set; }
        public decimal? ba_IdCbteCble { get; set; }
        public int? ba_IdTipocbte { get; set; }
        public DateTime? Fecha_dep { get; set; }
        public int? IdBanco_dep { get; set; }
        public string Banco_deposito { get; set; }
        public string Cliente { get; set; }
        public Boolean Check { get; set; }
        public string Referencia { get; set; } // aun no esta agregada en la vista por el sensei 19/03/2014

        public vwcxc_cobros_x_cheque_deposito_Info()
        {

        }

    

    }
}
