using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produc_Cirdesus
{

	public class prd_parametros_CusCidersus_Info
	{


    //    public int IdEmpresa{ get; set; } 
    //    public int IdSucursal_Princ{ get; set; } 
    //    public int IdBodega_Princ{ get; set; } 
    //    public int IdSucursal_Produccion{ get; set; } 
    //    public int IdBodega_Produccion{ get; set; } 
    //    public int IdMovi_inven_tipo_ing_suc_princ{ get; set; } 
    //    public int IdMovi_inven_tipo_ing_suc_prod{ get; set; }
    //    public int IdMovi_inven_tipo_egr_consumo { get; set; }


	




    //public int? IdMovi_inven_tipo_egr_suc_princ { get; set; }

    //public int? IdMovi_inven_tipo_egr_suc_prod { get; set; }
    //public string IdEstadoAprobacion_x_default { get; set; }
    //public int IdProductoTipo_ProdTerm { get; set; }
    //public string IdCategoria_ProdTerm { get; set; }
    //public decimal IdProveedor_ProdTerm { get; set; }
    //public int IdMarca_ProdTerm { get; set; }

    //public int? IdMovi_inven_tipo_ing_ContrlProduccion { get; set; }

    //public int? IdMovi_inven_tipo_egr_ContrlProduccion { get; set; }

        public int IdEmpresa { get; set; }
        public int IdSucursal_Princ { get; set; }
        public int IdBodega_Princ { get; set; }
        public int IdSucursal_Produccion { get; set; }
        public int IdBodega_Produccion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing_suc_princ { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egr_suc_princ { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egr_consumoprod { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing_consumoprod { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing_ContrlProduccion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egr_ContrlProduccion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egr_Conversion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing_Conversion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egr_Ensamblado { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ing_Ensamblado { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ingxresid_Conversion { get; set; }
        public Nullable<int> IdMovi_invent_tipo_egr_Despacho { get; set; }
        public string IdEstadoAprobacion_x_default { get; set; }
        public Nullable<int> IdProductoTipo_ProdTerm { get; set; }
        public string IdCategoria_ProdTerm { get; set; }
        public Nullable<decimal> IdProveedor_ProdTerm { get; set; }
        public Nullable<int> IdMarca_ProdTerm { get; set; }
        public Nullable<int> idTipo_Produto_Elemento { get; set; }
        public Nullable<int> IdProductoTipo_MateriaPrima { get; set; }

        public Nullable<decimal> IdMoviInicio { get; set; }

    public prd_parametros_CusCidersus_Info() { }
    }
}
