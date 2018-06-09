using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_moneda_info
    {
        public int IdMoneda { get; set; }
        public string im_descripcion { get; set; }
        public string im_simbolo { get; set; }
        public string im_nemonico { get; set; }
        public string Estado { get; set; }

        public tb_moneda_info() { }

    }
}
