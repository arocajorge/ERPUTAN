using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using System.Drawing;
namespace Core.Erp.Info.Produc_Cirdesus
{
    public class in_movi_inve_detalle_x_Producto_CusCider_Info
    {
        public bool check { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int mv_Secuencia { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string mv_tipo_movi { get; set; }
        public double dm_cantidad { get; set; }
        public string dm_observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public string Producto { get; set; }

        //uso para guia de remision
        public string pr_descripcion_2 { get; set; }

        public Nullable <int> et_IdEmpresa { get; set; }
        public Nullable <int> et_IdProcesoProductivo { get; set; }
        public Nullable <int> et_IdEtapa { get; set; }
        public Nullable<int> ot_IdEmpresa { get; set; }
        public Nullable<int> ot_IdSucursal { get; set; }
        public string ot_CodObra { get; set; }
        public Nullable<decimal> ot_IdOrdenTaller { get; set; }

        public string CodObra_preasignada { get; set; }
        public Nullable<decimal> IdOrdenTaller_preasignada { get; set; }

        public string OProducto { get; set; }
        public string pr_descripcion { get; set; }

        //DIMENSIONES DE TABLA IN_PRODUCTO_DIMENSIONES
        public double longitud { get; set; }
        public double espesor { get; set; }
        public double ancho { get; set; }
        public double alto { get; set; }
        public double ceja { get; set; }
        public double diametro { get; set; }
        public string descripcion_corta { get; set; }

        //LARGO Y ANCHO CONVERSION
        public Nullable<double> largo_conversion { get; set; }
        public Nullable<double> alto_conversion { get; set; }

        //campos para la vista
        public string pr_codigo { get; set; }
        public string Marca { get; set; }
        public string tp_descripcion { get; set; }
        public string ca_Categoria { get; set; }
        public decimal? IdProvedor { get; set; }
        public string NomProveedor { get; set; }
        public string CodOT { get; set; }
        public string ob_descripcion { get; set; }
        public string su_descripcion { get; set; }
        public string bo_descripcion { get; set; }
        public string et_descripcion { get; set; }
        public string ot_descripcion { get; set; }
        public DateTime cm_fecha{ get; set; }
        public string  mvtp_descripcion { get; set; }
        //para el kardex
        public double entrada { get; set; }

        //public decimal pr_peso { get; set; }
        public double pr_peso { get; set; }

        public double salida { get; set; }
        public double existencia { get; set; }
        // para la reimpresión de cod barra
        public string movilidadProducto { get; set; }
        public string Estado { get; set; }
        public string pr_observacion { get; set; }
        public Bitmap IcoProdNuevo { get; set; }
        public Bitmap IcoProdCons { get; set; }
        public Bitmap IcoCodBarra { get; set; }
        // datos para producto a cortar
        public double ?pr_alto { get; set; }
        public double ?pr_largo { get; set; }
        public double pr_profundidad { get; set; }
        public string pr_Descripcion { get; set; }
        public string pr_Observacion { get; set; }


        public string fa_Cliente { get; set; }
        public string obra { get; set; }
        public byte[] Logo { get; set; }

        public Nullable<double> Ancho { get; set; }
        public Nullable<decimal> ocd_IdOrdenCompra { get; set; }
        public string NumDocumentoRelacionadoProveedor { get; set; }
        public string NumFacturaProveedor { get; set; }

        public Nullable<decimal> IdMoviInicio { get; set; }

        public in_movi_inve_detalle_x_Producto_CusCider_Info() {

        }
    }
}
