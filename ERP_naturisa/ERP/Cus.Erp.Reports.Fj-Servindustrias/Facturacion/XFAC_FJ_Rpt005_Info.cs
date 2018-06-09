using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt005_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdActivoFijo { get; set; }
       public int IdTipoDepreciacion { get; set; }
       public string CodActivoFijo { get; set; }
       public string Af_Nombre { get; set; }
       public Nullable<double> Af_ValorUnidad_Actu { get; set; }
       public Nullable<double> Valor { get; set; }
       public Nullable<double> Horas_Trabajada_x_Af { get; set; }
       public int IdPeriodo { get; set; }
       public string pe_nombreCompleto { get; set; }
       public Nullable<double> hora_trabajada { get; set; }
       public string Centro_costo { get; set; }

       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
