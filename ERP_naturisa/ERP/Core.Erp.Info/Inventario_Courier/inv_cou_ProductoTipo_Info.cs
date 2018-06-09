using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Courier
{
    public class inv_cou_ProductoTipo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdProductoTipo { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }


        public inv_cou_ProductoTipo_Info()
        {

        }

    }
}
