using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public int IdNomina_tipo_Liq { get; set; }
       public int IdPeriodo { get; set; }
       public int IdEmpleado { get; set; }
       public int IdRuta { get; set; }
       public int IdEfectividad { get; set; }
       public double Efectividad_Entrega { get; set; }
       public double Efectividad_Entrega_aplica { get; set; }
       public double Efectividad_Volumen { get; set; }
       public double Efectividad_Volumen_aplica { get; set; }
       public double Recuperacion_cartera { get; set; }
       public double Recuperacion_cartera_aplica { get; set; }
       public string Observacion { get; set; }
       public bool icono_eliminar { get; set; }
       //vista
       public string pe_nombreCompleto { get; set; }
       public string de_descripcion { get; set; }
       public string ca_descripcion { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string ruta_excel { get; set; }
       public string ru_descripcion { get; set; }
       public string Error { get; set; }
       public Nullable<int> IdZona { get; set; }
       public int IdGrupo { get; set; }
       public DateTime fecha_Pago { get; set; }
   }
}
