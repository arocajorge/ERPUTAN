using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public string TipoDetalle { get; set; }
        public int secuencia { get; set; }
        public Nullable<int> IdEmpresa_OC { get; set; }
        public Nullable<int> IdSucursal_OC { get; set; }
        public Nullable<decimal> IdOrdenCompra_OC { get; set; }
        public Nullable<int> Secuencia_OC { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public Nullable<double> Cantidad_enviar { get; set; }
        public string nom_producto { get; set; }
        public Nullable<double> CantOC { get; set; }
        public string Observacion_OC { get; set; }
        public string Num_Fact { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string NumGuia { get; set; }
        public Nullable<int> IdSucursal_Partida { get; set; }
        public string Nom_Sucursal_Partida { get; set; }
        public string Direc_sucu_Partida { get; set; }
        public Nullable<int> IdSucursal_Llegada { get; set; }
        public string Nom_Sucursal_LLegada { get; set; }
        public string Direc_sucu_Llegada { get; set; }
        public Nullable<decimal> IdTransportista { get; set; }
        public string nom_transportista { get; set; }
        public string cedu_transportista { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Traslado { get; set; }
        public Nullable<System.DateTime> Fecha_llegada { get; set; }
        public string IdMotivo_Traslado { get; set; }
        public Nullable<System.TimeSpan> Hora_Traslado { get; set; }
        public Nullable<System.TimeSpan> Hora_Llegada { get; set; }
        public string nom_motivo { get; set; }
        public string pr_codigo { get; set; }
        public XINV_NAT_Rpt001_Info()

        {
     }
   }
 }
