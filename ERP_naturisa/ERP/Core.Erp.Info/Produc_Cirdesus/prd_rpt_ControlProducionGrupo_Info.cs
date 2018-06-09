using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;


namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_rpt_ControlProducionGrupo_Info
    {
        
        public List<prd_ControlProduccionObreroDetalle_Info> DetalleControlProdGrupo { get; set; }
        public prd_ControlProduccion_Obrero_Cab_Info ControProdGrupoCab { get; set; }
         public prd_OrdenTaller_Info OrdenTaller { get; set; }
        public double  TotKgAsig { get; set; }
        public int cantRegistradas { get; set; }

        public prd_rpt_ControlProducionGrupo_Info() 
        {
            DetalleControlProdGrupo = new List<prd_ControlProduccionObreroDetalle_Info>();
            ControProdGrupoCab = new prd_ControlProduccion_Obrero_Cab_Info();
            OrdenTaller = new prd_OrdenTaller_Info();
        }

    }
}
