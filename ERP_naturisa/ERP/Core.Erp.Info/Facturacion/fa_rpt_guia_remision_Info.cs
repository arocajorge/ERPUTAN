using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{

   public  class fa_rpt_guia_remision_Info
    {

        public fa_guia_remision_Info  Info { get; set; }
        public List<fa_guia_remision_det_Info> ListaDetalle { get; set; }
        public tb_Empresa_Info empresainfo { get; set; }

        public fa_rpt_guia_remision_Info()
        {
            empresainfo = new tb_Empresa_Info();
            Info = new fa_guia_remision_Info();
            ListaDetalle = new List<fa_guia_remision_det_Info>();
        }
    }
    

    }

 
