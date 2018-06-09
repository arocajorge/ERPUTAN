using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdNumMovi { get; set; }
        public string signo	 { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public int IdEmpresa_inv { get; set; }
        public int IdSucursal_inv { get; set; }
        public int IdBodega_inv { get; set; }
        public int IdMovi_inven_tipo_inv { get; set; }
        public decimal IdNumMovi_inv { get; set; }
        public int IdMotivo_oc { get; set; }
        public string Descripcion { get; set; }
        public int Secuencia { get; set; }
        public int IdBodega { get; set; }
        public string bodega { get; set; }
        public string sucursal { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public string dm_observacion { get; set; }
        public double dm_precio { get; set; }
        public double mv_costo { get; set; }
        public string IdEstadoAproba { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string IdSubCentro_Costo { get; set; }
        public string SubCentro_costo { get; set; }
        public int IdPunto_cargo { get; set; }
        public string punto_cargo { get; set; }
        public string  Nom_Unidad_Medida { get; set; }
        public string Tipo_Movi_Inven { get; set; }
        public int IdMotivo_Inv { get; set; }
        public string Nom_Motivo_Inv { get; set; }
        public string Nom_producto	 { get; set; }
        public string Empresa { get; set; }
        public Image Logo { get; set; }
        public double stock_ant { get; set; }
        public double stock_act { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public string nom_unidad_medida_sinConversion { get; set; }


        public XINV_Rpt003_Info()
        {

        }

    }
}
