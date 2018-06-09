using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public class ro_historico_liquidacion_vacaciones_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public int IdSolicitud_Vacaciones { get; set; }
       public decimal IdEmpleado { get; set; }
       public decimal IdOrdenPago { get; set; }
       public int IdEmpresa_OP { get; set; }
       public double ValorCancelado { get; set; }
       public System.DateTime FechaPago { get; set; }
       public string Observaciones { get; set; }
       public string IdUsuario { get; set; }
       public string Estado { get; set; }
       public Nullable<System.DateTime> Fecha_Transac { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> FechaHoraAnul { get; set; }
       public string MotiAnula { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public string EstadoContrato { get; set; }

       public List<ro_Historico_Liquidacion_Vacaciones_Det_Info> detalle { get; set; }

    }
}
