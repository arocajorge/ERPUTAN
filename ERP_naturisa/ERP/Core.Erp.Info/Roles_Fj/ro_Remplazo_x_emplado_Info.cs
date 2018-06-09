using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_Remplazo_x_emplado_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdEmpleado { get; set; }
       public decimal IdPersona { get; set; }
       public decimal IdEmpleado_Remplazo { get; set; }
       public int Id_remplazo { get; set; }
       public Nullable<int> IdNomina_Tipo { get; set; }
       public Nullable<int> IdNomina_TipoLiqui { get; set; }
       public Nullable<int> IdPeriodo { get; set; }
       public string IdRubro { get; set; }
       public Nullable<decimal> IdNovedad { get; set; }
       public Nullable<double> Valor_descuento_empleado { get; set; }
       public Nullable<System.DateTime> Fecha_descuenta_rol { get; set; }
       public double valor_x_dia_remplazo { get; set; }
       public double Total_pagar_remplazo { get; set; }
       public bool Descuenta_rol { get; set; }
       public System.DateTime Fecha { get; set; }
       public int Id_Motivo_Ausencia_Cat { get; set; }
       public int Id_Tipo_tipo_Remplazo_Cat { get; set; }
       public System.DateTime Fecha_Salida { get; set; }
       public System.DateTime Fecha_Entrada { get; set; }
       public Nullable<System.TimeSpan> Hora_salida { get; set; }
       public Nullable<System.TimeSpan> Hora_regreso { get; set; }
       public string Observacion { get; set; }
       public string IdUsuario { get; set; }
       public Nullable<System.DateTime> Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string Estado { get; set; }
       public string MotiAnula { get; set; }
    
       // vvista

       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string pe_nombreCompleto { get; set; }
    }
}
