
/*CLASE: ro_Novedad_x_Empleado_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Novedad_x_Empleado_Info
    {
        public int IdEmpresa {get; set ;}
        public decimal IdTransaccion { get; set; } 
        public int IdEmpresa_Emp_Novedad {get; set ;}
        public decimal IdNovedad_Emp_Novedad {get; set ;}
        public decimal IdEmpleado_Emp_Novedad {get; set ;}
        public string Observacion {get; set ;}
        public string  estado {get; set ;}
        public DateTime Fecha {get; set ;}
        public int IdNomina_Tipo {get; set ;}
        public int IdNomina_TipoLiqui {get; set ;}
        public string IdRubro {get; set ;}

        public ro_Novedad_x_Empleado_Info() { 
        
        }
    }
}
