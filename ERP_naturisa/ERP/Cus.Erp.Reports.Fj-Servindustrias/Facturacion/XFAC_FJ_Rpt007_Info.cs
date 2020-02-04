using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt007_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdPreFacturacion { get; set; }
       public int IdPeriodo { get; set; }
       public int IdNomina_Tipo { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdCargo { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_nombreCompleto { get; set; }
       public string ca_descripcion { get; set; }
       public Nullable<double> SALARIO { get; set; }
       public Nullable<double> H_EXTRAS { get; set; }
       public Nullable<double> ALIMENTACION { get; set; }
       public  Nullable<double> Total_Ingreso { get; set; }
       public Nullable<double> Total_mas_Beneficio { get; set; }
       public Nullable<double> total_ManoObra { get; set; }
       public string Centro_costo { get; set; }
       public string IdCentroCosto_sub_centro_costo { get; set; }
       public string IdCentroCosto { get; set; }
       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
