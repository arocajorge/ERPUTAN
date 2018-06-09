using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_rpt_Cbtecble_Info
    {
        
        public tb_Empresa_Info infoEmp { get; set; }
        public List<ct_Cbtecble_Info> lista { get; set; }
        public string idUsuario { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        //public ct_Cbtecble_Info info { get; set; }

        public ct_rpt_Cbtecble_Info() {

            infoEmp = new tb_Empresa_Info();
            lista = new List<ct_Cbtecble_Info>();

        }
    }
}
