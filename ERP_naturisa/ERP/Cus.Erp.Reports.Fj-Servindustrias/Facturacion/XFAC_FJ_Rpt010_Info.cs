using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
  public  class XFAC_FJ_Rpt010_Info
  {
      public int IdEmpresa { get; set; }
      public int IdPeriodo { get; set; }
      public int secuencia { get; set; }
      public decimal IdProveedor { get; set; }
      public Nullable<System.DateTime> Fecha { get; set; }
      public string Proveedor { get; set; }
      public Nullable<int> Cantidad { get; set; }
      public string Factura { get; set; }
      public string Descripcion { get; set; }
      public Nullable<double> Costounitario { get; set; }
      public Nullable<double> Total { get; set; }
      public string Fuerza { get; set; }
      public string NombreServicio { get; set; }
      public string em_nombre { get; set; }
      public byte[] em_logo { get; set; }
    }
}
