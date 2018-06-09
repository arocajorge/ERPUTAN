using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
   public  class prd_ControlProduccion_Obrero_Cab_Info
    {

       

        public prd_ControlProduccionObrero_Info  controlProduccion_Obrero_Info { get; set; }
        public string Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string DescripModelo { get; set; }
        public string NombreEtapa { get; set; }
        public string CodObra { get; set; }
        public string ob_descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Codigo { get; set; }

        public prd_ControlProduccion_Obrero_Cab_Info()
        {
            controlProduccion_Obrero_Info = new prd_ControlProduccionObrero_Info();

        }

    }
}
