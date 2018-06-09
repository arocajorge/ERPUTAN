using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
  public  class vwfa_creditos_debitos_con_saldo_Info
    {
      public int IdEmpresa { get; set; }
      public int IdSucursal { get; set; }
      public int IdBodega { get; set; }
      public string Tipo { get; set; }
      public decimal IdNota { get; set; }
      public string CreDeb { get; set; }

      public string Serie1 { get; set; }
      public string Serie2 { get; set; }
      public string NumNota_Impresa { get; set; }
      public decimal IdCliente { get; set; }

      public string NomSucursal { get; set; }
      public string Nom_Bodega { get; set; }
      public DateTime no_fecha { get; set; }
      public DateTime no_fecha_venc { get; set; }
      public string sc_observacion { get; set; }
      public string Nom_Cliente { get; set; }

      public string Motivo_Nota { get; set; }
      public string Referencia { get; set; }
      public double sc_total { get; set; }
      public double Saldo { get; set; }

      public Boolean check_cds { get; set; }

      //haac 06/03/2014
      public double saldoAUX_CreDeb { get; set; }
      //haac 10/03/2014
      public string IdTipoConciliacion { get; set; }
                  
      public vwfa_creditos_debitos_con_saldo_Info() { }
    }
}
