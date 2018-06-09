/*CLASE: ro_Participacion_Utilidad_Empleado_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 28-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Participacion_Utilidad_Empleado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public double DiasTrabajados { get; set; }
        public double CargasFamiliares { get; set; }
        public double ValorIndividual { get; set; }
        public double ValorCargaFamiliar { get; set; }
        public double ValorExedenteIESS { get; set; }
        public double ValorTotal { get; set; }

        public ro_Participacion_Utilidad_Empleado_Info() { }
    }
}
