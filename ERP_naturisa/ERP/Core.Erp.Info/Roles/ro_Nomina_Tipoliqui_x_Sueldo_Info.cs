using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Nomina_Tipoliqui_x_Sueldo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public double PorSueldo { get; set; }

        public string TipoNominaDescripcion { get; set; }
        public string LiquidacionDescripcion { get; set; }



        public ro_Nomina_Tipoliqui_x_Sueldo_Info() { }
    }
}
