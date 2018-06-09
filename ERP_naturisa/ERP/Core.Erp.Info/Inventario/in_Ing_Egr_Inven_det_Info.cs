using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
   public class in_Ing_Egr_Inven_det_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; } 
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public int? IdBodega { get; set; }             
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_stock_actu { get; set; }
        public string dm_observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public double dm_peso { get; set; }
       
       public string IdCentroCosto { get; set; }
       public string IdCentroCosto_sub_centro_costo { get; set; }

       public string IdRegistro { get; set; }

        public string IdEstadoAproba { get; set; }
        public string IdUnidadMedida { get; set; }

        public string Centro_costo2 { get; set; }
        public string NomSubCentroCosto { get; set; }
       
        public int? IdEmpresa_oc { get; set; } //nuevo
        public int? IdSucursal_oc { get; set; }//nuevo
        public decimal? IdOrdenCompra { get; set; }//nuevo
        public int? Secuencia_oc { get; set; }//nuevo        
        public int? IdEmpresa_inv { get; set; } //nuevo
        public int? IdSucursal_inv { get; set; } //nuevo
        public int? IdBodega_inv { get; set; } //nuevo
        public int? IdMovi_inven_tipo_inv { get; set; } //nuevo
        public decimal? IdNumMovi_inv { get; set; } //nuevo
        public int? secuencia_inv { get; set; } //nuevo
        
        public Nullable<int> IdPunto_cargo { get; set; }//nuevo
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdMotivo_Inv { get; set; }

        //Campos para saber cual movimiento esta devolviendo este
        public Nullable<int> IdEmpresa_dev { get; set; }
        public Nullable<int> IdSucursal_dev { get; set; }
        public Nullable<int> IdBodega_dev { get; set; }
        public Nullable<int> IdMovi_inven_tipo_dev { get; set; }
        public Nullable<decimal> IdNumMovi_dev { get; set; }
        public Nullable<int> Secuencia_dev { get; set; }

        public string Centro_costo { get; set; }
        public Boolean Checked { get; set; }

        // campos in_Producto
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }

        public string cod_producto { get; set; }
        public string nom_producto { get; set; }

        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public double mv_costo_sinConversion { get; set; }

        #region prop para vista vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo
           

        public string nom_sucu { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }     
        public string oc_observacion { get; set; }
        public double cantidad_pedida_OC { get; set; }    
        public double Saldo_x_Ing_OC { get; set; }  
        public double Saldo_x_Ing_OC_AUX { get; set; }
        public int IdMotivo_OC { get; set; }
        public string Nom_Motivo { get; set; }
        public DateTime oc_fecha { get; set; }
        public double cantidad_ingresada { get; set; }

        public string IdEstado_cierre { get; set; }
        public string nom_estado_cierre { get; set; }

        public string Nomsub_centro_costo { get; set; }
               
        public string Motivo_Aprobacion { get; set; }

        public string Ref_OC { get; set; }

        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public string nom_UnidadMedida { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public string oc_NumDocumento { get; set; }

        #endregion

        #region prop para vista vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det

        public string signo { get; set; }
        public string nom_tipo_inv { get; set; }

        public string nom_bodega { get; set; }
        public string nom_medida { get; set; }
        public string nom_punto_cargo { get; set; }

        public Nullable<System.DateTime> Fecha_registro { get; set; }

        public string IdUsuario { get; set; }


        #endregion
        #region campos para parametrizacion x centro, subcentro, categoria, linea, grupo y subgrupo
        public string IdCategoria { get; set; }
        public Nullable<int> IdLinea { get; set; }
        public Nullable<int> IdGrupo { get; set; }
        public Nullable<int> IdSubgrupo { get; set; }
        public string ca_Categoria { get; set; }
        public string nom_linea { get; set; }
        public string nom_grupo { get; set; }
        public string nom_subgrupo { get; set; }
        #endregion
        public in_Guia_x_traspaso_bodega_det_Info Info_Guia_x_traspaso_bodega_det { get; set; }

        public in_Ing_Egr_Inven_det_Info()
        {
            Info_Guia_x_traspaso_bodega_det = new in_Guia_x_traspaso_bodega_det_Info();
        }
    }
}
