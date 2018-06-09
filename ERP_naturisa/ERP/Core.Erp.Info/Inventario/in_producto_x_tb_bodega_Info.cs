using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_producto_x_tb_bodega_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public double? pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_puerta { get; set; }
        public double? pr_precio_minimo { get; set; }
        public double pr_Por_descuento { get; set; }
        public double pr_Pedidos_fact { get; set; }
        public double pr_Pedidos_inv { get; set; }
        public double pr_stock { get; set; }
        public double pr_Disponible { get; set; }


        public double pr_stock_maximo { get; set; }
        public double pr_stock_minimo { get; set; }
        public double pr_pedidos { get; set; }
        public double pr_costo_fob { get; set; }
        public double pr_costo_CIF { get; set; }
        public double? pr_costo_promedio { get; set; }
        public string Estado { get; set; }


        public string IdCtaCble_Vta { get; set; }
        public string IdCtaCble_CosBaseIva { get; set; }
        public string IdCtaCble_CosBase0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_DesIva{ get; set; }
        public string IdCtaCble_Des0{ get; set; }
        public string IdCtaCble_DevIva { get; set; }
        public string IdCtaCble_Dev0 { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCtaCble_Gasto_x_cxp { get; set; }


        public string IdCentro_Costo_Costo { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentroCosto_x_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_sub_centro_costo_inv { get; set; }
        public string IdCentroCosto_sub_centro_costo_cost { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }


        public string nom_SubCentroCosto_inv { get; set; }
        public string nom_SubCentroCosto_cost { get; set; }
        public string nom_SubCentroCosto_cxp { get; set; }


 
     
        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }


        public string Nom_Empresa { get; set; }
        public string Nom_bodega { get; set; }
        public string Nom_sucursal { get; set; }

        public string IdCategoria { get; set; }
        public string nom_categoria { get; set; }

        public int IdLinea { get; set; }
        public string nom_linea { get; set; }

        public int IdGrupo { get; set; }
        public string nom_grupo { get; set; }

        public int IdSubgrupo { get; set; }
        public string nom_subgrupo { get; set; }



        public Boolean EstaEnBase { get; set; }
        public Boolean RegModificado { get; set; }
        public Boolean Considera { get; set; }

        public string bodegaDest { get; set; }
        public string sucursalDest { get; set; }
        public double cantidad { get; set; }
        public decimal StockAnterior { get; set; }
        

        public string em_telefonos { get; set; }
        public string em_direccion { get; set; }
        public byte[] logo { get; set; }

        public bool Checked { get; set; }

        public in_producto_x_tb_bodega_Info() { }
        
    }
}
