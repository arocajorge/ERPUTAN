using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt003_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdCotizacion { get; set; }
       public int IdSucursal { get; set; }
       public int Secuencia { get; set; }
       public Nullable<decimal> Idproducto { get; set; }
       public Nullable<double> Cant_soli { get; set; }
       public Nullable<double> Cant_a_cotizar { get; set; }
       public Nullable<decimal> IdListadoMateriales_lq { get; set; }
       public string nom_sucursal { get; set; }
       public Nullable<System.DateTime> FechaReg { get; set; }
       public Nullable<int> IdDetalle_lq { get; set; }
       public string pr_descripcion { get; set; }
       public string Observacion { get; set; }
       public string pr_nombre { get; set; }
       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
