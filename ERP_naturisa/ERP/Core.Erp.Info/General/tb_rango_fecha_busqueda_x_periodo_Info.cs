using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
   public  class tb_rango_fecha_busqueda_x_periodo_Info
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int valor_ini { get; set; }
        public int valor_fin { get; set; }
        public string uni_medida { get; set; }

        public tb_rango_fecha_busqueda_x_periodo_Info()
        {

        }

    }
}
