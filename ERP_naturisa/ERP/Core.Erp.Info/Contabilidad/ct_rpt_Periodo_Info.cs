using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_rpt_Periodo_Info
    {

        public tb_Empresa_Info infoEmp { get; set; }
        public List<ct_Periodo_Info> lista { get; set; }
        public string idUsuario { get; set; }
        
        public ct_rpt_Periodo_Info()
        {
            infoEmp = new tb_Empresa_Info();
            lista = new List<ct_Periodo_Info>();
        }
    }

}
