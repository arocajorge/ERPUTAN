//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwin_Ing_Egr_Inven
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdNumMovi { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string signo { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<int> IdMotivo_oc { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdusuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string cod_tipo_inv { get; set; }
        public string nom_tipo_inv { get; set; }
        public string signo_tipo_inv { get; set; }
        public string nom_motivo { get; set; }
        public Nullable<int> IdMotivo_Inv { get; set; }
        public string IdEstadoAproba { get; set; }
        public string nom_EstadoAproba { get; set; }
        public string Desc_mov_inv { get; set; }
        public string IdEstadoDespacho_cat { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<System.DateTime> Fecha_registro { get; set; }
        public Nullable<decimal> IdResponsable { get; set; }
        public string co_factura { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public string IdEstado_cierre { get; set; }
        public string Descripcion { get; set; }
    }
}
