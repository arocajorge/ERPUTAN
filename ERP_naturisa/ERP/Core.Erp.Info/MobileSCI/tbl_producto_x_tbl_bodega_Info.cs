using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_producto_x_tbl_bodega_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }

        #region Campos que no existen en la base
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }
        public string ca_Categoria { get; set; }
        public string nom_linea { get; set; }
        public bool EnBase { get; set; }
        #endregion


        public bool Seleccionado { get; set; }
    }
}
