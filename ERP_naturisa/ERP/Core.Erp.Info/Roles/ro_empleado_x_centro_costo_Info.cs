/*CLASE: ro_empleado_x_centro_costo_Info
 *CREADO POR: ALBERTO MENA
 *FECHA: 21-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_empleado_x_centro_costo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo{ get; set; }
        public DateTime  FechaIngresa{ get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }


        //VISTA
        public string Centro_costo { get; set; }


        public ro_empleado_x_centro_costo_Info() { }

    }
}
