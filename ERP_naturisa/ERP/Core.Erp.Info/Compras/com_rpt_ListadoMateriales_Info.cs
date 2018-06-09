using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_rpt_ListadoMateriales_Info
    {
        public com_ListadoMateriales_Info cab { get; set; }
        public List<com_ListadoMateriales_Det_Info> det { get; set; }
        public string usuario { get; set; }
        public DateTime fecha { get; set; }
        public com_rpt_ListadoMateriales_Info()
        {
            cab = new com_ListadoMateriales_Info();
            det = new List<com_ListadoMateriales_Det_Info>();
        
        }
    }
}
