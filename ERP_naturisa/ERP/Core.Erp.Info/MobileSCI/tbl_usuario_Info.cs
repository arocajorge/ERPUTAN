using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_usuario_Info
    {
        public string IdUsuarioSCI { get; set; }
        public string clave { get; set; }
        public string nom_usuario { get; set; }
        public bool estado { get; set; }

        public List<tbl_usuario_x_bodega_Info> lst_usuario_x_bodega { get; set; }
        public List<tbl_usuario_x_subcentro_Info> lst_usuario_x_subcentro { get; set; }
    }
}
