using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_CotizacionPedidoDet_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencia { get; set; }
        public int opd_IdEmpresa { get; set; }
        public decimal opd_IdOrdenPedido { get; set; }
        public int opd_Secuencia { get; set; }
        public decimal? IdProducto { get; set; }
        public double cd_Cantidad { get; set; }
        public double cd_precioCompra { get; set; }
        public double cd_porc_des { get; set; }
        public double cd_descuento { get; set; }
        public double cd_precioFinal { get; set; }
        public double cd_subtotal { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double Por_Iva { get; set; }
        public double cd_iva { get; set; }
        public double cd_total { get; set; }
        public bool EstadoJC { get; set; }
        public bool EstadoGA { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string cd_DetallePorItem { get; set; }
        

        #region Campos que no existen en la tabla
        public int IdSucursalDestino { get; set; }
        public int IdSucursalOrigen { get; set; }
        public decimal? IdProveedor { get; set; }
        public string pr_descripcion { get; set; }
        public bool A { get; set; }
        public bool R { get; set; }
        public string opd_Detalle { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public double Stock { get; set; }
        public string nom_solicitante { get; set; }
        public decimal IdSolicitante { get; set; }
        public decimal IdDepartamento { get; set; }
        public decimal IdComprador { get; set; }
        public bool Add { get; set; }
        public bool Selec { get; set; }
        public string Grupo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string NomUnidadMedida { get; set; }
        public string nom_impuesto { get; set; }
        public System.Drawing.Color Color { get; set; }
        public double MejorPrecio { get; set; }
        #endregion



        public bool Adjunto { get; set; }

        public string op_Observacion { get; set; }

        public DateTime op_Fecha { get; set; }

        public string NombreArchivo { get; set; }

        public string EstadoDetalle { get; set; }

        public string opd_EstadoProceso { get; set; }

        public DateTime? FechaCantidad { get; set; }
    }
}
