using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina { get; set; }
        public int IdNomina_tipo { get; set; }
        public int IdPeriodo { get; set; }

        public decimal IdEmpleado { get; set; }
        public string IdRegistro { get; set; }
        public string IdRubro { get; set; }
        public System.DateTime es_fecha_registro { get; set; }
        public System.DateTime FechaPago { get; set; }

        public string Num_horasExtras { get; set; }
        public string Observacion { get; set; }
        public bool Estado_aprobacion { get; set; }
       // campos vista
        public string ru_descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public Nullable<double> SueldoActual { get; set; }
        public int Calculo_Horas_extras_Sobre { get; set; }
        public int Max_num_horas_sab_dom { get; set; }
        public int IdTipoNomina { get; set; }
    }
}
