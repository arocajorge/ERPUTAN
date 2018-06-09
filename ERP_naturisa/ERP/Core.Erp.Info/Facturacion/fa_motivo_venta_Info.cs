using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
   public  class fa_motivo_venta_Info
    {
       public int IdEmpresa { get; set; }
       public int IdMotivo_Vta { get; set; }
       public string codMotivo_Vta { get; set; }
       public string descripcion_motivo_vta { get; set; }
       public string Estado { get; set; }
       public DateTime FechaModificacion { get; set; }
       public DateTime FechaCreacion { get; set; }
       public string UsuarioModificacion { get; set; }
       public string UsuarioCreacion { get; set; }
       public DateTime FechaAnulacion { get; set; }
       public string UsuarioAnulacion { get; set; }
       public string MotivoAnulacion { get; set; }
    }
}
