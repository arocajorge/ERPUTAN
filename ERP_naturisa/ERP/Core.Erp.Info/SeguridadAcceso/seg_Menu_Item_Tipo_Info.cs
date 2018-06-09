using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SeguridadAcceso
{
   public class seg_Menu_Item_Tipo_Info
    {

       public seg_Menu_Item_Tipo_Info()
        {
            this.seg_Menu_Item = new HashSet<seg_Menu_Item_Info>();
        }
    
        public string IdTipo_Item { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<seg_Menu_Item_Info> seg_Menu_Item { get; set; }

    }
}
