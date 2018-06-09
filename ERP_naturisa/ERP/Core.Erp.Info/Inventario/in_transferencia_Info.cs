using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_transferencia_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdSucursalDest { get; set; }
        public int IdBodegaDest { get; set; }
        public string tr_Observacion { get; set; }
        public DateTime tr_fecha { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }        
        public DateTime? tr_fechaAnulacion { get; set; }
        public string tr_userAnulo { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string EstadoAprobacion_cat { get; set; }

        public string Bodega_Origen { get; set; }
        public string Bodega_Destino { get; set; }
        public string Sucursal_Origen { get; set; }
        public string Sucursal_Destino { get; set; }

        public string MotivoAnu { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }

        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuOrig { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Origen { get; set; }

        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuDest { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Destino { get; set; }

        
        


        public int IdMotivo_Inv_SucuOrig { get; set; }
        public int IdMotivo_Inv_SucuDest { get; set; }

        public string IdEstadoAproba_ing { get; set; }
        public string IdEstadoAproba_egr { get; set; }
        public string Codigo { get; set; }
        public bool Check { get; set; }
        public List<in_producto_x_tb_bodega_Info> lista_detalle_producto_x_bodega { get; set; }
        public List<in_transferencia_det_Info> lista_detalle_transferencia { get; set; }
        public List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> lista_detalle_guia_x_transferencia { get; set; }
        public in_transferencia_Info() 
        {
            lista_detalle_producto_x_bodega = new List<in_producto_x_tb_bodega_Info>();
            lista_detalle_transferencia = new List<in_transferencia_det_Info>();
            lista_detalle_guia_x_transferencia = new List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info>();
        }
    }
}
