using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion { get; set; }
        public DateTime Fecha_Conciliacion { get; set; }
        public decimal IdProveedor { get; set; }
        public string Observacion { get; set; }
        public int IdEmpresa_Apro_Ing { get; set; }
        public decimal IdAprobacion_Apro_Ing { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

        public cp_Aprobacion_Ing_Bod_x_OC_Info cp_Aprobacion_Ing_Bod_x_OC { get; set; }

        public cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info()
        {
                
        }
    }
}
