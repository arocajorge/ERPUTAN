using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string observacion { get; set; }
        public  DateTime fecha{ get; set; }
        public decimal IdProducto { get; set; }
        public double cantidad	 { get; set; }
        public double stock_ant { get; set; }
        public double stock_act { get; set; }
        public string observacion_det { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string Tipo_Movimiento { get; set; }
        public string Empresa { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string UnidadMedida { get; set; }
        public string IdEstadoDespacho_cat { get; set; }
        public Nullable<System.DateTime> Fecha_despacho { get; set; }
        public Nullable<System.DateTime> Fecha_registro { get; set; }
        public Nullable<System.DateTime> Fecha_ingreso { get; set; }
        public Image Logo { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public string UnidadMedida_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public XINV_Rpt002_Info()
        {
        }

    }
}
