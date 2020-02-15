using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_Ing_Egr_Inven_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdNumMovi { get; set; }
        public int? IdBodega { get; set; }
        public string signo { get; set; } //nuevo
        public int IdMovi_inven_tipo { get; set; }
        public string CodMoviInven { get; set; }
        public string cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public string Genera_Movi_Inven { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int IdEmpresa_x_Anu { get; set; }
        public int IdSucursal_x_Anu { get; set; }
        public int IdBodega_x_Anu { get; set; }
        public int IdMovi_inven_tipo_x_Anu { get; set; }
        public decimal IdNumMovi_x_Anu { get; set; }
        public string MotivoAnulacion { get; set; }
        public int? IdMotivo_oc { get; set; } //nueva
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdusuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public int? IdMotivo_Inv { get; set; } //nueva
        public Nullable<decimal> IdResponsable { get; set; }//nueva
        public string Desc_mov_inv { get; set; }

        //datos para el reversar_aprobación
        public string tm_descripcion { get; set; }
        public string cm_descripcionCorta { get; set; }

        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string nom_motivo { get; set; }
        public string nom_tipo_inv { get; set; }
        public string cod_tipo_inv { get; set; }
        public string signo_tipo_inv { get; set; }
        public string nom_proveedor { get; set; }
        public string IdEstadoCierre_oc { get; set; }
        public string nom_estado_cierre_oc { get; set; }

        public string IdEstadoAproba { get; set; }
        public string nom_EstadoAproba { get; set; }
        public bool Checked { get; set; }
        public string IdEstadoDespacho_cat { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public string co_factura { get; set; }
        public List<in_Ing_Egr_Inven_det_Info> listIng_Egr { get; set; }
        public List<in_movi_inve_detalle_Info> listMovi_inven_det { get; set; }
        public Nullable<System.DateTime> Fecha_registro { get; set; }
        public in_Ing_Egr_Inven_Info()
        {
            listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
            listMovi_inven_det = new List<in_movi_inve_detalle_Info>();
        }

        public string Bodega2 { get; set; }

        public string Bodega1 { get; set; }

        public double? TotalInventario { get; set; }

        public double? Diferencia { get; set; }

        public double? TotalContabilidad { get; set; }
    }
}
