/*CLASE: ro_Participacion_Utilidad_Info
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
    public class ro_Participacion_Utilidad_Info
    {
        public List<ro_Participacion_Utilidad_Empleado_Info> oListRo_Participacion_Utilidad_Empleado_Info = new List<ro_Participacion_Utilidad_Empleado_Info>();

        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public double UtilidadDerechoIndividual { get; set; }
        public double UtilidadCargaFamiliar { get; set; }
        public double LimiteDistribucionUtilidad { get; set; }
        public DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public string Observacion { get; set; }

        public ro_Participacion_Utilidad_Info() { }

    }
}
