using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt005_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_actu { get; set; }
        public double pr_costo_promedio { get; set; }
        public string TipoMovimiento { get; set; }
        public string Empresa { get; set; }
        public decimal IdNumMovi { get; set; }
        public Image Logo { get; set; }
        public string IdUnidadMedida { get; set; }
        
        

        public int IdMovi_inven_tipo { get; set; }
    }
}
