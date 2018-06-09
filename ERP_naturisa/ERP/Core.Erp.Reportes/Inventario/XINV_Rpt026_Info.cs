using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt026_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public System.DateTime Fecha_ini { get; set; }
        public System.DateTime Fecha_fin { get; set; }
        public string pr_codigo { get; set; }
        public string nom_producto { get; set; }
        public string IdCategoria { get; set; }
        public string nom_categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public double Saldo_inicial { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public double Saldo_final { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_unidad_medida { get; set; }
        public string nom_Bodega { get; set; }
        public string nom_Sucursal { get; set; }

        public double costo_inicial { get; set; }
        public double costo_ingresos { get; set; }
        public double costo_egresos { get; set; }
        public double costo_final { get; set; }
    }
}
