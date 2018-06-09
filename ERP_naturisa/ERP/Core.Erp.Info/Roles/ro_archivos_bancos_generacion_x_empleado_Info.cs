/*CLASE: ro_archivos_bancos_generacion_x_empleado_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 26-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_archivos_bancos_generacion_x_empleado_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdArchivo { get; set; }
        public double Valor { get; set; }
        public bool pagacheque { get; set; }

        public ro_archivos_bancos_generacion_x_empleado_Info() { }
    }
}
