using Core.Erp.Info.ActivoFijo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_det_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdTarifario { get; set; }
       public int Secuencia { get; set; }
       public int cantidad { get; set; }
       public double Valor_x_Unidad { get; set; }
       public double Unidades_minimas { get; set; }
       public string IdUsuario { get; set; }
       public string Estado { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> FechaUltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string MotiAnula { get; set; }
       public Nullable<int> IdCategoriaAF { get; set; }

       public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> lst_det_x_af { get; set; }
       public List<Af_Activo_fijo_Info> lst_Activos { get; set; }

       
   }
}
