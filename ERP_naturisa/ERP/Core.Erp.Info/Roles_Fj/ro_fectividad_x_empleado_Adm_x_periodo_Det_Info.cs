using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_fectividad_x_empleado_Adm_x_periodo_Det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public int IdNomina_Tipo_Liq { get; set; }
       public int IdPeriodo { get; set; }
       public decimal IdEmpleado { get; set; }
       public string cod_Pago_Variable { get; set; }
       public Nullable<double> Meta { get; set; }
       public Nullable<double> Real { get; set; }
       public Nullable<double> Cumplimiento { get; set; }
       public Nullable<double> Variable_porcentaje_prorrateado { get; set; }


       //public string IdRubro { get; set; }
       public string ru_descripcion { get; set; }
       public double Valor_bono { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string pe_NombreCompleto { get; set; }
       public decimal valor_ganado { get; set; }
       public string IdRubro { get; set; }
       public DateTime fechaPago { get; set; }
       //public string cod_Pago_Variable { get; set; }
       public ero_parametro_x_pago_variable_tipo cod_Pago_Variable_enum { get; set; }


       




       public Nullable<int> cantidad_empleados_nuevos { get; set; }
       public Nullable<int> cantidad_empleados_salieron { get; set; }
       public Nullable<int> cantidad_empleados_activos { get; set; }
       public Nullable<int> Total_Asistencia { get; set; }
       public Nullable<int> Total_Faltas { get; set; }
       public Nullable<double> efectividad_entrega { get; set; }
       public Nullable<double> efectividad_volumen { get; set; }
       public Nullable<double> recuperacion_cartera { get; set; }


    }
}
