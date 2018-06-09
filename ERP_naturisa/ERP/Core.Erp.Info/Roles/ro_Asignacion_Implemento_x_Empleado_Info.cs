using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
namespace Core.Erp.Info.Roles
{
    public class ro_Asignacion_Implemento_x_Empleado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdAsignacion_Impl { get; set; }
        public string Tipo_Movimiento { get; set; }
        public System.DateTime Fecha_Entrega { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public List<ro_Asignacion_Implemento_x_Empleado_det_Info> Lst_ro_Asignacion_Implemento_x_Empleado_det { get; set; }
        public in_Ing_Egr_Inven_Info Movimiento_Inventario { get; set; }
        public string pe_nombreCompleto { get; set; }
       
        
    }
}
