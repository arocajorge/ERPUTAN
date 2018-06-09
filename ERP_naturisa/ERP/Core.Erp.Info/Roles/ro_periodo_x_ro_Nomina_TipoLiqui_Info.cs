using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///Prog: Héctor Ayauca
///V 10.13 22022014
///



namespace Core.Erp.Info.Roles
{
   public class ro_periodo_x_ro_Nomina_TipoLiqui_Info
    {
        public bool check { get; set; }
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }     
        public string Cerrado { get; set; }
        public string Contabilizado { get; set; }

        public DateTime pe_FechaIni { get; set; }
        public DateTime pe_FechaFin { get; set; }
        public string pe_Descripcion { get; set; }

        public string Tipo { get; set; }
        public int pe_anio { get; set; }
        public int pe_mes { get; set; }

       public string Procesado { get; set; }

        public ro_periodo_x_ro_Nomina_TipoLiqui_Info() { }
    }
}
