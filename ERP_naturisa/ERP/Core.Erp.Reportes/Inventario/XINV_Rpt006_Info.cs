using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public decimal IdNumMovi { get; set; }
        public string signo { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string CodMoviInven { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }
        public double dm_cantidad { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public double dm_stock_actu { get; set; }
        public double dm_stock_ante { get; set; }
        public string IdUsuario { get; set; }
        public Image Logo { get; set; }
    }
}
