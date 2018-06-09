/*CLASE: ro_Empleado_X_Horario_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 12-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public  class ro_Empleado_X_Horario_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdHorario { get; set; }
        public Boolean EsPredeterminado { get; set; }
        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }

        public ro_Empleado_X_Horario_Info() { }
    }
}
