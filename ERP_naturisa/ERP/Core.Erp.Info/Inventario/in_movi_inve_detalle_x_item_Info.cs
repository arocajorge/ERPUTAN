using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_movi_inve_detalle_x_item_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal Secuencia_reg { get; set; }
        public string codigo_reg { get; set; }
        public double cantidad { get; set; }
        //Campos vista
        public decimal IdProducto { get; set; }
        public System.DateTime cm_fecha { get; set; }
    }
}
