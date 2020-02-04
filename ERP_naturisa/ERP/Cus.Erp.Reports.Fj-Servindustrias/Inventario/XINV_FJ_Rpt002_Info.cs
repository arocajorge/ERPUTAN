using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public System.DateTime Fecha { get; set; }
        public string cod_Movi_Inven_tipo { get; set; }
        public string nom_Movi_Inven_tipo { get; set; }
        public string NumDocumentoRelacionado { get; set; }
        public string NumFactura { get; set; }
        public string Observacion { get; set; }
        public string mv_tipo_movi { get; set; }
        public double Cantidad { get; set; }
        public string Cod_producto { get; set; }
        public string nom_producto { get; set; }
        public decimal IdProducto { get; set; }
        public double SaldoInicial { get; set; }
        public double SaldoFinal { get; set; }
        public double Saldo_x_Unidades { get; set; }
        public string Empresa { get; set; }
        public double ingresos { get; set; }
        public double egresos { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_Centro_costo { get; set; }
        public string IdSubCentro_costo { get; set; }
        public string nom_SubCentro_costo { get; set; }
    }
}
