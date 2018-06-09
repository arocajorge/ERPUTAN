using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SeguridadAcceso
{
  public  class seg_Menu_Pagina_Info
    {

      public seg_Menu_Pagina_Info()
        {
            
        }

        public string Codigo { get; set; }
        public string Codigo_Pagina { get; set; }
        public string Descripcion { get; set; }
        public bool Visible { get; set; }
        public bool Expanded { get; set; }
        public Int32 ImageIndex { get; set; }
        public string ImageAlign { get; set; }
        public string Codigo_Categoria { get; set; }
        public int position { get; set; }
    
        

    }
}
