using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_empleado_x_ro_rubro_Info
    {
        public ro_rubro_tipo_Info InfoTipoRubro { get; set; }

        public int IdEmpresa { get; set; }
      //  public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public decimal IdEmpleado { get; set; }

        public string IdRubro { get; set; }
       // public int Secuencia { get; set; }
        public decimal Valor { get; set; }


        // campos de la vista vwRo_Nomina_x_Liqui_x_Rubro_x_Empleado
        public string Descripcion{ get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string rub_codigo { get; set; }
        public string ru_descripcion { get; set; }
        public string IdCentroCosto { get; set; }


        public ro_empleado_x_ro_rubro_Info ()
        {
            InfoTipoRubro = new ro_rubro_tipo_Info();
        }

    }
}
