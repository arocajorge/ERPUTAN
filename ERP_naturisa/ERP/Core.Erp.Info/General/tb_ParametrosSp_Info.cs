using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_ParametrosSp_Info
    {

        public string Parameter_name { get; set; }
        public string Type { get; set; }
        public Int16  Length { get; set; }
        public Int32 Param_order { get; set; }
        public string Valor { get; set; }

        public tb_ParametrosSp_Info()
        {

        }
    }
}
