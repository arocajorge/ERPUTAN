using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.SeguridadAcceso
{
   public class seg_usuario_x_tb_sis_reporte_Info
    {
        public string IdUsuario { get; set; }
        public string CodReporte { get; set; }
        public string observacion { get; set; }
        public tb_sis_reporte_Info InfoReporte { get; set; }

        public seg_usuario_x_tb_sis_reporte_Info()
        {
            InfoReporte = new tb_sis_reporte_Info();
        }


    }
}
