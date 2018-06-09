using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAjusteFisico { get; set; }
        public string CodAjusteFisico { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public Nullable<decimal> IdNumMovi_Ing { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Ing { get; set; }
        public Nullable<decimal> IdNumMovi_Egr { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Egr { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double StockFisico { get; set; }
        public double StockSistema { get; set; }
        public double CantidadAjustada { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string nom_estado_aprobacion { get; set; }
        public string Observacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public string Centro_costo { get; set; }
        public string Tipo_ingreso { get; set; }
        public string Tipo_egreso { get; set; }
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string nom_unidad_medida { get; set; }
        public double costo { get; set; }
        public double Total_costo { get; set; }
    }
}
