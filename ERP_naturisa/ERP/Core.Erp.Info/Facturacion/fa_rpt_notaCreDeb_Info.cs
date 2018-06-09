using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_notaCreDeb_Info
    {

         
        public fa_notaCreDeb_Info InfoNota { get; set; }
        public tb_Empresa_Info empresainfo { get; set; }
        public String idUsuario { get; set; }

        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public List<fa_notaCreDeb_det_Info> listadetalle { get; set; }

        public fa_rpt_notaCreDeb_Info()
        {
            empresainfo = new tb_Empresa_Info();
            listadetalle = new List<fa_notaCreDeb_det_Info>();
        }

     }
    
    
}
