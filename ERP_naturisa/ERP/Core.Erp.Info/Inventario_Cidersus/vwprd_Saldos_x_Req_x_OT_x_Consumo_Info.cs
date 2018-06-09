using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//version 11:41 13/09/2013
namespace Core.Erp.Info.Produc_Cirdesus
{
    public class vwprd_Saldos_x_Req_x_OT_x_Consumo_Info
    {
        public Nullable<decimal> IdTransaccion { get; set; }
        public Nullable<int> IdDetTrans { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string Codigo { get; set; }
        public Nullable<decimal> IdListadoMateriales { get; set; }
        public Nullable<int> IdDetalle { get; set; }
        public Nullable<int> oc_IdEmpresa { get; set; }
        public Nullable<decimal> oc_IdOrdenCompra { get; set; }
        public string IdEstadoAprob { get; set; }
        public string oc_NumDocumento { get; set; }
        public string EstadoRecepcion { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<int> IdMovi_inven_tipo { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<decimal> IdNumMovi { get; set; }
        public Nullable<int> Secuencia { get; set; }
        public string mv_tipo_movi { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public Nullable<int> ot_IdEmpresa { get; set; }
        public Nullable<int> ot_IdSucursal { get; set; }
        public string ot_CodObra { get; set; }
        public Nullable<decimal> ot_IdOrdenTaller { get; set; }

        public Nullable<int> ped_IdSuc { get; set; }
        public string ped_codobra { get; set; }
        public Nullable<decimal> ped_IdOT { get; set; }
        public Nullable<double> saldo { get; set; }
        public Nullable<int> ped_IdEmp { get; set; }
        public Nullable<double> ped_saldo { get; set; }
        public Nullable<double> ent_saldo { get; set; }
        public Nullable<decimal> ped_IdProducto { get; set; }
        public vwprd_Saldos_x_Req_x_OT_x_Consumo_Info() { }
    }
}
