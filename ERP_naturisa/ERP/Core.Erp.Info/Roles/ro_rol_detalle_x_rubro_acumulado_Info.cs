/*CLASE: ro_rol_detalle_x_rubro_acumulado_Info
 *CREADA POR: ALBERTO MENA
 *FECHA: 15-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_rol_detalle_x_rubro_acumulado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public double Valor { get; set; }
        public string Estado { get; set; }

        //VISTA
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string RubroDescripcion { get; set; }
        public string Cerrado { get; set; }
        public string Procesado { get; set; }
        public string Contabilizado { get; set; }
        public int? pe_anio { get; set; }
        public int? pe_mes { get; set; }
        public DateTime pe_FechaIni { get; set; }
        public DateTime pe_FechaFin { get; set; }

        public ro_rol_detalle_x_rubro_acumulado_Info() { }
    }
}
