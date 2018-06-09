using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class vwin_categoria_lin_gr_subgr_Info
    {
        public int IdEmpresa { get; set; }
        public string ID { get; set; }
        public string IDPadre { get; set; }
        public string Codigo { get; set; }
        public string descripcion { get; set; }
        public string Estado { get; set; }
        public string IdCategoria { get; set; }
        public int IdLinea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubGrupo { get; set; }
        public int IdNivel { get; set; }

       public vwin_categoria_lin_gr_subgr_Info() { }
    }
}
