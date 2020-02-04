using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt009_Info
   {
       public int IdEmpresa { get; set; }
       public int IdPeriodo { get; set; }
       public int IdActivofijo { get; set; }
       public int Secuencia { get; set; }
       public Nullable<System.DateTime> Fecha_adquisicion { get; set; }
       public string Proveedor { get; set; }
       public string Factura { get; set; }
       public Nullable<int> Cantidad { get; set; }
       public string Af_nombre { get; set; }
       public Nullable<double> Costo_Unitario_Camion { get; set; }
       public Nullable<double> Costo_unitario_carroceria { get; set; }
       public Nullable<double> ValorSalvamento { get; set; }
       public Nullable<double> TotalDepreciar { get; set; }
       public Nullable<double> DepreciacionMensual { get; set; }
       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }

    }
}
