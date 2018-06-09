using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//v22102013
namespace Core.Erp.Info.Inventario
{
   public  class in_movi_inve_detalle_Info
    {

        #region Primitive Properties

        public virtual int IdEmpresa {get;set;}
        public virtual int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public virtual int IdMovi_inven_tipo { get; set; }
        public virtual decimal IdNumMovi { get; set; }
        public virtual int Secuencia { get; set; }
        public virtual string mv_tipo_movi { get; set; }
        public virtual decimal IdProducto { get; set; }
        public virtual double dm_cantidad { get; set; }
        public virtual double? dm_stock_ante { get; set; }
        public virtual double? dm_stock_actu { get; set; }
        public virtual string dm_observacion { get; set; }
        public virtual double? dm_precio { get; set; }
        public virtual double? mv_costo { get; set; }
        public virtual double Costo_Promedio_x_Producto { get; set; }


        public Nullable<double> peso { get; set; }
        public string CodProducto { get; set; }
        public string NomProducto { get; set; }
        public string Marca { get; set; }
        public string categoria { get; set; }
        public DateTime Fecha { get; set; }
        
        public string CodMoviInven { get; set; }
        public string CodTipoMoviInven { get; set; }
        public string TipoMoviInven { get; set; }

        public double pr_precio_publico { get; set; }

        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo{ get; set; }
        public Nullable<int> IdMotivo_Inv { get; set; }
       //Campos para saber cual movimiento esta devolviendo este
        public Nullable<int> IdEmpresa_dev { get; set; }
        public Nullable<int> IdSucursal_dev { get; set; }
        public Nullable<int> IdBodega_dev { get; set; }
        public Nullable<int> IdMovi_inven_tipo_dev { get; set; }
        public Nullable<decimal> IdNumMovi_dev { get; set; }
        public Nullable<int> Secuencia_dev { get; set; }
      
        #region prop para vista vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven

       
        public decimal IdOrdenCompra { get; set; }
        public int secuencia_oc_det { get; set; }
        public string nom_sucu { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string Tipo { get; set; }
        public DateTime oc_fecha { get; set; }
        //public string oc_observacion { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        //public decimal IdProducto { get; set; }
        public double oc_precio { get; set; }
        public int secuencia_inv_det { get; set; }
        public double cantidad_pedida_OC { get; set; }
        public double cantidad_ing_a_Inven { get; set; }
        public double Saldo_x_Ing_OC { get; set; }
        public double pr_stock { get; set; }
        public double pr_peso { get; set; }
        public double CostoProducto { get; set; }

        public string Estado { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdEstadoAprobacion { get; set; }

        public double Saldo_x_Ing_OC_AUX { get; set; }

        public string IdEstadoRecepcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public double cantidad_ingresada { get; set; }

        #endregion
              
       //prop para tabla intermedia Cidersus
        public int oc_IdEmpresa { get; set; }
        public int oc_IdSucursal { get; set; }

        public decimal oc_IdOrdenCompra { get; set; }
        public string NumDocumentoRelacionadoProveedor { get; set; }
        public string NumFacturaProveedor { get; set; }
       

        public int oc_Secuencial { get; set; }
        public string oc_NumDocumento { get; set; }
        public string oc_observacion { get; set; }
        public string CodBarra { get; set; }
        public Boolean valida { get; set; }
       public Boolean Checked {get;set;}
       public string observacion { get; set; }
       public int ? et_IdProcesoProductivo { get; set; }
       //campos para el kardex
        public DateTime  cm_fecha { get; set; }
        public double existencia { get; set; }
        public string pr_descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public in_movi_inve_detalle_Info() { }
        public string  ot_CodObra { get; set; }
        public int ? ot_IdordenTaller { get; set; }
        #endregion

        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public double mv_costo_sinConversion { get; set; }

       //campos para la preasignacion de Obra y Orden de Taller
        public string CodObra_preasignada { get; set; }
        public Nullable<decimal> IdOrdenTaller_preasignada { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Bodega { get; set; }

        public string Sucursal { get; set; }
    }
}
