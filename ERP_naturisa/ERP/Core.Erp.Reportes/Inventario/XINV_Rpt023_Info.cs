using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt023_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public string cod_Dev_Inven { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<int> IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> IdNumMovi { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public double cantidad_a_devolver { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public Nullable<double> mv_costo { get; set; }
        public string pr_descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public int Secuencia_movi_inv { get; set; }
        public string observacion { get; set; }
    }
}
