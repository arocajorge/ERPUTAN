using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
namespace Core.Erp.Info.Contabilidad
{
    public class ct_rpt_Cble_Tipo_Info
    {
        public tb_Empresa_Info infoEmp { get; set; }
        public List<ct_Cbtecble_tipo_Info> lista { get; set; }
        public string idUsuario { get; set; }

        public ct_rpt_Cble_Tipo_Info()
        {
            infoEmp = new tb_Empresa_Info();
            lista = new List<ct_Cbtecble_tipo_Info>();
        }
    }
}
