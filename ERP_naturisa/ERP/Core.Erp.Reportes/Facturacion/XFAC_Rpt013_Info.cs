using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
  public   class XFAC_Rpt013_Info
    {
      public int IdEmpresa { get; set; }
      public string nom_empresa { get; set; }
      public int IdSucursal { get; set; }
      public string nom_sucursal { get; set; }
      public decimal IdCliente { get; set; }
      public string nom_cliente { get; set; }
      public string Cedula_Ruc { get; set; }
      public DateTime fecha { get; set; }
      public string Documento { get; set; }
      public double ? Debito { get; set; }
      public double Credito { get; set; }
      public double  ? Saldo { get; set; }
      public string vt_Observacion { get; set; }

      public double ? SaldoInicial { get; set; }
      public double ? SaldoFinal { get; set; }



    }
}
