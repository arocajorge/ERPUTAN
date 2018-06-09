/*CLASE: ro_rol_individual_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 04-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_rol_individual_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public double Ingreso { get; set; }
        public double Egreso { get; set; }
        public int Orden { get; set; }
        public string FechaPago { get; set; }
        public ro_rol_individual_Info() { }
    }
}
