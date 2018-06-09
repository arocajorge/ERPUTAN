using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string IdUsuario { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string mv_tipo_movi { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_actu { get; set; }
        public double dm_stock_ante { get; set; }
        public string dm_observacion { get; set; }
        public double mv_costo { get; set; }
        public double dm_precio { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nomUnidadMedida { get; set; }
        public decimal Id_Ing_Egr { get; set; }
        public string Cod_ing_egr { get; set; }
        public double total_costo { get; set; }
        public double total_precio { get; set; }

        public XINV_Rpt012_Info()
        {

        }
    }
}
