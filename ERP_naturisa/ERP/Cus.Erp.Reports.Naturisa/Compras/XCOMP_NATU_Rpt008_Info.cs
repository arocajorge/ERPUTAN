using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt008_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<decimal> IdCotizacion { get; set; }
        public double cd_cantidad { get; set; }
        public Nullable<double> cd_precioCompra { get; set; }
        public Nullable<double> cd_porc_des { get; set; }
        public Nullable<double> cd_descuento { get; set; }
        public Nullable<double> cd_precioFinal { get; set; }
        public Nullable<double> cd_subtotal { get; set; }
        public string IdCod_Impuesto { get; set; }
        public Nullable<double> Por_Iva { get; set; }
        public Nullable<double> cd_iva { get; set; }
        public Nullable<double> cd_total { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdDepartamento { get; set; }
        public string nom_solicitante { get; set; }
        public string nomUnidadMedida { get; set; }
        public string EstadoDetalle { get; set; }
        public string opd_EstadoProceso { get; set; }
        public int IdSucursalDestino { get; set; }
        public int IdSucursalOrigen { get; set; }
        public Nullable<int> SecuenciaCot { get; set; }
        public string cd_DetallePorItem { get; set; }
        public string cp_Observacion { get; set; }
        public string cp_ObservacionAdicional { get; set; }
        public Nullable<System.DateTime> cp_Fecha { get; set; }
        public string Comprador { get; set; }
        public string opd_Detalle { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string SucursalOrigen { get; set; }
        public string SucursalDestino { get; set; }
        public Nullable<double> SubtotalIva { get; set; }
        public Nullable<double> SubtotalSinIva { get; set; }


        public string op_Observacion { get; set; }

        public DateTime op_Fecha { get; set; }
    }
}
