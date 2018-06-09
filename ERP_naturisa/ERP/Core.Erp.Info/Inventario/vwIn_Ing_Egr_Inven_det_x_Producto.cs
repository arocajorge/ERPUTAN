using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwIn_Ing_Egr_Inven_det_x_Producto
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_stock_actu { get; set; }
        public string dm_observacion { get; set; }
        public Double dm_precio { get; set; }
        public Double mv_costo { get; set; }
        public Double dm_peso { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdEstadoAproba { get; set; }
        public int IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }
        public int IdEmpresa_oc { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia_oc { get; set; }
        public int IdEmpresa_inv { get; set; }
        public int IdSucursal_inv { get; set; }
        public int IdBodega_inv { get; set; }
        public int IdMovi_inven_tipo_inv { get; set; }
        public decimal IdNumMovi_inv { get; set; }
        public int secuencia_inv { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Nom_Centro_costo { get; set; }
        public string Nom_SubCentroCosto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto_princ { get; set; }
        public double pr_stock { get; set; }


        public vwIn_Ing_Egr_Inven_det_x_Producto()
        {

        }
    }
}
