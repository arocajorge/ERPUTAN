using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt004_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public DateTime Fecha { get; set; }
        public string cod_Movi_Inven_tipo { get; set; }
        public string nom_Movi_Inven_tipo { get; set; }
        public string NumDocumentoRelacionado { get; set; }
        public string NumFactura { get; set; }
        public string Observacion { get; set; }
        public string mv_tipo_movi { get; set; }

        public double CantiIngreso { get; set; }
        public double CantiEgreso { get; set; }
        public double SaldoInicial { get; set; }
        public double Saldo_x_Unidades { get; set; }

        public double CostoIngreso { get; set; }
        public double CostoEgreso { get; set; }
        public double CostoInicial { get; set; }
        public double Costo_x_Unidades { get; set; }

        public double CostoUniIngreso { get; set; }
        public double CostoUniEgreso { get; set; }

        public double Costo { get; set; }
        public string Cod_producto { get; set; }
        public string nom_producto { get; set; }
        public decimal IdProducto { get; set; }

        public Image Logo { get; set; }
        public string Empresa { get; set; }

        public int IdEmpresa_oc { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }

        public double Costo_x_IngEgr { get; set; }

        public int? IdMotivo_Inv { get; set; }
        public string Cod_Motivo_Inv { get; set; }
        public string Desc_mov_inv { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_SubCentro_costo { get; set; }
        public string nom_Centro_costo { get; set; }

        public XINV_FJ_Rpt004_Info()
        {
                
        }
    }
}
