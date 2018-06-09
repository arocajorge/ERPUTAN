using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
   public class cxc_conciliacion_det_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public decimal IdConciliacion { get; set; }
       public int Secuencia { get; set; }
       public string  IdTipoConciliacion { get; set; }
       public int? IdEmpresa_nt { get; set; }
       public int? IdSucursal_nt { get; set; }
       public int? IdBodega_nt { get; set; }
       public decimal? IdNota_nt { get; set; }
       public int?  IdEmpresa_fa { get; set; }
       public int? IdSucursal_fa { get; set; }
       public int? IdBodega_fa { get; set; }
       public decimal? IdCbteVta_fa { get; set; }
       public double Saldo_por_aplicar { get; set; }
       public double Valor_Aplicado { get; set; }
       public string TipoDoc_vta { get; set; }

       //haac 10/03/2014
       public int? IdEmpresa_cbr { get; set; }
       public int? IdSucursal_cbr { get; set; }
       public decimal? IdCobro { get; set; }

       //haac 07/03/2014
       //vwcxc_cartera_x_cobrar_Info
       public Boolean check { get; set; }

       //haac 10/03/2014
       //vwfa_creditos_debitos_con_saldo
       public Boolean check_cds { get; set; }


       //haac 10/03/2014
       //vwcxc_cobros_Pendientes_x_conciliar
       public string IdCobro_Tipo { get; set; }
       public int IdTipoNota { get; set; }
       public int IdCaja { get; set; }


       public cxc_conciliacion_det_Info() { }
    }
}
