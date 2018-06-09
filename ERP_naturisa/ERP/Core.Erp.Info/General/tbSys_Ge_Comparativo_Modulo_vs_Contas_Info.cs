using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
  public  class tbSys_Ge_Comparativo_Modulo_vs_Contas_Info
    {

      public int IdEmpresa { get; set; }
      public int IdSucursal { get; set; }
      public string cod_sucu { get; set; }
      public int ?IdBodega { get; set; }
      public decimal? IdCbteVta { get; set; }
      public string vt_tipoDoc { get; set; }
      public string vt_serie1 { get; set; }
      public string vt_serie2 { get; set; }
      public string vt_NumFactura { get; set; }
      public decimal ?IdCliente { get; set; }
      public string pe_nombreCompleto { get; set; }
      public DateTime vt_fecha { get; set; }
      public string vt_Observacion { get; set; }
      public double ?Debito_Vta { get; set; }
      public double ?Credito_Vta { get; set; }
      public double ?Debito_Conta { get; set; }
      public double ?Credito_Conta { get; set; }
      public string pc_Cuenta { get; set; }
      public int ?IdEmpresa_ct { get; set; }
      public int ?IdTipoCbte_ct { get; set; }
      public decimal ?IdCbteCble_ct { get; set; }
      public int ?secuencia { get; set; }
      public string TIPO { get; set; }
      public string referencia { get; set; }
      public DateTime ?cb_Fecha { get; set; }
      public string cb_Observacion { get; set; }
      public string IdCtaCble { get; set; }
      public double ? Diferencia { get; set; }






    }
}
