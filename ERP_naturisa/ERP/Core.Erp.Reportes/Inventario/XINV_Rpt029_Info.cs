using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt029_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string nom_bodega { get; set; }
        public string nom_sucursal { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_observacion { get; set; }
        public double Stock { get; set; }
        public decimal IdProducto { get; set; }
        public double costo { get; set; }
        public double costo_total { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public string nom_UnidadMedida { get; set; }


    }
}
