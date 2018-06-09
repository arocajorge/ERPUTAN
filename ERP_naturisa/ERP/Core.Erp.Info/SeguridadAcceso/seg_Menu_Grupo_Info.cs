using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SeguridadAcceso
{
   public  class seg_Menu_Grupo_Info
    {

       public seg_Menu_Grupo_Info()
        {

        }

       public string Codigo { get; set; }
       public string Codigo_Grupo { get; set; }
       public string Descripcion { get; set; }
        public bool AllowMinimize { get; set; }
        public int ImageIndex { get; set; }
        public bool ShowCaptionButton { get; set; }
        public bool Visible { get; set; }
        public string Codigo_Pagina { get; set; }
        public int position { get; set; }

    }
}
