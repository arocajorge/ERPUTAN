using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAsignacion_Impl { get; set; }
        public decimal IdProducto { get; set; }
        public int secuencia { get; set; }
        public string Detalle { get; set; }
        public int Vida_Util { get; set; }
        public double Cantidad { get; set; }
        public System.DateTime Fecha_Caducidad { get; set; }
        public string Estado_implemnto { get; set; }
    
    }
}
