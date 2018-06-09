using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public  class in_movi_inven_tipo_x_tb_bodega_Info
    {   
        public Boolean Estado { get; set; }
        public string Sucursal { get; set; }
        public int IdSucucursal { get; set; }
        public string Bodega { get; set; }
        public int IdBodega { get; set; }
        public string IdCtaCble { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public int IdEmpresa  { get; set; }
        public in_movi_inven_tipo_x_tb_bodega_Info() { }

        public object idSucursal { get; set; }

        public object idBodega { get; set; }
    }
}
