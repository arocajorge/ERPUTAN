/*CLASE: vwro_empleado_por_novedades_cabecera_Info
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
    public class vwro_empleado_por_novedades_cabecera_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public string IdRubro { get; set; }
        public string DescripcionRubro { get; set; }
        public int TipoNomina { get; set; }
        public string DescripcionNomina { get; set; }
        public int TipoLiquidacion { get; set; }
        public string DescripcionProceso { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }

        public vwro_empleado_por_novedades_cabecera_Info() { }
    }
}
    