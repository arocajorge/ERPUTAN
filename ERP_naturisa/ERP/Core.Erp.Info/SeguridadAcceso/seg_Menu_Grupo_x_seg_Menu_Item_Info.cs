using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SeguridadAcceso
{
   public class seg_Menu_Grupo_x_seg_Menu_Item_Info
    {
       public string Codigo_Item { get; set; }
       public string Codigo_Grupo { get; set; }
        public string observacion { get; set; }

        public virtual seg_Menu_Grupo_Info seg_Menu_Grupo { get; set; }
        public virtual seg_Menu_Item_Info seg_Menu_Item { get; set; }    
       
    }
}
