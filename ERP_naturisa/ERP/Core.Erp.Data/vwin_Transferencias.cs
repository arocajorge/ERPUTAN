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
    
    public partial class vwin_Transferencias
    {
        public string SucuOrigen { get; set; }
        public string BodegaORIG { get; set; }
        public string SucuDEST { get; set; }
        public string BodegDest { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdSucursalDest { get; set; }
        public int IdBodegaDest { get; set; }
        public string tr_Observacion { get; set; }
        public System.DateTime tr_fecha { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<System.DateTime> tr_fechaAnulacion { get; set; }
        public string tr_userAnulo { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuOrig { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuDest { get; set; }
        public string IdEstadoAproba_ing { get; set; }
        public string IdEstadoAproba_egr { get; set; }
        public Nullable<decimal> IdGuia { get; set; }
        public string EstadoRevision { get; set; }
        public string IdUsuarioRevision { get; set; }
        public Nullable<System.DateTime> FechaRevision { get; set; }
        public Nullable<bool> TuvoError { get; set; }
    }
}
