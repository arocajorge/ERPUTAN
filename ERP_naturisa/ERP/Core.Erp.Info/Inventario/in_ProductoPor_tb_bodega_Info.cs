using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_ProductoPor_tb_bodega_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }

        public string pr_descripcion { get; set; }

        public string ca_Categoria { get; set; }

        public string nom_linea { get; set; }

        public string nom_grupo { get; set; }

        public bool Seleccionado { get; set; }

        public string fa_Descripcion { get; set; }
    }
}
