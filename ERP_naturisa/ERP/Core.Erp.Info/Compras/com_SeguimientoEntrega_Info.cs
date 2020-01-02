using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_SeguimientoEntrega_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string EstadoSolpe { get; set; }
        public int IdSucursalOrigen { get; set; }
        public string CodigoSucOrigen { get; set; }
        public string NombreSucursalOrigen { get; set; }
        public int IdSucursalDestino { get; set; }
        public string CodigoSucDestino { get; set; }
        public string NombreSucursalDestino { get; set; }
        public string EstadoDetalle { get; set; }
        public string nom_solicitante { get; set; }
        public System.DateTime op_Fecha { get; set; }
        public double opd_Cantidad { get; set; }
        public double opd_CantidadApro { get; set; }
        public string IdUsuarioCantidad { get; set; }
        public Nullable<System.DateTime> FechaCantidad { get; set; }
        public string NombreUsuarioCantidad { get; set; }
        public string NomUnidadMedida { get; set; }
        public string op_Observacion { get; set; }
        public string ObservacionGA { get; set; }
        public string opd_Detalle { get; set; }
        public Nullable<int> IdSucursalOC { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> SecuenciaOC { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string CodigoOC { get; set; }
        public Nullable<double> CantidadOC { get; set; }
        public Nullable<System.DateTime> FechaOC { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<int> IdComprador { get; set; }
        public string NombreComprador { get; set; }
        public Nullable<decimal> IB_UltIdNumMovi { get; set; }
        public Nullable<double> IB_Cantidad { get; set; }
        public Nullable<System.DateTime> IB_Fecha { get; set; }
        public Nullable<int> AlertaEntrega { get; set; }
        public Nullable<double> CantidadPendiente { get; set; }
        public Nullable<int> DiasPendiente { get; set; }
        public string NombreSucursalTransferencia { get; set; }
        public string NombreBodegaTransferencia { get; set; }
        public Nullable<System.DateTime> FechaTransferencia { get; set; }
        public Nullable<System.DateTime> FechaRecepcionTransferencia { get; set; }
    }
}
