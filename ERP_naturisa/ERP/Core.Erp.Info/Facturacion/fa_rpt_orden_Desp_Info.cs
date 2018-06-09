using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{
    public class fa_rpt_orden_Desp_Info
    {
        public fa_orden_Desp_Info info{ get; set; }
        public tb_Empresa_Info empresainfo { get; set; }
        public List<fa_orden_Desp_det_Info> ListDetalle { get; set; }

        public fa_rpt_orden_Desp_Info()
        {
            empresainfo = new tb_Empresa_Info();
            info = new fa_orden_Desp_Info();
            ListDetalle = new List<fa_orden_Desp_det_Info>();
        }
    }
}
