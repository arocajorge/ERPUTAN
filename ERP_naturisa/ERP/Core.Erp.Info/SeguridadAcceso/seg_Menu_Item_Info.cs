using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SeguridadAcceso
{
   public class seg_Menu_Item_Info
    {
       public seg_Menu_Item_Info()
        {
        }

       public string Codigo_Item { get; set; }
       public string Descripcion { get; set; }
       public int ImageIndex { get; set; }
       public Nullable<int> LargeImageIndex { get; set; }
       public string ItemShortcut { get; set; }
       public bool Enabled { get; set; }
       public int position { get; set; }
       public eTipo_Item Tipo_Item { get; set; }
       public string nom_Formulario { get; set; }
       public string nom_Asembly { get; set; }
       public string CodReporte { get; set; }
       public string Tipo { get; set; }
       public bool Se_muestra_menu_superior { get; set; }
       public bool Se_muestra_menu_lateral { get; set; }
       public bool Visible { get; set; }
        
    }

   public enum eTipo_Item
   {
       barButtonItem,
       SearchLookUpEdit
   }
}
